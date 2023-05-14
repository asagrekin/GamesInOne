using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static Games_In_One_App.MainScreen;

namespace Games_In_One_App
{
    public partial class AddGameScreen : UserControl
    {
        private MainScreen main;

        [DllImport("LinkFrontAndBack.dll")]
        public static extern void add([In] string game_name, [In] string game_path, [In] string image_path);
        public AddGameScreen(MainScreen main)
        {
            InitializeComponent();
            this.main = main;
        }

        private void ExitAddGameButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void ConfirmAddGameButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("***********************");
            string imagePath = GameImagePathTextBox.Text;
            if (!(imagePath.EndsWith(".png") ||
                imagePath.EndsWith(".ico") ||
                imagePath.EndsWith(".jpg") ||
                imagePath.EndsWith(".jpeg")))
            {
                imagePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\src\\front-end\\front-end-interface\\Resources\\Logo.png";
                Console.WriteLine("Using default image: " + imagePath);
            }
            Console.WriteLine("Using image: " + imagePath);
            add(GameNameTextBox.Text, GamePathTextBox.Text, imagePath);
            main.LoadData();
            resetTextBox();
            Console.WriteLine("***********************");
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
