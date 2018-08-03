using Datos;
using Servicios;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace JSYS.Formularios
{
    public partial class Frm_Mant_Proveedores : JSYS.Formularios.Frm_Plantilla
    {
        public Frm_Mant_Proveedores()
        {
            InitializeComponent();
            DG.AutoGenerateColumns = false;
        }

        public void Listar_Proveedores()
        {
            string Condicion = "(C.ID_PROVEEDOR LIKE'%" + Txt_Buscar.Text + "%' OR C.NOMBRE LIKE'%" + Txt_Buscar.Text + "%')";
            DG.DataSource = S_Proveedor.Listar_Proveedores(Condicion);
            Lbl_Total.Text = "Total de Registros:  " + DG.RowCount.ToString();
            Cambiar_Color_Filas();
        }

        public void Cambiar_Color_Filas()
        {
            int activo = 0;
            int inactivo = 0;
            foreach (DataGridViewRow row in DG.Rows)
            {
                if (row.Cells[9].Value.ToString() == "Inactivo")
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                    inactivo++;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.PaleGoldenrod;
                    activo++;
                }
            }
            lbl_activo.Text = activo.ToString();
            lbl_inactivo.Text = inactivo.ToString();
        }

        private void Txt_Buscar_TextChanged(object sender, EventArgs e)
        {
            Listar_Proveedores();
        }

        void frm_Closed(object sender, EventArgs e)
        {
            Listar_Proveedores();
        }

        public void Pasar_Datos()
        {
            if (DG.RowCount == 0)
            {
                return;
            }
            PROVEEDORES obj = new PROVEEDORES();
            obj.ID_PROVEEDOR = Convert.ToInt32(DG.SelectedCells[0].Value);
            Frm_Proveedor frm = new Frm_Proveedor();
            frm.Recibir_Datos(obj);
            frm.Titulo("Editar Proveedor");
            frm.Closed += new EventHandler(frm_Closed);
            frm.ShowDialog();
        }

        private void DG_DoubleClick(object sender, EventArgs e)
        {
            btn_editar.PerformClick();
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            Frm_Proveedor frm = new Frm_Proveedor();
            frm.Closed += new EventHandler(frm_Closed);
            frm.Titulo("Agregar Proveedor");
            frm.ShowDialog();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            Pasar_Datos();
        }

        private void Frm_Mant_Proveedores_Load(object sender, EventArgs e)
        {
            Listar_Proveedores();
        }

        private void Frm_Mant_Proveedores_Activated(object sender, EventArgs e)
        {
            Cambiar_Color_Filas();
        }
    }
}
