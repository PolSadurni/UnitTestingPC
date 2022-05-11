using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathCalculusPolCarlos
{
    public partial class frmCalculus : Form
    {
        Calculus funciones = new Calculus();
        int num1, num2;
        public frmCalculus()
        {
            InitializeComponent();
        }

        private void btnNumbers_Click(object sender, EventArgs e)
        {
           lblNum1.Text = funciones.GenerarAleatorio(0, 10).ToString();
           lblNum2.Text = funciones.GenerarAleatorio(0, 40).ToString();
           num1 = int.Parse(lblNum1.Text);
           num2 = int.Parse(lblNum2.Text);
        }

        private void btnMCM_Click(object sender, EventArgs e)
        {
            lblMCM.Text = funciones.generarMCM(num1, num2).ToString();
        }

        private void btnCalculs_Click(object sender, EventArgs e)
        {
            lbxResultados.Items.Clear();
            for (int i = 0; i < funciones.setCalculs(num1, num2).Count; i++)
            {
                lbxResultados.Items.Add(funciones.setCalculs(num1, num2)[i]);
            }
            
        }

        private void btnCMD_Click(object sender, EventArgs e)
        {
            lblCMD.Text = funciones.generarMCD(num1, num2).ToString();
        }
    }
}
