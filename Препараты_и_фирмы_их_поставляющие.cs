using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Курсовая_Чуваев
{
    public partial class Препараты_и_фирмы_их_поставляющие : Form
    {
        FarCompDataContext dc = new FarCompDataContext();

        public Препараты_и_фирмы_их_поставляющие()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            selResultBindingSource.DataSource = dc.sel(textBox1.Text);
            
         }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void Препараты_и_фирмы_их_поставляющие_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Заказ_препарата f = new Заказ_препарата();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Фирмы_табл f = new Фирмы_табл();
            f.Show();
        }
      
              
    }
}
