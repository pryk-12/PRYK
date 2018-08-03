
namespace Entidades
{
   public class E_Inventario_Articulo
    {
       public int ID_ARTICULO { get; set; }
       public string REFERENCIA { get; set; }
       public string DESCRIPCION { get; set; }
       public decimal PRECIO_COMPRA { get; set; }
       public decimal PRECIO_VENTA1 { get; set; }
       public decimal PRECIO_VENTA2 { get; set; }
       public decimal PRECIO_VENTA3 { get; set; }
       public int STOCK_ACTUAL { get; set; }
    }
}
