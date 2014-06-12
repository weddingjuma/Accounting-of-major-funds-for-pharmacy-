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
    public partial class Таблица_Заболевания : Form
    {
        FarCompDataContext dc = new FarCompDataContext();

        public Таблица_Заболевания()
        {
            InitializeComponent();
            заболеванияBindingSource.DataSource = dc.Заболеванияs;
        }

        private void заболеванияBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            dc.SubmitChanges();
        }

        private void Таблица_Заболевания_Load(object sender, EventArgs e)
        {

        }
    }
}
