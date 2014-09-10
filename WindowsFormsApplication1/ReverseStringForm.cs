using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            displayLabel.Text = reverseString(inputTextBox.Text);
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            displayLabel.Text = "";
            inputTextBox.Text = "";
            inputTextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        ////******************* Version 1 ************************
        //public string reverseString(string input)
        //{
        //    if (string.IsNullOrEmpty(input))
        //    {
        //        return input;
        //    }

        //    StringBuilder input_sb = new StringBuilder(input.Length);
        //    for (int i = input.Length - 1; i >= 0; i--)
        //    {
        //        input_sb.Append(input[i]);
        //    }

        //    return input_sb.ToString();
        //}

        ////******************* Version 2 ************************
        //public string reverseString(string input)
        //{
        //    if (input == null) return null;

        //    char[] array = input.ToCharArray();
        //    Array.Reverse(array);
        //    return new String(array);
        //}


        ////******************* Version 3 ************************
        //public string reverseString(string input)
        //{
        //    if (input == null) return null;

        //    return new string(input.Reverse().ToArray());
        //}

        //******************* Version 4 ************************       
        public string reverseString(string input)
        {
            if (input == null) return null;
            Stack<char> stck = new Stack<char>(input.ToCharArray());
            string output = "";
            char element;
            while (stck.Count > 0)
            {
                element = stck.Pop();
                output += element;
            }
            return output;
        }

    }
}
