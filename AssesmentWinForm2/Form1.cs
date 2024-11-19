using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssesmentWinForm2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        double Sal,Hra,Da,Ta,Pt,Pf,Gross;
        private void btmCal_Click(object sender, EventArgs e)
        {
            Sal = Convert.ToDouble(textBoxEmpSal.Text);

            Hra = Convert.ToDouble(Sal* 0.40);
            textBoxHra.Text = Hra.ToString();

            Da = Convert.ToDouble(Sal * 0.30);
            textBoxDa.Text = Da.ToString();

            Ta = Convert.ToDouble(Sal * 0.20);
            textBoxTa.Text = Ta.ToString();

            Pt = Convert.ToDouble(200);
            textBoxPt.Text = Pt.ToString();

            Pf = Convert.ToDouble(Sal * 0.12);
            textBoxPf.Text = Pf.ToString();

            Gross = Sal + Hra + Da + Ta + Pt - Pf;
            textBoxGross.Text = Gross.ToString();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGross_Click(object sender, EventArgs e)
        {
           

        }
    }
}
