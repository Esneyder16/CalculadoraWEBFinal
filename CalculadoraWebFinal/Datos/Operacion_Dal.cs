using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CalculadoraWebFinal.Datos
{
    public class Operacion_Dal
    {
        public  int Id { get; set; }
        public  int usuario_id { get; set; }
        public  string operacion { get; set; }
        public  decimal resultado { get; set; }
        public DateTime fecha_operacion { get; set; }

        public static Usuario_Dal Usuario { get; set; }

    }
}
