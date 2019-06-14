using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea5_Detalle.Entidades
{
    class Analisis
    {
        public int AnalisisId { get; set; }
        public DateTime Fecha { get; set; }
        public int UsuarioId { get; set; }

        public Analisis()
        {
            AnalisisId = 0;
            Fecha = DateTime.Now;
            UsuarioId = 0;
        }
    }
}
