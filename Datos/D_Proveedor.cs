using Entidades;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace Datos
{
   public class D_Proveedor
    {
        public List<E_Proveedor> Listar_Proveedores(string Condicion)
        {
            using (var db = new BD_JSYSEntities())
            {
                return db.Database.SqlQuery<E_Proveedor>(@"SP_LISTAR_PROVEEDORES @CONDICION", new SqlParameter("@CONDICION", Condicion)).ToList();
            }
        }

        public void Insertar_Proveedor(PROVEEDORES obj)
        {
            using (var db = new BD_JSYSEntities())
            {
                db.PROVEEDORES.Add(obj);
                db.SaveChanges();
            }
        }

        public void Actualizar_Proveedor(PROVEEDORES obj)
        {
            using (var db = new BD_JSYSEntities())
            {
                var obj_proveedor = db.PROVEEDORES.Find(obj.ID_PROVEEDOR);
                obj_proveedor.CELULAR = obj.CELULAR;
                obj_proveedor.CREADO_POR = obj.CREADO_POR;
                obj_proveedor.DIRECCION = obj.DIRECCION;
                obj_proveedor.EMAIL = obj.EMAIL;
                obj_proveedor.ESTADO = obj.ESTADO;
                obj_proveedor.FECHA_CREADO = obj.FECHA_CREADO;
                obj_proveedor.ID_TIPO_IDENTIFICACION = obj.ID_TIPO_IDENTIFICACION;
                obj_proveedor.NOMBRE = obj.NOMBRE;
                obj_proveedor.NUMERO_IDENTIFICACION = obj.NUMERO_IDENTIFICACION;
                obj_proveedor.TELEFONO = obj.TELEFONO;
                db.SaveChanges();
            }
        }
    }
}
