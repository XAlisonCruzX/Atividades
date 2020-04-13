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

        private void btnSoma_Click(object sender, EventArgs e)
        { 
            try
            {  
                lblResultado.Text = Convert.ToString(Int32.Parse(txtValor1.Text) + Int32.Parse(txtValor2.Text));
            }catch(FormatException)
            {
                lblResultado.Text = "Argument Null";      
            }
          
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            try
            {
                lblResultado.Text = Convert.ToString(Int32.Parse(txtValor1.Text) - Int32.Parse(txtValor2.Text));
            }
            catch (FormatException)
            {
                lblResultado.Text = "Argument Null";              
            }
          
        }


        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            try
            {
                lblResultado.Text = Convert.ToString(Int32.Parse(txtValor1.Text) * Int32.Parse(txtValor2.Text));
            }
            catch (FormatException)
            {                
                lblResultado.Text = "Argument Null";               
            }
           
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            try
            {
                lblResultado.Text = Convert.ToString(Int32.Parse(txtValor1.Text) / Int32.Parse(txtValor2.Text));
            }
            catch (FormatException)
            {
                lblResultado.Text = "Argument Null";          
            }
            catch (DivideByZeroException)
            {
                lblResultado.Text = "DivideByZero";
            }
        }

    }
}
