using Games_In_One.Games_In_One;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace Games_In_One
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
        private TableLayoutPanel gamesList;
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

            // Games Table
            this.gamesList = new TableLayoutPanel();
            this.gamesList.AutoSize = true;
            this.gamesList.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;

            //  GameEditList
            this.gamesEditList = new GamesEditList();
            this.gamesEditList.AutoSize = true;
            this.gamesEditList.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gamesEditList.BackColor = Color.Aqua;

            // Button locations
            this.saveOrderButton.Location = new Point(this.ClientSize.Width - this.saveOrderButton.Width - 20, 20);
            this.editOrderButton.Location = new Point(saveOrderButton.Location.X - this.editOrderButton.Width - 20, 20);
            this.addGameButton.Location = new Point(editOrderButton.Location.X - this.editOrderButton.Width - 20, 20);

            // Games Scroll Panel
            this.gamesScrollPanel = CreateScrollPanel(this.gamesList);
            this.Controls.Add(this.gamesScrollPanel);

            // Scroll Panel
            this.editScrollPanel = CreateScrollPanel(this.gamesEditList);
            this.Controls.Add(this.editScrollPanel);

        }
        private Panel CreateScrollPanel(TableLayoutPanel tablePanel)
        {
            Panel scrollPanel = new Panel();
            scrollPanel.Anchor = AnchorStyles.Top;
            scrollPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            scrollPanel.AutoScroll = true;
            scrollPanel.HorizontalScroll.Enabled = false;
            scrollPanel.Controls.Add(tablePanel);
            return scrollPanel;
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

        private void LoadDataToPanel(Panel scrollPanel, TableLayoutPanel gamesListPanel, bool showRowButtons)
        {
            gamesListPanel.Controls.Clear();
            gamesListPanel.RowCount = 0;
            Referesh();
            while (!AtEndOfList())
            {
                int id = 0;
                StringBuilder name = new StringBuilder(256);
                StringBuilder path = new StringBuilder(256);
                StringBuilder imagePath = new StringBuilder(256);
                GetGame(ref id, name, path, imagePath);
                Console.WriteLine(id + " " + name.ToString() + " " + path.ToString() + " " + imagePath.ToString());
                GameRow gameRow = new GameRow(this, id, name.ToString(), path.ToString(), imagePath.ToString(), showRowButtons);
                gameRow.Dock = DockStyle.Fill;
                gameRow.Enabled = showRowButtons;
                gamesListPanel.Controls.Add(gameRow, 0, gamesListPanel.RowCount);
                gamesListPanel.RowCount++;
            }
            scrollPanel.Location = new Point((ClientSize.Width - (gamesListPanel.Width+20)) / 2, 2 * this.logo.Height - 25);
            scrollPanel.Visible = true;
            if (gamesListPanel.RowCount != 0)
            {
                scrollPanel.Size = new Size(gamesListPanel.Width + 20, ClientSize.Height - 2 * this.logo.Height);
                scrollPanel.BringToFront();
            }
        }
        public void LoadData()
        {
            LoadDataToPanel(this.gamesScrollPanel, this.gamesList, true);
            InitialButtonsState();
        }

        private void EditGameButton_Click(object sender, EventArgs e)
        {
            this.addGameButton.Enabled = false;
            this.saveOrderButton.Enabled = true;
            this.saveOrderButton.Visible = true;
            this.editOrderButton.Enabled = false;

            this.gamesScrollPanel.Visible = false;
            LoadDataToPanel(this.editScrollPanel, this.gamesEditList, false);
        }

        private void Mainscreen_ClientSizeChanged(object sender, EventArgs e)
        {
            this.gamesScrollPanel.Size = new Size(this.gamesList.Width, ClientSize.Height - 2 * this.logo.Height);
            this.editScrollPanel.Size = new Size(this.gamesEditList.Width, ClientSize.Height - 2 * this.logo.Height);
        }

        private void SaveOrderButton_Click(object sender, EventArgs e)
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

        public void InitialButtonsState()
        {
            this.addGameButton.Visible = true;
            this.addGameButton.Enabled = true;
            this.editOrderButton.Visible = this.gamesList.Controls.Count > 0;
            this.editOrderButton.Enabled = this.gamesList.Controls.Count > 0;
            this.saveOrderButton.Visible = false;
        }
    }
}
