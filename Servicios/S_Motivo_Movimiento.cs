using Datos;
using Entidades;
using System.Collections.Generic;

namespace Servicios
{
   public class S_Motivo_Movimiento
    {
       public static List<E_Motivo_Movimiento> Listar_Motivos_Movimientos(string Condicion)
        {
            D_Motivo_Movimiento Metodo = new D_Motivo_Movimiento();
            return Metodo.Listar_Motivos_Movimientos(Condicion);
        }

        public static void Insertar_Motivo_Movimiento(MOTIVOS_MOVIMIENTOS obj)
        {
            D_Motivo_Movimiento Metodo = new D_Motivo_Movimiento();
            Metodo.Insertar_Motivo_Movimiento(obj);
        }

        public static void Actualizar_Motivo_Movimiento(MOTIVOS_MOVIMIENTOS obj)
        {
            D_Motivo_Movimiento Metodo = new D_Motivo_Movimiento();
            Metodo.Actualizar_Motivo_Movimiento(obj);
        }
    }
}
