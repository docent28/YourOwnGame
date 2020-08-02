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
    public partial class Form1 : Form
    {
       
        public List<Label> arrLabel = new List<Label>();
        int currentLabelNumber;
        Thread threadF3;
        bool isPause = true;

        public Form1()
        {
            InitializeComponent();

            // рисуем квадратики
            newGameLabel();

            // заполняем цифрами
            newGameLabelTxt();

            threadF3 = new Thread(new ThreadStart(this.PaintKv));
            threadF3.Start();
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
                    this.arrLabel[t].BackColor = Color.Red;
                    this.arrLabel[currentLabelNumber].BackColor = Color.White;
                    currentLabelNumber = t;
                }
                Thread.Sleep(100);
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                newGameLabelTxt();
            }
            if (e.KeyCode == Keys.F3)
            {
                if(isPause)
                {
                    isPause = false;
                }
            }

            if(e.KeyCode==Keys.Space)
            {
                if (!isPause)
                {
                    isPause = true;
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            threadF3.Abort();
        }
    }
}
