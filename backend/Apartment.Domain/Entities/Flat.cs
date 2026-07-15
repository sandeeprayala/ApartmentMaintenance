using Apartment.Domain.Common;

namespace Apartment.Domain.Entities;

public class Flat : AuditableEntity
{
    public string FlatNumber { get; set; } = string.Empty;

    public Guid ApartmentId { get; set; }

    public Guid BlockId { get; set; }

    public Block Block { get; set; } = default!;

    public int FloorNumber { get; set; }

    public decimal MaintenanceAmount { get; set; }

    public bool IsOccupied { get; set; }

    public decimal OpeningWaterReading { get; set; }

    public decimal CurrentWaterReading { get; set; }

    public Owner? Owner { get; set; }

    public Tenant? Tenant { get; set; }
}
