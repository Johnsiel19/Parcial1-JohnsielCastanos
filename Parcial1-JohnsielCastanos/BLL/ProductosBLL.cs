using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parcial1_JohnsielCastanos.DAL;
using Parcial1_JohnsielCastanos.Entidades;
using System.Data.Entity;
using System.Linq.Expressions;

namespace Parcial1_JohnsielCastanos.BLL
{
    public class ProductosBLL
    {

        public static bool Guardar(Productos productos)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                if (contexto.Producto.Add(productos) != null)
                    paso = contexto.SaveChanges() > 0;
                Inventario inventario = InventarioBLL.Buscar(1);
                inventario.Valor += productos.ValorInvetario;
                InventarioBLL.Modificar(inventario);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return paso;
        }


        public static bool Modificar(Productos producto)
        {
            bool paso = false;

            Contexto contexto = new Contexto();
            Productos pro = ProductosBLL.Buscar(producto.ProductoId);
            try
            {
                double resultado = producto.ValorInvetario - pro.ValorInvetario;

                Inventario inventario = InventarioBLL.Buscar(1);
                inventario.Valor += Convert.ToSingle( resultado);
                InventarioBLL.Modificar(inventario);

                contexto.Entry(producto).State = EntityState.Modified;
                paso = (contexto.SaveChanges() > 0);

            }
            catch (Exception)
            {
                throw;
            }
            finally { contexto.Dispose(); }

            return paso;
        }

        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                var eliminar = db.Producto.Find(id);

                var Inventario = InventarioBLL.Buscar(1);
                Inventario.Valor -= eliminar.ValorInvetario;
                InventarioBLL.Modificar(Inventario);
                //db.Producto.Remove(eliminar);
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

        public static Productos Buscar(int id)
        {
            Contexto db = new Contexto();
            Productos producto = new Productos();

            try
            {
                producto = db.Producto.Find(id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return producto;
        }




    }
}
