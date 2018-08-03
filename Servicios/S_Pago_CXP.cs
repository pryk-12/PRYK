using Datos;
using Entidades;
using System.Collections.Generic;

namespace Servicios
{
    public class S_Pago_CXP
    {
        public static List<E_Pago_CXP> Listar_Pago_CXP(string Condicion)
        {
            D_CXP Metodo = new D_CXP();
            return Metodo.Listar_Pago_CXP(Condicion);
        }

        public static void Insertar_Pago_CXP(PAGOS_CXP obj)
        {
            D_CXP Metodo = new D_CXP();
            Metodo.Insertar_Pago_CXP(obj);
        }

        public static void Anular_Pago_CXP(PAGOS_CXP obj)
        {
            D_CXP Metodo = new D_CXP();
            Metodo.Anular_Pago_CXP(obj);
        }

        public static void Actualizar_Monto(CXP obj)
        {
            D_CXP Metodo = new D_CXP();
            Metodo.Actualizar_Monto(obj);
        }
    }
}
