﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace HangMan
{
    public partial class frmHang : Form
    {
        private Bitmap[] hangImages = { HangMan.Properties.Resources.Hang1, HangMan.Properties.Resources.Hang2,
                                        HangMan.Properties.Resources.Hang3, HangMan.Properties.Resources.Hang4,
                                        HangMan.Properties.Resources.Hang5, HangMan.Properties.Resources.Hang6,
                                        HangMan.Properties.Resources.Hang7 };

        private int wrongGuesses = 0;

        private string[] words;

        private string current = "";
        
        private string copyCurrent = "";

        public frmHang()
        {
            InitializeComponent();
        }

        private void loadwords()
        {
            char[] delimitersChars = { ',' };

            string[] readText = File.ReadAllLines("CommonWords.txt");

            words = new string[readText.Length];

            int index = 0;

            foreach (string s in readText)
            {
                string[] line = s.Split(delimitersChars);
                words[index++] = line[0];
            }
        }

        private void setupWordChoice()
        {
            wrongGuesses = 0;

            HangImage.Image = hangImages[wrongGuesses];

            int guessIndex = (new Random()).Next(words.Length);

            current = words[guessIndex];

            copyCurrent = "";

            for (int index = 0; index < current.Length; index++)
            {
                copyCurrent += "_";
            }
            displayCopy();
        }

        private void displayCopy()
        {
            lblShowWord.Text = "";

            for (int index = 0; index < copyCurrent.Length; index++)
            {
                lblShowWord.Text += copyCurrent.Substring(index, 1);
                lblShowWord.Text += " ";
            }
        }

        private void updateCopy(char guess)
        {

        }

        private void guessClick(object sender, EventArgs e)
        {
            Button choice = sender as Button;
            choice.Enabled = false;

            if (current.Contains(choice.Text))
            {
                char[] temp = copyCurrent.ToCharArray();

                char[] find = current.ToCharArray();

                char guessChar = choice.Text.ElementAt(0);

                for (int index = 0; index < find.Length; index++)
                {
                    if (find[index] == guessChar)
                    {
                        temp[index] = guessChar;
                    }
                }

                copyCurrent = new string(temp);

                displayCopy();
            }
            else
            {
                wrongGuesses++;
            }
            if (wrongGuesses < 7)
            {
                HangImage.Image = hangImages[wrongGuesses];
            }
            else
            {
                MessageBox.Show("Przegrałeś!");
                
            }
            if (copyCurrent.Equals(current))
            {
                MessageBox.Show("Wygrałeś!");
                
            }
        }

        private void frmHang_Load(object sender, EventArgs e)
        {

            loadwords();
            setupWordChoice();
        }

        private void try_again(object sender, EventArgs e)
        {
            setupWordChoice();
            lblResult.Text = "";
            
            cmdA.Enabled = true;
            cmdĄ.Enabled = true;
            cmdB.Enabled = true;
            cmdC.Enabled = true;
            cmdĆ.Enabled = true;
            cmdD.Enabled = true;
            cmdE.Enabled = true;
            cmdĘ.Enabled = true;
            cmdF.Enabled = true;
            cmdG.Enabled = true;
            cmdH.Enabled = true;
            cmdI.Enabled = true;
            cmdJ.Enabled = true;
            cmdK.Enabled = true;
            cmdL.Enabled = true;
            cmdŁ.Enabled = true;
            cmdM.Enabled = true;
            cmdN.Enabled = true;
            cmdŃ.Enabled = true;
            cmdO.Enabled = true;
            cmdó.Enabled = true;
            cmdP.Enabled = true;
            cmdQ.Enabled = true;
            cmdR.Enabled = true;
            cmdS.Enabled = true;
            cmdŚ.Enabled = true;
            cmdT.Enabled = true;
            cmdU.Enabled = true;
            cmdV.Enabled = true;
            cmdW.Enabled = true;
            cmdX.Enabled = true;
            cmdY.Enabled = true;
            cmdZ.Enabled = true;
            cmdŹ.Enabled = true;
            cmdŻ.Enabled = true;
        }

        private void GoBack(object sender, EventArgs e)
        {
            this.Hide();

            Form1 menu = new Form1();
            menu.Show();

        }
    }
}
