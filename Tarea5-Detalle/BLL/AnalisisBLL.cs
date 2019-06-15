using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea5_Detalle.DAL;
using Tarea5_Detalle.Entidades;

namespace Tarea5_Detalle.BLL
{
    class AnalisisBLL
    {
        public static bool Guardar(Analisis analisis)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                if(db.Analisis.Add(analisis) != null)
                {
                    paso = db.SaveChanges() > 0;
                }

            }catch(Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }

            return paso;
        }

        public static bool Modificar(Analisis analisis)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                db.Entry(analisis).State = EntityState.Modified;
                paso = db.SaveChanges() > 0;

            }catch(Exception)
            {
                throw; 
            }
            finally
            {
                db.Dispose();
            }

            return paso;
        }

        public static Analisis Buscar(int id)
        {
            Analisis analisis = new Analisis();
            Contexto db = new Contexto();

            try
            {
                analisis = db.Analisis.Find(id);
                if(analisis != null)
                 analisis.Detalles = AnalisisDetallesBLL.GetList(p=>p.AnalisisId == analisis.AnalisisId);
                
                //if(analisis != null)
                

            }catch(Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }

            return analisis;
        }

        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto db = new Contexto();
            Analisis analisis = new Analisis();

            try
            {
                analisis = db.Analisis.Find(id);
                db.Entry(analisis).State = EntityState.Deleted;
                paso = db.SaveChanges() > 0;

            }catch(Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }


            return paso;
        }

        public static bool Exist(int id)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                if (db.Analisis.Find(id) != null)
                    paso = true;
              
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }

            return paso;
        }
    }
}
