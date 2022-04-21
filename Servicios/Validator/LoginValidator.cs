using FluentValidation;
using MODELOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Validator
{
    public class LoginValidator : AbstractValidator<UsuarioModel>
    {
        public LoginValidator()
        {
            RuleFor(x => x.USUARIO).NotEmpty().WithMessage($"El USUARIO es requerido");
            RuleFor(x => x.PASSWORD).NotEmpty().WithMessage($"El PASSWORD es requerido");
        }
    }
}
