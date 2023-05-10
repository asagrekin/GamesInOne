using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace Games_In_One_App
{
    public partial class MainScreen : Form
    {
        [DllImport("LinkFrontAndBack.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        public static extern void GetGame(ref int id, StringBuilder name, StringBuilder path, StringBuilder imagePath);
        [DllImport("LinkFrontAndBack.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        public static extern void Referesh();
        [DllImport("LinkFrontAndBack.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        public static extern bool AtEndOfList();


        public delegate void AddGameRowFunc(String gameName, String gamePath, String imagePath);
        public delegate void RefreshListFunc();

        public MainScreen()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            addGameScreen.Visible = false;
            LoadData();
        }

        private void AddGameButton_Click(object sender, EventArgs e)
        {
            this.addGameScreen.Visible = true;
            this.addGameScreen.BringToFront();
        }

        public void AddGameRow(String gameName, String gamePath, String imagePath)
        {
            addGameScreen.Visible = false;
        }


        public void LoadData()
        {
            GamesTable.Controls.Clear();
            GamesTable.RowCount = 0;
            Referesh();
            while (!AtEndOfList()) {
                int id = 0;
                StringBuilder name = new StringBuilder(256);
                StringBuilder path = new StringBuilder(256);
                StringBuilder imagePath = new StringBuilder(256);
                GetGame(ref id, name, path,imagePath);
                Console.WriteLine(id + " " + name.ToString() + " " + path.ToString() + " " + imagePath.ToString());
                GameRow gameRow = new GameRow(id, name.ToString(), path.ToString(), imagePath.ToString(), new RefreshListFunc(LoadData));
                gameRow.Dock = DockStyle.Fill;
                GamesTable.Controls.Add(gameRow, 0, GamesTable.RowCount);
                GamesTable.RowCount++;
            }
        }

        private void addGameScreen_Load(object sender, EventArgs e)
        {
            addGameScreen.Visible = false;
        }
    }
}
