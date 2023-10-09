namespace Ondc.Seller.Domain.Entities;

public class EntityBase
{
    public int Id { get; set; }
    public string? CreatedBy { get; set; }
    public DateTime? CreatedAt { get; set; }
    public string? UpdatedBy { get; set; }
    public DateTime? UpdatedAt { get; set; }
}
