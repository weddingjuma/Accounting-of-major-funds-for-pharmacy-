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
    public partial class Заказ_препарата : Form
    {
        FarCompDataContext dc = new FarCompDataContext();
        public Заказ_препарата()
        {
            InitializeComponent();
            заказ_по_фирмеBindingSource.DataSource = dc.Заказ_по_фирмеs;
        }

        private void заказ_по_фирмеBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

            dc.SubmitChanges();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Содержимое_заказа_перечень_препаратов f = new Содержимое_заказа_перечень_препаратов();
            f.Show();
        }

        private void Заказ_препарата_Load(object sender, EventArgs e)
        {

        }
    }
}
