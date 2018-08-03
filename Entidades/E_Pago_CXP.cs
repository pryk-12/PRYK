using System;

namespace Entidades
{
   public class E_Pago_CXP
    {
       public int ID_PAGO { get; set; }
       public int ID_CXP { get; set; }
       public string NUMERO_FACTURA { get; set; }
       public decimal MONTO_PAGADO { get; set; }
       public string ESTADO { get; set; }
       public string OBSERVACION { get; set; }
       public string CREADO_POR { get; set; }
       public DateTime FECHA_CREADO { get; set; }
       public string ANULADO_POR { get; set; }
       public string FECHA_ANULACION { get; set; }
       public string NOTA_ANULACION { get; set; }
       public string FORMA_PAGO { get; set; }
       public string NOMBRE { get; set; }
    }
}
