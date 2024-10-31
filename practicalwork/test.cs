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
    public partial class test : Form
    {
        Form mainform;
        public test(Form mainform) // main form connection by constructor
        {
            InitializeComponent();
            this.mainform = mainform;
        }

        private void proceed_Click(object sender, EventArgs e)
        {
           TestProcess f1 = new TestProcess(mainform);
            f1.Show();
            Visible = false;
        }
    }
}
