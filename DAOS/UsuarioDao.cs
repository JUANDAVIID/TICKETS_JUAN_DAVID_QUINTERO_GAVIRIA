using DAOS.Utilities;
using Dapper;
using MODELOS;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAOS
{
    public class UsuarioDao
    {
        private string cnx = ConfigurationManager.ConnectionStrings["cnx"].ToString();
        
        public bool LoginUsuario(UsuarioModel usuario)
        {
            DynamicParameters dParams = new DynamicParameters(new 
            {
                usuario.USUARIO,
                usuario.PASSWORD 
            });

            var result = DapperManage.ExecuteProcedure<UsuarioModel>(cnx, "LOGIN_USUARIO", dParams);

            if (result.Any()) return true;
            else return false;
        }
    }
}
