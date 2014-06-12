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
    public partial class Главная_форма : Form
    {  
        FarCompDataContext dc=new FarCompDataContext();
        
        public Главная_форма()
        {
            InitializeComponent();
        }
   private void Vhod_v_apteky_Click_1(object sender, EventArgs e)
   {
       Препараты_табл f = new Препараты_табл();
       f.ShowDialog();
   }

   private void button1_Click(object sender, EventArgs e)
   {
       Фирмы_табл f = new Фирмы_табл();
       f.ShowDialog();

   }

   private void button2_Click(object sender, EventArgs e)
   {
       Препараты_и_фирмы_их_поставляющие f = new Препараты_и_фирмы_их_поставляющие();
       f.ShowDialog();
   }
     }
}

