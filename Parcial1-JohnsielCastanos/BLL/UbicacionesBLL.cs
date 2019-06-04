using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parcial1_JohnsielCastanos.Entidades;
using Parcial1_JohnsielCastanos.DAL;
using System.Data.Entity;
using System.Linq.Expressions;

namespace Parcial1_JohnsielCastanos.BLL
{
    public class UbicacionesBLL
    {


        public static bool Guardar(Ubicaciones ubicacion)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                if (db.Ubicacion.Add(ubicacion) != null)
                    paso = db.SaveChanges() > 0;

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

        public static bool Modificar(Ubicaciones ubucacion)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                db.Entry(ubucacion).State = EntityState.Modified;
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


        public static Ubicaciones Buscar(int id)
        {
            Contexto db = new Contexto();
            Ubicaciones ubicacion = new Ubicaciones();

            try
            {
                ubicacion = db.Ubicacion.Find(id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return ubicacion;
        }
        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                var eliminar = db.Ubicacion.Find(id);
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


        public static List<Ubicaciones> GetList(Expression<Func<Ubicaciones, bool>> ubicacion)
        {
            Contexto contexto = new Contexto();
            List<Ubicaciones> lista = new List<Ubicaciones>();
            try
            {
                lista = contexto.Ubicacion.Where(ubicacion).ToList();

            }
            catch
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return lista;
        }


    }
}
