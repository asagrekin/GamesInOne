using System.Drawing;
using System.Runtime.InteropServices;
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
            this.addGameButton = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.PictureBox();
            this.editOrderButton = new System.Windows.Forms.Button();
            this.saveOrderButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // addGameButton
            // 
            this.addGameButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addGameButton.Location = new System.Drawing.Point(393, 31);
            this.addGameButton.Margin = new System.Windows.Forms.Padding(20);
            this.addGameButton.Name = "addGameButton";
            this.addGameButton.Size = new System.Drawing.Size(75, 23);
            this.addGameButton.TabIndex = 8;
            this.addGameButton.Text = "Add Game";
            this.addGameButton.UseVisualStyleBackColor = true;
            this.addGameButton.Click += new System.EventHandler(this.AddGameButton_Click);
            // 
            // logo
            // 
            this.logo.Image = global::Games_In_One_App.Properties.Resources.Logo;
            this.logo.InitialImage = global::Games_In_One_App.Properties.Resources.Logo;
            this.logo.Location = new System.Drawing.Point(12, 12);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(117, 57);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 11;
            this.logo.TabStop = false;
            // 
            // editOrderButton
            // 
            this.editOrderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editOrderButton.Location = new System.Drawing.Point(509, 29);
            this.editOrderButton.Name = "editOrderButton";
            this.editOrderButton.Size = new System.Drawing.Size(75, 23);
            this.editOrderButton.TabIndex = 12;
            this.editOrderButton.Text = "Edit Order";
            this.editOrderButton.UseVisualStyleBackColor = true;
            this.editOrderButton.Click += new System.EventHandler(this.EditGameButton_Click);
            // 
            // saveOrderButton
            // 
            this.saveOrderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.saveOrderButton.Location = new System.Drawing.Point(612, 31);
            this.saveOrderButton.Name = "saveOrderButton";
            this.saveOrderButton.Size = new System.Drawing.Size(75, 23);
            this.saveOrderButton.TabIndex = 13;
            this.saveOrderButton.Text = "Save Order";
            this.saveOrderButton.UseVisualStyleBackColor = true;
            this.saveOrderButton.Click += new System.EventHandler(this.saveOrderButton_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(734, 461);
            this.Controls.Add(this.saveOrderButton);
            this.Controls.Add(this.editOrderButton);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.addGameButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(750, 500);
            this.Name = "MainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Games In One";
            this.Load += new System.EventHandler(this.MainScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button addGameButton;
        private PictureBox logo;
        private Button editOrderButton;
        private Button saveOrderButton;
    }

}

