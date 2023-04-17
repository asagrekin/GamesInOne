using System.Drawing.Text;

namespace Games_In_One_App
{
    partial class GamesInOne
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
            this.GamesInOneTitle = new System.Windows.Forms.Label();
            this.AddGameButton = new System.Windows.Forms.Button();
            this.GamesTable = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // GamesInOneTitle
            // 
            this.GamesInOneTitle.AutoSize = true;
            this.GamesInOneTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GamesInOneTitle.Location = new System.Drawing.Point(9, 7);
            this.GamesInOneTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.GamesInOneTitle.Name = "GamesInOneTitle";
            this.GamesInOneTitle.Size = new System.Drawing.Size(201, 31);
            this.GamesInOneTitle.TabIndex = 2;
            this.GamesInOneTitle.Text = "Games In One";
            // 
            // AddGameButton
            // 
            this.AddGameButton.Location = new System.Drawing.Point(258, 20);
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
            this.GamesTable.Location = new System.Drawing.Point(27, 69);
            this.GamesTable.Name = "GamesTable";
            this.GamesTable.RowCount = 1;
            this.GamesTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.GamesTable.Size = new System.Drawing.Size(0, 0);
            this.GamesTable.TabIndex = 9;
            this.GamesTable.Paint += new System.Windows.Forms.PaintEventHandler(this.GamesTable_Paint);
            // 
            // GamesInOne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.GamesTable);
            this.Controls.Add(this.AddGameButton);
            this.Controls.Add(this.GamesInOneTitle);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GamesInOne";
            this.Text = "Games In One";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label GamesInOneTitle;
        private System.Windows.Forms.Button AddGameButton;
        private System.Windows.Forms.TableLayoutPanel GamesTable;
    }

}

