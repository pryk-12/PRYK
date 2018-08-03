using System;

namespace Entidades
{
   public class E_CXP
    {
        public int ID_CXP { get; set; }
        public int ID_MOVIMIENTO { get; set; }
        public string NUMERO_FACTURA { get; set; }
        public int ID_PROVEEDOR { get; set; }
        public string PROVEEDOR { get; set; }
        public decimal MONTO_TOTAL { get; set; }
        public decimal MONTO_PAGADO { get; set; }
        public decimal MONTO_PENDIENTE { get; set; }
        public string ESTADO { get; set; }
        public string OBSERVACION { get; set; }
        public string CREADO_POR { get; set; }
        public DateTime FECHA_CREADO { get; set; }
    }
}
