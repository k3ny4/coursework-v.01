using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practicalwork
{
    public partial class learn : Form
    {
        public learn()
        {
            InitializeComponent();
            text.Visible = false;
        }

        private void learn_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            text.Text = "Якість програмного забезпечення (ПЗ) – \nце його здатність при заданих умовах\nзадовольняти встановленим або передбачуваним потребам." +
                "\nХарактеризується якість ПЗ за 8 характеристиками, згідно до моделі якості ISO 25010:2011: \n• функціональність;\n \n• ефективність;\n \n• надійність;\n \n• безпека;\n \n• зручність використання;\n \n• зручність супроводу;\n \n• сумісність;\n \n• портативність.\n\n";
            text.Refresh();
            label2.Visible = false;
            text.Visible = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            text.Text = "З ростом кількості сучасних технічних засобів та можливостей ПЗ зростає зона його відповідальності та рівень довіри до нього." +
                "\nУже сьогодні людина довіряє ПП вирішувати важливі завдання,\n\nчасто пов'язані зі здоров'ям, безпекою та життям людей.\n" +
                "\nПри вирішенні завдань такого роду якість цих продуктів\n \nмає перебувати на належному рівні на всіх етапах його життєвого циклу.\n";
        }
    }
}
