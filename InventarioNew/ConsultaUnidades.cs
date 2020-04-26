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
    public partial class ConsultaUnidades : Consultas
    {
        public ConsultaUnidades()
        {
            InitializeComponent();
            LlenarTabla();
        }

        private void ConsultaUnidades_Load(object sender, EventArgs e)
        {

        }

        public void LlenarTabla(string condicion = "")
        {
            string cmd = "SELECT * FROM Unidades";
            if (condicion != "")
            {
                cmd += " " + String.Format("where nombre like '%{0}%'", condicion);
            }
            ds = Utilidades.Class1.Ejecutar(cmd);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void filtro_KeyUp(object sender, KeyEventArgs e)
        {
            LlenarTabla(filtro.Text.Trim());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0) return;
            DialogResult = DialogResult.OK;
            Close();

        }
    }
}
