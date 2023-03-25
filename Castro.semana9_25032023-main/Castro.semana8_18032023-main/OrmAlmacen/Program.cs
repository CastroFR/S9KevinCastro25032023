
using OrmAlmacen.DAO;
using OrmAlmacen.Models;
using System;
using System.Diagnostics;

CrudProducto crudProducto  = new CrudProducto();
Producto producto = new Producto();
Console.WriteLine("Menu");
Console.WriteLine("Pulse 1 para regresar e insetar productos");
Console.WriteLine("Pulse 2 para actualizar productos");
var Menu = Convert.ToInt32(Console.ReadLine());

switch (Menu)
{
   case 1:
         int bucle = 1;
         while(bucle == 1)
         {
            Console.WriteLine("Ingresa el nombre de tu producto ");
            producto.Nombre = Console.ReadLine();
            Console.WriteLine("Ingresa la descripción de tu producto ");
            producto.Descipción = Console.ReadLine();
            Console.WriteLine("Ingresa el precio de tu producto ");
            producto.Precio = Convert.ToDecimal (Console.ReadLine());
            Console.WriteLine("Ingresa la cantidad de productos disponibles ");
            producto.Stock = Convert.ToInt32 (Console.ReadLine());
         
            crudProducto.AgregarProducto(producto);
            Console.WriteLine("El producto se ingreso correctamente");
            Console.WriteLine("Pulse 1 para continuar añadiendo productos");
            Console.WriteLine("Pulse 0 para salir");

            bucle = Convert.ToInt32(Console.ReadLine());

         }

   break; 
   
   case 2:
        Console.WriteLine("Actualizar datos");
   break;

}
