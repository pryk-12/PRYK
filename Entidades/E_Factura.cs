﻿using System;

namespace Entidades
{
   public class E_Factura
    {
        public int ID_FACTURA { get; set; }
        public int NUMERO_CONTRATO { get; set; }
        public DateTime FECHA { get; set; }
        public int ID_CLIENTE { get; set; }
        public string CLIENTE { get; set; }
        public int ID_COBRADOR { get; set; }
        public string COBRADOR { get; set; }
        public int ID_VENDEDOR { get; set; }
        public string VENDEDOR { get; set; }
        public string NUMERO_LOTERIA { get; set; }
        public decimal MONTO_TOTAL { get; set; }
        public decimal MONTO_PAGADO { get; set; }
        public decimal MONTO_PENDIENTE { get; set; }
        public string RUTA { get; set; }
        public int ID_ESTADO { get; set; }
        public string ESTADO { get; set; }
        public string OBSERVACION { get; set; }
        public string CREADO_POR { get; set; }
        public DateTime FECHA_CREADO { get; set; }
        public string CAMBIO_ESTADO_POR { get; set; }
        public string FECHA_CAMBIO_ESTADO { get; set; }
        public string NOTA_CAMBIO_ESTADO { get; set; }
    }
}
