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
            lblResult.Text += Repeat(Char.Parse(txtQuestion1.Text), 10);
            

        }

        private void lblResult_Click(object sender, EventArgs e)
        {

        }

        private void btnQ1a_Click(object sender, EventArgs e)
        {
            char c = char.Parse(txtQuestion1.Text);

            lblResult.Text = "Result: ";

            for (int i = 0; i < 10; i++)
            {
                lblResult.Text += c.ToString();
            }
        }





        //methods
        //question 1 and 2
        public string Repeat(char c, int n)
        {
            //base case
            if (n == 0) return null;

            else
            {
                return c.ToString() + Repeat(c, n - 1);
            }
        }

        //question 3
        public string Expand(string Word)
        {
            //base case
            if(Word.Length == 1) return Word;
            else
            {
                //Word2 = Word
                return null;
            }

        }
    }
}