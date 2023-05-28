using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace Games_In_One
{
    public partial class GameRow : UserControl
    {

        private readonly MainScreen main;
        private readonly string name;
        private readonly string path;
        private readonly string imagePath;
        private readonly int id;

        // Imports the play() function from LinkedFrontAndBack DLL
        // Calls the backend function to launch the specified game.
        // Inputs:
        //  id: (int) the unique id of the game to be launched.
        [DllImport("LinkFrontAndBack.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        public static extern void Play(int id);

        // Imports the del() function from LinkedFrontAndBack DLL
        // Deletes the specified game from the overall list, and subsequently the database.
        // Inputs:
        //  id: (int) the unique id of the game to be deleted.
        [DllImport("LinkFrontAndBack.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        public static extern void Del(int id);
        
        // Imports the add() function from LinkedFrontAndBack DLL
        // Adds a new game with the specified info to the overall list, and subsequently the database.
        // The game's unique id will be generated automatically.
        // This function's use case in here is mainly to append the game to the end of the list
        // as the edited list will delete every game and and add the them in the new order.
        // Inputs:
        //  game_name: string representing the name of the game.
        //  game_path: string representing the exectuable path of the game.
        //  image_path: string representing the image path of the game.
        [DllImport("LinkFrontAndBack.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        public static extern void Add(string game_name, string game_path, string image_path, StringBuilder status);
        
        public GameRow(MainScreen main, int id, string name, string path, string imagePath, bool showButton)
        {
            InitializeComponent();
            this.GameName.Text = name;
            this.name = name;
            this.path = path;
            this.id = id;
            this.imagePath = imagePath;
            this.GameImage.Image = Image.FromFile(imagePath);
            this.main = main;
            SetButtons(showButton);
            Resize += GameRow_Resize;
            Invalidate();
        }

        // Set the buttons of the game row to be visble/enabled
        // based on showButton
        // Inputs:
        //  showButton: bool, true to show buttons.
        private void SetButtons(bool showButton)
        {
            this.StartGameButton.Visible = showButton;
            this.StartGameButton.Enabled = showButton;
            this.DeleteButton.Visible = showButton;
            this.DeleteButton.Enabled = showButton;
        }
        
        // Upon resize of the window, resize the components.
        private void GameRow_Resize(object sender, EventArgs e)
        {
            Invalidate();
        }

        // Returns the name of the game.
        public string GetName()
        {
            return GameName.Text;
        }
        
        // Tells backend to launch the game when `Start` is clicked.
        private void StartGameButton_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("Starting Game");
            Play(id);
        }

        // Tells backend to delete the game when `Delete` is clicked.
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("Deleting " + this.GameName.Text);
            Del(id);
            main.LoadData();
        }
  
        // Draws top and bottom boraders around the game row.
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Draw the top border
            using (var pen = new Pen(Color.Black))
            {
                e.Graphics.DrawLine(pen, 0, 0, Width, 0);
            }

            // Draw the bottom border
            using (var pen = new Pen(Color.Black))
            {
                e.Graphics.DrawLine(pen, 0, Height - 1, Width, Height - 1);
            }
        }
        
        // Delete this game's information from the database
        public void RemoveFromDB()
        {
            Del(id);
        }
        
        // Add this game's infromation to the database
        public void AddToDB()
        {
            StringBuilder status = new StringBuilder(256);
            Add(name, path, imagePath, status);
            Debug.WriteLine("Reorder add status: " + status.ToString());
        }

    }
}
