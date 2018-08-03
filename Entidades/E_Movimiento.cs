using System;

namespace Entidades
{
   public class E_Movimiento
    {
       public int ID_MOVIMIENTO { get; set; }
       public int ID_MOTIVO { get; set; }
       public string MOTIVO { get; set; }
       public string TIPO_MOVIMIENTO { get; set; }
       public string REFERENCIA { get; set; }
       public string ARTICULO { get; set; }
       public int CANTIDAD { get; set; }
       public string ESTADO { get; set; }
       public string OBSERVACION { get; set; }
       public string CREADO_POR { get; set; }
       public DateTime FECHA_CREADO { get; set; }
       public string ANULADO_POR { get; set; }
       public string FECHA_ANULADO { get; set; }
       public string NOTA_ANULACION { get; set; }
    }
}
