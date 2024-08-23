using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CalculadoraWebFinal.Datos
{
    public class Operacion_Dal
    {
        public static int Id { get; set; }
        public static int usuario_id { get; set; }
        public static string operacion { get; set; }
        public static decimal resultado { get; set; }
        public static DateTime fecha_operacion { get; set; }

        public static Usuario_Dal Usuario { get; set; }

    }
}
