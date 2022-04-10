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

namespace Activity5
{
    public partial class wordSorter : Form
    {
        public wordSorter()
        {
            InitializeComponent();
        }

        private void openFileButton_Click(object sender, EventArgs e)
        {
            try
            {
                //variable to hold word(s)
                string word;

                string file = null; //creates string to place the word on the current line in

                string[] list = null; //creates a list of strings to compare

                int count = 0; //counter variable
                int max = 0; //max counter variable
                string longest = ""; //string to hold longest word

                int vowCount = 0; //vowel counter
                int maxVow = 0; //max vowel counter

                string mostVow = ""; //string to hold word with most vowels

                string vowel = null; //will hold our word on current line
                string[] vList = null; //list for holding our words with vowels
                string vowels = "aeiouy";
                char v;

                //declare a stream reader
                StreamReader input;

                //open the selected file
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    // opens the selected file
                    input = File.OpenText(openFileDialog1.FileName);

                    while (!input.EndOfStream)
                    {
                        //gets word on that line
                        word = input.ReadLine();

                        //adds word to wordlistbox as lowercase
                        wordListBox.Items.Add(word.ToLower());

                        //sorts words alphabetically
                        wordListBox.Sorted = true;

                        //gets first alphabetically sorted word from list
                        firstWordTextBox.Text = wordListBox.Items[wordListBox.TopIndex].ToString();

                        //gets last alphabetically sorted word from list
                        lastWordTextBox.Text = wordListBox.Items[wordListBox.Items.Count - 1].ToString();

                        file = word;
                        file.Trim();
                        list = file.Split();

                        //used code from https://www.youtube.com/watch?v=-VOLoiVpgpE
                        for (int i = 0; i < list.Length; i++) //uses for loop to search words in list array
                        {
                            string[] findL = list[i].Split(); //checks each word individually
                            for(int j = 0; j < findL.Length; j++) //will check the number of characters
                            {
                                if(findL[i].Length > max)
                                {
                                    max = findL[j].Length; //if greater than current max size that is now the longest word
                                    longest = findL[j]; //longest will equal the word that is deemed longest
                                }
                            }
                        }
                        count += list.Length; //will increase list length as reads each line in file

                        vowel = word;
                        vowel.Trim();
                        vList = vowel.Split();

                        //to find word with most vowels
                        //could not get this portion to work
                        for(int i = 0; i < vList.Length; i++)
                        {
                            string [] findV = vList[i].Split();
                            for(int j = 0; j < findV.Length; j++)
                            {
                                if(findV[i].Contains(vowels))
                                {
                                    vowCount++;
                                }
                                if(vowCount > maxVow)
                                {
                                    maxVow = findV[j].Length;
                                    mostVow = findV[j];
                                }
                            }
                        }
                        count += vList.Length;
                        
                    }

                    longestTextBox.Text = longest.ToLower(); //prints out longest word

                    vowelsTextBox.Text = mostVow.ToLower();

                    //closes file
                    input.Close();

                }
                else
                {
                    MessageBox.Show("No file was opened");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Please select a valid file type");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //closes program
            this.Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            StreamWriter output;

            //saves data from d&d file to sorted text 
            //checks for file or creates it if does not exit
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                output = new StreamWriter(saveFileDialog1.FileName);//creates file if it doesnt exist. Edits if does.

                //write data to file "sorted words"
                output.WriteLine("List of words in lower case:");
                foreach(var Item in wordListBox.Items)
                {
                    output.WriteLine(Item.ToString());
                }
                output.WriteLine("");//creates a space
                output.WriteLine("First word in alphabetical order:");
                output.WriteLine(firstWordTextBox.Text);
                output.WriteLine("");
                output.WriteLine("Last word in alphabetical order:");
                output.WriteLine(lastWordTextBox.Text);
                output.WriteLine("");
                output.WriteLine("Longest word:");
                output.WriteLine(longestTextBox.Text);
                output.WriteLine("");
                output.WriteLine("Word with most vowels:");
                output.WriteLine(vowelsTextBox.Text);
                output.Close();
            }
            else
            {
                //error message
                MessageBox.Show("File not saved");
            }
        }
    }
}
