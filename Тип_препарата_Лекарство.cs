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
    public partial class Тип_препарата_Лекарство : Form
    {
        FarCompDataContext dc = new FarCompDataContext();

        public Тип_препарата_Лекарство()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            лекарствоResultBindingSource.DataSource = dc.Лекарство();
        }
    }
}
