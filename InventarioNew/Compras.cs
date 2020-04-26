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
    public partial class Compras : Form
    {
        public DataSet ds = new DataSet();
        public int cont_fila = 0;
        public double total_fac;

        public Compras()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConsultaSuplidores obj = new ConsultaSuplidores();
            if (obj.ShowDialog() == DialogResult.OK)
            {
                codigo_suplidor.Text = obj.dataGridView1.Rows[obj.dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString();
                codigo_suplidor.Focus();
                SendKeys.Send("{TAB}");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ConsultaProductos obj = new ConsultaProductos();
            if (obj.ShowDialog() == DialogResult.OK)
            {
                codigoProducto.Text = obj.dataGridView1.Rows[obj.dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString();
                codigoProducto.Focus();
                SendKeys.Send("{TAB}");
            }
        }

        private void codigoProducto_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(codigoProducto.Text.Trim())) return;
            String cdm = "Select * FRom Productos where codigo= " + codigoProducto.Text.Trim();


            ds = Utilidades.Class1.Ejecutar(cdm);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                nombre_producto.Text = ds.Tables[0].Rows[0]["nombre"].ToString().Trim();
                cantidad_producto.Text = ds.Tables[0].Rows[0]["cantidad_existente"].ToString().Trim();
                precio_producto.Text = ds.Tables[0].Rows[0]["precio_venta"].ToString().Trim();
            }

            else
            {

                nombre_producto.Text = "";
                cantidad_producto.Text = "";
                precio_producto.Text = "";
            }
        }

        private void Compras_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Utilidades.Class1.ValidarFormulario(this, errorProvider1) == false)
            {
              

                bool existe = false;
                int num_fila = 0;

                if (cont_fila == 0)
                {
                    dataGridView1.Rows.Add(codigoProducto.Text, nombre_producto.Text, precio_producto.Text, cantidad_producto.Text);

                    double importe = Convert.ToDouble(dataGridView1.Rows[cont_fila].Cells[2].Value) *
                       Convert.ToDouble(dataGridView1.Rows[cont_fila].Cells[3].Value);

                    dataGridView1.Rows[cont_fila].Cells[4].Value = importe;
                  

                    cont_fila++;
                }
                else
                {
                    foreach (DataGridViewRow fila in dataGridView1.Rows)
                    {

                        if (fila.Cells[0].Value.ToString() == codigoProducto.Text)
                        {
                            existe = true;
                            num_fila = fila.Index;
                        }
                    }
                    if (existe == true)
                    {
                        dataGridView1.Rows[num_fila].Cells[3].Value = (Convert.ToDouble(cantidad_producto.Text) + Convert.ToDouble(dataGridView1.Rows[num_fila].Cells[3].Value)).ToString();
                        double importe = Convert.ToDouble(dataGridView1.Rows[num_fila].Cells[2].Value) * Convert.ToDouble(dataGridView1.Rows[num_fila].Cells[3].Value);
                        dataGridView1.Rows[num_fila].Cells[4].Value = importe;
                       

                    }
                    else
                    {
                        dataGridView1.Rows.Add(codigoProducto.Text, nombre_producto.Text, precio_producto.Text, cantidad_producto.Text);

                        double importe = Convert.ToDouble(dataGridView1.Rows[cont_fila].Cells[2].Value) *
                            Convert.ToDouble(dataGridView1.Rows[cont_fila].Cells[3].Value);
                        dataGridView1.Rows[cont_fila].Cells[4].Value = importe;
                        cont_fila++;
                        total_fac += importe;
                    }

                }

                codigoProducto.Text = "";
                nombre_producto.Text = "";
                cantidad_producto.Text = "";
                precio_producto.Text = "";

                total_fac = 0;

                foreach (DataGridViewRow fila in dataGridView1.Rows)
                {
                    total_fac += (Convert.ToDouble(fila.Cells[4].Value));

                }
                total.Text = total_fac.ToString();

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (cont_fila != 0) // validar que hay produtos agregado en la tabla

                try
                {

                    string cmd = string.Format("EXEC COMPRAR '{0}','{1}'", codigo_suplidor.Text.Trim(), total.Text.Trim());
                    ds = Utilidades.Class1.Ejecutar(cmd);
                    if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                    {
                        int numero_Factura = int.Parse(ds.Tables[0].Rows[0]["codigo_compra"].ToString().Trim());

                        foreach (DataGridViewRow Fila in dataGridView1.Rows)
                        {
                            cmd = string.Format("EXEC DetallesCompras {0},'{1}','{2}','{3}'",
                                numero_Factura, Fila.Cells[0].Value.ToString(), Fila.Cells[2].Value.ToString(),
                            Fila.Cells[3].Value.ToString());
                            ds = Utilidades.Class1.Ejecutar(cmd);


                        }
                        cmd = "EXEC DatosComprar " + numero_Factura;
                        ds = Utilidades.Class1.Ejecutar(cmd);

                        reporteCompras factura = new reporteCompras();
                        factura.reportViewer1.LocalReport.DataSources[0].Value = ds.Tables[0];
                        factura.ShowDialog();
                        Nuevo();
                    }

                    //  imprimir();
                }
                catch (Exception errror)
                {
                    MessageBox.Show("hay un error" + errror);
                }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (cont_fila > 0)
            {
                total_fac = total_fac - (Convert.ToDouble(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[4].Value));
                total.Text = total_fac.ToString();
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index); // Para eliminar la fila seleccionada 
                cont_fila--;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        public void Nuevo()
        {
            codigo_suplidor.Text = "";
            nombre_suplidor.Text = "";
            codigoProducto.Text = "";
            nombre_producto.Text = "";
            precio_producto.Text = "";
            cantidad_producto.Text = "";
            total.Text = "RD 0";

            dataGridView1.Rows.Clear();
            cont_fila = 0;
            total_fac = 0;
            codigo_suplidor.Focus();
        }

        private void codigo_suplidor_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(codigo_suplidor.Text.Trim()))
                return;
            string CMD = "SELECT * FROM Suplidores WHERE codigo='" + codigo_suplidor.Text.Trim() + "'";
            ds = Utilidades.Class1.Ejecutar(CMD);

            if (ds.Tables[0].Rows.Count > 0)
            {
               nombre_suplidor.Text = ds.Tables[0].Rows[0]["nombre"].ToString().Trim();
            }
            else
            {
                nombre_suplidor.Text = "";
            }
        }
    }
}
