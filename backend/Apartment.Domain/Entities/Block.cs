using Apartment.Domain.Common;

namespace Apartment.Domain.Entities;

public class Block : AuditableEntity
{
    public string Name { get; set; } = string.Empty;

    public Guid CommunityId { get; set; }

    public Community Community { get; set; } = default!;

    public ICollection<Flat> Flats { get; set; } = new List<Flat>();
}
