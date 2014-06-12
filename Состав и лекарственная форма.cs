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
    public partial class Состав_и_лекарственная_форма : Form
    {
        FarCompDataContext dc = new FarCompDataContext();

        public Состав_и_лекарственная_форма()
        {
            InitializeComponent();
        }

        private void препаратыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            dc.SubmitChanges();
        }
    }
}
