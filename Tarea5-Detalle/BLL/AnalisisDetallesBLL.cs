using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Tarea5_Detalle.DAL;
using Tarea5_Detalle.Entidades;

namespace Tarea5_Detalle.BLL
{
    class AnalisisDetallesBLL
    {

        public static List<AnalisisDetalles> GetList(Expression<Func<AnalisisDetalles, bool>> expression)
        {
            List<AnalisisDetalles> Lista = new List<AnalisisDetalles>();
            Contexto db = new Contexto();

            try
            {

                Lista = db.AnalisisDetalles.Where(expression).ToList();


            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }


            return Lista;
        }
    }
}
