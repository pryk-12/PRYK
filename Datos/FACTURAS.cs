//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Datos
{
    using System;
    using System.Collections.Generic;
    
    public partial class FACTURAS
    {
        public int ID_FACTURA { get; set; }
        public System.DateTime FECHA { get; set; }
        public string REFERENCIA { get; set; }
        public int ID_COBRADOR { get; set; }
        public string NUMERO_LOTERIA { get; set; }
        public decimal MONTO_TOTAL { get; set; }
        public decimal MONTO_PAGADO { get; set; }
        public decimal MONTO_PENDIENTE { get; set; }
        public int ID_ESTADO { get; set; }
        public string OBSERVACION { get; set; }
        public string CREADO_POR { get; set; }
        public System.DateTime FECHA_CREADO { get; set; }
        public string CAMBIO_ESTADO_POR { get; set; }
        public string FECHA_CAMBIO_ESTADO { get; set; }
        public string NOTA_CAMBIO_ESTADO { get; set; }
        public string GARANTIA1 { get; set; }
        public string GARANTIA2 { get; set; }
        public string GARANTIA3 { get; set; }
        public string GARANTIA4 { get; set; }
        public string GARANTIA5 { get; set; }
        public string GARANTIA6 { get; set; }
        public string GARANTIA7 { get; set; }
        public Nullable<decimal> MONTO_DESCONTADO { get; set; }
        public string RUTA { get; set; }
    }
}
