using Azure.Storage.Blobs;
using Azure.Storage.Sas;
using Microsoft.Extensions.Configuration;
using Ondc.Seller.Integration.Interfaces;

namespace Ondc.Seller.Integration;
public class StorageService : IStorageService
{
    private readonly IConfiguration _configuration;

    public StorageService(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public Uri GenerateSasUri(string folderName)
    {
        BlobServiceClient blobServiceClient = new BlobServiceClient(_configuration["Ondc:ConnectionStrings:StorageConnectionString"]);
        BlobContainerClient containerClient = blobServiceClient.GetBlobContainerClient("Ondc");

        BlobSasBuilder sasBuilder = new BlobSasBuilder()
        {
            BlobContainerName = "Ondc",
            StartsOn = DateTimeOffset.UtcNow.Subtract(TimeSpan.FromMinutes(5)), // Optional: Start time
            ExpiresOn = DateTimeOffset.UtcNow.AddHours(1), // Set the expiration time
            Resource = "c"
        };

        sasBuilder.SetPermissions(BlobSasPermissions.Write | BlobSasPermissions.Read | BlobSasPermissions.List | BlobSasPermissions.Delete);

        // Create the SAS URI for the folder
        return containerClient.GenerateSasUri(sasBuilder);
    }
}

