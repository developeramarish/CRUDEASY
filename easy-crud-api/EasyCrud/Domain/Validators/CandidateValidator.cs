using EasyCrud.Domain.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyCrud.Domain.Validators
{
    public class CandidateValidator : AbstractValidator<Candidate>
    {
        public CandidateValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Por favor informe o nome");
            RuleFor(x => x.CPFRecipient).NotEmpty().WithMessage("Por favor informe o cpf");
            RuleFor(x => x.CPFRecipient).MinimumLength(11).MaximumLength(11).WithMessage("O número de caracteres no cpf são de 11 números");
            RuleFor(x => x.Email).NotEmpty().WithMessage("Por favor informe o email");
            RuleFor(x => x.Email).EmailAddress().WithMessage("Email não válido");
            RuleFor(x => x.Cellphone).NotEmpty().WithMessage("Por favor informe o celular");
            RuleFor(x => x.CrudLink).NotEmpty().WithMessage("Por favor informe o link do crud");
        }
    }
}
