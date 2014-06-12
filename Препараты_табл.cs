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
    public partial class Препараты_табл : Form
    {
        FarCompDataContext dc = new FarCompDataContext();
        public Препараты_табл()
        {
            InitializeComponent();
            препаратыBindingSource.DataSource = dc.Препаратыs;

        }
       

        private void Препараты_табл_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Фармакологические_свойства f = new Фармакологические_свойства();
            f.ShowDialog();

        }

        private void примечаниеLabel_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Состав_и_лекарственная_форма f = new Состав_и_лекарственная_форма();
            f.ShowDialog();
        }

        private void примечаниеTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
 Показания_к_применению_препаратов f = new Показания_к_применению_препаратов();
            f.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
           Поиск_препарата_по_названию_препарата f = new Поиск_препарата_по_названию_препарата();
            f.ShowDialog();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Тип_препарата_БАД f = new Тип_препарата_БАД();
            f.ShowDialog();

        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Тип_препарата_Витамин f = new Тип_препарата_Витамин ();
            f.ShowDialog();

        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Тип_препарата_Лекарство f = new Тип_препарата_Лекарство();
            f.ShowDialog();
        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Тип_препарата_Косметика f = new Тип_препарата_Косметика();
            f.ShowDialog();
        }

        private void препаратыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            dc.SubmitChanges();
        }

        
    }
}
