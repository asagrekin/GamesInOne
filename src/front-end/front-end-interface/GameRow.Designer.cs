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
            this.DeleteButton = new System.Windows.Forms.Button();
            this.StartGameButton = new System.Windows.Forms.Button();
            this.GameImage = new System.Windows.Forms.PictureBox();
            this.GameName = new System.Windows.Forms.Label();
            this.GameRowContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GameImage)).BeginInit();
            this.SuspendLayout();
            // 
            // GameRowContainer
            // 
            this.GameRowContainer.ColumnCount = 5;
            this.GameRowContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.9375F));
            this.GameRowContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.0625F));
            this.GameRowContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 145F));
            this.GameRowContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 101F));
            this.GameRowContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 119F));
            this.GameRowContainer.Controls.Add(this.DeleteButton, 4, 0);
            this.GameRowContainer.Controls.Add(this.StartGameButton, 2, 0);
            this.GameRowContainer.Controls.Add(this.GameImage, 0, 0);
            this.GameRowContainer.Controls.Add(this.GameName, 1, 0);
            this.GameRowContainer.Location = new System.Drawing.Point(4, 4);
            this.GameRowContainer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GameRowContainer.Name = "GameRowContainer";
            this.GameRowContainer.RowCount = 1;
            this.GameRowContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.GameRowContainer.Size = new System.Drawing.Size(808, 123);
            this.GameRowContainer.TabIndex = 0;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DeleteButton.Location = new System.Drawing.Point(698, 47);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(100, 28);
            this.DeleteButton.TabIndex = 4;
            this.DeleteButton.Text = "Delete Button";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // StartGameButton
            // 
            this.StartGameButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.StartGameButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(177)))), ((int)(((byte)(76)))));
            this.StartGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartGameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartGameButton.ForeColor = System.Drawing.Color.White;
            this.StartGameButton.Location = new System.Drawing.Point(464, 47);
            this.StartGameButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.StartGameButton.Name = "StartGameButton";
            this.StartGameButton.Size = new System.Drawing.Size(100, 28);
            this.StartGameButton.TabIndex = 0;
            this.StartGameButton.Text = "Start Game";
            this.StartGameButton.UseVisualStyleBackColor = false;
            this.StartGameButton.Click += new System.EventHandler(this.StartGameButton_Click);
            // 
            // GameImage
            // 
            this.GameImage.Image = global::Games_In_One_App.Properties.Resources.game_placeholder;
            this.GameImage.InitialImage = global::Games_In_One_App.Properties.Resources.game_placeholder;
            this.GameImage.Location = new System.Drawing.Point(4, 4);
            this.GameImage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GameImage.Name = "GameImage";
            this.GameImage.Size = new System.Drawing.Size(128, 114);
            this.GameImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.GameImage.TabIndex = 3;
            this.GameImage.TabStop = false;
            // 
            // GameName
            // 
            this.GameName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GameName.AutoSize = true;
            this.GameName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameName.ForeColor = System.Drawing.Color.Red;
            this.GameName.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.GameName.Location = new System.Drawing.Point(226, 47);
            this.GameName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GameName.Name = "GameName";
            this.GameName.Size = new System.Drawing.Size(149, 29);
            this.GameName.TabIndex = 1;
            this.GameName.Text = "Game Name";
            this.GameName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // GameRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GameRowContainer);
            this.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Name = "GameRow";
            this.Size = new System.Drawing.Size(812, 129);
            this.GameRowContainer.ResumeLayout(false);
            this.GameRowContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GameImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel GameRowContainer;
        private System.Windows.Forms.Button StartGameButton;
        private System.Windows.Forms.Label GameName;
        private System.Windows.Forms.PictureBox GameImage;
        private System.Windows.Forms.Button DeleteButton;
    }
}
