using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades
{
    public partial class Errortextbox : System.Windows.Forms.TextBox
    {
        public bool Validar { set; get; }
            
        public Errortextbox()
        {
            InitializeComponent();
        }

        public Errortextbox(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
