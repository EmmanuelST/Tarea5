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
    class UsuariosBLL
    {
        public static bool Guardar(Usuarios usuario)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                if (db.Usuario.Add(usuario) != null)
                {
                    paso = db.SaveChanges() > 0;
                }

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


        public static bool Modificar(Usuarios usuario)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {

                db.Entry(usuario).State = EntityState.Modified;
                paso = (db.SaveChanges() > 0);
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


        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                var eliminar = db.Usuario.Find(id);
                db.Entry(eliminar).State = EntityState.Deleted;
                paso = (db.SaveChanges() > 0);

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

        public static Usuarios Buscar(int id)
        {
            Contexto db = new Contexto();
            Usuarios usuario = new Usuarios();

            try
            {

                usuario = db.Usuario.Find(id);

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }

            return usuario;
        }

        public static List<Usuarios> GetList(Expression<Func<Usuarios, bool>> expression)
        {
            List<Usuarios> Lista = new List<Usuarios>();
            Contexto db = new Contexto();

            try
            {

                Lista = db.Usuario.Where(expression).ToList();


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

        public static bool Duplicado(string nick)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                paso = db.Usuario.Any(p => p.Usuario == nick);

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
