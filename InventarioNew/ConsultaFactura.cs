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
    public partial class ConsultaFactura : Consultas
    {
        public ConsultaFactura()
        {
            InitializeComponent();

            dataGridView1.AutoGenerateColumns = false;
            Factura.DataPropertyName = "codigo";
            Fecha.DataPropertyName = "fecha";
            Total.DataPropertyName = "total";
            Cliente.DataPropertyName = "nombre";
            Codigo_Cliente.DataPropertyName = "cod_clienteFact";
            LlenarTabla();

        }

        private void ConsultaFactura_Load(object sender, EventArgs e)
        {

        }

        public void LlenarTabla(string condicion = "")
        {
            string CMD = "Select f.codigo,f.fecha,f.total, C.nombre ,C.codigo  as cod_clienteFact from Facturas F inner join Clientes C on F.codigo_cliente =C.codigo";
                ds =Utilidades.Class1.Ejecutar(CMD);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void Filtrar_Click(object sender, EventArgs e)
        {
            if (orden.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor Selecciona el orden");
                orden.Focus();
                return;
            }

            try
            {
                int filtroCliente = 0;
                if (cliente_Factura.Text.Trim().Equals("") == false)
                {
                    filtroCliente = int.Parse(cliente_Factura.Text.Trim()); 
                }
                int ordenFac = orden.SelectedIndex + 1;
                String CMD = String.Format("EXEC FiltrarFactura '{0}','{1}','{2}','{3}'", fechaini.Value.ToString("yyyyMMdd"), dateTimePicker1.Value.ToString("yyyyMMdd"), filtroCliente, ordenFac);
                ds =Utilidades.Class1.Ejecutar(CMD);
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = ds.Tables[0];

            }
            catch (Exception error)
            {
                MessageBox.Show("Ha ocurrido un error" + error.Message);
            }
        }
    }
}
