﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Games_In_One_App
{
    public partial class GameRow : UserControl
    {
        
        private bool running = false;
        private string path;
        private int id;

        [DllImport("LinkFrontAndBack.dll")]
        public static extern void play(int id);

        [DllImport("LinkFrontAndBack.dll")]
        public static extern void del(int id);
        public GameRow(int id, string name, string path, string imagePath)
        {
            InitializeComponent();
            this.GameName.Text = name;
            this.path = path;
            this.id = id;
            this.GameImage.Image = Image.FromFile(imagePath);
            Resize += GameRow_Resize;
            Invalidate();
        }
        private void GameRow_Resize(object sender, EventArgs e)
        {
            Invalidate();
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
                Console.WriteLine("Starting Game");
                play(id);
            } else
            {
                this.GameStatus.Text = "";
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Deleting " +  this.GameName.Text);
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
    }
}
