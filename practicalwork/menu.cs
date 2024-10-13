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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            learnpage f2 = new learnpage();
            f2.Show();
            Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            test f3 = new test();
            f3.Show();
            Visible = false;
        }
    }
}
