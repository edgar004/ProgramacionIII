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
    public partial class mantenimientoClientes : Mantenimientos
    {
        public mantenimientoClientes()
        {
            InitializeComponent();
        }

        private void mantenimientoClientes_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Utilidades.Class1.ValidarFormulario(this, errorProvider1) == true) return;

            string CMD = string.Format("EXEC MANTENIMIENTO_CLIENTES '{0}','{1}', '{2}', '{3}', '{4}'", txt_codigo.Text.Trim(), txt_nombre.Text.Trim(), txt_telefono.Text.Trim(), txt_email.Text.Trim(), estado.Checked);
            ds = Utilidades.Class1.Ejecutar(CMD);

            if (ds.Tables.Count == 1)
            {  
                txt_codigo.Text = "";
                txt_nombre.Text = "";
                txt_telefono.Text = "";
                txt_email.Text = "";
                estado.Checked = false;
            }
            MessageBox.Show("Se guardaron los datos correctamente.");

        }

        private void txt_codigo_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_codigo.Text.Trim()))
                return;
            string CMD = "SELECT * FROM Clientes WHERE codigo='" + txt_codigo.Text.Trim() + "'";
            ds = Utilidades.Class1.Ejecutar(CMD);
          
            if (ds.Tables[0].Rows.Count > 0)
            {
                txt_nombre.Text = ds.Tables[0].Rows[0]["nombre"].ToString().Trim();
                txt_telefono.Text = ds.Tables[0].Rows[0]["telefono"].ToString().Trim();
                txt_email.Text = ds.Tables[0].Rows[0]["email"].ToString().Trim();
                estado.Checked = bool.Parse(ds.Tables[0].Rows[0]["estado"].ToString());
               
            }
            else
            {
                txt_nombre.Text = "";
                txt_telefono.Text = "";
                txt_email.Text  = "";
                estado.Checked = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txt_codigo.Text.Trim() != "")
            {
                string CMD = "DELETE FROM clientes WHERE codigo="+ txt_codigo.Text.Trim();
                ds = Utilidades.Class1.Ejecutar(CMD);
                MessageBox.Show("El cliente se elimino correctamente.");
                txt_codigo.Text = "";
                txt_nombre.Text = "";
                txt_telefono.Text = "";
                txt_email.Text = "";
                estado.Checked = false;
            }
        }

        private void txt_codigo_KeyUp(object sender, KeyEventArgs e)
        {
            if (txt_codigo.Text.Equals(""))
            {
                txt_codigo.Text = "";
                txt_nombre.Text = "";
                txt_telefono.Text = "";
                txt_email.Text = "";
                estado.Checked = false;

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ConsultaClientes obj = new ConsultaClientes();
            if (obj.ShowDialog() == DialogResult.OK)
            {
                txt_codigo.Text = obj.dataGridView1.Rows[obj.dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString();
                txt_codigo.Focus();
                SendKeys.Send("{TAB}");
            }
            }
    }
}
