using Datos;
using Entidades;
using System.Collections.Generic;

namespace Servicios
{
   public class S_Cobrador
    {
       public static List<E_Cobrador> Listar_Cobradores(string Condicion)
        {
            D_Cobrador Metodo = new D_Cobrador();
            return Metodo.Listar_Cobradores(Condicion);
        }

        public static void Insertar_Cobrador(COBRADORES obj)
        {
            D_Cobrador Metodo = new D_Cobrador();
            Metodo.Insertar_Cobrador(obj);
        }

        public static void Actualizar_Cobrador(COBRADORES obj)
        {
            D_Cobrador Metodo = new D_Cobrador();
            Metodo.Actualizar_Cobrador(obj);
        }
    }
}
