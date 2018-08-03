using Datos;
using Servicios;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace JSYS.Formularios
{
    public partial class Frm_Mant_Motivos_Movimientos : JSYS.Formularios.Frm_Plantilla
    {
        public Frm_Mant_Motivos_Movimientos()
        {
            InitializeComponent();
            DG.AutoGenerateColumns = false;
        }

        public void Listar_Motivos_Movimientos()
        {
            string Condicion = "(ID_MOTIVO LIKE'%" + Txt_Buscar.Text + "%' OR DESCRIPCION LIKE'%" + Txt_Buscar.Text + "%' OR TIPO_MOVIMIENTO LIKE'%" + Txt_Buscar.Text + "%')";
            DG.DataSource = S_Motivo_Movimiento.Listar_Motivos_Movimientos(Condicion);
            Lbl_Total.Text = "Total de Registros:  " + DG.RowCount.ToString();
            Cambiar_Color_Filas();
        }

        public void Cambiar_Color_Filas()
        {
            int activo = 0;
            int inactivo = 0;
            foreach (DataGridViewRow row in DG.Rows)
            {
                if (row.Cells[3].Value.ToString() == "Inactivo")
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
            Listar_Motivos_Movimientos();
        }

        void frm_Closed(object sender, EventArgs e)
        {
            Listar_Motivos_Movimientos();
        }

        public void Pasar_Datos()
        {
            if (DG.RowCount == 0)
            {
                return;
            }
            MOTIVOS_MOVIMIENTOS obj = new MOTIVOS_MOVIMIENTOS();
            obj.ID_MOTIVO = Convert.ToInt32(DG.SelectedCells[0].Value);
            Frm_Motivo_Movimiento frm = new Frm_Motivo_Movimiento();
            frm.Recibir_Datos(obj);
            frm.Titulo("Editar Motivo Movimiento");
            frm.Closed += new EventHandler(frm_Closed);
            frm.ShowDialog();
        }

        private void DG_DoubleClick(object sender, EventArgs e)
        {
            btn_editar.PerformClick();
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            Frm_Motivo_Movimiento frm = new Frm_Motivo_Movimiento();
            frm.Closed += new EventHandler(frm_Closed);
            frm.Titulo("Agregar Motivo Movimiento");
            frm.ShowDialog();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            Pasar_Datos();
        }

        private void Frm_Mant_Motivos_Movimientos_Load(object sender, EventArgs e)
        {
            Listar_Motivos_Movimientos();
        }

        private void Frm_Mant_Motivos_Movimientos_Activated(object sender, EventArgs e)
        {
            Cambiar_Color_Filas();
        }
    }
}
