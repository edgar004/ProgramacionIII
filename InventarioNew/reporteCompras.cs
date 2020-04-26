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
    public partial class reporteCompras : Form
    {
        public reporteCompras()
        {
            InitializeComponent();
        }

        private void reporteCompras_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ComprasDataSet.DatosComprar' Puede moverla o quitarla según sea necesario.

            this.reportViewer1.RefreshReport();
        }
    }
}
