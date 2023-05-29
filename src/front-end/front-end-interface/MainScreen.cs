using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace Games_In_One
{
    public partial class MainScreen : Form
    {   
        private AddGameScreen addGameScreen;
        private TableLayoutPanel gamesList;
        private GamesEditList gamesEditList;
        private Panel editScrollPanel;
        private Panel gamesScrollPanel;

        // Imports the GetGame() function from LinkedFrontAndBack DLL.
        // Copies the information from the current game into the specified int pointer and c strings.
        // The current game is the current game that the overall games' list iterator is pointing to.
        // Inputs:
        //  id: the ref int that will get the id of the current game.
        //  name: StringBuilder  that will recieve the name of the current game.
        //  path: StringBuilder  that will recieve the executable path of the current game.
        //  imagePath: StringBuilder  that will recieve the image path of the current game.
        //  status: the c string that will recieve the status of the adding game
        [DllImport("LinkFrontAndBack.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        public static extern void GetGame(ref int id, StringBuilder name, StringBuilder path, StringBuilder imagePath);
        
        // Imports the RefreshList() function from LinkedFrontAndBack DLL.
        // Gets the current list of games stored in the database, and sends its iterator to the beginning.
        [DllImport("LinkFrontAndBack.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void RefreshList();

        // Imports the AtEndOfList() function from LinkedFrontAndBack DLL.
        // Returns true if the iterator is at the end of the overall games list, or false otherwise.
        [DllImport("LinkFrontAndBack.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern bool AtEndOfList();

        public MainScreen()
        {
            InitializeComponent();
            InitializeCustomComponents();
            this.ClientSizeChanged += new System.EventHandler(this.Mainscreen_ClientSizeChanged);
        }

        // Initilize custom components
        private void InitializeCustomComponents()
        {
            // AddGameScreen
            this.addGameScreen = new AddGameScreen(this);
            this.Controls.Add(this.addGameScreen);
            addGameScreen.Anchor = AnchorStyles.None;
            addGameScreen.Location = new Point((ClientSize.Width - addGameScreen.Width) / 2, (ClientSize.Height - addGameScreen.Height) / 2);

            // Games Table
            this.gamesList = new TableLayoutPanel
            {
                AutoSize = true,
                AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            };

            //  GameEditList
            this.gamesEditList = new GamesEditList
            {
                AutoSize = true,
                AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink,
                BackColor = Color.Aqua
            };

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

        // Create scroll panel that contains a TableLayoutPanel
        // Input:
        //  tablePanel: TableLayoutPanel that consists of the game rows
        private Panel CreateScrollPanel(TableLayoutPanel tablePanel)
        {
            Panel scrollPanel = new Panel
            {
                Anchor = AnchorStyles.Top,
                AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink,
                AutoScroll = true
            };
            scrollPanel.HorizontalScroll.Enabled = false;
            scrollPanel.Controls.Add(tablePanel);
            return scrollPanel;
        }

        // On load, set the addGameScreen to be invisible,
        // and display the saved game rows.
        private void MainScreen_Load(object sender, EventArgs e)
        {
            addGameScreen.Visible = false;
            LoadData();
        }

        // When `Add Game` is clicked, set the AddGameScreen
        // to be visible and bring it to the front.
        // Disable the edit game button .
        private void AddGameButton_Click(object sender, EventArgs e)
        {
            this.addGameScreen.Visible = true;
            this.addGameScreen.BringToFront();
            this.editOrderButton.Enabled = false;
        }

        // Load in the game rows to the scroll panel
        // Input:
        //  scrollPanel: Panel that contains the gamesList
        //  gamesListPanel: TableLayoutPanel that contains the game rows
        //  showRowButtons: bool, true if we want to show the buttons for the game row
        private void LoadDataToPanel(Panel scrollPanel, TableLayoutPanel gamesListPanel, bool showRowButtons)
        {
            gamesListPanel.Controls.Clear();
            gamesListPanel.RowCount = 0;
            RefreshList();
            while (!AtEndOfList())
            {
                int id = 0;
                StringBuilder name = new StringBuilder(256);
                StringBuilder path = new StringBuilder(256);
                StringBuilder imagePath = new StringBuilder(256);
                GetGame(ref id, name, path, imagePath);
                Debug.WriteLine(id + " " + name.ToString() + " " + path.ToString() + " " + imagePath.ToString());
                GameRow gameRow = new GameRow(this, id, name.ToString(), path.ToString(), imagePath.ToString(), showRowButtons)
                {
                    Dock = DockStyle.Fill,
                    Enabled = showRowButtons
                };
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
        
        // Loads the data to the game table in the main screen,
        // and set the buttons to initial states.
        public void LoadData()
        {
            LoadDataToPanel(this.gamesScrollPanel, this.gamesList, true);
            InitialButtonsState();
        }

        // When `Edit Order` button is clicked, disable `Add Game` button,
        // and make `Save Order` to be visible and enabled.
        private void EditOrderButton_Click(object sender, EventArgs e)
        {
            this.addGameButton.Enabled = false;
            this.saveOrderButton.Enabled = true;
            this.saveOrderButton.Visible = true;
            this.editOrderButton.Enabled = false;

            this.gamesScrollPanel.Visible = false;
            LoadDataToPanel(this.editScrollPanel, this.gamesEditList, false);
        }

        // Updates the size of the scroll panels when window size changes.
        private void Mainscreen_ClientSizeChanged(object sender, EventArgs e)
        {
            this.gamesScrollPanel.Size = new Size(this.gamesList.Width, ClientSize.Height - 2 * this.logo.Height);
            this.editScrollPanel.Size = new Size(this.gamesEditList.Width, ClientSize.Height - 2 * this.logo.Height);
        }

        // When `Save Order` is pressed, delete and append each game to 
        // save the new order to database.
        private void SaveOrderButton_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("New Order:");
            for (int i = 0; i < this.gamesEditList.RowCount; i++)
            {
                GameRow gameRow = (GameRow)(this.gamesEditList.GetControlFromPosition(0, i));
                Debug.WriteLine(gameRow.GetName());
                gameRow.RemoveFromDB();
                gameRow.AddToDB();
            }
            this.editScrollPanel.Visible = false;
            LoadData();
        }
        
        // Set the buttons to their initial states
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
