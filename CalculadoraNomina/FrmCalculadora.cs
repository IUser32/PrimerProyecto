using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraNomina
{
    public partial class FrmCalculadora : Form
    {
        public FrmCalculadora()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(mskSueldo.Text))
            {
                MessageBox.Show("Debe introducir un sueldo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double sueldo = double.Parse(mskSueldo.Text);

            // ARS = 0.0287 | AFP = 0.0304
            double ars = sueldo * 0.0287;
            double afp = sueldo * 0.0304;

            txtArs.Text = ars.ToString("C2");
            txtAfp.Text = afp.ToString("C2");

            double salarioAnual = (sueldo - ars - afp) * 12;
            double impuestoAnual = 0;


            // Calculando ISR

            if (salarioAnual <= 416220)
            {
                impuestoAnual = 0;
            } 
            else if(salarioAnual <= 624329)
            {
                impuestoAnual = (salarioAnual - 416220) * 0.15;
            } 
            else if (salarioAnual <= 867123)
            {
                impuestoAnual = ((salarioAnual - 624329) * 0.20) + 31216;
            }
            else
            {
                impuestoAnual = ((salarioAnual - 867123) * 0.25) + 79776;
            }

            txtIsr.Text = (impuestoAnual / 12).ToString("C2");

            double sueldoNeto = (sueldo - ars - afp - (impuestoAnual / 12));

            txtTotal.Text = sueldoNeto.ToString("C2");
        }
    }
}
