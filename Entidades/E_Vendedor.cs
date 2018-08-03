using System;

namespace Entidades
{
   public class E_Vendedor
    {
        public int ID_VENDEDOR { get; set; }
        public string NOMBRE { get; set; }
        public int ID_TIPO_IDENTIFICACION { get; set; }
        public string DESCRIPCION { get; set; }
        public string NUMERO_IDENTIFICACION { get; set; }
        public string ESTADO { get; set; }
        public string SEXO { get; set; }
        public string CREADO_POR { get; set; }
        public DateTime FECHA_CREADO { get; set; }
    }
}

