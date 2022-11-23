using FluentValidation;
using MVCprojeto.Models;

namespace MVCprojeto.Validator
{
    public class UserValidator : AbstractValidator<UserViewModel>
    {
        public UserValidator() {
            RuleFor(user => user.Email).NotNull().WithMessage("Favor preencha o e-mail  ");
            RuleFor(user => user.Email).EmailAddress().WithMessage("Formato do e-mail é invalido  ");
            RuleFor(user => user.Password).NotNull().WithMessage("Favor digite a senha  ");
        }
    }
}
