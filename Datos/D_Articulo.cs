using Entidades;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace Datos
{
   public class D_Articulo
    {
        public List<E_Articulo> Listar_Articulos(string Condicion)
        {
            using (var db = new BD_JSYSEntities())
            {
                return db.Database.SqlQuery<E_Articulo>(@"SP_LISTAR_ARTICULOS @CONDICION", new SqlParameter("@CONDICION", Condicion)).ToList();
            }
        }

        public List<E_Inventario_Articulo> Listar_Inventario_Articulos(string Condicion)
        {
            using (var db = new BD_JSYSEntities())
            {
                return db.Database.SqlQuery<E_Inventario_Articulo>(@"SP_LISTAR_INVENTARIO_ARTICULOS @CONDICION", new SqlParameter("@CONDICION", Condicion)).ToList();
            }
        }


        public void Insertar_Articulo(ARTICULOS obj)
        {
            using (var db = new BD_JSYSEntities())
            {
                db.ARTICULOS.Add(obj);
                db.SaveChanges();
            }
        }

        public void Actualizar_Articulo(ARTICULOS obj)
        {
            using (var db = new BD_JSYSEntities())
            {
                var obj_articulo = db.ARTICULOS.Find(obj.ID_ARTICULO);
                obj_articulo.CREADO_POR = obj.CREADO_POR;
                obj_articulo.DESCRIPCION = obj.DESCRIPCION;
                obj_articulo.ESTADO = obj.ESTADO;
                obj_articulo.FECHA_CREADO = obj.FECHA_CREADO;
                obj_articulo.IMAGEN = obj.IMAGEN;
                obj_articulo.PRECIO_COMPRA = obj.PRECIO_COMPRA;
                obj_articulo.PRECIO_VENTA1 = obj.PRECIO_VENTA1;
                obj_articulo.PRECIO_VENTA2 = obj.PRECIO_VENTA2;
                obj_articulo.PRECIO_VENTA3 = obj.PRECIO_VENTA3;
                obj_articulo.REFERENCIA = obj.REFERENCIA;
                obj_articulo.STOCK_MININO = obj.STOCK_MININO;
                db.SaveChanges();
            }
        }
    }
}
