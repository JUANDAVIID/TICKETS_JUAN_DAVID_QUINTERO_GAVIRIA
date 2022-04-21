using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELOS
{
    public class UsuarioModel
    {
        [Key] 
        public int ID_SEGURIDAD { get; set; }
        public string USUARIO { get; set; }
        public string PASSWORD { get; set; }
        public int GRUPO_USUARIO { get; set; }
        public string NOMBRES { get; set; }
        public string CORREO { get; set; }
        public bool ESTADO { get; set; }
        public bool BLOQUEADO { get; set; }
        public DateTime? FECHA_BLOQUEO { get; set; }
        public DateTime? FECHA_CREA { get; set; }
        public int USUARIO_CREA { get; set; }
        public int ACCESOS_INCORRECTOS { get; set; }
        public int MAX_INTENTOS_ACCESO { get; set; }
        
    }
}
