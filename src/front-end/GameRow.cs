using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Games_In_One_App
{
    public partial class GameRow : UserControl
    {
        private bool running = false;
        private string path;

        public GameRow(string name, string path, string imagePath)
        {
            InitializeComponent();
            this.GameName.Text = name;
            this.path = path;
            this.GameImage.Image = Image.FromFile(imagePath);
        }

        private void GameRow_Load(object sender, EventArgs e)
        {
            GameStatus.Text = "";
        }

        private void StartGameButton_Click(object sender, EventArgs e)
        {
            running = !running;
            if (running)
            {
                this.GameStatus.Text = "Game Running...";
            } else
            {
                this.GameStatus.Text = "";
            }
        }

    }
}
