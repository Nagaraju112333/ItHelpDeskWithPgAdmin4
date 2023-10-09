namespace Ondc.Seller.Integration.Interfaces;

public interface IStorageService
{
    Uri GenerateSasUri(string folderName);
}
