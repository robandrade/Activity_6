using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void convertButtton_Click(object sender, EventArgs e)
        {

            double earthWeight;
            double convertGravity;
            double marsGravity = (9.81 / 3.711);

            try 
            {
                // input of users earth weight
                earthWeight = double.Parse(inputWeight.Text);
                // convert that to mars weight
                convertGravity = earthWeight / marsGravity;

                outputWeight.Text = Convert.ToString(convertGravity);
                outputWeight.Text = string.Format("{0:F3}", double.Parse(outputWeight.Text));
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
                 

        }

        private void label1_Click(object sender, EventArgs e)
        {
              
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
