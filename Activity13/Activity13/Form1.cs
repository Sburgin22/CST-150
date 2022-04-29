using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity13
{

    //used code from https://github.com/maxwell-martin/gaddis-visualcsharp2017-projects/blob/master/TicTacToe/TicTacToe/Form1.cs as reference

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //will display our board as 2d array
        int[,] board = new int[3, 3];

        //converts 0 & 1 to x and o in 2d array
        string[,] move = new string[3, 3];

        //Random generator
        Random r = new Random();

        //creates new board and fills in with 0 or 1
        //as a 2d array
        public void NewBoard(int[,] board)
        {
            for(int row = 0; row < 3; row++)
            {
                for(int col = 0; col < 3; col++)
                {
                    board[row, col] = r.Next(2);
                }
            }
        }

        //this is creates a new 2d array with x and o values
        //based on the location of 1 and 0 in our board array
        public void XO(int[,] board)
        {
            for( int row = 0; row < 3; row++)
            {
                for(int col = 0; col < 3; col++)
                {
                    if(board[row, col] == 0)
                    {
                        move[row, col] = "O";
                    }
                    else
                    {
                        move[row, col] = "X";
                    }
                }
            }
        }

        //displays x or o to their designated label based on move chosen
        //given their location in our move 2d array
        public void DisplayXO(string[,] move)
        {
            label1.Text = move[0,0].ToString();
            label2.Text = move[0,1].ToString();
            label3.Text = move[0,2].ToString();
            label4.Text = move[1,0].ToString();
            label5.Text = move[1,1].ToString();
            label6.Text = move[1,2].ToString();
            label7.Text = move[2,0].ToString();
            label8.Text = move[2,1].ToString();
            label9.Text = move[2,2].ToString();
        }

        //checks various win conditions
        //rows, cols, diagonals
        //if three matching x's or o's
        //that letter wins
        //otherwise game ends in tie
        public void WinnerResults()
        {
            //check each row for matching x or o
            //highlights winning row/column/diagonal using backcolor
            //checks first row
            if (board[0, 0] == board[0, 1] && board[0, 1] == board[0, 2])
            {
                label1.BackColor = Color.Green;
                label2.BackColor = Color.Green;
                label3.BackColor = Color.Green;
                resultLabel.Text = "Winner is " + move[0, 0];//displays x or o based on what is in first box
            }
            //checks second row
            else if (board[1, 0] == board[1, 1] && board[1, 1] == board[1, 2])
            {
                label4.BackColor = Color.Green;
                label5.BackColor = Color.Green;
                label6.BackColor = Color.Green;
                resultLabel.Text = "Winner is " + move[1, 0];//displays x or o based on what is in first box
            }
            //checks 3rd row
            else if (board[2, 0] == board[2, 1] && board[2, 1] == board[2, 2])
            {
                label7.BackColor = Color.Green;
                label8.BackColor = Color.Green;
                label9.BackColor = Color.Green;
                resultLabel.Text = "Winner is " + move[2, 0];//displays x or o based on what is in first box
            }


            //now we check the columns
            //first column
            else if (board[0, 0] == board[1, 0] && board[1, 0] == board[2, 0])
            {
                label1.BackColor = Color.Green;
                label4.BackColor = Color.Green;
                label7.BackColor = Color.Green;
                resultLabel.Text = "Winner is " + move[0, 0];//displays x or o based on what is in first box
            }
            //second column
            else if (board[0, 1] == board[1, 1] && board[1, 1] == board[2, 1])
            {
                label2.BackColor = Color.Green;
                label5.BackColor = Color.Green;
                label8.BackColor = Color.Green;
                resultLabel.Text = "Winner is " + move[0, 1];//displays x or o based on what is in first box
            }
            //check third column
            else if (board[0, 2] == board[1, 2] && board[1, 2] == board[2, 2])
            {
                label3.BackColor = Color.Green;
                label6.BackColor = Color.Green;
                label9.BackColor = Color.Green;
                resultLabel.Text = "Winner is " + move[0, 2];//displays x or o based on what is in first box
            }

            //now check the diagonals
            //should be only two
            //first diagonal from 1st label to 9th label
            else if (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2])
            {
                label1.BackColor = Color.Green;
                label5.BackColor = Color.Green;
                label9.BackColor = Color.Green;
                resultLabel.Text = "Winner is " + move[0, 0];//displays x or o based on what is in first box
            }
            //second diagonal from 3rd label to 7th label
            else if (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0])
            {
                label3.BackColor = Color.Green;
                label5.BackColor = Color.Green;
                label7.BackColor = Color.Green;
                resultLabel.Text = "Winner is " + move[0, 2];//displays x or o based on what is in first box
            }

            //else displays tie message
            //does not highlight since no winner
            else
            {
                resultLabel.Text = "Tie! no winners this game!";
            }
        }

        public void DefaultColor(int[,] board)
        {
            label1.BackColor = DefaultBackColor;
            label2.BackColor = DefaultBackColor;
            label3.BackColor = DefaultBackColor;
            label4.BackColor = DefaultBackColor;
            label5.BackColor = DefaultBackColor;
            label6.BackColor = DefaultBackColor;
            label7.BackColor = DefaultBackColor;
            label8.BackColor = DefaultBackColor;
            label9.BackColor = DefaultBackColor;
        }

        private void newGameButton_Click(object sender, EventArgs e)
        {
            Array.Clear(board,0,board.Length);//clears previous board
            DefaultColor(board);//resets the board color to default
            NewBoard(board);//creates new board and fills with 0 or 1
            XO(board);//changes 0 and 1 to X and O
            DisplayXO(move);//displays board with X and O
            WinnerResults();//displays results in results label
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //closes program
            this.Close();
        }
    }
}
