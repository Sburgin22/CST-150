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

namespace Activity12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ReadFile(List<string> stringList)
        {
            try
            {
                //open Raven.txt
                StreamReader inputFile = File.OpenText("Raven.txt");

                //read the words into the list
                while(!inputFile.EndOfStream)
                {
                    stringList.Add(inputFile.ReadLine());
                }

                //close file
                inputFile.Close();
            }

            //return error if file not found
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //displays file contents to listbox
        private void DisplayLines(List<string> stringList)
        {
            foreach(string str in stringList)
            {
                wordsListBox.Items.Add(str);
            }
        }

        //checks if word ends in 'e', 'E', 't', or 'T'
        //increases counter if finds word with e or t at end
        private int EndsIn(List<string> stringList)
        {
            //counter variable
            int wordCount = 0;

            //checks each string in the list
            //if the last letter is 't' or 'e'
            //regardless of case, it increases the wordCount
            foreach(string str in stringList)
            { 
                //checks last index of each string
                //if it ends in e or t increases word count
                if(str[str.Length - 1] == 'e' || str[str.Length - 1] == 'E' 
                    || str[str.Length - 1]  == 't' || str[str.Length - 1] == 'T')
                {
                    wordCount++;
                }
            }
            return wordCount;
        }

        private void findWordsButton_Click(object sender, EventArgs e)
        {
            int totalWords;

            //creates list to hold strings
            List<string> stringList = new List<string>();

            //reads words from file to list
            ReadFile(stringList);

            //displays to textfile
            wordsListBox.Items.Add("Here are the words from the file:");

            //displays words in list
            DisplayLines(stringList);

            //get number of words that end in t or e
            totalWords = EndsIn(stringList);

            //display results
            wordsListBox.Items.Add(" ");
            wordsListBox.Items.Add("Total words that end in 't' or 'e': " + totalWords);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //closes program
            this.Close();
        }
    }
}
