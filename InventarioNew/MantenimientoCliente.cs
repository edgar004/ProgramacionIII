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
    public partial class MantenimientoCliente : Mantenimientos
    {
        public MantenimientoCliente()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MantenimientoCliente_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string cmd = String.Format("EXEC mantenimientoCliente {0},'{1}'", textbox1.Text,textbox2.Text);
            DataSet DS = new DataSet();
            DS = Utilidades.Class1.ejecutar(cmd);
            MessageBox.Show("Los datos se ha guardado correctamente");
            textbox1.Text = "";
            textbox2.Text = "";
        }

        private void textbox1_Leave(object sender, EventArgs e)
        {
            if (textbox1.Text != "")
            {
                int codigo_cliente = int.Parse(textbox1.Text);
                string cmd = "select * from Clientes where codigo = " + codigo_cliente;

                DataSet DS = new DataSet();
                DS = Utilidades.Class1.ejecutar(cmd);

                if (DS.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("Cliente no existente");
                    textbox2.Text = "";
                }
                else
                {
                    textbox2.Text = DS.Tables[0].Rows[0]["nombre"].ToString();
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textbox1.Text != "")
            {
                int codigo_cliente = int.Parse(textbox1.Text);
                string cmd = "delete from Clientes where codigo = " + codigo_cliente;

                DataSet DS = new DataSet();
                DS = Utilidades.Class1.ejecutar(cmd);
                MessageBox.Show("El cliente se ha eliminado correctamente");
                textbox1.Text = "";
                textbox2.Text = "";

            }
        }

        private void textbox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
