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
    public partial class FrmMenu : Form
    {
        private int childFormNumber = 0;

        public FrmMenu()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            
        }

        private void Menu_MdiChildActivate(object sender, EventArgs e)
        {
            /*if (ActivateMdiChild is FormBase)
            {
                FormBase obj = new FormBase();
                saveToolStripButton.Enabled = obj.puede_actualizar;
                printToolStripButton.Enabled = obj.puede_imprimir;
                printPreviewToolStripButton.Enabled = obj.puede_consultar;
            }*/

          
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
        }

        private void toolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void cLIENTESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mantenimientoClientes mantenimiento_Clientes = new mantenimientoClientes();
            mantenimiento_Clientes.MdiParent = this;
            mantenimiento_Clientes.Show();
        }

        private void dEPARTAMENTOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mantenimientoDepartamentos mantenimientoDepartamentos = new mantenimientoDepartamentos();
            mantenimientoDepartamentos.MdiParent = this;
            mantenimientoDepartamentos.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultaClientes ConsultaClientes = new ConsultaClientes();
            ConsultaClientes.MdiParent = this;
            ConsultaClientes.Show();
        }

        private void departamentosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultaDepartamentos ConsultaDepartamentos = new ConsultaDepartamentos();
            ConsultaDepartamentos.MdiParent = this;
            ConsultaDepartamentos.Show();

        }

        private void sUPLIDORESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mantenimientoSuplidores mantenimientoSuplidores = new mantenimientoSuplidores();
            mantenimientoSuplidores.MdiParent = this;
            mantenimientoSuplidores.Show();
        }

        private void uNIDADESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mantenimientoUnidad mantenimientoUnidad = new mantenimientoUnidad();
            mantenimientoUnidad.MdiParent = this;
            mantenimientoUnidad.Show();
        }

        private void suplidoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultaSuplidores ConsultaSuplidores = new ConsultaSuplidores();
            ConsultaSuplidores.MdiParent = this;
            ConsultaSuplidores.Show();
        }

        private void pRODUCTOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mantenimientoProducto mantenimientoProducto = new mantenimientoProducto();
            mantenimientoProducto.MdiParent = this;
            mantenimientoProducto.Show();
        }

        private void productosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultaProductos ConsultaProductos = new ConsultaProductos();
            ConsultaProductos.MdiParent = this;
            ConsultaProductos.Show();
        }

        private void viewMenu_Click(object sender, EventArgs e)
        {

        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Facturas Facturas = new Facturas();
            Facturas.MdiParent = this;
            Facturas.Show();
        }

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Compras Compras = new Compras();
            Compras.MdiParent = this;
            Compras.Show();
        }

        private void facturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaFactura ConsultaFactura = new ConsultaFactura();
            ConsultaFactura.MdiParent = this;
            ConsultaFactura.Show();
        }
    }
}
