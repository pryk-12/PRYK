using Entidades;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace Datos
{
   public class D_Vendedor
    {
        public List<E_Vendedor> Listar_Vendedores(string Condicion)
        {
            using (var db = new BD_JSYSEntities())
            {
                return db.Database.SqlQuery<E_Vendedor>(@"SP_LISTAR_VENDEDORES @CONDICION", new SqlParameter("@CONDICION", Condicion)).ToList();
            }
        }

        public void Insertar_Vendedor(VENDEDORES obj)
        {
            using (var db = new BD_JSYSEntities())
            {
                db.VENDEDORES.Add(obj);
                db.SaveChanges();
            }
        }

        public void Actualizar_Vendedor(VENDEDORES obj)
        {
            using (var db = new BD_JSYSEntities())
            {
                var obj_vendedor = db.VENDEDORES.Find(obj.ID_VENDEDOR);
                obj_vendedor.CREADO_POR = obj.CREADO_POR;
                obj_vendedor.ESTADO = obj.ESTADO;
                obj_vendedor.FECHA_CREADO = obj.FECHA_CREADO;
                obj_vendedor.ID_TIPO_IDENTIFICACION = obj.ID_TIPO_IDENTIFICACION;
                obj_vendedor.NOMBRE = obj.NOMBRE;
                obj_vendedor.NUMERO_IDENTIFICACION = obj.NUMERO_IDENTIFICACION;
                obj_vendedor.SEXO = obj.SEXO;
                db.SaveChanges();
            }
        }
    }
}
