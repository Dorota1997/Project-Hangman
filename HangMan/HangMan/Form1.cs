using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HangMan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Play_Click(object sender, EventArgs e)
        {
            frmHang transition = new frmHang();      
            this.Hide();                        
            transition.Show();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
