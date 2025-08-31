using Accommodation.Application.Repositories;
using Accommodation.Domain.Hotel;

namespace Accommodation.Application.Handlers.CreateHotel;

public class CreateHotelCommandHandler(IEventStoreRepository<Hotel> eventStoreRepository) : IRequestHandler<CreateHotelCommand>
{
    public async Task Handle(CreateHotelCommand request, CancellationToken cancellationToken)
    {
        //state builder
        
        Result<Address> address = Address.Create(request.Country, request.City, request.Street, request.StateOrRegion, request.PostCode);
        Result<ContactInformation> contactInformation =
            ContactInformation.Create(request.Phone, request.Email, address.Value);
        Result<Hotel> hotel = Hotel.Create(new HotelId(Guid.NewGuid()), request.Name, request.Capacity, contactInformation.Value!, request.Facilities, request.Stars);
        
        Result<AppendEventsResult> result = await eventStoreRepository.AppendEventsAsync(hotel.Value!, 0, cancellationToken);
    }
}
