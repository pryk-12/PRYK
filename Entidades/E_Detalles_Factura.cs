
namespace Entidades
{
   public class E_Detalles_Factura
    {
        public int ID_FACTURA { get; set; }
        public int ID_ARTICULO { get; set; }
        public string REFERENCIA { get; set; }
        public string DESCRIPCION { get; set; }
        public int CANTIDAD { get; set; }
        public decimal PRECIO { get; set; }
        public decimal MONTO_TOTAL { get; set; }
    }
}
