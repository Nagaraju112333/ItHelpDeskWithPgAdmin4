namespace Ondc.Seller.Domain.Entities;

public class Companies : EntityBase
{
   
    public string? BusinessEmail { get; set; }
    public string? ComapnyName { get; set; }
    public string? PhoneNumber { get; set; }

    public string? CompanyLogoPath { get; set; }
    public string? Country { get; set; }
    public string? State { get; set; }
    public string? City { get; set; }
    public string? PinCode { get; set; }
    public string? Address { get; set; }

   // public Uri? ImageSasUri { get; set; }
}
