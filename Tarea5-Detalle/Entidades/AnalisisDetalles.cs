using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea5_Detalle.Entidades
{
    class AnalisisDetalles
    {
        [Key]
        public int AnalisisDetalleId { get; set; }
        public int AnalisisId { get; set; }
        public int TipoAnalisisId { get; set; }
        public string Descripcion { get; set; }
        public string Resultado { get; set; }

        public AnalisisDetalles()
        {
            AnalisisDetalleId = 0;
            AnalisisId = 0;
            TipoAnalisisId = 0;
            Descripcion = string.Empty;
            Resultado = string.Empty;
        }
    }
}
