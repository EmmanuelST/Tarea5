using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea5_Detalle.Entidades
{
    class AnalisisDetalles
    {
        
        public int AnalisisId { get; set; }
        public int TipoId { get; set; }
        public string Resultado { get; set; }

        public AnalisisDetalles()
        {
            AnalisisId = 0;
            TipoId = 0;
            Resultado = string.Empty;
        }
    }
}
