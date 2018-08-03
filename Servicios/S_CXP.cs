using Datos;
using Entidades;
using System.Collections.Generic;

namespace Servicios
{
   public class S_CXP
    {
       public static List<E_CXP> Listar_CXP(string Condicion)
        {
            D_CXP Metodo = new D_CXP();
            return Metodo.Listar_CXP(Condicion);
        }

        public static void Insertar_CXP(CXP obj)
        {
            D_CXP Metodo = new D_CXP();
            Metodo.Insertar_CXP(obj);
        }

        public static void Actualizar_CXP(CXP obj)
        {
            D_CXP Metodo = new D_CXP();
            Metodo.Actualizar_CXP(obj);
        }
    }
}
