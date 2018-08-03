using Datos;
using Servicios;
using System;
using System.Windows.Forms;
using System.Linq;

namespace JSYS.Formularios
{
    public partial class Frm_Movimiento : JSYS.Formularios.Frm_Plantilla
    {
        public class _MOTIVOS_MOVIMIENTOS
        {
            public int ID_MOTIVO { get; set; }
            public string DESCRIPCION { get; set; }
        }

        public class _PROVEEDORES
        {
            public int ID_PROVEEDOR { get; set; }
            public string NOMBRE { get; set; }
        }

        public Frm_Movimiento()
        {
            InitializeComponent();
            S_Utilidades.Llenar_ComboBox<_MOTIVOS_MOVIMIENTOS>(cb_motivo_movimiento, "DESCRIPCION", "ID_MOTIVO", "DESCRIPCION LIKE'%" + "" + "%'", "MOTIVOS_MOVIMIENTOS");
            S_Utilidades.Llenar_ComboBox<_PROVEEDORES>(cb_proveedor, "NOMBRE", "ID_PROVEEDOR", "NOMBRE LIKE'%" + "" + "%'", "PROVEEDORES");
        }

        private void Frm_Movimiento_Load(object sender, EventArgs e)
        {
            tabControl1.Controls.Remove(tabPage2);
            if (Txt_ID.Text == "")
            {
                cb_estado.Text = "Vigente";
                cb_estado_cxp.Text = "Vigente";
                cb_estado_cxp.Enabled = false;
                cb_estado.Enabled = false;
            }
        }

        void frm_Closed(object sender, EventArgs e)
        {
            try
            {
                txt_referencia.Text = S_Utilidades.Datos_Entidades.REFERENCIA;
                buscar_articulo();
            }
            catch
            {
            }
        }

        void frm_Closed_CXP(object sender, EventArgs e)
        {
            try
            {
                cb_proveedor.SelectedValue = S_Utilidades.Datos_Entidades.ID_PROVEEDOR;
            }
            catch
            {
            }        
        }

        public void Recibir_Datos(MOVIMIENTOS obj)
        {
            using (var db = new BD_JSYSEntities())
            {
                var obj_movimiento = db.MOVIMIENTOS.Find(obj.ID_MOVIMIENTO);
                Txt_ID.Text = obj_movimiento.ID_MOVIMIENTO.ToString();
                txt_articulo.Text = db.ARTICULOS.Find(obj_movimiento.ID_ARTICULO).DESCRIPCION;
                txt_cantidad.Text = obj_movimiento.CANTIDAD.ToString();
                txt_observacion.Text = obj_movimiento.OBSERVACION;
                txt_referencia.Text = db.ARTICULOS.Find(obj_movimiento.ID_ARTICULO).REFERENCIA;
                txt_tipo_movimiento.Text = db.MOTIVOS_MOVIMIENTOS.Find(obj_movimiento.ID_MOTIVO).TIPO_MOVIMIENTO;
                cb_estado.Text = obj_movimiento.ESTADO == "V" ? "Vigente" : "Anulado";
                cb_motivo_movimiento.SelectedValue = obj_movimiento.ID_MOTIVO;
                btn_consultar.Enabled = false;
                buscar_articulo();

                txt_cantidad.Enabled = false;
                txt_referencia.Enabled = false;
                cb_motivo_movimiento.Enabled = false;

                if (cb_estado.Text == "Anulado")
                {
                    groupBox1.Enabled = false;
                    groupBox2.Enabled = false;
                    groupBox3.Enabled = false;
                }
            }
        }

        public void Recibir_Datos_CXP(CXP obj)
        {
            using (var db = new BD_JSYSEntities())
            {
                var obj_cxp = db.CXP.Find(obj.ID_CXP);
                txt_id_cxp.Text = obj_cxp.ID_CXP.ToString();
                txt_numero_factura.Text = obj_cxp.NUMERO_FACTURA;
                cb_proveedor.SelectedValue = obj_cxp.ID_PROVEEDOR;
                txt_observacion_cxp.Text = obj_cxp.OBSERVACION;
                cb_estado.Text = obj_cxp.ESTADO == "V" ? "Vigente" : "Anulado";
            }
        }

        public void Titulo(string Titulo)
        {
            Lbl_Titulo.Text = Titulo;
        }

        public void Insertar_CXP()
        {
            BD_JSYSEntities db = new BD_JSYSEntities();
            CXP obj_cxp = new CXP();
            obj_cxp.CREADO_POR = S_Utilidades.Datos_Usuario.USUARIO;
            obj_cxp.ESTADO = cb_estado_cxp.Text == "Vigente" ? "V" : "A";
            obj_cxp.FECHA_CREADO = DateTime.Now;
            obj_cxp.ID_PROVEEDOR = Convert.ToInt32(cb_proveedor.SelectedValue);
            obj_cxp.MONTO_PAGADO = 0;
            obj_cxp.MONTO_PENDIENTE = Convert.ToDecimal(txt_monto.Text);
            obj_cxp.MONTO_TOTAL = Convert.ToDecimal(txt_monto.Text);
            obj_cxp.NUMERO_FACTURA = txt_numero_factura.Text.Trim();
            obj_cxp.OBSERVACION = txt_observacion_cxp.Text.Trim();
            obj_cxp.ANULADO_POR = "";
            obj_cxp.FECHA_ANULACION = "";
            obj_cxp.NOTA_ANULACION = "";
            obj_cxp.ID_MOVIMIENTO = db.MOVIMIENTOS.Max(m => m.ID_MOVIMIENTO);
            S_CXP.Insertar_CXP(obj_cxp);
        }

        public void Anular_CXP()
        {
            BD_JSYSEntities db = new BD_JSYSEntities();
            CXP obj_cxp = new CXP();
            obj_cxp.ESTADO = cb_estado.Text == "Vigente" ? "V" : "A";
            obj_cxp.ANULADO_POR = S_Utilidades.Datos_Usuario.USUARIO; ;
            obj_cxp.FECHA_ANULACION = DateTime.Now.ToString();
            obj_cxp.NOTA_ANULACION = txt_observacion.Text.Trim(); ;
            obj_cxp.ID_MOVIMIENTO = Convert.ToInt32(Txt_ID.Text);
            S_CXP.Actualizar_CXP(obj_cxp);
        }

        public void Actualizar_Inventario_Por_Movimiento()
        {
            INVENTARIO_ARTICULOS obj_inventario = new INVENTARIO_ARTICULOS();
            obj_inventario.ID_ARTICULO = Convert.ToInt32(txt_id_articulo.Text);
            obj_inventario.STOCK_ACTUAL = Convert.ToInt32(txt_cantidad.Text);

            if (txt_tipo_movimiento.Text == "Entrada")
            {
                S_Movimiento.Entrada_Inventario(obj_inventario);
            }
            else
            {
                S_Movimiento.Salida_Inventario(obj_inventario);
            }
        }

        public void Actualizar_Inventario_Por_Anulacion()
        {
            INVENTARIO_ARTICULOS obj_inventario = new INVENTARIO_ARTICULOS();
            obj_inventario.ID_ARTICULO = Convert.ToInt32(txt_id_articulo.Text);
            obj_inventario.STOCK_ACTUAL = Convert.ToInt32(txt_cantidad.Text);

            if (txt_tipo_movimiento.Text == "Entrada")
            {
                S_Movimiento.Salida_Inventario(obj_inventario);
            }
            else
            {
                S_Movimiento.Entrada_Inventario(obj_inventario);
            }
        }

        public void Insertar()
        {
            string Mensaje = "";
            try
            {
                MOVIMIENTOS obj = new MOVIMIENTOS();
                obj.CANTIDAD = Convert.ToInt32(txt_cantidad.Text);
                obj.CREADO_POR = S_Utilidades.Datos_Usuario.USUARIO;
                obj.ESTADO = cb_estado.Text == "Vigente" ? "V" : "A";
                obj.FECHA_CREADO = DateTime.Now;
                obj.ID_ARTICULO = Convert.ToInt32(txt_id_articulo.Text);
                obj.ID_MOTIVO = Convert.ToInt32(cb_motivo_movimiento.SelectedValue);
                obj.OBSERVACION = txt_observacion.Text.Trim();


                if (Txt_ID.Text.Equals(""))
                {
                    obj.ANULADO_POR = "";
                    obj.FECHA_ANULADO = "";
                    obj.NOTA_ANULACION = "";

                    //Insertar Movimiento
                    S_Movimiento.Insertar_Movimiento(obj);

                    //Insertar CXP
                    if (Convert.ToInt32(cb_motivo_movimiento.SelectedValue) == 3)
                    {
                        Insertar_CXP();
                    }

                    //Actualizar Inventario
                    Actualizar_Inventario_Por_Movimiento();

                    Mensaje = "Registro Insertado con Éxito";
                }
                else
                {
                    if (cb_estado.Text == "Anulado")
                    {
                        obj.ID_MOVIMIENTO = Convert.ToInt32(Txt_ID.Text);
                        obj.ANULADO_POR = S_Utilidades.Datos_Usuario.USUARIO;
                        obj.FECHA_ANULADO = DateTime.Now.ToString();
                        obj.NOTA_ANULACION = txt_observacion.Text.Trim();

                        //Anular Movimiento
                        S_Movimiento.Actualizar_Movimiento(obj);

                        //Anular CXP
                        if (Convert.ToInt32(cb_motivo_movimiento.SelectedValue) == 3)
                        {
                            Anular_CXP();
                        }

                        //Actualizar Inventario
                        Actualizar_Inventario_Por_Anulacion();

                        Mensaje = "Registro Actualizado con Éxito";
                    }
                }

                S_Utilidades.Mensaje_Informacion(Mensaje);
                this.Close();
            }
            catch (Exception ex)
            {
                S_Utilidades.Mensaje_Error(ex.Message);
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (cb_motivo_movimiento.Text.Equals(""))
            {
                S_Utilidades.Mensaje_Informacion("El Motivo Es Obligatorio");
                cb_motivo_movimiento.Focus();
                return;
            }
            if (txt_tipo_movimiento.Text.Equals(""))
            {
                S_Utilidades.Mensaje_Informacion("El Tipo de Movimiento Es Obligatorio");
                cb_motivo_movimiento.Focus();
                return;
            }
            if (txt_referencia.Text.Equals(""))
            {
                S_Utilidades.Mensaje_Informacion("La Referencia Es Obligatoria");
                txt_referencia.Focus();
                return;
            }
            if (txt_id_articulo.Text.Equals(""))
            {
                S_Utilidades.Mensaje_Informacion("El ID del Articulo Es Obligatorio");
                txt_referencia.Focus();
                return;
            }
            if (txt_articulo.Text.Equals(""))
            {
                S_Utilidades.Mensaje_Informacion("El Articulo Es Obligatorio");
                txt_referencia.Focus();
                return;
            }
            if (cb_estado.Text.Equals(""))
            {
                S_Utilidades.Mensaje_Informacion("El Estado Es Obligatorio");
                cb_estado.Focus();
                return;
            }
            if (Txt_ID.Text == "")
            {
                if (Convert.ToInt32(cb_motivo_movimiento.SelectedValue) == 3 && (txt_numero_factura.Text.Equals("") || cb_proveedor.Text.Equals("") || cb_estado.Equals("") || txt_monto.TextLength == 0))
                {
                    S_Utilidades.Mensaje_Informacion("Se Deben Completar Los datos de La CXP");
                    cb_estado.Focus();
                    return;
                }
            }

            if (txt_tipo_movimiento.Text == "Entrada" && (Convert.ToInt32(txt_cantidad.Text) <= 0 || txt_cantidad.Text == ""))
            {
                S_Utilidades.Mensaje_Informacion("La Cantidad Debe ser Mayor a Cero(0)");
                txt_cantidad.Focus();
                return;
            }

            BD_JSYSEntities db = new BD_JSYSEntities();
            int id_articulo = Convert.ToInt32(txt_id_articulo.Text);
            var articulo = db.INVENTARIO_ARTICULOS.Where(p => p.ID_ARTICULO == id_articulo).ToList();

            if (articulo.Count > 0 && cb_estado.Text == "Vigente")
            {

                if (txt_tipo_movimiento.Text == "Salida" && articulo[0].STOCK_ACTUAL < Convert.ToInt32(txt_cantidad.Text) || txt_tipo_movimiento.Text == "Salida" && articulo[0].STOCK_ACTUAL == 0)
                {
                    S_Utilidades.Mensaje_Informacion("La Cantidad En Stock es Menor a la Cantidad a Salir, o No Tiene Stock Disponible");
                    return;
                }
            }

            if (cb_estado.Text == "Anulado" && txt_observacion.Text.Equals(""))
            {
                S_Utilidades.Mensaje_Informacion("Se Debe Ingresar Una Observacion para La Anulación");
                txt_observacion.Focus();
                return;
            }
            if (articulo.Count > 0)
            {
                if (txt_tipo_movimiento.Text == "Entrada" && articulo[0].STOCK_ACTUAL < Convert.ToInt32(txt_cantidad.Text) || txt_tipo_movimiento.Text == "Salida" && articulo[0].STOCK_ACTUAL == 0)
                {
                    S_Utilidades.Mensaje_Informacion("Este Movimiento no puede ser Anulado La Cantidad En Stock es Menor a la Cantidad a Anular, o No Tiene Stock Disponible");
                    return;
                }
            }          
            Insertar();
        }

        private void txt_cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            S_Utilidades.Permitir_Solo_Numero(sender, e);
        }

        private void cb_motivo_movimiento_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                BD_JSYSEntities db = new BD_JSYSEntities();
                var TIPO = db.MOTIVOS_MOVIMIENTOS.Where(p => p.DESCRIPCION == cb_motivo_movimiento.Text).Single();
                txt_tipo_movimiento.Text = TIPO.TIPO_MOVIMIENTO;

                if (Convert.ToInt32(cb_motivo_movimiento.SelectedValue) == 3)
                {
                    if (tabControl1.TabPages.Contains(tabPage2) == false)
                        tabControl1.Controls.Add(tabPage2);
                }
                else
                {
                    tabControl1.Controls.Remove(tabPage2);
                }
            }
            catch
            {

            }

        }

        public void buscar_articulo()
        {
            BD_JSYSEntities db = new BD_JSYSEntities();
            var articulo = db.ARTICULOS.Where(p => p.REFERENCIA == txt_referencia.Text).Single();
            var inventario = db.INVENTARIO_ARTICULOS.Where(p => p.ID_ARTICULO == articulo.ID_ARTICULO).ToList();

            txt_articulo.Text = articulo.DESCRIPCION;
            txt_id_articulo.Text = articulo.ID_ARTICULO.ToString();
            if (inventario.Count > 0)
            {
                txt_stock.Text = inventario[0].STOCK_ACTUAL.ToString();
            }
            else
            {
                txt_stock.Text = "0";
            }

        }

        private void txt_referencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                buscar_articulo();
            }
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            Frm_Consultar_Articulo frm = new Frm_Consultar_Articulo();
            frm.Closed += new EventHandler(frm_Closed);
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Frm_Consultar_Proveedor frm = new Frm_Consultar_Proveedor();
            frm.Closed += new EventHandler(frm_Closed_CXP);
            frm.ShowDialog();
        }

        private void txt_monto_KeyPress(object sender, KeyPressEventArgs e)
        {
            S_Utilidades.Permitir_Solo_Numero_y_Punto(sender,e,txt_monto);
        }


    }
}
