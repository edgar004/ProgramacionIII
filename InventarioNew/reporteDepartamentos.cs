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
    public partial class reporteDepartamentos : Form
    {
        public reporteDepartamentos()
        {
            InitializeComponent();
        }

        private void reporteDepartamentos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ReporteDepartamentosDataSet1.Departamentos' Puede moverla o quitarla según sea necesario.
            this.DepartamentosTableAdapter.Fill(this.ReporteDepartamentosDataSet1.Departamentos);

            this.reportViewer1.RefreshReport();
        }
    }
}
