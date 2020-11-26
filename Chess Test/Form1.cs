﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chess_Test
{
    public partial class Form1 : Form
    {
        //Global Variables
        double mouseGridPosX;
        double mouseGridPosY;
        int scaleValue = 55;

        Button pressedButton;
        Button pressedPiece;

        bool whiteTurn = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {

            timer1.Enabled = true;
            //scaleValue is the value multiplied from grid position to get pixel position
            //realPos is used whenever the pixel position of stuff is needed
            int[] realPos = {(1 * scaleValue), (2 * scaleValue),(3 * scaleValue),(4 * scaleValue),(5 * scaleValue),(6 * scaleValue),(7 * scaleValue),(8 * scaleValue)};
            //int[,] gridLoc = new int[8, 8];
            //Generating the grid for the chess board, because I don't wanna manually create 64 spaces
            for (int x = 1; x <=8; x++)
            {
                for (int y = 1; y <= 8; y++)
                {
                    Button testButton = new Button();
                    this.Controls.Add(testButton);
                    testButton.Location = new Point((x * scaleValue), (y * scaleValue));
                    testButton.Size = new Size(54, 54);
                    testButton.Click += new EventHandler(button_down);

                    //Generating diagonal colours
                    if (x % 2 == 0 && y % 2 == 0)
                    {
                        testButton.BackColor = Color.Green;
                    }
                    else if (x % 2 != 0 && y % 2 != 0)
                    {
                        testButton.BackColor = Color.Green;
                    }
                    else
                    {
                        testButton.BackColor = Color.Brown;
                    }
                    
                    testButton.FlatStyle = FlatStyle.Flat;
                    testButton.FlatAppearance.BorderColor = Color.Red;

                }
            }
            startButton.Visible = false;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {

        }


        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseGridPosX = MousePosition.X / scaleValue;
            mouseGridPosY = MousePosition.Y / scaleValue;
            mouseGridPosX = Math.Floor(mouseGridPosX);
            mouseGridPosY = Math.Floor(mouseGridPosY);
            debugLabel.Text = (mouseGridPosX + "\n" + mouseGridPosY + "\n");
        }
        private void button_down(object sender, EventArgs e)
        {
            pressedButton = (Button)sender;
            debugLabel.Text = ("Button pressed at\n" + pressedButton.Location.X / scaleValue + "\n\n" + pressedButton.Location.Y / scaleValue);
            if (whiteTurn == true && pressedPiece.BackColor != Color.Black)
            {
                if (pressedPiece.Name.Contains("Pawn"))
                {
                    pawn_movement();
                }

            }
            else if (whiteTurn == false && pressedPiece.BackColor == Color.Black)
            {
                if (pressedPiece.Name.Contains("Pawn"))
                {
                    pawn_movement();
                }
            }
                

        }

        private void button_down_on_piece(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;

                pressedPiece = (Button)sender;

        }

        private void pawn_movement()
        {
            if (whiteTurn == true && pressedPiece.Location.Y / scaleValue == 7 && pressedButton.Location.X/scaleValue == pressedPiece.Location.X / scaleValue && pressedPiece.Location.Y / scaleValue - pressedButton.Location.Y / scaleValue <= 2)
            {
                pressedPiece.Location = pressedButton.Location;
                whiteTurn = false;
            }
            else if (whiteTurn == false && pressedPiece.Location.Y / scaleValue == 2 && pressedButton.Location.X / scaleValue == pressedPiece.Location.X / scaleValue && pressedButton.Location.Y / scaleValue - pressedPiece.Location.Y / scaleValue   <= 2)
            {
                pressedPiece.Location = pressedButton.Location;
                whiteTurn = true;
            }
            else if (whiteTurn == true && pressedButton.Location.X / scaleValue == pressedPiece.Location.X / scaleValue && pressedPiece.Location.Y / scaleValue - pressedButton.Location.Y / scaleValue <= 1)
            {
                pressedPiece.Location = pressedButton.Location;
                whiteTurn = false;
            }
            else if (whiteTurn == false && pressedButton.Location.X / scaleValue == pressedPiece.Location.X / scaleValue && pressedButton.Location.Y / scaleValue - pressedPiece.Location.Y / scaleValue <= 1)
            {
                pressedPiece.Location = pressedButton.Location;
                whiteTurn = true;
            }
        }
    }
}
