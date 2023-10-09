namespace Ondc.Seller.Domain.Entities;

public class Seller : EntityBase
{
    public string? Name { get; set; }

    public string? CompanyName { get; set; }

    public string? PhoneNumber { get; set; }

    public string? EmailAddress { get; set; }

    public string? Password { get; set; }

    public DateTime? RegisteredDate { get; set; }
}
