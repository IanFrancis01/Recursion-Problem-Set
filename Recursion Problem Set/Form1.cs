using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recursion_Problem_Set
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnQuestion1a_Click(object sender, EventArgs e)
        {
            lblResult.Text = "Result: ";
            lblResult.Text += Repeat('X', 10);
            

        }

        private void lblResult_Click(object sender, EventArgs e)
        {

        }

        private void btnQ1a_Click(object sender, EventArgs e)
        {
            char c = 'X';
            lblResult.Text = "Result: ";
            for (int i = 0; i < 10; i++)
            {
                lblResult.Text += c.ToString();
            }
        }





        //methods
        public string Repeat(char c, int n)
        {
            //base case
            if (n == 0) return null;

            else
            {
                return c.ToString() + Repeat(c, n - 1);
            }
        }

        public string Expand(string Word)
        {
            return null;

        }
    }
}