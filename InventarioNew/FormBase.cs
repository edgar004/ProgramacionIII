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
    public partial class FormBase : Form
    {
        public bool puede_salvar { set; get; }
        public bool puede_eliminar { set; get; }
        public bool puede_consultar { set; get; }
        public bool puede_actualizar { set; get; }
        public bool puede_imprimir { set; get; }
        public FormBase()
        {
            InitializeComponent();
        }

        public virtual void salvar()
        {
            MessageBox.Show("Guardando...");
        }

        public virtual void actualizar()
        {
            MessageBox.Show("Actualizando...");
        }
        public virtual void eliminar()
        {
            MessageBox.Show("Eliminando...");
        }
        public virtual void consultar()
        {
            MessageBox.Show("Consultando...");
        }
        public virtual void imprimir()
        {
            MessageBox.Show("Imprimiendo...");
        }

        public DataSet ds = new DataSet();
        public virtual void limpiar()
        {
            MessageBox.Show("Limpiando...");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormBase_Load(object sender, EventArgs e)
        {

        }
    }
}
