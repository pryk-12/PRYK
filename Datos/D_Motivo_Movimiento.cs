using Entidades;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace Datos
{
   public class D_Motivo_Movimiento
    {
        public List<E_Motivo_Movimiento> Listar_Motivos_Movimientos(string Condicion)
        {
            using (var db = new BD_JSYSEntities())
            {
                return db.Database.SqlQuery<E_Motivo_Movimiento>(@"SP_LISTAR_MOTIVOS_MOVIMIENTOS @CONDICION", new SqlParameter("@CONDICION", Condicion)).ToList();
            }
        }

        public void Insertar_Motivo_Movimiento(MOTIVOS_MOVIMIENTOS obj)
        {
            using (var db = new BD_JSYSEntities())
            {
                db.MOTIVOS_MOVIMIENTOS.Add(obj);
                db.SaveChanges();
            }
        }

        public void Actualizar_Motivo_Movimiento(MOTIVOS_MOVIMIENTOS obj)
        {
            using (var db = new BD_JSYSEntities())
            {
                var obj_motivo = db.MOTIVOS_MOVIMIENTOS.Find(obj.ID_MOTIVO);
                obj_motivo.ESTADO = obj.ESTADO;
                obj_motivo.DESCRIPCION = obj.DESCRIPCION;
                obj_motivo.OBSERVACION = obj.OBSERVACION;
                obj_motivo.TIPO_MOVIMIENTO = obj.TIPO_MOVIMIENTO;
                db.SaveChanges();
            }
        }
    }
}
