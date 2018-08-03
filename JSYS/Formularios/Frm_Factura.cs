﻿using System;
using System.Windows.Forms;
using System.Linq;
using Servicios;
using Datos;
using System.Collections.Generic;
using Entidades;
using DevExpress.XtraReports.UI;
namespace JSYS.Formularios
{
    public partial class Frm_Factura : JSYS.Formularios.Frm_Plantilla
    {

        public class _CLIENTE
        {
            public int ID_CLIENTE { get; set; }
            public string NOMBRE { get; set; }
        }

        public class _VENDEDOR
        {
            public int ID_VENDEDOR { get; set; }
            public string NOMBRE { get; set; }
        }
        public class _COBRADOR
        {
            public int ID_COBRADOR { get; set; }
            public string NOMBRE { get; set; }
        }
        public class _USUARIO
        {
            public int ID_USUARIO { get; set; }
            public string NOMBRE { get; set; }
        }
        public Frm_Factura()
        {
            InitializeComponent();

            S_Utilidades.Llenar_ComboBox<_CLIENTE>(cb_cliente, "NOMBRE", "ID_CLIENTE", "NOMBRE LIKE'%" + "" + "%' AND ESTADO='A'", "CLIENTES");
            S_Utilidades.Llenar_ComboBox<_USUARIO>(cb_vendedor, "NOMBRE", "ID_USUARIO", "NOMBRE LIKE'%" + "" + "%' AND TIPO='Vendedor' AND ESTADO='A'", "USUARIOS");
            S_Utilidades.Llenar_ComboBox<_USUARIO>(cb_cobrador, "NOMBRE", "ID_USUARIO", "NOMBRE LIKE'%" + "" + "%' AND TIPO='Cobrador' AND ESTADO='A'", "USUARIOS");
            S_Utilidades.Llenar_ComboBox<ESTADO_FACTURAS>(cb_estado, "DESCRIPCION", "ID_ESTADO", "DESCRIPCION LIKE'%" + "" + "%'", "ESTADO_FACTURAS");
        }


        public void Recibir_Datos(FACTURAS obj)
        {
            using (var db = new BD_JSYSEntities())
            {
                //factura
                var obj_factura = db.FACTURAS.Find(obj.ID_FACTURA);
                txt_numero_factura.Text = obj_factura.ID_FACTURA.ToString();
                txt_numero_contrato.Text = obj_factura.NUMERO_CONTRATO.ToString();
                txt_observacion.Text = obj_factura.OBSERVACION;
                txt_total.Text = obj_factura.MONTO_TOTAL.ToString("N2");
                cb_cliente.SelectedValue = obj_factura.ID_CLIENTE;
                cb_cobrador.SelectedValue = obj_factura.ID_COBRADOR;
                cb_estado.SelectedValue = obj_factura.ID_ESTADO;
                cb_numero_loteria.Text = obj_factura.NUMERO_LOTERIA;
                cb_vendedor.SelectedValue = obj_factura.ID_VENDEDOR;

                groupBox3.Enabled = false;
                groupBox6.Enabled = false;
                groupBox7.Enabled = false;
                groupBox8.Enabled = false;
                btn_agregar_articulo.Enabled = false;
                btn_quitar_articulo.Enabled = false;
                txt_total.Enabled = false;
                dg_detalle_cuotas.Enabled = false;
                
                if(cb_estado.Text !="Activo")
                {
                    cb_estado.Enabled = false ;
                    txt_observacion.Enabled = false;
                    btn_guardar.Enabled = false;
                }

                //detalle factura
                List<E_Detalles_Factura> Lista_Detalle = S_Factura.Listar_Detalles_Facturas("A.ID_FACTURA=" + obj_factura.ID_FACTURA + "");
                dg_detalle_factura.Rows.Clear();
                foreach (E_Detalles_Factura p in Lista_Detalle)
                {
                    dg_detalle_factura.Rows.Add(p.ID_ARTICULO, p.REFERENCIA,p.DESCRIPCION,p.CANTIDAD,p.PRECIO,p.MONTO_TOTAL.ToString("n2"));
                }               
                dg_detalle_factura.DataSource = null;

                //encabezado cuotas
                var encabezado = db.ENCABEZADO_CUOTAS.Where(e => e.ID_FACTURA == obj_factura.ID_FACTURA).Single();
                cb_modo_calculo.Text = encabezado.MODO_CALCULO;
                txt_cantidad_cuota.Text = encabezado.CANTIADA_CUOTA.ToString();
                dt_fecha_primera_cuota.Text = encabezado.FECHA_PRIMERA_CUOTA.ToString();              

                //detalle cuotas
                List<E_Detalles_Cuota> Lista_Cuotas = S_Factura.Listar_Detalles_Cuotas("A.ID_FACTURA=" + obj_factura.ID_FACTURA + "");
                dg_detalle_cuotas.Rows.Clear();
                foreach (E_Detalles_Cuota p in Lista_Cuotas)
                {
                    dg_detalle_cuotas.Rows.Add(p.NUMERO_CUOTA, p.FECHA.ToString("dd/MM/yyyy"), p.MONTO_CUOTA);
                }
                dg_detalle_cuotas.DataSource = null;
            }
        }

        public void Titulo(string Titulo)
        {
            Lbl_Titulo.Text = Titulo;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Frm_Consultar_Articulo_Para_Factura frm = new Frm_Consultar_Articulo_Para_Factura();
            frm.ShowDialog();
        }

        public void Calcular_Cuotas()
        {
            DateTime fecha = dt_fecha_primera_cuota.Value;
            DateTime fecha_1 = dt_fecha_primera_cuota.Value;
            decimal valor_cuotas;
            decimal total = Convert.ToDecimal(txt_total.Text);
            int numero_cuotas = Convert.ToInt32(txt_cantidad_cuota.Text);

            valor_cuotas = (total / numero_cuotas );
            dg_detalle_cuotas.Rows.Clear();

            if (cb_modo_calculo.Text == "Semanal")
            {
                for (int index = 1; (index <= numero_cuotas); index++)
                {
                    fecha = fecha;
                    dg_detalle_cuotas.Rows.Add(index, fecha.ToString("dd/MM/yyyy"), valor_cuotas);
                    fecha = fecha.AddDays(7);
                }
            }

            if (cb_modo_calculo.Text == "Quincenal")
            {
                for (int index = 1; (index <= numero_cuotas); index++)
                {
                    fecha = fecha;
                    dg_detalle_cuotas.Rows.Add(index, fecha.ToString("dd/MM/yyyy"), valor_cuotas);
                    fecha = fecha.AddDays(15);
                }
            }

            if (cb_modo_calculo.Text == "Mensual")
            {
                for (int index = 1; (index <= numero_cuotas); index++)
                {
                    fecha = fecha;
                    dg_detalle_cuotas.Rows.Add(index, fecha.ToString("dd/MM/yyyy"), valor_cuotas);
                    fecha = fecha.AddMonths(1);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(txt_total.TextLength ==0)
            {
                S_Utilidades.Mensaje_Informacion("La Factura no tiene Monto Calculado");
                return;
            }

            if (cb_modo_calculo.Text.Equals(""))
            {
                S_Utilidades.Mensaje_Informacion("El Modo de Calculo es Obligatorio");
                cb_modo_calculo.Focus();
                return;
            }

            if (txt_cantidad_cuota.TextLength == 0)
            {
                S_Utilidades.Mensaje_Informacion("La Cantidad de Cuota es Obligatorio");
                txt_cantidad_cuota.Focus();
                return;
            }

            Calcular_Cuotas();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_Consultar_Cliente_Para_Factura frm = new Frm_Consultar_Cliente_Para_Factura();
            frm.ShowDialog();
        }

        public void Insertar()
        {
            try
            {
                //insertar_factura
                FACTURAS obj_factura = new FACTURAS();
                obj_factura.CREADO_POR = S_Utilidades.Datos_Usuario.USUARIO;
                obj_factura.CAMBIO_ESTADO_POR = "";
                obj_factura.FECHA = dt_fecha_factura.Value;
                obj_factura.FECHA_CAMBIO_ESTADO = "";
                obj_factura.FECHA_CREADO = DateTime.Now;
                obj_factura.ID_CLIENTE = Convert.ToInt32(cb_cliente.SelectedValue);
                obj_factura.ID_COBRADOR = Convert.ToInt32(cb_cobrador.SelectedValue);
                obj_factura.ID_ESTADO = Convert.ToInt32(cb_estado.SelectedValue);
                obj_factura.ID_VENDEDOR = Convert.ToInt32(cb_vendedor.SelectedValue);
                obj_factura.MONTO_PAGADO = 0;
                obj_factura.MONTO_PENDIENTE = Convert.ToDecimal(txt_total.Text);
                obj_factura.MONTO_TOTAL = Convert.ToDecimal(txt_total.Text);
                obj_factura.NOTA_CAMBIO_ESTADO = "";
                obj_factura.NUMERO_CONTRATO = Convert.ToInt32(txt_numero_contrato.Text);
                obj_factura.NUMERO_LOTERIA = cb_numero_loteria.Text;
                obj_factura.OBSERVACION = txt_observacion.Text.Trim();

                S_Factura.Insertar_Factura(obj_factura);

                BD_JSYSEntities db = new BD_JSYSEntities();

                //obtener ultimo numero de factura
                int id_factura = db.FACTURAS.Max(m => m.ID_FACTURA);

                //insertar detalles factura
                foreach (DataGridViewRow row in dg_detalle_factura.Rows)
                {
                    DETALLES_FACTURAS obj_detalle_factura = new DETALLES_FACTURAS();

                    obj_detalle_factura.ID_FACTURA = id_factura;
                    obj_detalle_factura.ID_ARTICULO = Convert.ToInt32(row.Cells[0].Value);
                    obj_detalle_factura.CANTIDAD = Convert.ToInt32(row.Cells[3].Value);
                    obj_detalle_factura.PRECIO = Convert.ToDecimal(row.Cells[4].Value);
                    obj_detalle_factura.MONTO_TOTAL = Convert.ToDecimal(row.Cells[5].Value);

                    S_Factura.Insertar_Detalle_Factura(obj_detalle_factura);

                    //actualizar inventario
                    INVENTARIO_ARTICULOS obj_inventario = new INVENTARIO_ARTICULOS();
                    obj_inventario.ID_ARTICULO = Convert.ToInt32(row.Cells[0].Value);
                    obj_inventario.STOCK_ACTUAL = Convert.ToInt32(row.Cells[3].Value);

                    S_Factura.Actualizar_Inventario(obj_inventario);
                }
               
                //insertar encabezado cuota
                ENCABEZADO_CUOTAS obj_encabezado_cuota = new ENCABEZADO_CUOTAS();
                obj_encabezado_cuota.CANTIADA_CUOTA = Convert.ToInt32(txt_cantidad_cuota.Text);
                obj_encabezado_cuota.ID_FACTURA = id_factura;
                obj_encabezado_cuota.MODO_CALCULO = cb_modo_calculo.Text;
                obj_encabezado_cuota.FECHA_PRIMERA_CUOTA = dt_fecha_primera_cuota.Value;
                S_Factura.Insertar_Encabezado_Cuota(obj_encabezado_cuota);

                //insertar detalles cuotas
                foreach (DataGridViewRow row in dg_detalle_cuotas.Rows)
                {
                    DETALLES_CUOTAS obj_detalle_cuotas = new DETALLES_CUOTAS();

                    obj_detalle_cuotas.ID_FACTURA = id_factura;
                    obj_detalle_cuotas.NUMERO_CUOTA = Convert.ToInt32(row.Cells[0].Value);
                    obj_detalle_cuotas.FECHA = Convert.ToDateTime(row.Cells[1].Value);
                    obj_detalle_cuotas.MONTO_CUOTA = Convert.ToDecimal(row.Cells[2].Value);
                    obj_detalle_cuotas.MONTO_PAGADO = 0;
                    obj_detalle_cuotas.MONTO_PENDIENTE = Convert.ToDecimal(row.Cells[2].Value);

                    S_Factura.Insertar_Detalle_Cuota(obj_detalle_cuotas);
                }
                Close();
            }
            catch (Exception ex)
            {
                S_Utilidades.Mensaje_Error(ex.Message);
            }
        }

        public void Cambiar_Estado()
        {
            FACTURAS obj_factura = new FACTURAS();
            
            if(cb_estado.Text =="Activo")
            {
                return;
            }
                obj_factura.ID_FACTURA = Convert.ToInt32(txt_numero_factura.Text);
                obj_factura.ID_ESTADO = Convert.ToInt32(cb_estado.SelectedValue);
                obj_factura.CAMBIO_ESTADO_POR = S_Utilidades.Datos_Usuario.USUARIO;
                obj_factura.FECHA_CAMBIO_ESTADO = DateTime.Now.ToString("dd/MM/yyyy");
                obj_factura.NOTA_CAMBIO_ESTADO = txt_observacion.Text.Trim();
                S_Factura.Cambiar_Estado_Factura(obj_factura);
                
                if (cb_estado.Text == "Anulado" || cb_estado.Text == "Abandonado")
                {
                    foreach (DataGridViewRow row in dg_detalle_factura.Rows)
                    {
                        //actualizar inventario
                        INVENTARIO_ARTICULOS obj_inventario = new INVENTARIO_ARTICULOS();
                        obj_inventario.ID_ARTICULO = Convert.ToInt32(row.Cells[0].Value);
                        obj_inventario.STOCK_ACTUAL = Convert.ToInt32(row.Cells[3].Value);

                        S_Factura.Actualizar_Inventario_Entrada(obj_inventario);
                    }
                }
                S_Utilidades.Mensaje_Informacion("Datos Actualizados con Exito");
                Close();        
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if(cb_cliente.Text =="")
            {
                S_Utilidades.Mensaje_Informacion("El Cliente es Obligatorio");
                cb_cliente.Focus();
                return;
            }

            if (txt_numero_contrato.Text == "")
            {
                S_Utilidades.Mensaje_Informacion("El Numero de Contrato es Obligatorio");
                txt_numero_contrato.Focus();
                return;
            }

            if (cb_numero_loteria.Text == "")
            {
                S_Utilidades.Mensaje_Informacion("El Numero de Loteria Obligatorio");
                cb_numero_loteria.Focus();
                return;
            }

            if (cb_vendedor.Text == "")
            {
                S_Utilidades.Mensaje_Informacion("El Venderor es Obligatorio");
                cb_vendedor.Focus();
                return;
            }

            if (cb_cobrador.Text == "")
            {
                S_Utilidades.Mensaje_Informacion("El Cobrador es Obligatorio");
                cb_cobrador.Focus();
                return;
            }

            if (cb_estado.Text == "")
            {
                S_Utilidades.Mensaje_Informacion("El Estado es Obligatorio");
                cb_estado.Focus();
                return;
            }

            if (dg_detalle_factura.Rows.Count == 0)
            {
                S_Utilidades.Mensaje_Informacion("Se debe Ingresar por lo menos un Articulo");
                return;
            }

            if(dg_detalle_cuotas.Rows.Count==0)
            {
                S_Utilidades.Mensaje_Informacion("Se debe hacer el Calculo de las Cuotas");
                tabControl1.SelectedIndex = 1;
                return;
            }
            if (txt_numero_factura.TextLength == 0)
            {
                Insertar();

                 DialogResult Resultado = MessageBox.Show("Deseas Imprimir La Factura", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                 if (Resultado == DialogResult.Yes)
                 {
                     Imprimir();
                 }
            }
            else
            {
                if(txt_observacion.Text =="")
                {
                    S_Utilidades.Mensaje_Informacion("La Observación es Obligatorio");
                    return;
                }
                Cambiar_Estado();
            }
        }

        private void Frm_Factura_Load(object sender, EventArgs e)
        {
            if(txt_numero_factura.Text.Equals("") )
            {
                cb_estado.Text = "Activo";
                cb_estado.Enabled = false;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Reportes.Rep_Factura report = new Reportes.Rep_Factura();
            report.FilterString = "([ID_FACTURA]= " + txt_numero_factura.Text + ")";
            ReportPrintTool tool = new ReportPrintTool(report);
            tool.ShowPreview();
        }

        public void Imprimir()
        {
            Reportes.Rep_Factura report = new Reportes.Rep_Factura();
            BD_JSYSEntities db = new BD_JSYSEntities();
            var id_factura = db.FACTURAS.Where(r => r.CREADO_POR == S_Utilidades.Datos_Usuario.USUARIO).Max(r => r.ID_FACTURA);
            report.FilterString = "([ID_FACTURA]= " + id_factura + ")";
            ReportPrintTool tool = new ReportPrintTool(report);
            tool.ShowPreview();
        }
    }
}