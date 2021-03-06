﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YourOwnGame
{
    public partial class frmBasicForm : Form
    {
        public List<Label> arrLabel = new List<Label>();
        public int currentLabelNumber;
        Thread threadF3;
        bool isPause = true;
        public Questions listRndQuestions;
        static public List<int> numSelectedQuestions = new List<int>(100);  // лист с номерами которые уже выпадали

        public frmBasicForm()
        {
            InitializeComponent();

            // рисуем квадратики
            newGameLabel();

            // заполняем цифрами
            newGameLabelTxt();

            // выбираем 100 вопросов из файла
            listRndQuestions = selectionRndQuestions(frmQuestion.DeserializeXML());

            threadF3 = new Thread(new ThreadStart(this.PaintKv));
            threadF3.Start();
        }

        // Составляем список из 100 случайных вопросов
        private Questions selectionRndQuestions(Questions questions)
        {
            Questions lstRndQuestions = new Questions();

            if (questions.QuestionsList.Count < 100)
            {
                throw new Exception();
            }

            int[] numLabel = new int[questions.QuestionsList.Count];
            Random rnd = new Random();

            for (int i = 0; i < questions.QuestionsList.Count; i++)
            {
                numLabel[i] = i;
            }

            for (int i = 0; i < questions.QuestionsList.Count; i++)
            {
                int j = rnd.Next(i + 1);
                if (j != i)
                {
                    int tmp = numLabel[i];
                    numLabel[i] = numLabel[j];
                    numLabel[j] = tmp;
                }
            }

            for (int i = 0; i < 100; i++)
            {
                lstRndQuestions.QuestionsList.Add(questions.QuestionsList[numLabel[i]]);
            }

            return lstRndQuestions;
        }

        private void tsmNew_Click(object sender, EventArgs e)
        {
            newGameLabelTxt();
        }

        // рисуем квадратики
        private void newGameLabel()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Label newlbl = new Label();
                    newlbl.Width = 100;
                    newlbl.Height = 100;
                    newlbl.BorderStyle = BorderStyle.FixedSingle;
                    newlbl.Font = new Font("Microsoft Sans Serif", 20);
                    newlbl.TextAlign = ContentAlignment.MiddleCenter;
                    string tmpString = (i * 10 + j + 1).ToString("000");
                    newlbl.Name = "lbl" + tmpString;
                    newlbl.Location = new Point(10 + 105 * j, 40 + 105 * i);
                    newlbl.BackColor = Color.White;
                    this.Controls.Add(newlbl);
                    this.arrLabel.Add(newlbl);
                }
            }
        }

        // пишем текст на метке
        private void newGameLabelTxt()
        {
            int[] arr = InitPole.initNewGame();
            int i = 0;

            foreach (Label lbl in this.arrLabel)
            {
                lbl.Text = arr[i].ToString();
                lbl.Name = "lbl" + arr[i].ToString("000");
                i = i + 1;
            }
        }

        private void tsmExit_Click(object sender, EventArgs e)
        {
            threadF3.Abort();
            this.Close();
        }

        public void PaintKv()
        {
            while (true)
            {
                if (!isPause)
                {
                    var t = InitPole.rndSampling();
                    var findLbl = this.Controls["lbl" + t.ToString("000")];
                    findLbl.BackColor = Color.Red;
                    if (currentLabelNumber == 0)        // срабатывает один раз, так как нумерация ячеек начинается с 1
                    {
                        currentLabelNumber = 1;
                    }
                    findLbl = this.Controls["lbl" + currentLabelNumber.ToString("000")];

                    if (numSelectedQuestions.IndexOf(currentLabelNumber) != -1) // остается зеленым если был выбран
                    {
                        findLbl.BackColor = Color.Green;
                    }
                    else
                    {
                        findLbl.BackColor = Color.White;
                    }
                    currentLabelNumber = t;
                }
                Thread.Sleep(100);
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2 && isPause && frmBasicForm.numSelectedQuestions.Count() == 0)    // перемешиваем карточки
            {
                newGameLabelTxt();
            }

            if (e.KeyCode == Keys.F3)   // выбираем случайный номер
            {
                if (isPause)
                {
                    isPause = false;
                }
            }

            if (e.KeyCode == Keys.Space)   // вызываем форму с вопросом
            {
                if (!isPause)
                {
                    isPause = true;

                    frmAskedQuestion frmAskedQuestion = new frmAskedQuestion();
                    frmAskedQuestion.Owner = this;  // назначаем родителя
                    frmAskedQuestion.fillForm();    // заполняем форму
                    frmAskedQuestion.ShowDialog();

                    var findLbl = this.Controls["lbl" + currentLabelNumber.ToString("000")];
                    findLbl.BackColor = Color.Green;

                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            threadF3.Abort();
        }

        private void tsmAbout_Click(object sender, EventArgs e)
        {
            frmAbout frmAbout = new frmAbout();
            frmAbout.ShowDialog();
        }

        private void questionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuestion frmQuestion = new frmQuestion();
            frmQuestion.ShowDialog();
        }
    }
}
