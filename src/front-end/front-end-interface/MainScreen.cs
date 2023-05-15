using Games_In_One_App.Games_In_One_App;
using System;
using System.Collections.Generic;
using System.Drawing;
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

        private AddGameScreen addGameScreen;
        private TableLayoutPanel gamesTable;
        private GamesEditList gamesEditList;
        private Panel editScrollPanel;
        private Panel gamesScrollPanel;

        public MainScreen()
        {
            InitializeComponent();
            InitializeCustomComponents();
            this.ClientSizeChanged += new System.EventHandler(this.Mainscreen_ClientSizeChanged);
        }

        public void InitializeCustomComponents()
        {
            // AddGameScreen
            this.addGameScreen = new AddGameScreen(this);
            this.Controls.Add(this.addGameScreen);
            addGameScreen.Anchor = AnchorStyles.None;
            addGameScreen.Location = new Point((ClientSize.Width - addGameScreen.Width) / 2, (ClientSize.Height - addGameScreen.Height) / 2);


            this.gamesTable = new TableLayoutPanel();
            this.gamesTable.AutoSize = true;
            this.gamesTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gamesTable.ColumnCount = 1;
            this.gamesTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.gamesTable.Name = "gamesTable";
            this.gamesTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.gamesTable.Dock = DockStyle.Left;


            //  GameEditList
            this.gamesEditList = new GamesEditList();
            //this.Controls.Add(this.gamesEditList);
            this.gamesEditList.AutoSize = true;
            this.gamesEditList.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gamesEditList.ColumnCount = 1;
            this.gamesEditList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.gamesEditList.Name = "gamesEditList";
            this.gamesEditList.RowCount = 1;
            this.gamesEditList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.gamesEditList.BackColor = Color.Aqua;

            // Button locations
            this.saveOrderButton.Location = new Point(this.ClientSize.Width - this.saveOrderButton.Width - 20, 20);
            this.editOrderButton.Location = new Point(saveOrderButton.Location.X - this.editOrderButton.Width - 20, 20);
            this.addGameButton.Location = new Point(editOrderButton.Location.X - this.editOrderButton.Width - 20, 20);

            // Games Scroll Panel
            this.gamesScrollPanel = new Panel();
            this.gamesScrollPanel.Anchor = AnchorStyles.Top;
            this.gamesScrollPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gamesScrollPanel.AutoScroll = true;
            this.gamesScrollPanel.HorizontalScroll.Enabled = false;
            this.gamesScrollPanel.Controls.Add(this.gamesTable);
            this.Controls.Add(this.gamesScrollPanel);

            // Scroll Panel
            this.editScrollPanel = new Panel();
            this.editScrollPanel.Anchor = AnchorStyles.Top;
            this.editScrollPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.editScrollPanel.AutoScroll = true;
            this.editScrollPanel.HorizontalScroll.Enabled = false;
            this.editScrollPanel.Controls.Add(this.gamesEditList);
            this.Controls.Add(this.editScrollPanel);

        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
            addGameScreen.Visible = false;
            LoadData();
        }

        private void AddGameButton_Click(object sender, EventArgs e)
        {
            this.addGameScreen.Visible = true;
            this.addGameScreen.BringToFront();
            this.editOrderButton.Enabled = false;
        }

        public void LoadData()
        {
            gamesTable.Controls.Clear();
            gamesTable.RowCount = 0;
            Referesh();
            while (!AtEndOfList())
            {
                int id = 0;
                StringBuilder name = new StringBuilder(256);
                StringBuilder path = new StringBuilder(256);
                StringBuilder imagePath = new StringBuilder(256);
                GetGame(ref id, name, path, imagePath);
                Console.WriteLine(id + " " + name.ToString() + " " + path.ToString() + " " + imagePath.ToString());
                GameRow gameRow = new GameRow(this, id, name.ToString(), path.ToString(), imagePath.ToString(), true);
                gameRow.Dock = DockStyle.None;
                gamesTable.Controls.Add(gameRow, 0, gamesTable.RowCount);
                gamesTable.RowCount++;
            }
            this.gamesTable.Anchor = AnchorStyles.Top;
            this.gamesScrollPanel.Location = new Point((ClientSize.Width - gamesTable.Width) / 2, 2 * this.logo.Height - 25);
            if (gamesTable.RowCount != 0)
            {
                this.gamesScrollPanel.MinimumSize = new Size(this.gamesTable.Width, ClientSize.Height - 2 * this.logo.Height);
                this.gamesScrollPanel.BringToFront();
            }
            initialButtonsState();

        }

        private void ShowEditScreen()
        {
            this.gamesEditList.Controls.Clear();
            this.gamesEditList.RowCount = 0;
            Referesh();
            while (!AtEndOfList())
            {
                int id = 0;
                StringBuilder name = new StringBuilder(256);
                StringBuilder path = new StringBuilder(256);
                StringBuilder imagePath = new StringBuilder(256);
                GetGame(ref id, name, path, imagePath);
                Console.WriteLine(id + " " + name.ToString() + " " + path.ToString() + " " + imagePath.ToString());
                GameRow gameRow = new GameRow(this, id, name.ToString(), path.ToString(), imagePath.ToString(), false);
                gameRow.Dock = DockStyle.Fill;
                gameRow.Enabled = false;
                this.gamesEditList.Controls.Add(gameRow, 0, this.gamesEditList.RowCount);
                this.gamesEditList.RowCount++;
            }
            this.gamesEditList.Anchor = AnchorStyles.Top;
            this.editScrollPanel.Location = new Point((ClientSize.Width - gamesEditList.Width) / 2, 2 * this.logo.Height - 25);
            this.editScrollPanel.Visible = true;
            if (gamesEditList.RowCount != 0)
            {
                this.editScrollPanel.Size = new Size(this.gamesEditList.Width, ClientSize.Height - 2 * this.logo.Height);
                this.editScrollPanel.BringToFront();
            }
        }

        private void addGameScreen_Load(object sender, EventArgs e)
        {
            addGameScreen.Visible = false;
        }

        private void EditGameButton_Click(object sender, EventArgs e)
        {
            this.addGameButton.Enabled = false;
            this.saveOrderButton.Enabled = true;
            this.saveOrderButton.Visible = true;
            this.editOrderButton.Enabled = false;

            ShowEditScreen();
        }

        private void Mainscreen_ClientSizeChanged(object sender, EventArgs e)
        {
            this.gamesScrollPanel.Size = new Size(this.gamesTable.Width, ClientSize.Height - 2 * this.logo.Height);
            this.editScrollPanel.Size = new Size(this.gamesEditList.Width, ClientSize.Height - 2 * this.logo.Height);
        }

        private void saveOrderButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("New Order:");
            for (int i = 0; i < this.gamesEditList.RowCount; i++)
            {
                GameRow gameRow = (GameRow)(this.gamesEditList.GetControlFromPosition(0, i));
                Console.WriteLine(gameRow.GetName());
                gameRow.removeFromDB();
                gameRow.addToDB();
            }
            this.editScrollPanel.Visible = false;
            LoadData();
        }

        public void initialButtonsState()
        {
            this.addGameButton.Visible = true;
            this.addGameButton.Enabled = true;
            this.editOrderButton.Visible = this.gamesTable.Controls.Count > 0;
            this.editOrderButton.Enabled = this.gamesTable.Controls.Count > 0;
            this.saveOrderButton.Visible = false;
        }
    }
}
