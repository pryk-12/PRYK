using Datos;
using Entidades;
using System.Collections.Generic;

namespace Servicios
{
   public class S_Proveedor
    {
       public static List<E_Proveedor> Listar_Proveedores(string Condicion)
        {
            D_Proveedor Metodo = new D_Proveedor();
            return Metodo.Listar_Proveedores(Condicion);
        }

       public static void Insertar_Proveedor(PROVEEDORES obj)
        {
            D_Proveedor Metodo = new D_Proveedor();
            Metodo.Insertar_Proveedor(obj);
        }

       public static void Actualizar_Proveedor(PROVEEDORES obj)
        {
            D_Proveedor Metodo = new D_Proveedor();
            Metodo.Actualizar_Proveedor(obj);
        }
    }
}
