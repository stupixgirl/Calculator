using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {

            if(txtSo1.Text != String.Empty)
            {
                double a = double.Parse(txtSo1.Text);
                double b = double.Parse(txtSo2.Text);
                double c = a + b;
                txtKq.Text = c.ToString();
            }
        }

        private void btTru_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtSo1.Text);
            double b = double.Parse(txtSo2.Text);
            double c = a - b;
            txtKq.Text = c.ToString();
        }
    }
}
