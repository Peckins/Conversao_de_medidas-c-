using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicioMedidas
{
    public partial class Calculador : Form
    {
        public Calculador()
        {
            InitializeComponent();
        }

        int op = 0;
        int op2 = 0;
        string caution;
        double v1;
        double res;

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_Valor1.Text = "";        
            txt_res.Text = "";
            op = 0;
            op2 = 0;
        }

        private void btn_Calc_Click(object sender, EventArgs e)
        {
            if(op == 1 && op2 == 1)
            {
                v1 = Convert.ToInt32(txt_Valor1.Text);
                res = v1;
                txt_res.Text= Convert.ToString(res+" Centímetros");
                op = 0;
                op2 = 0;
            }
            if (op == 1 && op2 == 2)
            {
                v1 = Convert.ToInt32(txt_Valor1.Text);
                res = v1 / 100;
                txt_res.Text = Convert.ToString(res + " Metros");
                op = 0;
                op2 = 0;
            }
            if (op == 1 && op2 == 3)
            {
                v1 = Convert.ToInt32(txt_Valor1.Text);
                res = v1 / 100000;
                txt_res.Text = Convert.ToString(res + " Kilômetros");
                op = 0;
                op2 = 0;
            }
            if (op == 2 && op2 == 1)
            {
                v1 = Convert.ToInt32(txt_Valor1.Text);
                res = v1 * 100;
                txt_res.Text = Convert.ToString(res + " Centímetros");
                op = 0;
                op2 = 0;
            }
            if (op == 2 && op2 == 2)
            {
                v1 = Convert.ToInt32(txt_Valor1.Text);
                res = v1;
                txt_res.Text = Convert.ToString(res + " Metros");
                op = 0;
                op2 = 0;
            }
            if (op == 2 && op2 == 3)
            {
                v1 = Convert.ToInt32(txt_Valor1.Text);
                res = v1 / 1000;
                txt_res.Text = Convert.ToString(res + " Kilômetros");
                op = 0;
                op2 = 0;
            }
            if (op == 3 && op2 == 1)
            {
                v1 = Convert.ToInt32(txt_Valor1.Text);
                res = v1 * 100000;
                txt_res.Text = Convert.ToString(res + " Centímetros");
                op = 0;
                op2 = 0;
            }
            if (op == 3 && op2 == 2)
            {
                v1 = Convert.ToInt32(txt_Valor1.Text);
                res = v1 * 1000;
                txt_res.Text = Convert.ToString(res + " Metros");
                op = 0;
                op2 = 0;
            }
            if (op == 3 && op2 == 3)
            {
                v1 = Convert.ToInt32(txt_Valor1.Text);
                res = v1;
                txt_res.Text = Convert.ToString(res + " Kilômetros");
                op = 0;
                op2 = 0;
            }
        }

        private void rbtn1_CheckedChanged(object sender, EventArgs e)
        {
            op = 1;
          
        }

        private void rbtn2_CheckedChanged(object sender, EventArgs e)
        {
            op = 2;
          
        }

        private void rbtn3_CheckedChanged(object sender, EventArgs e)
        {
            op = 3;
            
        }

        private void rbtn4_CheckedChanged(object sender, EventArgs e)
        {
            op2 = 1;
        }

        private void rbtn5_CheckedChanged(object sender, EventArgs e)
        {
            op2 = 2;
        }

        private void rbtn6_CheckedChanged(object sender, EventArgs e)
        {
            op2 = 3;
        }
    }
}
