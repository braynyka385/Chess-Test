using System;
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
        public Form1()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            //scaleValue is the value multiplied from grid position to get pixel position
            int scaleValue = 55;
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
                    testButton.BackColor = Color.Brown;
                    testButton.FlatStyle = FlatStyle.Flat;
                    testButton.FlatAppearance.BorderColor = Color.Red;

                }
            }
            startButton.Visible = false;
        }
    }
}
