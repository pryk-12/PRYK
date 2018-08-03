using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace Datos
{
    public class D_Factura
    {
        public List<E_Factura> Listar_Facturas(string Condicion)
        {
            using (var db = new BD_JSYSEntities())
            {
                return db.Database.SqlQuery<E_Factura>(@"SP_LISTAR_FACTURAS @CONDICION", new SqlParameter("@CONDICION", Condicion)).ToList();
            }
        }

        public List<E_Detalles_Factura> Listar_Detalles_Facturas(string Condicion)
        {
            using (var db = new BD_JSYSEntities())
            {
                return db.Database.SqlQuery<E_Detalles_Factura>(@"SP_LISTAR_DETALLES_FACTURAS @CONDICION", new SqlParameter("@CONDICION", Condicion)).ToList();
            }
        }

        public List<E_Detalles_Cuota> Listar_Detalles_Cuotas(string Condicion)
        {
            using (var db = new BD_JSYSEntities())
            {
                return db.Database.SqlQuery<E_Detalles_Cuota>(@"SP_LISTAR_DETALLES_CUOTAS @CONDICION", new SqlParameter("@CONDICION", Condicion)).ToList();
            }
        }

        public List<E_Detalles_Cuota> Listar_Detalles_Cuotas_CXC(string Condicion)
        {
            using (var db = new BD_JSYSEntities())
            {
                return db.Database.SqlQuery<E_Detalles_Cuota>(@"SP_LISTAR_DETALLES_CUOTAS_CXC @CONDICION", new SqlParameter("@CONDICION", Condicion)).ToList();
            }
        }

        public List<E_Detalles_Cuotas_Web> Listar_Detalles_Cuotas_WEB(string Condicion)
        {
            using (var db = new BD_JSYSEntities())
            {
                return db.Database.SqlQuery<E_Detalles_Cuotas_Web>(@"SP_LISTAR_DETALLES_CUOTAS_CXC_WEB @CONDICION", new SqlParameter("@CONDICION", Condicion)).ToList();
            }
        }

        public List<E_Recibo> Listar_Recibos(string Condicion)
        {
            using (var db = new BD_JSYSEntities())
            {
                return db.Database.SqlQuery<E_Recibo>(@"SP_LISTAR_RECIBOS @CONDICION", new SqlParameter("@CONDICION", Condicion)).ToList();
            }
        }

        public List<E_Cuadre> Listar_Cuadre(DateTime Fecha)
        {
            using (var db = new BD_JSYSEntities())
            {
                return db.Database.SqlQuery<E_Cuadre>(@"SP_LISTAR_CUADRE_DEL_DIA @FECHA", new SqlParameter("@FECHA", Fecha)).ToList();
            }
        }

        public List<E_Cliente_X_Cobrador> Listar_Clientes_X_Cobrador(string Condicion)
        {
            using (var db = new BD_JSYSEntities())
            {
                return db.Database.SqlQuery<E_Cliente_X_Cobrador>(@"SP_LISTAR_CLIENTES_X_COBRADOR @CONDICION", new SqlParameter("@CONDICION", Condicion)).ToList();
            }
        }
        
        public void Insertar_Factura(FACTURAS obj)
        {
            using (var db = new BD_JSYSEntities())
            {
                db.FACTURAS.Add(obj);
                db.SaveChanges();
            }
        }

        public void Insertar_Detalle_Factura(DETALLES_FACTURAS obj)
        {
            using (var db = new BD_JSYSEntities())
            {
                db.DETALLES_FACTURAS.Add(obj);
                db.SaveChanges();
            }
        }

        public void Insertar_Encabezado_Cuota(ENCABEZADO_CUOTAS obj)
        {
            using (var db = new BD_JSYSEntities())
            {
                db.ENCABEZADO_CUOTAS.Add(obj);
                db.SaveChanges();
            }
        }

        public void Insertar_Detalle_Cuota(DETALLES_CUOTAS obj)
        {
            using (var db = new BD_JSYSEntities())
            {
                db.DETALLES_CUOTAS.Add(obj);
                db.SaveChanges();
            }
        }

        public void Cambiar_Estado_Factura(FACTURAS obj)
        {
            using (var db = new BD_JSYSEntities())
            {
                var obj_factura = db.FACTURAS.Find(obj.ID_FACTURA);
                obj_factura.ID_ESTADO = obj.ID_ESTADO;
                obj_factura.CAMBIO_ESTADO_POR = obj.CAMBIO_ESTADO_POR;
                obj_factura.FECHA_CAMBIO_ESTADO = obj.FECHA_CAMBIO_ESTADO;
                obj_factura.NOTA_CAMBIO_ESTADO = obj.NOTA_CAMBIO_ESTADO;
                db.SaveChanges();
            }
        }

        public void Actualizar_Inventario(INVENTARIO_ARTICULOS obj)
        {
            using (var db = new BD_JSYSEntities())
            {
                var obj_invetario = db.INVENTARIO_ARTICULOS.Find(obj.ID_ARTICULO);
                obj_invetario.STOCK_ACTUAL = obj_invetario.STOCK_ACTUAL - obj.STOCK_ACTUAL;
                db.SaveChanges();
            }
        }

        public void Actualizar_Inventario_Entrada(INVENTARIO_ARTICULOS obj)
        {
            using (var db = new BD_JSYSEntities())
            {
                var obj_invetario = db.INVENTARIO_ARTICULOS.Find(obj.ID_ARTICULO);
                obj_invetario.STOCK_ACTUAL = obj_invetario.STOCK_ACTUAL + obj.STOCK_ACTUAL;
                db.SaveChanges();
            }
        }

        public void Actualizar_Montos_Factura(FACTURAS obj)
        {
            using (var db = new BD_JSYSEntities())
            {
                var obj_factura = db.FACTURAS.Find(obj.ID_FACTURA);
                obj_factura.MONTO_PAGADO  = obj_factura.MONTO_PAGADO + obj.MONTO_PAGADO;
                obj_factura.MONTO_PENDIENTE = obj_factura.MONTO_PENDIENTE - obj.MONTO_PAGADO;
                db.SaveChanges();

            }
        }

        public void Cobrar_Cuota(DETALLES_CUOTAS obj)
        {
            using (var db = new BD_JSYSEntities())
            {
                var obj_detalle = db.DETALLES_CUOTAS.Where(a => a.ID_FACTURA == obj.ID_FACTURA).Where(a => a.NUMERO_CUOTA == obj.NUMERO_CUOTA).Single();
                obj_detalle.MONTO_PAGADO = obj_detalle.MONTO_PAGADO + obj.MONTO_PAGADO;
                obj_detalle.MONTO_PENDIENTE = obj.MONTO_PENDIENTE;
                db.SaveChanges();

            }
        }

        public void Insertar_Recibo_Cobros(RECIBOS_COBRADOS obj)
        {
            using (var db = new BD_JSYSEntities())
            {
                db.RECIBOS_COBRADOS.Add(obj);
                db.SaveChanges();
            }
        }

        public void Actualizar_Montos_Factura_Recibo_Anulado(FACTURAS obj)
        {
            using (var db = new BD_JSYSEntities())
            {
                var obj_factura = db.FACTURAS.Find(obj.ID_FACTURA);
                obj_factura.MONTO_PAGADO = obj_factura.MONTO_PAGADO - obj.MONTO_PAGADO;
                obj_factura.MONTO_PENDIENTE = obj_factura.MONTO_PENDIENTE + obj.MONTO_PAGADO;
                db.SaveChanges();
            }
        }

        public void Anular_Recibo(RECIBOS_COBRADOS obj)
        {
            using (var db = new BD_JSYSEntities())
            {
                var obj_recibo = db.RECIBOS_COBRADOS.Find(obj.ID_RECIBO);
                obj_recibo.ESTADO = obj.ESTADO;
                obj_recibo.FECHA_ANULADO = obj.FECHA_ANULADO;
                obj_recibo.ANULADO_POR = obj.ANULADO_POR;
                obj_recibo.NOTA_ANULACION = obj.NOTA_ANULACION;
                db.SaveChanges();
            }
        }

        public void Anular_Detalle_Cuota(DETALLES_CUOTAS obj)
        {
            using (var db = new BD_JSYSEntities())
            {
                var obj_detalle = db.DETALLES_CUOTAS.Where(a => a.ID_FACTURA == obj.ID_FACTURA).Where(a => a.NUMERO_CUOTA == obj.NUMERO_CUOTA).Single();
                obj_detalle.MONTO_PAGADO = obj_detalle.MONTO_PAGADO - obj.MONTO_PAGADO;
                obj_detalle.MONTO_PENDIENTE = obj_detalle.MONTO_PENDIENTE + obj.MONTO_PAGADO;
                db.SaveChanges();
            }
        }

        public void Insertar_Cuadre_Diario(CUADRES_DIARIOS obj)
        {
            using (var db = new BD_JSYSEntities())
            {
                db.CUADRES_DIARIOS.Add(obj);
                db.SaveChanges();
            }
        }

        public void Actualizar_Cuadre_Diario(CUADRES_DIARIOS obj)
        {
            using (var db = new BD_JSYSEntities())
            {
                var obj_cuadre = db.CUADRES_DIARIOS.Where(f => f.FECHA == obj.FECHA).Single();
                obj_cuadre.VALOR_ANULADO = obj.VALOR_ANULADO;
                obj_cuadre.VALOR_CXP_ANULADO = obj.VALOR_CXP_ANULADO;
                obj_cuadre.VALOR_CXP_PAGADO = obj.VALOR_CXP_PAGADO;
                obj_cuadre.VALOR_PAGADO = obj.VALOR_PAGADO;
                obj_cuadre.VALOR_TOTAL = obj.VALOR_TOTAL;
                db.SaveChanges();
            }
        }
    }
}
