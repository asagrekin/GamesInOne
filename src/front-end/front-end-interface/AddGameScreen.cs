using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using static Games_In_One_App.MainScreen;

namespace Games_In_One_App
{
    public partial class AddGameScreen : UserControl
    {   
        private AddGameRowFunc addGameFunc;
        //private RefreshListFunc refreshListFunc;

        [DllImport("LinkFrontAndBack.dll")]
        public static extern void add([In] string game_name, [In] string game_path, [In] string image_path);
        public AddGameScreen(AddGameRowFunc addGameFunc)
        {
            InitializeComponent();
            this.addGameFunc = addGameFunc;
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

            // Currently assuming user inputed everything correctly.
            add(GameNameTextBox.Text, GamePathTextBox.Text, GameImagePathTextBox.Text);
            this.addGameFunc(GameNameTextBox.Text, GamePathTextBox.Text, GameImagePathTextBox.Text);
            //this.refreshListFunc();
            resetTextBox();
        }

        private void ClearAddGameButton_Click(object sender, EventArgs e)
        {
            resetTextBox();
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

        private void resetTextBox()
        {
            GameNameTextBox.Text = "Name";
            GameNameTextBox.ForeColor = Color.Gray;

            GamePathTextBox.Text = "Game Path";
            GamePathTextBox.ForeColor = Color.Gray;

            GameImagePathTextBox.Text = "Image Path";
            GameImagePathTextBox.ForeColor = Color.Gray;
        }

        private void GamePathFileExplorer_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            GamePathTextBox.Text = GamePathFileExplorer.FileName;
            GamePathTextBox.ForeColor = Color.Black;
        }

        private void GameImagePathFileExplorer_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            GameImagePathTextBox.Text = GameImagePathFileExplorer.FileName;
            GameImagePathTextBox.ForeColor = Color.Black;
        }



        private void GamePathFileExplorerButton_Click(object sender, EventArgs e)
        {
            this.GamePathFileExplorer.ShowDialog();
        }

        private void GameImagePathExplorerButton_Click(object sender, EventArgs e)
        {
            this.GameImagePathFileExplorer.ShowDialog();
        }
    }
}
