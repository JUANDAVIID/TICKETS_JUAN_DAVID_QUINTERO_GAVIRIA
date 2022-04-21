using DAOS;
using MODELOS;
using Servicios.Utilities;
using Servicios.Validator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{ 
    public class UsuarioService
    {
        UsuarioDao usuarioDao;

        public UsuarioService()
        {
            usuarioDao = new UsuarioDao();
        }

        public string UsuarioLogin(UsuarioModel usuario)
        {
            string respuesta = "";
            var loginValidator = new LoginValidator().Validate(usuario);

            if (!loginValidator.IsValid)
            {
                respuesta = string.Join(" * ", loginValidator.Errors.Select(error => error.ErrorMessage).Distinct());
                return respuesta;
            }      
            else
            {
                //usuario.PASSWORD = HashService.HashGenerator(usuario.PASSWORD);
                bool existe = usuarioDao.LoginUsuario(usuario);
                if (!existe) respuesta = $"USUARIO o PASWWORD incorrecto";

                return respuesta;
            } 
        }
    }
}
