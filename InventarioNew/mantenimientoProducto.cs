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
    public partial class mantenimientoProducto : Mantenimientos
    {
        public mantenimientoProducto()
        {
            InitializeComponent();
            LlenarDepartamento();
            LlenarSuplidores();
            LlenarUnidadMedida();
        }

        private void mantenimientoProducto_Load(object sender, EventArgs e)
        {

        }


        public void LlenarDepartamento()
        {
            String cmd = "Select * FROM Departamentos";
            ds = Utilidades.Class1.Ejecutar(cmd);
            departamento.DisplayMember = "nombre"; // nombre que se despliega para el usuario
            departamento.ValueMember = "codigo";// codigo que guardo en la base de datos para la relacion
            departamento.DataSource = ds.Tables[0];
        }


        public void LlenarSuplidores()
        {
            String cmd = "Select * FROM Suplidores";
            //me llama lo de la base de datos 
            ds = Utilidades.Class1.Ejecutar(cmd);
            suplidor.DisplayMember = "nombre"; // nombre que se despliega para el usuario
            suplidor.ValueMember = "codigo";// codigo que guardo en la base de datos para la relacion
            suplidor.DataSource = ds.Tables[0];
        }


        public void LlenarUnidadMedida()
        {
            String cmd = "Select * FROM Unidades";
            //me llama lo de la base de datos 
            ds = Utilidades.Class1.Ejecutar(cmd);
            unidad_medida.DisplayMember = "nombre"; // nombre que se despliega para el usuario
            unidad_medida.ValueMember = "codigo";// codigo que guardo en la base de datos para la relacion
            unidad_medida.DataSource = ds.Tables[0];
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Utilidades.Class1.ValidarFormulario(this, errorProvider1) == true) return;

            String cmd = String.Format("EXEC MANTENIMIENTO_PRODUCTOS '{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}'", txt_codigo.Text.Trim(),
                txt_nombre.Text.Trim(), departamento.SelectedValue, suplidor.SelectedValue,
                existente.Text.Trim(), reorden.Text.Trim(),
                unidad_medida.SelectedValue, estado.Checked, precio.Text.Trim());

            //MessageBox.Show("" + Cantidadexis);
            ds = Utilidades.Class1.Ejecutar(cmd);
            MessageBox.Show("Se ha guardado correctamente");
            if (ds.Tables.Count == 1) Limpiar();
        }

        public void Limpiar()
        {
            txt_codigo.Focus();

            txt_codigo.Text = "";
            txt_nombre.Text = "";
            suplidor.SelectedIndex = 0;
            departamento.SelectedIndex = 0;
            precio.Text = "";
            existente.Text = "";
            reorden.Text = "";
            unidad_medida.SelectedIndex = 0;
            estado.Checked = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txt_codigo.Text.Trim() != "")
            {
                string CMD = "DELETE FROM Productos WHERE codigo=" + txt_codigo.Text.Trim();
                ds = Utilidades.Class1.Ejecutar(CMD);
                MessageBox.Show("El producto se elimino correctamente.");
                Limpiar();
            }
        }

        private void txt_codigo_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_codigo.Text.Trim())) return;
            String cdm = "Select * FRom Productos where codigo= " + txt_codigo.Text.Trim();


            ds = Utilidades.Class1.Ejecutar(cdm);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                txt_nombre.Text = ds.Tables[0].Rows[0]["nombre"].ToString().Trim();
                departamento.SelectedValue = ds.Tables[0].Rows[0]["codigo_departamento"].ToString().Trim();
                suplidor.SelectedValue = ds.Tables[0].Rows[0]["codigo_suplidor"].ToString().Trim();
                existente.Text = ds.Tables[0].Rows[0]["cantidad_existente"].ToString().Trim();
                reorden.Text = ds.Tables[0].Rows[0]["punto_reorden"].ToString().Trim();
                unidad_medida.SelectedValue = ds.Tables[0].Rows[0]["codigo_unidad"].ToString().Trim();
                precio.Text = ds.Tables[0].Rows[0]["precio_venta"].ToString().Trim();
                estado.Checked = Convert.ToBoolean(ds.Tables[0].Rows[0]["estado"]);

            }

            else
            {

                txt_nombre.Text = "";
                departamento.SelectedIndex = 0;
                suplidor.SelectedIndex = 0;
                existente.Text = "";
                reorden.Text = "";
                unidad_medida.SelectedIndex = 0;
                precio.Text = "";
                estado.Checked = false;
            }
        }

        private void txt_codigo_KeyUp(object sender, KeyEventArgs e)
        {
            if (txt_codigo.Text.Equals(""))
            {
                txt_nombre.Text = "";
                departamento.SelectedIndex = 0;
                suplidor.SelectedIndex = 0;
                existente.Text = "";
                reorden.Text = "";
                unidad_medida.SelectedIndex = 0;
                precio.Text = "";
                estado.Checked = false;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ConsultaProductos obj = new ConsultaProductos();
            if (obj.ShowDialog() == DialogResult.OK)
            {
                txt_codigo.Text = obj.dataGridView1.Rows[obj.dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString();
                txt_codigo.Focus();
                SendKeys.Send("{TAB}");
            }
        }
    }


}
