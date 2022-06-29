using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AreaTriangulo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }            
        private void button1_Click(object sender, EventArgs e)
        {
            // Váriaveis p/ armazenar os valores:
            double ba = 0;
            double al = 0;
            double area = 0;
            // Iniciando o programa:
            if (txtBase.Text != "" && txtAltura.Text != "")
            {
                // Armazenando novas informações:
                ba = double.Parse(txtBase.Text);
                al = double.Parse(txtAltura.Text);
            }
            // Cálculo da Área:
            area = ba * al / 2;

            // Mostrando resultado:
            lblResultado.Text = area.ToString();
        }       
    }
}
