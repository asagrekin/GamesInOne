using System.Drawing;
using System.Windows.Forms;

namespace Games_In_One_App
{
    partial class MainScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AddGameButton = new System.Windows.Forms.Button();
            this.GamesTable = new System.Windows.Forms.TableLayoutPanel();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.addGameScreen = new Games_In_One_App.AddGameScreen(new AddGameRowFunc(AddGameRow));
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // AddGameButton
            // 
            this.AddGameButton.Location = new System.Drawing.Point(603, 29);
            this.AddGameButton.Margin = new System.Windows.Forms.Padding(2);
            this.AddGameButton.Name = "AddGameButton";
            this.AddGameButton.Size = new System.Drawing.Size(80, 19);
            this.AddGameButton.TabIndex = 8;
            this.AddGameButton.Text = "Add Game";
            this.AddGameButton.UseVisualStyleBackColor = true;
            this.AddGameButton.Click += new System.EventHandler(this.AddGameButton_Click);
            // 
            // GamesTable
            // 
            this.GamesTable.AutoSize = true;
            this.GamesTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.GamesTable.ColumnCount = 1;
            this.GamesTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.GamesTable.Location = new System.Drawing.Point(27, 100);
            this.GamesTable.Name = "GamesTable";
            this.GamesTable.RowCount = 1;
            this.GamesTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.GamesTable.Size = new System.Drawing.Size(0, 0);
            this.GamesTable.TabIndex = 9;
            // 
            // Logo
            // 
            this.Logo.Image = global::Games_In_One_App.Properties.Resources.Logo;
            this.Logo.InitialImage = global::Games_In_One_App.Properties.Resources.Logo;
            this.Logo.Location = new System.Drawing.Point(12, 12);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(117, 57);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo.TabIndex = 11;
            this.Logo.TabStop = false;
            // 
            // addGameScreen
            // 
            this.addGameScreen.BackColor = System.Drawing.SystemColors.ControlDark;
            this.addGameScreen.Location = new System.Drawing.Point(194, 80);
            this.addGameScreen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addGameScreen.Name = "addGameScreen";
            this.addGameScreen.Size = new System.Drawing.Size(341, 342);
            this.addGameScreen.TabIndex = 10;
            this.addGameScreen.Load += new System.EventHandler(this.addGameScreen_Load);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(752, 492);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.addGameScreen);
            this.Controls.Add(this.GamesTable);
            this.Controls.Add(this.AddGameButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Games In One";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button AddGameButton;
        private System.Windows.Forms.TableLayoutPanel GamesTable;
        private AddGameScreen addGameScreen;
        private PictureBox Logo;
    }

}

