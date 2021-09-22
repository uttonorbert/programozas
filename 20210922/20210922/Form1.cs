using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20210922
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Btn_kor_Click(object sender, EventArgs e)
        {
            double sugar = double.Parse(txt_sugar.Text);
            lbl_kerulet.Text = "Kör kerülete";
            lbl_terulet.Text = "Kör területe";
            double kerulet = 2 * sugar * Math.PI;
            double terulet = Math.Pow(sugar, 2) * Math.PI;
            textBox1.Text =Convert.ToString( kerulet);
            textBox2.Text = Convert.ToString(terulet);

        }

        private void Txt_sugar_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void Btn_gomb_Click(object sender, EventArgs e)
        {
            double sugar = double.Parse(txt_sugar.Text);
            lbl_kerulet.Text = "Gömb felszine";
            lbl_terulet.Text = "Gömb térfogata";
            double felszine = 4 * Math.PI * Math.Pow(sugar,2);
            double térfogata = 4 * Math.PI/3 * Math.Pow(sugar, 3);
            textBox1.Text = Convert.ToString(felszine);
            textBox2.Text = Convert.ToString(térfogata);
        }
    }
}
