using AzureFunctionsDDD.Cosmos.Core.Domain;
using FluentValidation;

namespace AzureFunctionsDDD.Cosmos.Core.Validators
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            // Required validators.
            RuleFor(x => x.FirstName).NotEmpty().WithMessage("First name should not be empty");
            RuleFor(x => x.LastName).NotEmpty().WithMessage("Last name should not be empty");
        }
    }
}
