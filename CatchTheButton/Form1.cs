using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatchTheButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCatchMe_MouseEnter(object sender, EventArgs e)
        {
            Random rand = new Random();
            var maxWidth = this.Width - btnCatchMe.ClientSize.Width;
            var maxHeight = this.Height - btnCatchMe.ClientSize.Height;
            this.btnCatchMe.Location = new Point(rand.Next(maxWidth), rand.Next(maxHeight));
           
            

        }

        private void btnCatchMe_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Congratulations! You win!");
        }

        




    }
}
