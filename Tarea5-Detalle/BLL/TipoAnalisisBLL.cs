using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Tarea5_Detalle.DAL;
using Tarea5_Detalle.Entidades;

namespace Tarea5_Detalle.BLL
{
    class TipoAnalisisBLL
    {

        public static bool Guardar(TipoAnalisis tipo)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                if(db.TipoAnalisis.Add(tipo) != null)
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

        public static bool Modificar(TipoAnalisis tipo)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                db.Entry(tipo).State = EntityState.Modified;
                paso = db.SaveChanges() > 0;

            } catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }


            return paso;
        }

        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto db = new Contexto();
            TipoAnalisis tipo = new TipoAnalisis();

            try
            {
                tipo = db.TipoAnalisis.Find(id);
                db.Entry(tipo).State = EntityState.Deleted;
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

        public static TipoAnalisis Buscar(int id)
        {
            TipoAnalisis tipo;
            Contexto db = new Contexto();

            try
            {
                tipo = db.TipoAnalisis.Find(id);

            }catch(Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return tipo;
        }

        public static List<TipoAnalisis> GetList(Expression<Func<TipoAnalisis, bool>> expression)
        {
            Contexto db = new Contexto();
            List<TipoAnalisis> lista = new List<TipoAnalisis>();

            try
            {

                lista = db.TipoAnalisis.Where(expression).ToList();

            }catch(Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }

            return lista;
        }

        public static bool Duplicado(string descriocion)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                paso = db.TipoAnalisis.Any(p => p.Descripcion == descriocion);

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
    }
}
