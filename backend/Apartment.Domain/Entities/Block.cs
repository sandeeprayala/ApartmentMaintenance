using Apartment.Domain.Common;

namespace Apartment.Domain.Entities;

public class Block : AuditableEntity
{
    public string Name { get; set; } = string.Empty;

    public Guid ApartmentId { get; set; }

    public Apartment Apartment { get; set; } = default!;

    public ICollection<Flat> Flats { get; set; } = new List<Flat>();
}
