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
    public partial class Поиск_фирмы_по_названию : Form
    {
        FarCompDataContext dc = new FarCompDataContext();
        public Поиск_фирмы_по_названию()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            поиск_фирмыResultBindingSource.DataSource = dc.Поиск_фирмы(textBox1.Text);
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void поиск_фирмы_по_названиюResultBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            dc.SubmitChanges();
        }
    }
}
