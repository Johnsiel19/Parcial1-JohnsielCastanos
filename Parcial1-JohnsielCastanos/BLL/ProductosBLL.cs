using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parcial1_JohnsielCastanos.DAL;
using Parcial1_JohnsielCastanos.Entidades;
using System.Data.Entity;
using System.Linq.Expressions;
using Parcial1_JohnsielCastanos.BLL;

namespace Parcial1_JohnsielCastanos.BLL
{
    public class ProductosBLL
    {

        public static Inventario LlenaClase()
        {
            Inventario inventario = new Inventario();
            inventario.Valor = 0;
            inventario.InventarioId = 1;

            return inventario;
        }
        public static bool Guardar(Productos productos)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            Inventario inventario = new Inventario();
            try
            {
                inventario = InventariosBLL.Buscar(1);
                if (inventario == null)
                {

                    inventario = LlenaClase();
                    paso = InventariosBLL.Guardar(inventario);
   
                }
               
                if (contexto.Producto.Add(productos) != null) 
                    paso = contexto.SaveChanges() > 0;
               
                inventario.Valor += productos.ValorInvetario;
                InventariosBLL.Modificar(inventario);
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

                Inventario inventario = InventariosBLL.Buscar(1);
                inventario.Valor += Convert.ToSingle( resultado);
                InventariosBLL.Modificar(inventario);

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

                var Inventario = InventariosBLL.Buscar(1);
                Inventario.Valor -= eliminar.ValorInvetario;
                InventariosBLL.Modificar(Inventario);
        
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

        public static List<Productos> GetList(Expression<Func<Productos, bool>> producto)
        {
            Contexto contexto = new Contexto();
            List<Productos> lista = new List<Productos>();
            try
            {
                lista = contexto.Producto.Where(producto).ToList();

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
