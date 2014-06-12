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
    public partial class Содержимое_заказа_перечень_препаратов : Form
    {
        FarCompDataContext dc = new FarCompDataContext();

        public Содержимое_заказа_перечень_препаратов()
        {
            InitializeComponent();
            содержимое_заказаBindingSource.DataSource = dc.Содержимое_заказаs;
        }
        private void препаратыBindingNavigator_RefreshItems(object sender, EventArgs e)
        {
            dc.SubmitChanges();
        }

        

        private void Содержимое_заказа_перечень_препаратов_Load(object sender, EventArgs e)
        {

        }

        private void содержимое_заказаBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            dc.SubmitChanges();
        }

        private void содержимое_заказаBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

       
    }
}
