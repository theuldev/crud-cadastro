using crud_mvc.Models;
using FluentValidation;
using System.Text.RegularExpressions;

namespace crud_mvc.Validations
{
    public class ClientValidation : AbstractValidator<Client>
    {
        public ClientValidation()
        {

            RuleFor(x => x.CPF)
                .NotNull()
                .Must(x => x.IsValidCPF())
                .WithMessage("CPF Invalido");

            RuleFor(x => x.RG)
                .NotNull()
                .Must(x  => x.IsValidRG())
                .WithMessage("RG Invalido");

            RuleFor(x => x.CEP)
                .NotNull()
                .Must(x => x.IsValidCEP())
                .WithMessage("CEP Invalido");

            RuleFor(x => x.Email)
                .NotNull()
                .EmailAddress()
                .WithMessage("Email Invalido");

            RuleFor(x => x.Phone)
                .NotNull()
                .Length(11)
                .WithMessage("Telefone Invalido");
        }
    }
}
