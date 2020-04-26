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
    public partial class ConsultaCliente : Form
    {
        public ConsultaCliente()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AllowUserToAddRows = false;
            codigo.DataPropertyName = "codigo";
            nombre.DataPropertyName = "nombre";



            string cmd = "select * from Clientes";
            DataSet DS = new DataSet();

            DS = Utilidades.Class1.ejecutar(cmd);
            dataGridView1.DataSource = DS.Tables[0];

        }

        private void ConsultaCliente_Load(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
