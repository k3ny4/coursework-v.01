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
    public partial class testprocess : Form
    {
        int correctAnswer;
        int questionNumber = 1;
        int score;
        int totalQuestions;
        List<int> incorrectQuestions = new List<int>();

        public testprocess()
        {
            InitializeComponent();
            totalQuestions = 4;
            askQuestion(questionNumber);
        }

        private void AnswerCheck(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;
            int selectedAnswer = Convert.ToInt32(senderObject.Tag);

            if (selectedAnswer == correctAnswer)
            {
                score++;
            }
            else
            {
                incorrectQuestions.Add(questionNumber);
            }

            if (questionNumber == totalQuestions)
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
                MessageBox.Show(
                                    "Тест завершено." + Environment.NewLine +
                                    "Ви відповіли на " + score + " з " + totalQuestions + " питань правильно." + Environment.NewLine +
                                    incorrectQuestionsText + Environment.NewLine +
                                    "Натисніть OK для повторення тесту або закрийте повідомлення."
                                    );

                score = 0;
                questionNumber = 1;
                incorrectQuestions.Clear();
                askQuestion(questionNumber);
            }
            else
            {
                questionNumber++;
                askQuestion(questionNumber);
            }
        }

        private void askQuestion(int qnum)
        {
            switch (qnum)
            {
                case 1:
                    label1.Text = "Яка характеристика якості ПЗ за \nISO 25010:2011 стосується його здатності захистити дані?\n";
                    button1.Text = "Функціональність";
                    button2.Text = "Безпека";
                    button3.Text = "Сумісність";
                    button4.Text = "Зручність супроводу";
                    correctAnswer = 2;
                    break;

                case 2:
                    label1.Text = "Який з інструментів використовується \nдля обчислення LOC-метрик?\n";
                    button1.Text = "PVS-Studio";
                    button2.Text = "USC Codecount";
                    button3.Text = "Locmethics";
                    button4.Text = "SourceStat";
                    correctAnswer = 3;
                    break;

                case 3:
                    label1.Text = "Який метод використовується для аналізу \nрезультатів розрахунку метрик у розробленій системі оцінки якості?\n";
                    button1.Text = "Метод найменших квадратів";
                    button2.Text = "Коефіцієнти кореляції рангів Спірмена";
                    button3.Text = "Метод Монте-Карло";
                    button4.Text = "Аналіз чутливості";
                    correctAnswer = 2;
                    break;

                case 4:
                    label1.Text = "Що є однією з причин потреби \nв нових рішеннях для оцінки якості ПЗ?\n";
                    button1.Text = "Застарілість існуючих рішень";
                    button2.Text = "Велика кількість метрик";
                    button3.Text = "Надлишкова документація";
                    button4.Text = "Недостатня потужність сучасних комп'ютерів";
                    correctAnswer = 1;
                    break;
            }
        }
    }


}


/*
 */