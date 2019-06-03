using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Parcial1_JohnsielCastanos.DAL;
using Parcial1_JohnsielCastanos.Entidades;

namespace Parcial1_JohnsielCastanos.BLL
{
     public class InventarioBLL
    {

        public static bool Guardar(Inventario inventario)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                if (db.inventario.Add(inventario) != null)
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

        public static bool Modificar(Inventario inventario)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                db.Entry(inventario).State = EntityState.Modified;
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
                var eliminar = db.inventario.Find(id);
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

        public static Inventario Buscar(int id)
        {
            Contexto db = new Contexto();
            Inventario inventario = new Inventario();

            try
            {
                inventario = db.inventario.Find(id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return inventario;
        }

    }
}
