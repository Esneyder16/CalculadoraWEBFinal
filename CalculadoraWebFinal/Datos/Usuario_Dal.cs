using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services.Description;

namespace CalculadoraWebFinal.Datos
{
    public class Usuario_Dal
    {
    

        public static int id { get; set; }
        public static string nombre { get; set; }
        public static string contrasena { get; set; }
        public static DateTime Fecha_creacion { get; set; }

        public static ICollection<Operacion_Dal> Operaciones { get; set; }

    }
}