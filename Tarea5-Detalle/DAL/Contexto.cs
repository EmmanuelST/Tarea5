using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea5_Detalle.Entidades;

namespace Tarea5_Detalle.DAL
{
    class Contexto : DbContext
    {
        public DbSet<Usuarios>Usuario { get; set; }
        public DbSet<Analisis>Analisi { get; set; }
        public Contexto() : base("Constr")
        {

        }
    }
}
