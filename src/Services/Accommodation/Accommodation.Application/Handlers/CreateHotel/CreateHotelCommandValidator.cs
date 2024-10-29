namespace Accommodation.Application.Handlers.CreateHotel;

public class CreateHotelCommandValidator : AbstractValidator<CreateHotelCommand>
{
    public CreateHotelCommandValidator()
    {
        RuleFor(p => p.Name)
            .NotEmpty().WithMessage(RequiredMessage("Name"))
            .NotNull();
        
        RuleFor(p => p.Capacity)
            .NotEmpty().WithMessage(RequiredMessage("Capacity"))
            .GreaterThan(0).WithMessage("Capacity should be greater than zero.");       
        
        RuleFor(p => p.Email)
            .NotEmpty().WithMessage(RequiredMessage("Email"))
            .NotNull();
        
        RuleFor(p => p.Phone)
            .NotEmpty().WithMessage(RequiredMessage("Phone Number"))
            .NotNull();
        
        RuleFor(p => p.Country)
            .NotEmpty().WithMessage(RequiredMessage("Country"))
            .NotNull();
        
        RuleFor(p => p.City)
            .NotEmpty().WithMessage(RequiredMessage("City"))
            .NotNull();
        
        RuleFor(p => p.Street)
            .NotEmpty().WithMessage(RequiredMessage("Street"))
            .NotNull();
        
        RuleFor(p => p.StateOrRegion)
            .NotEmpty().WithMessage(RequiredMessage("State/Region"))
            .NotNull();
        
        RuleFor(p => p.PostCode)
            .NotEmpty().WithMessage(RequiredMessage("Post Code"))
            .NotNull();
    }
    
    private static readonly Func<string, string> RequiredMessage = property => $"'{property}' is required.";
}
