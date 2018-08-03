using Entidades;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace Datos
{
   public class D_CXP
    {
        public List<E_CXP> Listar_CXP(string Condicion)
        {
            using (var db = new BD_JSYSEntities())
            {
                return db.Database.SqlQuery<E_CXP>(@"SP_LISTAR_CXP @CONDICION", new SqlParameter("@CONDICION", Condicion)).ToList();
            }
        }

        public void Insertar_CXP(CXP obj)
        {
            using (var db = new BD_JSYSEntities())
            {
                db.CXP.Add(obj);
                db.SaveChanges();
            }
        }

        public void Actualizar_CXP(CXP obj)
        {
            using (var db = new BD_JSYSEntities())
            {
                var obj_cxp = db.CXP.Where(p => p.ID_MOVIMIENTO== obj.ID_MOVIMIENTO).Single();
                obj_cxp.ESTADO = obj.ESTADO;
                obj_cxp.NOTA_ANULACION = obj.NOTA_ANULACION;
                obj_cxp.ANULADO_POR = obj.ANULADO_POR;
                obj_cxp.FECHA_ANULACION = obj.FECHA_ANULACION;
                db.SaveChanges();
            }
        }


        public List<E_Pago_CXP> Listar_Pago_CXP(string Condicion)
        {
            using (var db = new BD_JSYSEntities())
            {
                return db.Database.SqlQuery<E_Pago_CXP>(@"SP_LISTAR_PAGOS_CXP @CONDICION", new SqlParameter("@CONDICION", Condicion)).ToList();
            }
        }

        public void Insertar_Pago_CXP(PAGOS_CXP obj)
        {
            using (var db = new BD_JSYSEntities())
            {
                db.PAGOS_CXP.Add(obj);
                db.SaveChanges();
            }
        }

        public void Anular_Pago_CXP(PAGOS_CXP obj)
        {
            using (var db = new BD_JSYSEntities())
            {
                var obj_cxp = db.PAGOS_CXP.Where(p => p.ID_PAGO == obj.ID_PAGO).Single();
                obj_cxp.ESTADO = obj.ESTADO;
                obj_cxp.NOTA_ANULACION = obj.NOTA_ANULACION;
                obj_cxp.ANULADO_POR = obj.ANULADO_POR;
                obj_cxp.FECHA_ANULACION = obj.FECHA_ANULACION;
                db.SaveChanges();
            }
        }

        //public void Actualizar_Monto_Por_Anulacion_CXP(CXP obj)
        //{
        //    using (var db = new BD_JSYSEntities())
        //    {
        //        var obj_cxp = db.CXP.Where(p => p.ID_CXP == obj.ID_CXP).Single();
        //        obj_cxp.MONTO_PAGADO = (obj_cxp.MONTO_PAGADO - obj.MONTO_PAGADO);
        //        obj_cxp.MONTO_PENDIENTE = (obj.MONTO_PENDIENTE + obj.MONTO_PENDIENTE);
        //        db.SaveChanges();
        //    }
        //}

        public void Actualizar_Monto(CXP obj)
        {
            using (var db = new BD_JSYSEntities())
            {
                var obj_cxp = db.CXP.Where(p => p.ID_CXP == obj.ID_CXP).Single();
                obj_cxp.MONTO_PAGADO = obj.MONTO_PAGADO;
                obj_cxp.MONTO_PENDIENTE = obj.MONTO_PENDIENTE;
                db.SaveChanges();
            }
        }
    }
}
