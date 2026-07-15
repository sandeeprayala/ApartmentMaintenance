using Apartment.Domain.Common;

namespace Apartment.Domain.Entities;

public class Tenant : AuditableEntity
{
    public string FirstName { get; set; } = string.Empty;

    public string LastName { get; set; } = string.Empty;

    public string Email { get; set; } = string.Empty;

    public string PhoneNumber { get; set; } = string.Empty;

    public DateTime LeaseStartDate { get; set; }

    public DateTime? LeaseEndDate { get; set; }

    public Guid ApartmentComplexId { get; set; }

    public Guid FlatId { get; set; }

    public Flat Flat { get; set; } = default!;
}
