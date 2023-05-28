using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace Games_In_One
{
    public partial class AddGameScreen : UserControl
    {
        private readonly MainScreen main;

        // Imports the add() function from LinkedFrontAndBack DLL.
        // Adds a new game with the specified info to the overall list, and subsequently the database.
        // The game's unique id will be generated automatically.
        // Inputs:
        //  game_name: string representing the name of the game.
        //  game_path: string representing the exectuable path of the game.
        //  image_path: string representing the image path of the game.
        //  status: the c string that will recieve the status of the adding game
        [DllImport("LinkFrontAndBack.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        public static extern void Add(string game_name, string game_path, string image_path, StringBuilder status);

        public AddGameScreen()
        {
            InitializeComponent();
        }

        public AddGameScreen(MainScreen main)
        {
            InitializeComponent();
            this.main = main;
        }

        // When `Exit` is clicked, change the AddGameScreen to not be visible
        // and resets the states of the buttons in MainScreen.
        private void ExitAddGameButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            AddStatusLabel.Text = "";
            ResetTextBox();
            main.InitialButtonsState();
        }

        // Whe `Add` is clicked, check if the user has enetered a image path
        // if not pass in the GamesInOne logo as the path.
        private void ConfirmAddGameButton_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("***********************");
            string imagePath = GameImagePathTextBox.Text;
            if (!(imagePath.EndsWith(".png") ||
                imagePath.EndsWith(".ico") ||
                imagePath.EndsWith(".jpg") ||
                imagePath.EndsWith(".jpeg")))
            {
                imagePath = "Resources/Logo.png";
                Debug.WriteLine("Using default image: " + imagePath);
            }
            Debug.WriteLine("Using image: " + imagePath);
            StringBuilder status = new StringBuilder(256);
            Add(GameNameTextBox.Text, GamePathTextBox.Text, imagePath, status);
            if (status.ToString().Equals("success"))
            {
                AddStatusLabel.Text = "";
                this.Visible = false;
                main.LoadData();
                ResetTextBox();
            }
            else
            {
                AddStatusLabel.Text = status.ToString();
            }
            Debug.WriteLine("***********************");

        }

        // When `Clear` is clicked, reset the textboxes to inital state.
        private void ClearAddGameButton_Click(object sender, EventArgs e)
        {
            AddStatusLabel.Text = "";
            ResetTextBox();
        }

        // Clicking into the GameName textbox for the first time will 
        // will remove the palce holder text, and set font color to black.
        private void GameNameTextBox_Enter(object sender, EventArgs e)
        {
            if (GameNameTextBox.Text == "Name")
            {
                GameNameTextBox.Text = "";
                GameNameTextBox.ForeColor = Color.Black;
            }
        }
        
        // Clicking off of the GameName textbox when no text was entered
        // will replace the textbox with placeholder text "Name".
        private void GameNameTextBox_Exit(object sender, EventArgs e)
        {
            if (GameNameTextBox.Text == "")
            {
                GameNameTextBox.Text = "Name";
                GameNameTextBox.ForeColor = Color.Gray;
            }
        }

        // Clicking into the GamePath textbox for the first time will 
        // will remove the palce holder text, and set font color to black.
        private void GamePathTextBox_Enter(object sender, EventArgs e)
        {
            if (GamePathTextBox.Text == "Game Path")
            {
                GamePathTextBox.Text = "";
                GamePathTextBox.ForeColor = Color.Black;
            }
        }

        // Clicking off of the GamePath textbox when no text was entered
        // will replace the textbox with placeholder text "Game Path".
        private void GamePathTextBox_Exit(object sender, EventArgs e)
        {
            if (GamePathTextBox.Text == "")
            {
                GamePathTextBox.Text = "Game Path";
                GamePathTextBox.ForeColor = Color.Gray;
            }
        }

        // Clicking into the GameImagePath textbox for the first time will 
        // will remove the palce holder text, and set font color to black.
        private void GameImagePathTextBox_Enter(object sender, EventArgs e)
        {
            if (GameImagePathTextBox.Text == "Image Path")
            {
                GameImagePathTextBox.Text = "";
                GameImagePathTextBox.ForeColor = Color.Black;
            }
        }

        // Clicking off of the GameImagePath textbox when no text was entered
        // will replace the textbox with placeholder text "Image Path".
        private void GameImagePathTextBox_Exit(object sender, EventArgs e)
        {
            if (GameImagePathTextBox.Text == "")
            {
                GameImagePathTextBox.Text = "Image Path";
                GameImagePathTextBox.ForeColor = Color.Gray;
            }
        }

        // Reseting the textbox to their initial state with
        // placeholder texts and gray font color.
        private void ResetTextBox()
        {
            GameNameTextBox.Text = "Name";
            GameNameTextBox.ForeColor = Color.Gray;

            GamePathTextBox.Text = "Game Path";
            GamePathTextBox.ForeColor = Color.Gray;

            GameImagePathTextBox.Text = "Image Path";
            GameImagePathTextBox.ForeColor = Color.Gray;
        }

        // Set the GamePath textbox with the path selected by the GamePathFileExplorer.
        private void GamePathFileExplorer_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            GamePathTextBox.Text = GamePathFileExplorer.FileName;
            GamePathTextBox.ForeColor = Color.Black;
        }

        // Set the GameIimagePath textbox with the path selected by the GameImagePathFileExplorer.
        private void GameImagePathFileExplorer_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            GameImagePathTextBox.Text = GameImagePathFileExplorer.FileName;
            GameImagePathTextBox.ForeColor = Color.Black;
        }

        // Show file explorer for .exe files when GamePathFileExplorer button is clicked.
        private void GamePathFileExplorerButton_Click(object sender, EventArgs e)
        {
            this.GamePathFileExplorer.ShowDialog();
        }

        // Show file explorer for image files when GameImagePathFileExplorer button is clicked.
        private void GameImagePathExplorerButton_Click(object sender, EventArgs e)
        {
            this.GameImagePathFileExplorer.ShowDialog();
        }

        // Limit the GameName to be 16 characters only.
        private void GameNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (this.GameNameTextBox.Text.Length > 16)
            {
                GameNameTextBox.Text = GameNameTextBox.Text.Substring(0, 16);
                GameNameTextBox.SelectionStart = 16;
            }
        }

    }
}
