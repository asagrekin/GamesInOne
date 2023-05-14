using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using static Games_In_One_App.MainScreen;

namespace Games_In_One_App
{
    public partial class GameRow : UserControl
    {

        private MainScreen main;
        private string name;
        private string path;
        private string imagePath;
        private int id;
        private bool showButton;

        [DllImport("LinkFrontAndBack.dll")]
        public static extern void play(int id);

        [DllImport("LinkFrontAndBack.dll")]
        public static extern void del(int id);

        [DllImport("LinkFrontAndBack.dll")]
        public static extern void add([In] string game_name, [In] string game_path, [In] string image_path);
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
            this.showButton = showButton;
            this.StartGameButton.Visible = showButton;
            this.DeleteButton.Visible = showButton; 
            Resize += GameRow_Resize;
            Invalidate();
        }
        private void GameRow_Resize(object sender, EventArgs e)
        {
            Invalidate();
        }

        public string GetName()
        {
            return GameName.Text;
        }
        private void StartGameButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Starting Game");
            play(id);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Deleting " + this.GameName.Text);
            del(id);
            main.LoadData();
        }
    

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

        public void removeFromDB()
        {
            del(id);
        }

        public void addToDB()
        {
            add(name, path, imagePath);
        }

    }
}
