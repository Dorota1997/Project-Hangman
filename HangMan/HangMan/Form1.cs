using System;
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

        public frmHang()
        {
            InitializeComponent();
        }

        private void loadwords()
        {
            string[] readText = File.ReadAllLines("CommonWords.csv");
            foreach (string s in readText)
            {

            }
        }


        private void guessClick(object sender, EventArgs e)
        {
            wrongGuesses++;
            if (wrongGuesses < 7)
            {
                HangImage.Image = hangImages[wrongGuesses];
            }
            else
            {
                lblResult.Text = "You lose!";
            }

        }

        private void frmHang_Load(object sender, EventArgs e)
        {
            loadwords();
        }
    }
}
