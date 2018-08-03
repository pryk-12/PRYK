using Datos;
using Servicios;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace JSYS.Formularios
{
    public partial class Frm_Mant_Articulos : JSYS.Formularios.Frm_Plantilla
    {
        public Frm_Mant_Articulos()
        {
            InitializeComponent();
            DG.AutoGenerateColumns = false;
        }

        public void Listar_Articulos()
        {
            string Condicion = "(ID_ARTICULO LIKE'%" + Txt_Buscar.Text + "%' OR DESCRIPCION LIKE'%" + Txt_Buscar.Text + "%' OR REFERENCIA LIKE'%" + Txt_Buscar.Text + "%')";
            DG.DataSource = S_Articulo.Listar_Articulos(Condicion);
            Lbl_Total.Text = "Total de Registros:  " + DG.RowCount.ToString();
            Cambiar_Color_Filas();
        }

        public void Cambiar_Color_Filas()
        {
            int activo = 0;
            int inactivo = 0;
            foreach (DataGridViewRow row in DG.Rows)
            {
                if (row.Cells[8].Value.ToString() == "Inactivo")
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
            Listar_Articulos();
        }

        void frm_Closed(object sender, EventArgs e)
        {
            Listar_Articulos();
        }

        public void Pasar_Datos()
        {
            if (DG.RowCount == 0)
            {
                return;
            }
            ARTICULOS obj = new ARTICULOS();
            obj.ID_ARTICULO = Convert.ToInt32(DG.SelectedCells[0].Value);
            Frm_Articulo frm = new Frm_Articulo();
            frm.Recibir_Datos(obj);
            frm.Titulo("Editar Articulo");
            frm.Closed += new EventHandler(frm_Closed);
            frm.ShowDialog();
        }

        private void DG_DoubleClick(object sender, EventArgs e)
        {
            btn_editar.PerformClick();
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            Frm_Articulo frm = new Frm_Articulo();
            frm.Closed += new EventHandler(frm_Closed);
            frm.Titulo("Agregar Articulo");
            frm.ShowDialog();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            Pasar_Datos();
        }

        private void Frm_Mant_Articulos_Load(object sender, EventArgs e)
        {
            Listar_Articulos();
        }

        private void Frm_Mant_Articulos_Activated(object sender, EventArgs e)
        {
            Cambiar_Color_Filas();
        }
    }
}
