using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtNum1_TextChanged(object sender, EventArgs e)
        {
            Random aleatorio1 = new Random();
            int num = aleatorio1.Next(1, 100);
            txtNum1.Text = num.ToString();
        }

        private void txtNum2_TextChanged(object sender, EventArgs e)
        {
            Random aleatorio2 = new Random();
            int num2 = aleatorio2.Next(1, 100);
            txtNum2.Text = num2.ToString();
        }

        private void txtResultado_TextChanged(object sender, EventArgs e)
        {
            int resultado;
            int num1 = Int32.Parse(txtNum1.Text);
            int num2 = Int32.Parse(txtNum2.Text);
            resultado = operaciones(num1, num2);
            txtResultado.Text = resultado.ToString();
            



        }
        static int operaciones(int par1, int par2)
        {
            Random operacion = new Random();
            int num = operacion.Next(1, 4);
            if (num == 1)
            {
                int res;
                res = par1 + par2;
                return res;
                
            }
            if (num == 2)
            {
                int res;
                res = par1 - par2;
                return res;
            }
            if (num == 3)
            {
                int res;
                res = par1 * par2;
                return res;
            }
            if (num == 4)
            {
                int res;
                res = par1 / par2;
                return res;
            }
            return 0;
            
            
            
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sum1 = Int32.Parse(txtNum1.Text);
            int sum2 = Int32.Parse(txtNum2.Text);
            int resultado = (sum1 + sum2);
            if (resultado == Int32.Parse(txtResultado.Text))
            {
                txtMensaje.Clear();
                txtMensaje.AppendText("Resultado Correcto");

            }
            else
            {
                txtMensaje.Clear();
                txtMensaje.AppendText("ERROR");
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sum1 = Int32.Parse(txtNum1.Text);
            int sum2 = Int32.Parse(txtNum2.Text);
            int resultado = (sum1 - sum2);
            if (resultado == Int32.Parse(txtResultado.Text))
            {
                txtMensaje.Clear();
                txtMensaje.AppendText("Resultado Correcto");

            }
            else
            {
                txtMensaje.Clear();
                txtMensaje.AppendText("ERROR");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int sum1 = Int32.Parse(txtNum1.Text);
            int sum2 = Int32.Parse(txtNum2.Text);
            int resultado = (sum1 * sum2);
            if (resultado == Int32.Parse(txtResultado.Text))
            {
                txtMensaje.Clear();
                txtMensaje.AppendText("Resultado Correcto");

            }
            else
            {
                txtMensaje.Clear();
                txtMensaje.AppendText("ERROR");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int sum1 = Int32.Parse(txtNum1.Text);
            int sum2 = Int32.Parse(txtNum2.Text);
            int resultado = (sum1 / sum2);
            if (resultado == Int32.Parse(txtResultado.Text))
            {
                txtMensaje.Clear();
                txtMensaje.AppendText("Resultado Correcto");

            }
            else
            {
                txtMensaje.Clear();
                txtMensaje.AppendText("ERROR");
            }
        }
    }
}
