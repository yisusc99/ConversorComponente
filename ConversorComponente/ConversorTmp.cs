using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibreriaConversorTEMP;
namespace ConversorComponente
{
    public partial class Conversor: UserControl
    {
        public Conversor()
        {
            InitializeComponent();
        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            tCent.Clear();
            tFah.Clear();
        }

        private void Convertir_Click(object sender, EventArgs e)
        {
            if (tCent.Text != "") {
                tFah.Text = Convierte.Fahrenheit(Convert.ToDouble(tCent.Text)).ToString();
            }
            else if (tFah.Text != "") {
                tCent.Text = Convierte.Centigrado(Convert.ToDouble(tFah.Text)).ToString();
            }
            else {
                MessageBox.Show("No has introducido ningun dato.");
            }
        }
    }
}
