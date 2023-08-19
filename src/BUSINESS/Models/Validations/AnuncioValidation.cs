using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUSINESS.Models.Validations
{
    public class AnuncioValidation : AbstractValidator<Anuncio>
    {
        public AnuncioValidation()
        {
            RuleFor(a => a.NomeAnuncio)
                    .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido")
                    .Length(2, 200).WithMessage("O campo {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres");
        }
    }
}
