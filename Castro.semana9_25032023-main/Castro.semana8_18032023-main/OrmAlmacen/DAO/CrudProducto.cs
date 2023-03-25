using Microsoft.EntityFrameworkCore;
using OrmAlmacen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrmAlmacen.DAO
{
    public class CrudProducto
    {
        public void AgregarProducto(Producto producto)
        {
            using (OrmAlmacenContext db = new OrmAlmacenContext())
            {
                Producto producto1 = new Producto();
                producto1.Nombre = producto.Nombre;
                producto1.Descipción = producto.Descipción;
                producto1.Precio = producto1.Precio;
                producto1.Stock = producto1.Stock;

                db.Add(producto1);
                db.SaveChanges();
            }
        }
        public Producto ProductoUnitario(int id)
        {
            using (OrmAlmacenContext db = new OrmAlmacenContext())
            {
                var buscar = db.Productos.FirstOrDefault(s=>s.Id==id);
                return buscar;


            }

        }

        public void ActualizarProducto(Producto producto)
        {
            using (OrmAlmacenContext db = new OrmAlmacenContext())
            {
                var buscar = ProductoUnitario(producto.Id);
                if (buscar == null) 
                {
                    Console.WriteLine("Id no existe");
                }
                else
                {
                    buscar.Nombre = producto.Nombre;
                    db.Update(buscar);
                    db.SaveChanges();
                }
            }
        }
        
    }
}
