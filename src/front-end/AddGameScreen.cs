using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Games_In_One_App
{
    public partial class AddGameScreen : UserControl
    {
        public AddGameScreen()
        {
            InitializeComponent();
        }

        private void ExitAddGameButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void ConfirmAddGameButton_Click(object sender, EventArgs e)
        {
            // Check if it is valid to add the game
            // Valid: Add the selected game, display "Game has been added text"
            // Invalid: Display error message 
            //      - Path not to an executable file (if user is the one entering the path)
            //      - 


            /*Process.Start("explorer.exe", @"C:\Users");*/
        }

        private void GameNameTextBox_Enter(object sender, EventArgs e)
        {
            if (GameNameTextBox.Text == "Name")
            {
                GameNameTextBox.Text = "";
                GameNameTextBox.ForeColor = Color.Black;
            }
        }

        private void GameNameTextBox_Exit(object sender, EventArgs e)
        {
            if (GameNameTextBox.Text == "")
            {
                GameNameTextBox.Text = "Name";
                GameNameTextBox.ForeColor = Color.Gray;
            }
        }

        private void GamePathTextBox_Enter(object sender, EventArgs e)
        {
            if (GamePathTextBox.Text == "Game Path")
            {
                GamePathTextBox.Text = "";
                GamePathTextBox.ForeColor = Color.Black;
            }
        }

        private void GamePathTextBox_Exit(object sender, EventArgs e)
        {
            if (GamePathTextBox.Text == "")
            {
                GamePathTextBox.Text = "Game Path";
                GamePathTextBox.ForeColor = Color.Gray;
            }
        }

        private void GameImagePathTextBox_Enter(object sender, EventArgs e)
        {
            if (GameImagePathTextBox.Text == "Image Path")
            {
                GameImagePathTextBox.Text = "";
                GameImagePathTextBox.ForeColor = Color.Black;
            }
        }

        private void GameImagePathTextBox_Exit(object sender, EventArgs e)
        {
            if (GameImagePathTextBox.Text == "")
            {
                GameImagePathTextBox.Text = "Image Path";
                GameImagePathTextBox.ForeColor = Color.Gray;
            }
        }
    }
}
