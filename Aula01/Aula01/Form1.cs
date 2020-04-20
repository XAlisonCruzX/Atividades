using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private double valor = 0;
        private String str = "";
        private String strEquacao = "";
        private List<String> listEquacao = new List<string>();

        private void btnSoma_Click(object sender, EventArgs e) 
        {
            
           if(this.valor == null || this.valor == 0)
            {
               this.valor = double.Parse(txtValor1.Text);
            }
            else
            {
                this.strEquacao += str;
            }


            this.strEquacao += this.valor;
            if (str != "+")
            {
                str = "+";
               
            }
            else
            {
                
                valor += double.Parse(txtValor1.Text);
                txtValor1.Text = "";
               


            }

            lblEquacao.Text = this.valor.ToString() + str;

        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {

            if (this.valor == null || this.valor == 0)
            {
                this.valor = double.Parse(txtValor1.Text);
            }
            else
            {
                this.strEquacao += str;
            }
            this.strEquacao += this.valor;

            if (str != "-")
            {
                str = "-";
               
            }
            else
            {

                
                valor -= double.Parse(txtValor1.Text);
                txtValor1.Text = "";
                str = "-";
            }

            lblEquacao.Text = this.valor.ToString() + str;
        }


        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            if (this.valor == null || this.valor == 0)
            {
                this.valor = double.Parse(txtValor1.Text);
            }
            else
            {
                this.strEquacao += str;
            }
            this.strEquacao += this.valor;
            if (str != "*")
            {
                str = "*";
               
            }
            else
            {
                valor *= double.Parse(txtValor1.Text);
                txtValor1.Text = "";
                str = "*";
            }

            lblEquacao.Text = this.valor.ToString() + str;
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            if (this.valor == null || this.valor == 0)
            {
                this.valor = double.Parse(txtValor1.Text);
            }
            else
            {
                this.strEquacao += str;
            }
            this.strEquacao += this.valor;
            if (str != "/")
            {
                str = "/";
                
            }
            else
            {
                valor /= double.Parse(txtValor1.Text);
                txtValor1.Text = "";
                str = "/";
            }

            lblEquacao.Text = this.valor.ToString() + str;
        }

        private void btnPorcent_Click(object sender, EventArgs e)
        {
            if (this.valor == null || this.valor == 0)
            {
                this.valor = double.Parse(txtValor1.Text);
            }
            else
            {
                this.strEquacao += str;
            }
            this.strEquacao += this.valor;
            if (str != "%")
            {
                str = "%";
               
            }
            else
            {
                valor *= (100.0/double.Parse(txtValor1.Text));
                txtValor1.Text = "";
                str = "%";
            }

            lblEquacao.Text = this.valor.ToString() + str;
        }

        private void btnRaiz_Click(object sender, EventArgs e)
        {
            if (this.valor == null || this.valor == 0)
            {
                this.valor = double.Parse(txtValor1.Text);
            }
            else
            {
                this.strEquacao += str;
            }
            this.strEquacao += this.valor;
            double x = double.Parse(txtValor1.Text);
            if (x < 0)
            {
                txtValor1.Text = "Este valor não é valido.";
            }
            else
            {
                x = Math.Sqrt(x);
                txtValor1.Text = x.ToString();
            }

            lblEquacao.Text = this.valor.ToString() + str;
        }

        private void btnResult_Click(object sender, EventArgs e)
        {

            this.strEquacao += this.str + txtValor1.Text + "=";
            if (str.Equals("+"))
            {
                
                valor += double.Parse(txtValor1.Text);
                txtValor1.Text = valor.ToString();
            }
            else if (str.Equals("-"))
            {
                valor -= double.Parse(txtValor1.Text);
                txtValor1.Text = valor.ToString();
            }
            else if (str.Equals("*"))
            {
                
                valor *= double.Parse(txtValor1.Text);
                txtValor1.Text = valor.ToString();
            }
            else if (str.Equals("/"))
            {
               
                if (double.Parse(txtValor1.Text) != 0)
                {
                    valor /= double.Parse(txtValor1.Text);
                    txtValor1.Text = valor.ToString();
                }
                else
                {
                    txtValor1.Text = "Dividindo por zero";
                }
            }else if(str.Equals("%"))
            {
                
                valor *= (100.0 / double.Parse(txtValor1.Text));
                txtValor1.Text = valor.ToString();
            }
            else
            {
                txtValor1.Text = "Nao encontrado";
            }
            lblEquacao.Text = this.strEquacao + this.valor;
            this.listEquacao.Add(this.strEquacao);
            this.strEquacao = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblEquacao.Text = "";
            this.strEquacao = "";
            txtValor1.Text = "";
            this.valor = 0;
            this.str = "";
           
        }

       
    }
}
