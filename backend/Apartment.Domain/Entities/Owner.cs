using Apartment.Domain.Common;

namespace Apartment.Domain.Entities;

public class Owner : AuditableEntity
{
    public string FirstName { get; set; } = string.Empty;

    public string LastName { get; set; } = string.Empty;

    public string Email { get; set; } = string.Empty;

    public string PhoneNumber { get; set; } = string.Empty;

    public Guid ApartmentComplexId { get; set; }

    public Guid FlatId { get; set; }

    public Flat Flat { get; set; } = default!;
}
