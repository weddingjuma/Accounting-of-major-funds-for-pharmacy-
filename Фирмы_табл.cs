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
    public partial class Фирмы_табл : Form
    {
        FarCompDataContext dc = new FarCompDataContext();
        public Фирмы_табл()
        {
            InitializeComponent();
            фирмыBindingSource.DataSource = dc.Фирмыs;

        }
       
        
        private void Фирмы_табл_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Поиск_фирмы_по_названию f = new Поиск_фирмы_по_названию();
            f.ShowDialog();
        }

        private void фирмыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            dc.SubmitChanges();
        }


    }
}
