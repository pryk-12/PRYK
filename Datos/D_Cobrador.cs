using Entidades;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace Datos
{
   public class D_Cobrador
    {
        public List<E_Cobrador> Listar_Cobradores(string Condicion)
        {
            using (var db = new BD_JSYSEntities())
            {
                return db.Database.SqlQuery<E_Cobrador>(@"SP_LISTAR_COBRADORES @CONDICION", new SqlParameter("@CONDICION", Condicion)).ToList();
            }
        }

        public void Insertar_Cobrador(COBRADORES obj)
        {
            using (var db = new BD_JSYSEntities())
            {
                db.COBRADORES.Add(obj);
                db.SaveChanges();
            }
        }

        public void Actualizar_Cobrador(COBRADORES obj)
        {
            using (var db = new BD_JSYSEntities())
            {
                var obj_cobrador = db.COBRADORES.Find(obj.ID_COBRADOR);
                obj_cobrador.CREADO_POR = obj.CREADO_POR;
                obj_cobrador.ESTADO = obj.ESTADO;
                obj_cobrador.FECHA_CREADO = obj.FECHA_CREADO;
                obj_cobrador.ID_TIPO_IDENTIFICACION = obj.ID_TIPO_IDENTIFICACION;
                obj_cobrador.NOMBRE = obj.NOMBRE;
                obj_cobrador.NUMERO_IDENTIFICACION = obj.NUMERO_IDENTIFICACION;
                obj_cobrador.SEXO = obj.SEXO;
                obj_cobrador.RUTA = obj.RUTA;
                db.SaveChanges();
            }
        }
    }
}
