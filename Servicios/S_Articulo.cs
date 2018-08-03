using Datos;
using Entidades;
using System.Collections.Generic;

namespace Servicios
{
   public class S_Articulo
    {
       public static List<E_Articulo> Listar_Articulos(string Condicion)
        {
            D_Articulo Metodo = new D_Articulo();
            return Metodo.Listar_Articulos(Condicion);
        }

       public static List<E_Inventario_Articulo> Listar_Inventario_Articulos(string Condicion)
       {
           D_Articulo Metodo = new D_Articulo();
           return Metodo.Listar_Inventario_Articulos(Condicion);
       }

        public static void Insertar_Articulo(ARTICULOS obj)
        {
            D_Articulo Metodo = new D_Articulo();
            Metodo.Insertar_Articulo(obj);
        }

        public static void Actualizar_Articulo(ARTICULOS obj)
        {
            D_Articulo Metodo = new D_Articulo();
            Metodo.Actualizar_Articulo(obj);
        }
    }
}
