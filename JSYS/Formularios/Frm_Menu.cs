using System;
using System.Linq;
using System.Windows.Forms;
using Servicios;
using Datos;

namespace JSYS.Formularios
{
    public partial class Frm_Menu : Form
    {
        BD_JSYSEntities db = new BD_JSYSEntities();

        public Frm_Menu()
        {
            InitializeComponent();
        }

        public void Cargar_Permisos()
        {
            try
            {
                //Menu lateral derecho.
                var obj_1 = db.PERMISOS.Where(a => a.USUARIO == S_Utilidades.Datos_Usuario.USUARIO).Where(a => a.PANTALLA == "Menu - Mantenimientos").SingleOrDefault();
                btn_Mantenimiento.Enabled = obj_1.ACCESO == true ? true : false;

                var obj_2 = db.PERMISOS.Where(a => a.USUARIO == S_Utilidades.Datos_Usuario.USUARIO).Where(a => a.PANTALLA == "Menu - Procesos").SingleOrDefault();
                btn_procesos.Enabled = obj_2.ACCESO == true ? true : false;

                var obj_3 = db.PERMISOS.Where(a => a.USUARIO == S_Utilidades.Datos_Usuario.USUARIO).Where(a => a.PANTALLA == "Menu - Inventario").SingleOrDefault();
                btn_inventario.Enabled = obj_3.ACCESO == true ? true : false;

                var obj_4 = db.PERMISOS.Where(a => a.USUARIO == S_Utilidades.Datos_Usuario.USUARIO).Where(a => a.PANTALLA == "Menu - Reportes").SingleOrDefault();
                btn_reportes.Enabled = obj_4.ACCESO == true ? true : false;

                var obj_5 = db.PERMISOS.Where(a => a.USUARIO == S_Utilidades.Datos_Usuario.USUARIO).Where(a => a.PANTALLA == "Menu - Consultas").SingleOrDefault();
                btn_reportes.Enabled = obj_5.ACCESO == true ? true : false;

                var obj_6 = db.PERMISOS.Where(a => a.USUARIO == S_Utilidades.Datos_Usuario.USUARIO).Where(a => a.PANTALLA == "Menu - Configuraciones").SingleOrDefault();
                btn_configuraciones.Enabled = obj_6.ACCESO == true ? true : false;

                //Botones Barra Mantenimiento
                var obj_7 = db.PERMISOS.Where(a => a.USUARIO == S_Utilidades.Datos_Usuario.USUARIO).Where(a => a.PANTALLA == "Mantenimientos - Usuarios").SingleOrDefault();
                btn_usuario.Enabled = obj_7.ACCESO == true ? true : false;

                var obj_8 = db.PERMISOS.Where(a => a.USUARIO == S_Utilidades.Datos_Usuario.USUARIO).Where(a => a.PANTALLA == "Mantenimientos - Clientes").SingleOrDefault();
                btn_cliente.Enabled = obj_8.ACCESO == true ? true : false;

                var obj_9 = db.PERMISOS.Where(a => a.USUARIO == S_Utilidades.Datos_Usuario.USUARIO).Where(a => a.PANTALLA == "Mantenimientos - Articulos").SingleOrDefault();
                btn_articulos.Enabled = obj_9.ACCESO == true ? true : false;

                //Botones Barra Procesos
                var obj_10 = db.PERMISOS.Where(a => a.USUARIO == S_Utilidades.Datos_Usuario.USUARIO).Where(a => a.PANTALLA == "Procesos - Facturación").SingleOrDefault();
                btn_facturacion.Enabled = obj_10.ACCESO == true ? true : false;

                var obj_11 = db.PERMISOS.Where(a => a.USUARIO == S_Utilidades.Datos_Usuario.USUARIO).Where(a => a.PANTALLA == "Procesos - CXC").SingleOrDefault();
                btn_cxc.Enabled = obj_11.ACCESO == true ? true : false;

                var obj_12 = db.PERMISOS.Where(a => a.USUARIO == S_Utilidades.Datos_Usuario.USUARIO).Where(a => a.PANTALLA == "Procesos - Cuadre Diario").SingleOrDefault();
                btn_cuadre.Enabled = obj_12.ACCESO == true ? true : false;

                var obj_13 = db.PERMISOS.Where(a => a.USUARIO == S_Utilidades.Datos_Usuario.USUARIO).Where(a => a.PANTALLA == "Procesos - Entrega Articulo").SingleOrDefault();
                btn_entrega_articulo.Enabled = obj_13.ACCESO == true ? true : false;

                var obj_14 = db.PERMISOS.Where(a => a.USUARIO == S_Utilidades.Datos_Usuario.USUARIO).Where(a => a.PANTALLA == "Procesos - Anular Recibo").SingleOrDefault();
                btn_anular_recibo.Enabled = obj_14.ACCESO == true ? true : false;

                //Botones Barra Inventario
                var obj_15 = db.PERMISOS.Where(a => a.USUARIO == S_Utilidades.Datos_Usuario.USUARIO).Where(a => a.PANTALLA == "Inventario - Consultar CXP").SingleOrDefault();
                btn_anular_cxp.Enabled = obj_15.ACCESO == true ? true : false;

                var obj_16 = db.PERMISOS.Where(a => a.USUARIO == S_Utilidades.Datos_Usuario.USUARIO).Where(a => a.PANTALLA == "Inventario - Consultar Pago CXP").SingleOrDefault();
                btn_consultar_pago.Enabled = obj_16.ACCESO == true ? true : false;
                
                var obj_17 = db.PERMISOS.Where(a => a.USUARIO == S_Utilidades.Datos_Usuario.USUARIO).Where(a => a.PANTALLA == "Inventario - Movimientos").SingleOrDefault();
                btn_movimientos.Enabled = obj_17.ACCESO == true ? true : false;

                var obj_18 = db.PERMISOS.Where(a => a.USUARIO == S_Utilidades.Datos_Usuario.USUARIO).Where(a => a.PANTALLA == "Inventario - Proveedores").SingleOrDefault();
                btn_proveedores.Enabled = obj_18.ACCESO == true ? true : false;

                var obj_19 = db.PERMISOS.Where(a => a.USUARIO == S_Utilidades.Datos_Usuario.USUARIO).Where(a => a.PANTALLA == "Inventario - Motivo Movimiento").SingleOrDefault();
                btn_motivo_movimiento.Enabled = obj_19.ACCESO == true ? true : false;

                //Botones Barra Reportes
                var obj_20 = db.PERMISOS.Where(a => a.USUARIO == S_Utilidades.Datos_Usuario.USUARIO).Where(a => a.PANTALLA == "Reportes - Articulos").SingleOrDefault();
                btn_rep_articulo.Enabled = obj_20.ACCESO == true ? true : false;

                var obj_21 = db.PERMISOS.Where(a => a.USUARIO == S_Utilidades.Datos_Usuario.USUARIO).Where(a => a.PANTALLA == "Reportes - Cobros Realizados").SingleOrDefault();
                btn_rep_cobros_realizados.Enabled = obj_21.ACCESO == true ? true : false;

                var obj_22 = db.PERMISOS.Where(a => a.USUARIO == S_Utilidades.Datos_Usuario.USUARIO).Where(a => a.PANTALLA == "Reportes - Cuadre Diario").SingleOrDefault();
                btn_rep_cuadre.Enabled = obj_22.ACCESO == true ? true : false;

                var obj_23 = db.PERMISOS.Where(a => a.USUARIO == S_Utilidades.Datos_Usuario.USUARIO).Where(a => a.PANTALLA == "Reportes - Facturas").SingleOrDefault();
                btn_rep_facturas.Enabled = obj_23.ACCESO == true ? true : false;

                var obj_24 = db.PERMISOS.Where(a => a.USUARIO == S_Utilidades.Datos_Usuario.USUARIO).Where(a => a.PANTALLA == "Reportes - Movimientos").SingleOrDefault();
                btn_rep_movimientos.Enabled = obj_24.ACCESO == true ? true : false;

                var obj_25 = db.PERMISOS.Where(a => a.USUARIO == S_Utilidades.Datos_Usuario.USUARIO).Where(a => a.PANTALLA == "Reportes - Reimprimir Recibos").SingleOrDefault();
                btn_rep_reimprimir_recibos.Enabled = obj_25.ACCESO == true ? true : false;

                var obj_31 = db.PERMISOS.Where(a => a.USUARIO == S_Utilidades.Datos_Usuario.USUARIO).Where(a => a.PANTALLA == "Reportes - Historial Pagos").SingleOrDefault();
                btn_rep_historial.Enabled = obj_31.ACCESO == true ? true : false;

                //Botones Barra Consultas
                var obj_26 = db.PERMISOS.Where(a => a.USUARIO == S_Utilidades.Datos_Usuario.USUARIO).Where(a => a.PANTALLA == "Consultas - Facturas Inactivas").SingleOrDefault();
                btn_facturas_no_activas.Enabled = obj_26.ACCESO == true ? true : false;

                var obj_27 = db.PERMISOS.Where(a => a.USUARIO == S_Utilidades.Datos_Usuario.USUARIO).Where(a => a.PANTALLA == "Consultas - Movimientos Anulados").SingleOrDefault();
                btn_movimientos_anulados.Enabled = obj_27.ACCESO == true ? true : false;

                var obj_28 = db.PERMISOS.Where(a => a.USUARIO == S_Utilidades.Datos_Usuario.USUARIO).Where(a => a.PANTALLA == "Consultas - Recibos Anulados").SingleOrDefault();
                btn_recibos_anulados.Enabled = obj_28.ACCESO == true ? true : false;


                //Botones Barra Configuraciones
                var obj_29 = db.PERMISOS.Where(a => a.USUARIO == S_Utilidades.Datos_Usuario.USUARIO).Where(a => a.PANTALLA == "Configuraciones - Empresa").SingleOrDefault();
                btn_empresa.Enabled = obj_29.ACCESO == true ? true : false;

                var obj_30 = db.PERMISOS.Where(a => a.USUARIO == S_Utilidades.Datos_Usuario.USUARIO).Where(a => a.PANTALLA == "Configuraciones - Permisos").SingleOrDefault();
                btn_permiso.Enabled = obj_30.ACCESO == true ? true : false;
                
            }
            catch
            {
                S_Utilidades.Mensaje_Error("Revisar si este Usuario tiene los Permisos Asignados");
                this.Enabled = false;
            }
           
          
        }

        private void Frm_Menu_Load(object sender, EventArgs e)
        {
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;

            foreach (System.Windows.Forms.Control ctrl in this.Controls)
            {
                if (ctrl is MdiClient)
                {
                    ctrl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                }
            }

            lbl_usuario.Text = "Usuario:  " + S_Utilidades.Datos_Usuario.USUARIO;
            //Cargar_Permisos();
        }

        public void ocultar_barra_menu(bool opcion)
        {
            pn_matenimientos.Visible = opcion;
            pn_procesos.Visible = opcion;
            pn_inventario.Visible = opcion;
            pn_configuraciones.Visible = opcion;
            pn_reporte.Visible = opcion;
            pn_consultas.Visible = opcion;
        }

        private void btn_Mantenimiento_Click(object sender, EventArgs e)
        {
            ocultar_barra_menu(false);
            pn_matenimientos.Visible = true;
        }

        private void btn_procesos_Click(object sender, EventArgs e)
        {
            ocultar_barra_menu(false);
            pn_procesos.Visible = true;
        }

        private void btn_usuario_Click(object sender, EventArgs e)
        {
            Form Frm_Mant_Usuarios = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "Frm_Mant_Usuarios").SingleOrDefault();
            if (Frm_Mant_Usuarios == null)
            {
                Frm_Mant_Usuarios frm = new Frm_Mant_Usuarios();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void Frm_Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult Resultado = MessageBox.Show("Deseas Salir Del Sistema", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (Resultado == DialogResult.Yes)
            {
                e.Cancel = false;
                this.Dispose();
                //try
                //{
                   S_Utilidades.Crear_Backup();
                //}
                //catch
                //{

                //}
                Application.Exit();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void btn_cliente_Click(object sender, EventArgs e)
        {
            Form Frm_Mant_Clientes = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "Frm_Mant_Clientes").SingleOrDefault();
            if (Frm_Mant_Clientes == null)
            {
                Frm_Mant_Clientes frm = new Frm_Mant_Clientes();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void btn_cobradore_Click(object sender, EventArgs e)
        {
            Form Frm_Mant_Cobradores = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "Frm_Mant_Cobradores").SingleOrDefault();
            if (Frm_Mant_Cobradores == null)
            {
                Frm_Mant_Cobradores frm = new Frm_Mant_Cobradores();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void btn_vendedores_Click(object sender, EventArgs e)
        {
            Form Frm_Mant_Vendedores = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "Frm_Mant_Vendedores").SingleOrDefault();
            if (Frm_Mant_Vendedores == null)
            {
                Frm_Mant_Vendedores frm = new Frm_Mant_Vendedores();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void btn_articulos_Click(object sender, EventArgs e)
        {
            Form Frm_Mant_Articulos = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "Frm_Mant_Articulos").SingleOrDefault();
            if (Frm_Mant_Articulos == null)
            {
                Frm_Mant_Articulos frm = new Frm_Mant_Articulos();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void btn_motivo_movimiento_Click(object sender, EventArgs e)
        {
            Form Frm_Mant_Motivos_Movimientos = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "Frm_Mant_Motivos_Movimientos").SingleOrDefault();
            if (Frm_Mant_Motivos_Movimientos == null)
            {
                Frm_Mant_Motivos_Movimientos frm = new Frm_Mant_Motivos_Movimientos();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void btn_inventario_Click(object sender, EventArgs e)
        {
            ocultar_barra_menu(false);
            pn_inventario.Visible = true;
        }

        private void btn_proveedores_Click(object sender, EventArgs e)
        {
            Form Frm_Mant_Proveedores = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "Frm_Mant_Proveedores").SingleOrDefault();
            if (Frm_Mant_Proveedores == null)
            {
                Frm_Mant_Proveedores frm = new Frm_Mant_Proveedores();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void btn_movimientos_Click(object sender, EventArgs e)
        {
            Form Frm_Mant_Movimientos = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "Frm_Mant_Movimientos").SingleOrDefault();
            if (Frm_Mant_Movimientos == null)
            {
                Frm_Mant_Movimientos frm = new Frm_Mant_Movimientos();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void btn_anular_cxp_Click(object sender, EventArgs e)
        {
            Form Frm_Consultar_CXP = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "Frm_Consultar_CXP").SingleOrDefault();
            if (Frm_Consultar_CXP == null)
            {
                Frm_Consultar_CXP frm = new Frm_Consultar_CXP();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void btn_consultar_pago_Click(object sender, EventArgs e)
        {
            Form Frm_Consultar_Pagos_CXP = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "Frm_Consultar_Pagos_CXP").SingleOrDefault();
            if (Frm_Consultar_Pagos_CXP == null)
            {
                Frm_Consultar_Pagos_CXP frm = new Frm_Consultar_Pagos_CXP();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void btn_empresa_Click(object sender, EventArgs e)
        {
            Form Frm_Empresa = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "Frm_Empresa").SingleOrDefault();
            if (Frm_Empresa == null)
            {
                Frm_Empresa frm = new Frm_Empresa();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void btn_configuraciones_Click(object sender, EventArgs e)
        {
            ocultar_barra_menu(false);
            pn_configuraciones.Visible = true;
        }

        private void btn_facturacion_Click(object sender, EventArgs e)
        {
            Form Frm_Mant_Facturas = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "Frm_Mant_Facturas").SingleOrDefault();
            if (Frm_Mant_Facturas == null)
            {
                Frm_Mant_Facturas frm = new Frm_Mant_Facturas();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void btn_cxc_Click(object sender, EventArgs e)
        {
            Form Frm_CXC = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "Frm_CXC").SingleOrDefault();
            if (Frm_CXC == null)
            {
                Frm_CXC frm = new Frm_CXC();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void btn_anular_recibo_Click(object sender, EventArgs e)
        {
            Form Frm_Anular_Recibo = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "Frm_Anular_Recibo").SingleOrDefault();
            if (Frm_Anular_Recibo == null)
            {
                Frm_Anular_Recibo frm = new Frm_Anular_Recibo();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void btn_entrega_articulo_Click(object sender, EventArgs e)
        {
            Form Frm_Entregar_Articulos = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "Frm_Entregar_Articulos").SingleOrDefault();
            if (Frm_Entregar_Articulos == null)
            {
                Frm_Entregar_Articulos frm = new Frm_Entregar_Articulos();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void btn_cuadre_Click(object sender, EventArgs e)
        {
            Form Frm_Cuadre_Diario = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "Frm_Cuadre_Diario").SingleOrDefault();
            if (Frm_Cuadre_Diario == null)
            {
                Frm_Cuadre_Diario frm = new Frm_Cuadre_Diario();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void btn_rep_articulo_Click(object sender, EventArgs e)
        {
            Form Frm_Rep_Articulos = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "Frm_Rep_Articulos").SingleOrDefault();
            if (Frm_Rep_Articulos == null)
            {
                Frm_Rep_Articulos frm = new Frm_Rep_Articulos();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void btn_reportes_Click(object sender, EventArgs e)
        {
            ocultar_barra_menu(false);
            pn_reporte.Visible = true;
        }

        private void btn_rep_facturas_Click(object sender, EventArgs e)
        {
            Form Frm_Rep_Facturas = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "Frm_Rep_Facturas").SingleOrDefault();
            if (Frm_Rep_Facturas == null)
            {
                Frm_Rep_Facturas frm = new Frm_Rep_Facturas();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void btn_rep_cobros_realizados_Click(object sender, EventArgs e)
        {
            Form Frm_Rep_Cobros_Realizados = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "Frm_Rep_Cobros_Realizados").SingleOrDefault();
            if (Frm_Rep_Cobros_Realizados == null)
            {
                Frm_Rep_Cobros_Realizados frm = new Frm_Rep_Cobros_Realizados();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void btn_rep_cuadre_Click(object sender, EventArgs e)
        {
            Form Frm_Rep_Cuadre = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "Frm_Rep_Cuadre").SingleOrDefault();
            if (Frm_Rep_Cuadre == null)
            {
                Frm_Rep_Cuadre frm = new Frm_Rep_Cuadre();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void btn_rep_movimientos_Click(object sender, EventArgs e)
        {
            Form Frm_Rep_Movimientos = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "Frm_Rep_Movimientos").SingleOrDefault();
            if (Frm_Rep_Movimientos == null)
            {
                Frm_Rep_Movimientos frm = new Frm_Rep_Movimientos();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void btn_rep_reimprimir_recibos_Click(object sender, EventArgs e)
        {
            Form Frm_Reimprimir_Recibos = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "Frm_Reimprimir_Recibos").SingleOrDefault();
            if (Frm_Reimprimir_Recibos == null)
            {
                Frm_Reimprimir_Recibos frm = new Frm_Reimprimir_Recibos();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void btn_recibos_anulados_Click(object sender, EventArgs e)
        {
            Form Frm_Consultar_Recibos_Anulados = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "Frm_Consultar_Recibos_Anulados").SingleOrDefault();
            if (Frm_Consultar_Recibos_Anulados == null)
            {
                Frm_Consultar_Recibos_Anulados frm = new Frm_Consultar_Recibos_Anulados();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void btn_consultas_Click(object sender, EventArgs e)
        {
            ocultar_barra_menu(false);
            pn_consultas.Visible = true;
        }

        private void btn_movimientos_anulados_Click(object sender, EventArgs e)
        {
            Form Frm_Consultar_Movimientos_Anulados = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "Frm_Consultar_Movimientos_Anulados").SingleOrDefault();
            if (Frm_Consultar_Movimientos_Anulados == null)
            {
                Frm_Consultar_Movimientos_Anulados frm = new Frm_Consultar_Movimientos_Anulados();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void btn_facturas_no_activas_Click(object sender, EventArgs e)
        {
            Form Frm_Consultar_Facturas_Anuladas = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "Frm_Consultar_Facturas_Anuladas").SingleOrDefault();
            if (Frm_Consultar_Facturas_Anuladas == null)
            {
                Frm_Consultar_Facturas_Anuladas frm = new Frm_Consultar_Facturas_Anuladas();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void btn_permiso_Click(object sender, EventArgs e)
        {
            Form Frm_Permisos = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "Frm_Permisos").SingleOrDefault();
            if (Frm_Permisos == null)
            {
                Frm_Permisos frm = new Frm_Permisos();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void btn_rep_historial_Click(object sender, EventArgs e)
        {
            Form Frm_Rep_Historial_Pagos = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "Frm_Rep_Historial_Pagos").SingleOrDefault();
            if (Frm_Rep_Historial_Pagos == null)
            {
                Frm_Rep_Historial_Pagos frm = new Frm_Rep_Historial_Pagos();
                frm.MdiParent = this;
                frm.Show();
            }
        }
    }
}
