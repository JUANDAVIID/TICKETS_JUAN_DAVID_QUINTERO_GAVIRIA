using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAOS.Utilities
{
    public class DapperManage
    { //metodo generico para ejecutar cualquier procedimiento almacenado, y retornar un modelo dinanmico
        //por eso se le puso el Ienumerable tipo T porque puede ser cualquier cosa sin importar el modelo.
         // y entonces no tenemos que instanciar la coneccion porque por eso es el using of manera local.
        
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="Conexion"></param>
        /// <param name="Spname"></param>
        /// <param name="parametros"></param>
        /// <returns></returns>
        public static IEnumerable<T> ExecuteProcedure<T> (string Conexion, string Spname, DynamicParameters parametros)
        {
            using (IDbConnection conection = new SqlConnection(Conexion))
            {
                return conection.Query<T>(Spname, parametros, commandType: CommandType.StoredProcedure, commandTimeout: 0);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="Conexion"></param>
        /// <param name="Spname"></param>
        /// <param name="parametros"></param>
        /// <returns></returns>
        public static async Task<IEnumerable<T>> ExecuteProcedureAsync<T>(string Conexion, string Spname, DynamicParameters parametros)
        {
            using (IDbConnection conection = new SqlConnection(Conexion))
            {
                return await conection.QueryAsync<T>(Spname, parametros, commandType: CommandType.StoredProcedure, commandTimeout: 0);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Conexion"></param>
        /// <param name="Spname"></param>
        /// <param name="parametros"></param>
        /// <returns></returns>
        public static int ExecuteProcedure(string Conexion, string Spname, DynamicParameters parametros=null)
        {
            using (IDbConnection conection = new SqlConnection(Conexion))
            {
                return conection.Execute(Spname, parametros, commandType: CommandType.StoredProcedure, commandTimeout: 0);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Conexion"></param>
        /// <param name="Spname"></param>
        /// <param name="parametros"></param>
        /// <returns></returns>
        public static async Task<int> ExecuteProcedureAsync(string Conexion, string Spname, DynamicParameters parametros = null)
        {
            using (IDbConnection conection = new SqlConnection(Conexion))
            {
                return await conection.ExecuteAsync(Spname, parametros, commandType: CommandType.StoredProcedure, commandTimeout: 0);
            }
        }
    }
}
