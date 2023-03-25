using Almacen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Almacen.DAO
{
    public class CrudProductos
    {
        public void AgregarProducto(Producto ParametrosProducto)
        {
            using (AlmacenContext db = new AlmacenContext())
            {
                Producto producto = new Producto();
                producto.Nombre = ParametrosProducto.Nombre;
                producto.Descripción = ParametrosProducto.Descripción;
                producto.Precio = ParametrosProducto.Precio;
                producto.Stock = ParametrosProducto.Stock;
                db.Add(producto);
                db.SaveChanges();


            }


        }

    }   

}