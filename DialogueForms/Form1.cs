using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DialogueForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (insertDropDown.Text == "")
                return;
            
            RawText.Text += $"<{insertDropDown.Text}>({insertText.Text})";
        }

        private void Display_Click(object sender, EventArgs e)
        {
            DisplayText.Text = ParseOutFX(RawText.Text);
        }

        private string ParseOutFX(string text)
        {
            string parsedText = "";

            Regex regex = new Regex(@"<\w+>\(\w+\)");
            Regex textRX = new Regex(@"[\w\s]*");

            string[] textNoFX = regex.Split(text);
            MatchCollection matches = regex.Matches(text);
            MatchCollection textExtracts;

            int counter = 0;
            foreach (Match match in matches)
            {
                textExtracts = textRX.Matches(match.Value);
                parsedText += textNoFX[counter] + textExtracts[0];

                counter++;
                // if (textNoFX[counter] != "")
            }

            for(int i = 0; i < (textNoFX.Length - counter); i++)
            {
                parsedText += textNoFX[counter + i];
            }

            return parsedText;
        }
    }
}
