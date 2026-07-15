using Apartment.Domain.Common;

namespace Apartment.Domain.Entities;

public class ApartmentComplex : AuditableEntity
{
    public string Name { get; set; } = string.Empty;

    public string AddressLine1 { get; set; } = string.Empty;

    public string? AddressLine2 { get; set; }

    public string City { get; set; } = string.Empty;

    public string State { get; set; } = string.Empty;

    public string PinCode { get; set; } = string.Empty;

    public int TotalBlocks { get; set; }

    public int TotalFlats { get; set; }

    public ICollection<Block> Blocks { get; set; } = new List<Block>();
}
