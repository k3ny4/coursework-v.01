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
    public partial class testform : Form
    {
        int percentage;
        int correctAnswer;
        int questionNumber = 1;
        int score;
        int totalQuestions;
        List<int> incorrectQuestions = new List<int>();

        public testform()
        {
            InitializeComponent();
            askQuestion(questionNumber);
            totalQuestions = 4;
        }

        private void checkedAnswer(object sender, EventArgs e)
        {
            int selectedAnswer = -1;
            if (checkBox1.Checked) selectedAnswer = 1;
            else if (checkBox2.Checked) selectedAnswer = 2;
            else if (checkBox3.Checked) selectedAnswer = 3;
            else if (checkBox4.Checked) selectedAnswer = 4;

            bool isAnswerCorrect = false;

            if (checkBox1.Checked && correctAnswer == 1)
            {
                isAnswerCorrect = true;
            }
            else if (checkBox2.Checked && correctAnswer == 2)
            {
                isAnswerCorrect = true;
            }
            else if (checkBox3.Checked && correctAnswer == 3)
            {
                isAnswerCorrect = true;
            }
            else if (checkBox4.Checked && correctAnswer == 4)
            {
                isAnswerCorrect = true;
            }

            if (isAnswerCorrect)
            {
                score++;
            }


            var senderObject = (CheckBox)sender;

            int buttonTag = Convert.ToInt32(senderObject.Tag);
            
            if (buttonTag == correctAnswer)
            {
                score++;
            }

            if (selectedAnswer == correctAnswer)
            {
                score++;
            }

            else
            {
                incorrectQuestions.Add(questionNumber);
            }

            questionNumber++;

            if (questionNumber > totalQuestions)
            {
                resultats result = new resultats(score, totalQuestions, incorrectQuestions);
                result.Show();
                this.Hide();
            }
            else
            {
                askQuestion(questionNumber);
            }

            if (questionNumber == totalQuestions)
            {
                percentage = (int)Math.Round((double)(score * 100) / totalQuestions);

                resultats resultsForm = new resultats(score, totalQuestions);
                resultsForm.Show();

                score = 0;
                questionNumber = 1;
                askQuestion(questionNumber);
            }
            else
            {
                questionNumber++;
                askQuestion(questionNumber);

                checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
        }

        private void askQuestion(int qnum)
        {
            if (qnum == totalQuestions)
            {
                button1.Text = "Здати тест";
            }
            else
            {
                button1.Text = "Дати відповідь";
            }

            switch (qnum)
            {
                case 1:
                    label1.Text = "Що таке якість ПЗ згідно з ISO 25010:2011?";
                    checkBox1.Text = "Здатність автоматизувати процеси";
                    checkBox2.Text = "Здатність задовольняти потреби";
                    checkBox3.Text = "Відповідність сучасним стандартам безпеки";
                    checkBox4.Text = "Інтеграція в будь-які системи";
                    correctAnswer = 2;
                    break;
                case 2:
                    label1.Text = "Який продукт використовується для обчислення LOC-метрик?";
                    checkBox1.Text = "Borland Together";
                    checkBox2.Text = "SourceStat";
                    checkBox3.Text = "PVS-Studio";
                    checkBox4.Text = "Locmetrics";
                    correctAnswer = 4;
                    break;
                case 3:
                    label1.Text = "Який мінус програми SourceStat?";
                    checkBox1.Text = "Працює тільки під Windows XP/Vista/7";
                    checkBox2.Text = "Висока вартість";
                    checkBox3.Text = "Відсутність експорту даних";
                    checkBox4.Text = "Вимагає багато оперативної пам'яті";
                    correctAnswer = 1;
                    break;
                case 4:
                    label1.Text = "Який метод використовується для аналізу результатів?";
                    checkBox1.Text = "Метод найменших квадратів";
                    checkBox2.Text = "Спосіб парного порівняння";
                    checkBox3.Text = "Коефіцієнти кореляції рангів Спірмена";
                    checkBox4.Text = "Метод середніх арифметичних значень";
                    correctAnswer = 3;
                    break;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {

        }

       
    }
}
