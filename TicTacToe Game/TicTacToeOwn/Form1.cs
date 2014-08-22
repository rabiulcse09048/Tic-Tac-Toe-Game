using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TicTacToeOwn
{
    public partial class Form1 : Form
    {
        private int playerNo, numberOfClick;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ButtonClick(sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ButtonClick(sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ButtonClick(sender);
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            ButtonClick(sender);
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            ButtonClick(sender);
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            ButtonClick(sender);
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            ButtonClick(sender);
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            ButtonClick(sender);
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            ButtonClick(sender);
        }
        private void ButtonClick(object sender)
        {
            numberOfClick += 1;

            if (numberOfClick % 2 == 1)
            {
                playerNo = 1;
            }
            else
            {
                playerNo = 2;
            }

            if (playerNo == 1)
            {
                ((Button)sender).Text = "X";
            }
            else
            {
                ((Button)sender).Text = "0";
            }

            ((Button)sender).Enabled = false;
            CheckWinner();
        }

        private void CheckWinner()
        {
            if (button1.Text == button2.Text&&button2.Text== button3.Text&&button1.Text!="")
            {
               DisplayWinner();
            }

            else if (button1.Text == button4.Text && button4.Text == button7.Text && button1.Text!="")
            {
                DisplayWinner();
            }

            else if (button1.Text == button5.Text && button5.Text == button9.Text&&button1.Text!="")
            {
                DisplayWinner();
            }

            else if (button3.Text == button4.Text && button4.Text == button6.Text&&button3.Text!="")
            {
                DisplayWinner();
            }

            else if (button7.Text == button8.Text && button8.Text == button9.Text&&button7.Text!="")
            {
                DisplayWinner();
            }

            else if (button2.Text == button5.Text && button5.Text == button8.Text&&button2.Text!="")
            {
                DisplayWinner();
            }

            else if(button3.Text==button6.Text&&button6.Text==button9.Text&&button3.Text!="")
            {
                DisplayWinner();
            }

            else if (button3.Text == button5.Text && button5.Text == button7.Text&&button3.Text!="")
            {
                DisplayWinner();
            }
            else if(numberOfClick==9) 
            {
                MessageBox.Show("Game drawn!");
            }
        }
        private void DisplayWinner()
        {
            if (playerNo == 1)
            {
                MessageBox.Show("A is winner!");
            }
            else
            {
                MessageBox.Show("B is winner");
            }
        }

        //private void NewGame()
        //{
        //    ClearWindow();
        //    button1.Enabled = true;
        //    button2.Enabled = true;
        //    button3.Enabled = true;
        //    button4.Enabled = true;
        //    button5.Enabled = true;
        //    button6.Enabled = true;
        //    button7.Enabled = true;
        //    button8.Enabled = true;
        //    button9.Enabled = true;
        //}
        //private void ClearWindow()
        //{
        //    button1.Text = "";
        //    button2.Text = "";
        //    button3.Text = "";
        //    button4.Text = "";
        //    button5.Text = "";
        //    button6.Text = "";
        //    button7.Text = "";
        //    button8.Text = "";
        //    button9.Text = "";
        //}
    }
}
