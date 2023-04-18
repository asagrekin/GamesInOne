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
    public partial class GamesInOne : Form
    {
        public GamesInOne()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            addGameScreen.Visible = false;
        }

        private void AddGameButton_Click(object sender, EventArgs e)
        {
            /*GameRow gameRow = new GameRow();
            gameRow.Dock = DockStyle.Fill;
            GamesTable.Controls.Add(gameRow, 0, GamesTable.RowCount);
            GamesTable.RowCount++;*/

            addGameScreen.Visible = true;
            addGameScreen.BringToFront();

        }

        private void GamesTable_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addGameScreen_Load(object sender, EventArgs e)
        {
            addGameScreen.Visible = false;
        }
    }
}
