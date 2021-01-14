using System;
using System.Windows.Forms;

namespace AnimalEmpire
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Rabbit bunny = new Rabbit(2, "Thumper", Hair.Long);
            bunny.Age = 2;
            bunny.IsPregnant = true;

            textBox1.Text += Environment.NewLine;
            textBox1.Text += bunny.ShowInfo();
        }
    }
}