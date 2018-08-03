using System;

namespace Entidades
{
   public class E_Articulo
    {
        public int ID_ARTICULO { get; set; }
        public string REFERENCIA { get; set; }
        public string DESCRIPCION { get; set; }
        public decimal PRECIO_COMPRA { get; set; }
        public decimal PRECIO_VENTA1 { get; set; }
        public decimal PRECIO_VENTA2 { get; set; }
        public decimal PRECIO_VENTA3 { get; set; }
        public int STOCK_MININO { get; set; }
        public string ESTADO { get; set; }
        public string CREADO_POR { get; set; }
        public DateTime FECHA_CREADO { get; set; }
        public byte[] IMAGEN { get; set; }
    }
}














