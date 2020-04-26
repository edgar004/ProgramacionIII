using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Utilidades
{
    public class Class1
    {

        public static DataSet Ejecutar(string cmd)
        {

            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=InventarioProgramacion;Integrated Security=True");

            con.Open();
            DataSet DS = new DataSet();
            SqlDataAdapter DP = new SqlDataAdapter(cmd, con);
            DP.Fill(DS);
            con.Close();
            return DS;
        }

        public static Boolean ValidarFormulario(Control objeto, ErrorProvider ErrorProvider)
        {
            Boolean HayError = false;

            foreach (Control Item in objeto.Controls)
            {
                if (Item is Errortextbox)
                {
                    Errortextbox obj = (Errortextbox)Item;
                    if (obj.Validar == true)
                    {
                        if (String.IsNullOrEmpty(obj.Text.Trim()))
                        {
                            ErrorProvider.SetError(obj, "No puede estar en blanco");
                            HayError = true;

                        }
                    }
                    if (!HayError) ErrorProvider.SetError(obj, "");
                }
            }

            return HayError;
        }
    }
}
