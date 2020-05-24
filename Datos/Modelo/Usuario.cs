using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Modelo
{
    /// <summary>
    /// Representa cada usuario registrado.
    /// Cada usuario tiene como atrubutos su nombre de usuario, contraseña, nombre completo, correo, foto y privilgios.
    /// </summary>
   public class Usuario
    {
        public String User { get; set; }
        public String Password { get; set; }
        public String Nombre { get; set; }
        public String ApellidoPaterno { get; set; }
        public String ApellidoMaterno { get; set; }
        public String Correo { get; set; }
        public String Foto { get; set; }
        public String Privilegio { get; set; }

    }
}
