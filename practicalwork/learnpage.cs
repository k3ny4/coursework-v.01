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
    public partial class learnpage : Form
    {
        private int Page = 0;
        public learnpage()
        {
            InitializeComponent();
            text.Visible = false;
            nextbtn.Enabled = false;
            prevbtn.Enabled = false;
            linkLabel2.Enabled = false;
            linkLabel3.Enabled = false;
            linkLabel4.Enabled = false;
            linkLabel5.Enabled = false;
            linkLabel6.Enabled = false;
            linkLabel7.Enabled = false;
            linkLabel8.Enabled = false;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) // Better if there would be if-else func
        {
            Page = 0;
            NextPage();
            nextbtn.Enabled = true;
            text.Visible = true;
            instruct.Visible = false;
            linkLabel2.Enabled = true;
            linkLabel3.Enabled = true;
            linkLabel4.Enabled = true;
            linkLabel5.Enabled = true;
            linkLabel6.Enabled = true;
            linkLabel7.Enabled = true;
            linkLabel8.Enabled = true;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Page = 1;
            NextPage();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Page = 2;
            NextPage();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Page = 3;
            NextPage();
        }
        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Page = 4;
            NextPage();
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Page = 5;
            NextPage();
        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Page = 6;
            NextPage();
        }

        private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Page = 7;
            NextPage();
        }
        private void EndPage()
        {
            Page = 8;
            NextPage();
        }
        private void nextbtn_Click(object sender, EventArgs e)
        {
            if (Page < 8)
            {
                Page++;
                NextPage();
            }
            if (Page == 8)
            {
                nextbtn.Enabled = false;
            }
        }
        private void NextPage()
        {
            switch(Page)
            {
                case 0: 
                    text.Font = new Font(text.Font.FontFamily, 12);
                    text.Location = new Point(102, 74);
                    text.Text = "Якість програмного забезпечення (ПЗ) – це його здатність при заданих умовах\r" +
                        "\nзадовольняти встановленим або передбачуваним потребам.\r" +
                        "\nХарактеризується якість ПЗ за 8 характеристиками, згідно до моделі якості ISO 25010:2011:\r" +
                        "\n• функціональність;\r\n• ефективність;\r\n• надійність;\r\n• безпека;\r\n• зручність використання;\r" +
                        "\n• зручність супроводу;\r\n• сумісність;\r\n• портативність.\r\nЗ ростом кількості сучасних технічних засобів " +
                        "та можливостей ПЗ зростає зона його\r\nвідповідальності та рівень довіри до нього.\r\nУже сьогодні людина довіряє " +
                        "ПП вирішувати важливі завдання, часто пов'язані зі\r\nздоров'ям, безпекою та життям людей. При вирішенні завдань такого " +
                        "роду якість цих\r\nпродуктів має перебувати на належному рівні на всіх етапах його життєвого циклу.";
                    break;
                case 1:
                    prevbtn.Enabled = true;
                    text.Font = new Font(text.Font.FontFamily, 12);
                    text.Location = new Point(102, 74);
                    text.Text = "Для успішного контролю якості необхідні формалізовані, кількісні оцінки\r" +
                        "\nпоказників якості.\r\nТакими оцінками виступають метрики ПЗ. Вони знаходяться на найнижчому " +
                        "–\r\nфундаментальному рівні моделі якості ПП (згідно стандартів), та є" +
                        "\r\nосновоположними.\r\nСаме тому починати оцінювання якості\r\nпотрібно з та базуючись на метриках.";
                    break;
                case 2:
                    text.Font = new Font(text.Font.FontFamily, 11);
                    text.Location = new Point(102, 74);
                    text.Text = "Для проведення оцінки якості ПЗ існують різноманітні програми.\r" +
                        "\nСеред них, наприклад: Locmetrics, USC Codecount, Code Counter Pro, SourceStat, " +
                        "Borland Together, PVS-Studio та інші.\r\nLocmetrics – продукт для обчислення LOC-метрик.\r" +
                        "\nДо плюсів цього продукту можна віднести те, що\r\nвін безкоштовний і має простий інтерфейс.\r" +
                        "\nАле мінусами цієї розробки виступають:\r\n• відсутність документації по використанню\r\nпрограми;\r" +
                        "\n• відсутність опису методики розрахунку метрик;\r\n• відсутність хоча б найпростіших засобів\r\nпобудови звітності або експорту даних.";
                        break;
                case 3:
                    text.Font = new Font(text.Font.FontFamily, 12);
                    text.Location = new Point(102, 74);
                    text.Text = "SourceStat – утиліта, яка виконує розрахунок статистики (метрик) для програм, " +
                        "написаних на мовах C/C++.\r\nАктуальна версія SourceStat використовує наступний набір метрик: " +
                        "кількість рядків коду, кількість рядків\r\nкоментарів, ставлення рядків коду до рядків коментарів.\r" +
                        "\nДо плюсів відносяться:\r\n• простий інтерфейс, який дозволяє сортувати відображення метрик;\r\n• " +
                        "збереження результатів роботи.\r\nСеред мінусів:\r\n• дуже мала кількість метрик для обчислення;\r\n• " +
                        "відсутність опису методики розрахунку метрик;\r\n• програма працює лише під управлінням операційних систем Windows XP/Vista/7.";
                    break;
                case 4:
                    text.Font = new Font(text.Font.FontFamily, 12);
                    text.Location = new Point(102, 74);
                    text.Text = "Але більшість продуктів, які призначені для оцінки ПЗ\r" +
                        "\nне володіють презентабельним інтерфейсом, а супроводжує\r\nїх досить скупа або зовсім відсутня документація.\r" +
                        "\nОдні з них абсолютно безкоштовні, але при цьому\r\nрозраховують невелику кількість метрик, а переважна\r" +
                        "\nбільшість – є комерційними рішеннями та бувають\r\nнеймовірно дорогими, які до того ж не можна попередньо\r\nвипробувати.\r" +
                        "\nТакож, серед мінусів усіх програм для\r\nоцінювання якості ПЗ є те, що майже всі\r\nіснуючі рішення застарілі та вже не\r\nпідтримуються розробниками, а також не\r" +
                        "\nпризначені для роботи на сучасних\r\nопераційних системах.";
                    break;
                case 5:
                    text.Font = new Font(text.Font.FontFamily, 12);
                    text.Location = new Point(102, 74);
                    text.Text = "Після проведення аналізу існуючих методів проведення оцінки якості ПЗ та\r" +
                        "\nвивчення існуючих програмних рішень, можна робити висновки про недосконалість\r" +
                        "\nіснуючих рішень.\r\nЩо призводить до виникнення необхідності розробки нових або вдосконалення\r" +
                        "\nіснуючих методів та розробки сучасних програмних рішень для оцінки якості ПЗ.\r" +
                        "\nТому було поставлене завдання створення автоматизованої системи, яка зробить\r" +
                        "\nпроведення оцінювання якості доступним, а також, дозволить удосконалити спосіб\r\nвизначення якості.";
                    break;
                case 6:
                    text.Font = new Font(text.Font.FontFamily, 11);
                    text.Location = new Point(102, 74);
                    text.Text = "Робота з системою проходить у декілька простих етапів:\r\n• користувач повинен відкрити програмний код та дати старт розрахунку метрик;\r" +
                        "\n• надалі проводиться аналіз отриманих результатів, використовуючи коефіцієнти\r\nкореляції рангів Спірмена;\r" +
                        "\n• також, проводиться графічний аналіз для відстеження залежності певної оцінки\r\nвід змін у програмному коді;\r" +
                        "\n• усі результати можна зберігати у вигляді звітів. Архітектура створеної системи досить проста. Основними складовими \nможна виділити власне саму\r\n" +
                        "\nсистему та її контент, а управління створеним програмним рішенням виконує безпосередньо\r\nкористувач.\r" +
                        "\nСклад автоматизованої системи представлений, використовуючи функціональну декомпозицію\r\nсистеми, що дозволяє побачити всі основні компоненти програми та їх взаємодію.";
                    break;
                case 7:
                    text.Font = new Font(text.Font.FontFamily, 12);
                    text.Location = new Point(102, 74);
                    text.Text = "Із результатів аналізу сучасного стану галузі оцінювання якості ПЗ випливають потреба й \nактуальність наукових досліджень у\r" +
                        "\nгалузі оцінювання та прогнозування якості ПЗ \nна усіх етапах його життєвого циклу.\r" +
                        "\nА також є необхідність покращення вже існуючих рішень оцінки якості.\r" +
                        "\nМоделі оцінювання якості ПП \nвключають метрики для визначення рівня кожної характеристики якості.\n \nЯкщо характеристики\r" +
                        "\nякості обрані правильно, такі вимірювання можуть підтримати якість (рівень якості) багатьма способами.\n \nМетрики можуть\r" +
                        "\nдопомогти в управлінні процесом прийняття рішень,\n сприяти пошуку проблемних аспектів і вузьких місць в процесах.\r" +
                        "\nЗа час виконання магістерської дисертації була \nрозроблена автоматизована інформаційна система,\n яка дозволяє забезпечити\r" +
                        "\nоцінку якості ПЗ за різними показниками \nякості та на усіх стадіях життєвого циклу ПП.\n\r" +
                        "\nА також, покращено спосіб розрахунку трьох розмірно– \nта однієї об’єктно–орієнтованої метрик програмного коду\n";
                    break;
                case 8:
                    text.Font = new Font(text.Font.FontFamily, 24);
                    text.Location = new Point(341, 247);
                    text.Text = "Кінець теми.";
                    break;
            }
            text.Refresh();
            instruct.Visible = false;
            text.Visible = true;
        }

        private void prevbtn_Click(object sender, EventArgs e)
        {
            if (Page > 0)
            {
                prevbtn.Enabled = true;
                Page--;
                NextPage();
            }
            else
            {
                prevbtn.Enabled = false;
            }
        }

        private void menubtn_Click(object sender, EventArgs e)
        {
            menu f1 = new menu();
            f1.Show();
            Visible = false;
        }
    }
}
