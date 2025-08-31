namespace Accommodation.Domain.Hotel.Commands;

public record CreateHotelCommand : IRequest
{
    public string Name { get; init; }
    public int Capacity { get; init; }
    public string Email { get; init; }
    public string Phone { get; init; }
    public string Country { get; init; }
    public string City { get; init; }
    public string Street { get; init; }
    public string StateOrRegion { get; init; }
    public string PostCode { get; init; }
    public ICollection<Facility> Facilities { get; init; }
    public ICollection<Star>? Stars { get; init; }
};
