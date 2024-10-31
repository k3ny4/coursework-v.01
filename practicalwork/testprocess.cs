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
    public partial class TestProcess : Form
    {
        int correctAnswer;
        int QuestionNumber = 1;
        int score;
        int totalQuestions;
        List<int> incorrectQuestions = new List<int>();
        Form mainform; // return to main

        public TestProcess(Form mainform) // main form connection in constructor
        {
            InitializeComponent();
            totalQuestions = 4;
            AskQuestion(QuestionNumber);
            this.mainform = mainform;
        }


        private void AnswerCheck(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;
            int selectedAnswer = Convert.ToInt32(senderObject.Tag); // senderObject.Tag didn't used to buttons

            if (selectedAnswer == correctAnswer)
            {
                score++;
            }
            else
            {
                incorrectQuestions.Add(QuestionNumber);
            }

            if (QuestionNumber == totalQuestions)
            {
                string incorrectQuestionsText = "";
                if (incorrectQuestions.Count > 0)
                {
                    incorrectQuestionsText = "Неправильні відповіді в питаннях: " + string.Join(", ", incorrectQuestions);
                }
                else
                {
                    incorrectQuestionsText = "Усі відповіді правильні.";
                }
                var msgbox = MessageBox.Show(string.Format(
                                    "Тест завершено. Ви відповіли на {0} з {1} питань.\n{2}",
                                    score, totalQuestions, incorrectQuestionsText), // MSGBox int array
                                    "Бажаєте повторно пройти тест?", MessageBoxButtons.YesNo, MessageBoxIcon.Question
                                    );

                score = 0;
                QuestionNumber = 1;
                incorrectQuestions.Clear();
                AskQuestion(QuestionNumber);
                if (msgbox == DialogResult.Yes)
                {
                    this.Refresh();
                }

                else
                {
                    mainform.Show();
                    this.Close();
                }
            }
            else
            {
                QuestionNumber++;
                AskQuestion(QuestionNumber);
            }
        }

        private void AskQuestion(int qnum)
        {
            switch (qnum)
            {
                case 1:
                    label1.Text = "Яка характеристика якості ПЗ за \nISO 25010:2011 стосується його здатності захистити дані?\n";
                    CenterLabel(label1, this);
                    button1.Text = "Функціональність";
                    button2.Text = "Безпека";
                    button3.Text = "Сумісність";
                    button4.Text = "Зручність супроводу";
                    correctAnswer = 2;
                    button2.Tag = 2;
                    break;

                case 2:
                    label1.Text = "Який з інструментів використовується \nдля обчислення LOC-метрик?\n";
                    CenterLabel(label1, this);
                    button1.Text = "PVS-Studio";
                    button2.Text = "USC Codecount";
                    button3.Text = "Locmethics";
                    button4.Text = "SourceStat";
                    correctAnswer = 3;
                    button3.Tag = 3;
                    break;

                case 3:
                    label1.Text = "Який метод використовується для аналізу \nрезультатів розрахунку метрик у розробленій системі оцінки якості?\n";
                    CenterLabel(label1, this);
                    button1.Text = "Метод найменших квадратів";
                    button2.Text = "Коефіцієнти кореляції рангів Спірмена";
                    button3.Text = "Метод Монте-Карло";
                    button4.Text = "Аналіз чутливості";
                    correctAnswer = 2;
                    button2.Tag = 2;
                    break;

                case 4:
                    label1.Text = "Що є однією з причин потреби \nв нових рішеннях для оцінки якості ПЗ?\n";
                    CenterLabel(label1, this);
                    button1.Text = "Застарілість існуючих рішень";
                    button2.Text = "Велика кількість метрик";
                    button3.Text = "Надлишкова документація";
                    button4.Text = "Недостатня потужність сучасних комп'ютерів";
                    correctAnswer = 1;
                    button1.Tag = 1;
                    break;
            }
        }
        private void CenterLabel(Label label, Control container) // label is centered to form
        {
            label.AutoSize = true;

            int x = (container.ClientSize.Width - label.Width) / 2;
            int y = (container.ClientSize.Height - label.Height) / 4;

            label.Location = new Point(x, y);
        }
    }
}