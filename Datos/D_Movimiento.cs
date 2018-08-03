using Entidades;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace Datos
{
   public class D_Movimiento
    {
        public List<E_Movimiento> Listar_Movimientos(string Condicion)
        {
            using (var db = new BD_JSYSEntities())
            {
                return db.Database.SqlQuery<E_Movimiento>(@"SP_LISTAR_MOVIMIENTOS @CONDICION", new SqlParameter("@CONDICION", Condicion)).ToList();
            }
        }

        public void Insertar_Movimiento(MOVIMIENTOS obj)
        {
            using (var db = new BD_JSYSEntities())
            {
                db.MOVIMIENTOS.Add(obj);
                db.SaveChanges();
            }
        }

        public void Actualizar_Movimiento(MOVIMIENTOS obj)
        {
            using (var db = new BD_JSYSEntities())
            {
                var obj_movimiento = db.MOVIMIENTOS.Find(obj.ID_MOVIMIENTO);
                obj_movimiento.ESTADO = obj.ESTADO;
                obj_movimiento.NOTA_ANULACION = obj.NOTA_ANULACION;
                obj_movimiento.ANULADO_POR = obj.ANULADO_POR;
                obj_movimiento.FECHA_ANULADO = obj.FECHA_ANULADO;
                db.SaveChanges();
            }
        }

        public void Entrada_Inventario(INVENTARIO_ARTICULOS obj)
        {
            using (var db = new BD_JSYSEntities())
            {
                   
                    if (db.INVENTARIO_ARTICULOS.Where(p => p.ID_ARTICULO == obj.ID_ARTICULO).Count() > 0)
                    {
                        var obj_inventario = db.INVENTARIO_ARTICULOS.Find(obj.ID_ARTICULO);
                        obj_inventario.ID_ARTICULO = obj.ID_ARTICULO;
                        obj_inventario.STOCK_ACTUAL = obj_inventario.STOCK_ACTUAL + obj.STOCK_ACTUAL;
                        db.SaveChanges();
                    }
                    else
                    {
                        db.INVENTARIO_ARTICULOS.Add(obj);
                        db.SaveChanges();
                    }   
            }
        }

        public void Salida_Inventario(INVENTARIO_ARTICULOS obj)
        {
            using (var db = new BD_JSYSEntities())
            {
                var obj_inventario = db.INVENTARIO_ARTICULOS.Find(obj.ID_ARTICULO);
                obj_inventario.STOCK_ACTUAL = obj_inventario.STOCK_ACTUAL - obj.STOCK_ACTUAL;
                db.SaveChanges();
            }
        }
    }
}
