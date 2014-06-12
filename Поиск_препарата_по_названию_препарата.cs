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
    public partial class Поиск_препарата_по_названию_препарата : Form
    {
        FarCompDataContext dc = new FarCompDataContext();

        public Поиск_препарата_по_названию_препарата()
        {
            InitializeComponent();
        }

        private void Поиск_препарата_по_названию_препарата_Load(object sender, EventArgs e)
        {

        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            поиск_препаратаResultBindingSource.DataSource = dc.Поиск_препарата(textBox1.Text);
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void поиск_препаратаResultBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            dc.SubmitChanges();
        }
    }
}
