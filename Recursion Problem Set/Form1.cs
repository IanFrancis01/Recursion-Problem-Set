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

        private void btnQ3_Click(object sender, EventArgs e)
        {
            string Original;
            if (txtQuestion3.Text == "") MessageBox.Show("Please enter a word!");
            else
            {
                Original = txtQuestion3.Text;
                lblResult.Text = Expand(Original);
            }
        }

        private void txtQuestion3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnQuestion4_Click(object sender, EventArgs e)
        {
            string Original;
            if (txtQuestion4.Text == "") MessageBox.Show("Please enter a word!");
            else
            {
                Original = txtQuestion4.Text;
                lblResult.Text = Compact(Original);
            }
        }

        private void btnQuestion5_Click(object sender, EventArgs e)
        {
            string Original = txtQuestion5.Text;
            if (Palidrome(Original) == true)
                lblResult.Text = Original + " is a palidrome!";
            else
                lblResult.Text = Original + " is not a palidrome.";
        }

        private void btnQuestion6_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtQuestion6a.Text);
            int b = int.Parse(txtQuestion6b.Text);
            
            lblResult.Text = string.Empty + GCD(a, b);
        }

        //methods
        //question 1 and 2 - Repeat
        public string Repeat(char c, int n)
        {
            //base case
            if (n == 0) return null;

            else
            {
                return c.ToString() + Repeat(c, n - 1);
            }
        }

        //question 3 - Expand
        public string Expand(string Word)
        {
            //base case
            if (Word.Length == 1) return Word;
            else
            {
                return (Word[0] + "-" + Expand(Word.Substring(1)));
            }
        }

        //question 4 - Compact
        public string Compact(string Word)
        {
            //base case 1
            if(Word.Length == 1)
            {
                if (Word == " ")
                {
                    return string.Empty;
                }
                else
                {
                    return Word;
                }
            }
            else
            {
                string letter = Word[0].ToString();

                if (letter == " ")
                {
                    return Compact(Word.Substring(1));
                }
                else
                {
                    return letter + Compact(Word.Substring(1));
                }
            }
        }

        //Question 5 - Palendrome
        bool Palidrome(string Word)
        {
            //base case
            if (Word.Length <= 1)
            {
                return true;
            }
            else
            {
                if (Word[0] == Word[Word.Length - 1])
                    return Palidrome(Word.Substring(1, Word.Length - 2));
                else return false;
            }
        }
        //Question 6 - GCD
        public int GCD(int a, int b)
        {
            //base
            if (b == 0)
                return a;
            else
                return GCD(b, a % b);
        }
    }
}