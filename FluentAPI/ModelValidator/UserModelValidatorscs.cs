using FluentAPI.Models;
using FluentValidation;

namespace FluentAPI.ModelValidator
{
    public class UserModelValidatorscs : AbstractValidator<UserModel>
    {
        public UserModelValidatorscs()
        {
            RuleFor(model => model.FirstName).NotNull().NotEmpty().WithMessage("Please Insert a Valid First Name");
            RuleFor(model => model.LastName).NotNull().NotEmpty().WithMessage("Please Insert a Last Name");

        }
    }
}
