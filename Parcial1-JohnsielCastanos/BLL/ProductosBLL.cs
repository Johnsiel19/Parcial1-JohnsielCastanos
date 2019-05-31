using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parcial1_JohnsielCastanos.DAL;
using Parcial1_JohnsielCastanos.Entidades;
using System.Data.Entity;

namespace Parcial1_JohnsielCastanos.BLL
{
    public class ProductosBLL
    {

        public static bool Guardar(Productos producto)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                if (db.Producto.Add(producto) != null)
                    paso = db.SaveChanges() > 0;

            }
            catch (Exception)
            {
                throw
            }
            finally
            {
                db.Dispose();
            }

            return paso;
        }

        public static bool Modificar(Productos producto)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                db.Entry(producto).State = EntityState.Modified;
                paso = (db.SaveChanges() > 0);
            }
            catch
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
