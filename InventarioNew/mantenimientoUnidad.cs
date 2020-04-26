using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventarioNew
{
    public partial class mantenimientoUnidad : Mantenimientos
    {
        public mantenimientoUnidad()
        {
            InitializeComponent();
        }

        private void mantenimientoUnidad_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Utilidades.Class1.ValidarFormulario(this, errorProvider1) == true) return;

            string CMD = string.Format("EXEC MANTENIMIENTO_UNIDADES '{0}','{1}', '{2}'", txt_codigo.Text.Trim(), txt_nombre.Text.Trim(), estado.Checked);
            ds = Utilidades.Class1.Ejecutar(CMD);

            if (ds.Tables.Count == 1)
            {
                txt_codigo.Text = "";
                txt_nombre.Text = "";
                estado.Checked = false;
            }
            MessageBox.Show("Se guardaron los datos correctamente.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txt_codigo.Text.Trim() != "")
            {
                string CMD = "DELETE FROM Unidades WHERE codigo=" + txt_codigo.Text.Trim();
                ds = Utilidades.Class1.Ejecutar(CMD);
                MessageBox.Show("La unidad se elimino correctamente.");
                txt_codigo.Text = "";
                txt_nombre.Text = "";
                estado.Checked = false;
            }
        }

        private void txt_codigo_Validated(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_codigo.Text.Trim()))
                return;
            string CMD = "SELECT * FROM Unidades WHERE codigo='" + txt_codigo.Text.Trim() + "'";
            ds = Utilidades.Class1.Ejecutar(CMD);

            if (ds.Tables[0].Rows.Count > 0)
            {
                txt_nombre.Text = ds.Tables[0].Rows[0]["nombre"].ToString().Trim();
                estado.Checked = bool.Parse(ds.Tables[0].Rows[0]["estado"].ToString());

            }
            else
            {
                txt_nombre.Text = "";
                estado.Checked = false;
            }
        }

        private void txt_codigo_KeyUp(object sender, KeyEventArgs e)
        {
            if (txt_codigo.Text.Equals(""))
            {
                txt_nombre.Text = "";
                estado.Checked = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ConsultaUnidades obj = new ConsultaUnidades();
            if (obj.ShowDialog() == DialogResult.OK)
            {
                txt_codigo.Text = obj.dataGridView1.Rows[obj.dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString();
                txt_codigo.Focus();
                SendKeys.Send("{TAB}");
            }
        }
    }
}
