using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ch2LatinTranslator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LatinText_Click(object sender, EventArgs e)
        {

        }

        private void LeftButton_Click(object sender, EventArgs e)
        {
            latinText.Text = "Sinister";
        }

        private void CenterButton_Click(object sender, EventArgs e)
        {
            latinText.Text = "medium";
        }

        private void RightButton_Click(object sender, EventArgs e)
        {
            latinText.Text = "Dexter";
        }
    }
}
