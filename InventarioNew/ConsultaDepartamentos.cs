using Microsoft.Reporting.WebForms;
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
    public partial class ConsultaDepartamentos : Consultas
    {
        public ConsultaDepartamentos()
        {
            InitializeComponent();
            LlenarTabla();

        }

        public void LlenarTabla(string condicion = "")
        {
            string cmd = "SELECT * FROM Departamentos";
            if (condicion != "")
            {
                cmd +=" " + String.Format("where nombre like '%{0}%'", condicion);
            }
            ds = Utilidades.Class1.Ejecutar(cmd);
            dataGridView1.DataSource = ds.Tables[0];
        }


        private void ConsultaDepartamentos_Load(object sender, EventArgs e)
        {

        }

        private void filtro_Leave(object sender, EventArgs e)
        {
            LlenarTabla(filtro.Text.Trim());

        }

        private void button2_Click(object sender, EventArgs e)
        {
            reporteDepartamentos reporte = new reporteDepartamentos();
            reporte.reportViewer1.LocalReport.DataSources[0].Value = ds.Tables[0];
            reporte.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0) return;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
