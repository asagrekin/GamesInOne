namespace Games_In_One_App
{
    partial class GameRow
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GameRowContainer = new System.Windows.Forms.TableLayoutPanel();
            this.StartGameButton = new System.Windows.Forms.Button();
            this.GameName = new System.Windows.Forms.Label();
            this.GameStatus = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GameRowContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // GameRowContainer
            // 
            this.GameRowContainer.ColumnCount = 4;
            this.GameRowContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.9375F));
            this.GameRowContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.0625F));
            this.GameRowContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 106F));
            this.GameRowContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 106F));
            this.GameRowContainer.Controls.Add(this.StartGameButton, 2, 0);
            this.GameRowContainer.Controls.Add(this.GameName, 1, 0);
            this.GameRowContainer.Controls.Add(this.GameStatus, 3, 0);
            this.GameRowContainer.Controls.Add(this.pictureBox1, 0, 0);
            this.GameRowContainer.Location = new System.Drawing.Point(3, 3);
            this.GameRowContainer.Name = "GameRowContainer";
            this.GameRowContainer.RowCount = 1;
            this.GameRowContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.GameRowContainer.Size = new System.Drawing.Size(513, 100);
            this.GameRowContainer.TabIndex = 0;
            // 
            // StartGameButton
            // 
            this.StartGameButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.StartGameButton.Location = new System.Drawing.Point(315, 38);
            this.StartGameButton.Name = "StartGameButton";
            this.StartGameButton.Size = new System.Drawing.Size(75, 23);
            this.StartGameButton.TabIndex = 0;
            this.StartGameButton.Text = "Start Game";
            this.StartGameButton.UseVisualStyleBackColor = true;
            this.StartGameButton.Click += new System.EventHandler(this.StartGameButton_Click);
            // 
            // GameName
            // 
            this.GameName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GameName.AutoSize = true;
            this.GameName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameName.Location = new System.Drawing.Point(145, 38);
            this.GameName.Name = "GameName";
            this.GameName.Size = new System.Drawing.Size(117, 24);
            this.GameName.TabIndex = 1;
            this.GameName.Text = "Game Name";
            this.GameName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GameStatus
            // 
            this.GameStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GameStatus.AutoSize = true;
            this.GameStatus.Location = new System.Drawing.Point(425, 43);
            this.GameStatus.Name = "GameStatus";
            this.GameStatus.Size = new System.Drawing.Size(68, 13);
            this.GameStatus.TabIndex = 2;
            this.GameStatus.Text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Games_In_One_App.Properties.Resources.game_placeholder;
            this.pictureBox1.InitialImage = global::Games_In_One_App.Properties.Resources.game_placeholder;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // GameRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GameRowContainer);
            this.Name = "GameRow";
            this.Size = new System.Drawing.Size(517, 105);
            this.GameRowContainer.ResumeLayout(false);
            this.GameRowContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel GameRowContainer;
        private System.Windows.Forms.Button StartGameButton;
        private System.Windows.Forms.Label GameName;
        private System.Windows.Forms.Label GameStatus;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
