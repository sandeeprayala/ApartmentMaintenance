using Apartment.Domain.Common;

namespace Apartment.Domain.Entities;

public class Block : AuditableEntity
{
    public string Name { get; set; } = string.Empty;

    public Guid ApartmentComplexId { get; set; }

    public ApartmentComplex ApartmentComplex { get; set; } = default!;

    public ICollection<Flat> Flats { get; set; } = new List<Flat>();
}
