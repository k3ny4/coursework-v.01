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
    public partial class resultats : Form
    {
        public resultats(int score, int totalQuestions, List<int> incorrectQuestions)
        {
            InitializeComponent();
            label1.Text = "Ви відповіли правильно на " + score + " з " + totalQuestions + " питань.";

            if (incorrectQuestions.Count > 0)
            {
                label3.Text = "Неправильно відповіли на питання: " + string.Join(", ", incorrectQuestions);
            }
            else
            {
                label3.Text = "Усі відповіді правильні!";
            }
        }
    }
}
