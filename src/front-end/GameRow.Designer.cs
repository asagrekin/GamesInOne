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
            this.GameImage = new System.Windows.Forms.PictureBox();
            this.GameRowContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GameImage)).BeginInit();
            this.SuspendLayout();
            // 
            // GameRowContainer
            // 
            this.GameRowContainer.ColumnCount = 4;
            this.GameRowContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.9375F));
            this.GameRowContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.0625F));
            this.GameRowContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 141F));
            this.GameRowContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 143F));
            this.GameRowContainer.Controls.Add(this.StartGameButton, 2, 0);
            this.GameRowContainer.Controls.Add(this.GameName, 1, 0);
            this.GameRowContainer.Controls.Add(this.GameStatus, 3, 0);
            this.GameRowContainer.Controls.Add(this.GameImage, 0, 0);
            this.GameRowContainer.Location = new System.Drawing.Point(4, 4);
            this.GameRowContainer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GameRowContainer.Name = "GameRowContainer";
            this.GameRowContainer.RowCount = 1;
            this.GameRowContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.GameRowContainer.Size = new System.Drawing.Size(684, 123);
            this.GameRowContainer.TabIndex = 0;
            // 
            // StartGameButton
            // 
            this.StartGameButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.StartGameButton.Location = new System.Drawing.Point(419, 47);
            this.StartGameButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.StartGameButton.Name = "StartGameButton";
            this.StartGameButton.Size = new System.Drawing.Size(100, 28);
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
            this.GameName.Location = new System.Drawing.Point(196, 47);
            this.GameName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GameName.Name = "GameName";
            this.GameName.Size = new System.Drawing.Size(149, 29);
            this.GameName.TabIndex = 1;
            this.GameName.Text = "Game Name";
            this.GameName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GameStatus
            // 
            this.GameStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GameStatus.AutoSize = true;
            this.GameStatus.Location = new System.Drawing.Point(612, 53);
            this.GameStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GameStatus.Name = "GameStatus";
            this.GameStatus.Size = new System.Drawing.Size(0, 16);
            this.GameStatus.TabIndex = 2;
            // 
            // GameImage
            // 
            this.GameImage.Image = global::Games_In_One_App.Properties.Resources.game_placeholder;
            this.GameImage.InitialImage = global::Games_In_One_App.Properties.Resources.game_placeholder;
            this.GameImage.Location = new System.Drawing.Point(4, 4);
            this.GameImage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GameImage.Name = "GameImage";
            this.GameImage.Size = new System.Drawing.Size(135, 115);
            this.GameImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.GameImage.TabIndex = 3;
            this.GameImage.TabStop = false;
            // 
            // GameRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GameRowContainer);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "GameRow";
            this.Size = new System.Drawing.Size(689, 129);
            this.GameRowContainer.ResumeLayout(false);
            this.GameRowContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GameImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel GameRowContainer;
        private System.Windows.Forms.Button StartGameButton;
        private System.Windows.Forms.Label GameName;
        private System.Windows.Forms.Label GameStatus;
        private System.Windows.Forms.PictureBox GameImage;
    }
}
