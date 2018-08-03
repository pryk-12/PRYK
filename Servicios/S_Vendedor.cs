using Datos;
using Entidades;
using System.Collections.Generic;

namespace Servicios
{
   public class S_Vendedor
    {
       public static List<E_Vendedor> Listar_Vendedores(string Condicion)
        {
            D_Vendedor Metodo = new D_Vendedor();
            return Metodo.Listar_Vendedores(Condicion);
        }

        public static void Insertar_Vendedor(VENDEDORES obj)
        {
            D_Vendedor Metodo = new D_Vendedor();
            Metodo.Insertar_Vendedor(obj);
        }

        public static void Actualizar_Vendedor(VENDEDORES obj)
        {
            D_Vendedor Metodo = new D_Vendedor();
            Metodo.Actualizar_Vendedor(obj);
        }
    }
}
