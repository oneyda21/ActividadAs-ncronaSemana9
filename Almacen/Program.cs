using Almacen.DAO;
using Almacen.Models;
using System;
using System.Text.RegularExpressions;

#region
//var buscar = db.Productos.FirstOrDefault(x => x.Id == 1);
//Console.WriteLine(buscar);

//{
//    Producto producto = new Producto();
//    Console.WriteLine("Ingresar el nombre del producto ->");
//    producto.Nombre = Console.ReadLine();
//    Console.WriteLine("Ingresar la descripcion ->");
//    producto.Descripción = Console.ReadLine();
//    Console.WriteLine("Ingresar el precio del producto -> ");
//    producto.Precio = Convert.ToDecimal(Console.ReadLine());
//    Console.WriteLine("Ingresar el Stock del producto -> ");
//    producto.Stock = Convert.ToInt32(Console.ReadLine()); 

//    db.Productos.Add(producto);
//    db.SaveChanges();
//}

//var ListProductos = db.Productos.ToList();

//foreach (var pro in ListProductos)
//{
//    Console.WriteLine("=============================================");
//    Console.WriteLine($"Los produtos ingresados son:\n" +  
//        $"Nombre: {pro.Nombre}\n" +
//        $"Descripcion: {pro.Descripción}\n" +
//        $"Precio: {pro.Precio}\n" +
//        $"Stock: {pro.Stock}\n");
//    Console.WriteLine("=============================================");
//}
#endregion

#region Insertar/guardar
CrudProductos CrudProductos = new CrudProductos();
Producto producto = new Producto();


Console.WriteLine("Menu");
Console.WriteLine("Pulse 1 para realizar insertar productos");

var Menu = Convert.ToInt32(Console.ReadLine());

switch (Menu)
{
    case 1:
        int bucle = 1;
        while (bucle == 1)
        {
            Console.WriteLine("Ingresa el nombre del producto");
            producto.Nombre = Console.ReadLine();
            Console.WriteLine("Ingresa la descripcion del producto");
            producto.Descripción = Console.ReadLine();
            Console.WriteLine("Ingresa el precio del producto");
            producto.Precio = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Ingresa el Stock");
            producto.Stock = Convert.ToInt32(Console.ReadLine());
            CrudProductos.AgregarProducto(producto);
            Console.WriteLine("El producto se ingreso correctamente");
            Console.WriteLine("Pulsa 1 para continuar insertando productos");
            Console.WriteLine("Pulsa 0 para salir");
            bucle = Convert.ToInt32(Console.ReadLine());

        }
        break;
    
}
#endregion