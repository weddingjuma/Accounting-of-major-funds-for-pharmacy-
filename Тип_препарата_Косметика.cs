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
    public partial class Тип_препарата_Косметика : Form
    {
        FarCompDataContext dc = new FarCompDataContext();

        public Тип_препарата_Косметика()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            косметикаResultBindingSource.DataSource = dc.Косметика();
        }

        private void Тип_препарата_Косметика_Load(object sender, EventArgs e)
        {

        }
    }
}
