using System;

namespace Entidades
{
   public class E_Proveedor
    {
        public int ID_PROVEEDOR { get; set; }
        public string NOMBRE { get; set; }
        public int ID_TIPO_IDENTIFICACION { get; set; }
        public string DESCRIPCION { get; set; }
        public string NUMERO_IDENTIFICACION { get; set; }
        public string DIRECCION { get; set; }
        public string TELEFONO { get; set; }
        public string CELULAR { get; set; }
        public string EMAIL { get; set; }
        public string ESTADO { get; set; }
        public string CREADO_POR { get; set; }
        public DateTime FECHA_CREADO { get; set; }
    }
}

