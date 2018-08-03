using Datos;
using Entidades;
using System.Collections.Generic;

namespace Servicios
{
   public class S_Movimiento
    {
       public static List<E_Movimiento> Listar_Movimientos(string Condicion)
        {
            D_Movimiento Metodo = new D_Movimiento();
            return Metodo.Listar_Movimientos(Condicion);
        }

       public static void Insertar_Movimiento(MOVIMIENTOS obj)
        {
            D_Movimiento Metodo = new D_Movimiento();
            Metodo.Insertar_Movimiento(obj);
        }

        public static void Actualizar_Movimiento(MOVIMIENTOS obj)
        {
            D_Movimiento Metodo = new D_Movimiento();
            Metodo.Actualizar_Movimiento(obj);
        }

        public static void Entrada_Inventario(INVENTARIO_ARTICULOS obj)
        {
            D_Movimiento Metodo = new D_Movimiento();
            Metodo.Entrada_Inventario(obj);
        }

        public static void Salida_Inventario(INVENTARIO_ARTICULOS obj)
        {
            D_Movimiento Metodo = new D_Movimiento();
            Metodo.Salida_Inventario(obj);
        }
    }
}
