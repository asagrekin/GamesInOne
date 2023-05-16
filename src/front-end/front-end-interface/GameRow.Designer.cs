namespace Games_In_One
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
            this.GameRowContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.73273F));
            this.GameRowContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.26727F));
            this.GameRowContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 109F));
            this.GameRowContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.GameRowContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.GameRowContainer.Controls.Add(this.DeleteButton, 4, 0);
            this.GameRowContainer.Controls.Add(this.StartGameButton, 2, 0);
            this.GameRowContainer.Controls.Add(this.GameImage, 0, 0);
            this.GameRowContainer.Controls.Add(this.GameName, 1, 0);
            this.GameRowContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.GameRowContainer.Location = new System.Drawing.Point(0, 0);
            this.GameRowContainer.Name = "GameRowContainer";
            this.GameRowContainer.RowCount = 1;
            this.GameRowContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.GameRowContainer.Size = new System.Drawing.Size(609, 100);
            this.GameRowContainer.TabIndex = 0;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DeleteButton.Location = new System.Drawing.Point(526, 38);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
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
            this.StartGameButton.Location = new System.Drawing.Point(350, 38);
            this.StartGameButton.Name = "StartGameButton";
            this.StartGameButton.Size = new System.Drawing.Size(75, 23);
            this.StartGameButton.TabIndex = 0;
            this.StartGameButton.Text = "Start Game";
            this.StartGameButton.UseVisualStyleBackColor = false;
            this.StartGameButton.Click += new System.EventHandler(this.StartGameButton_Click);
            // 
            // GameImage
            // 
            this.GameImage.Dock = System.Windows.Forms.DockStyle.Right;
            this.GameImage.Location = new System.Drawing.Point(10, 3);
            this.GameImage.Name = "GameImage";
            this.GameImage.Size = new System.Drawing.Size(96, 94);
            this.GameImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.GameImage.TabIndex = 3;
            this.GameImage.TabStop = false;
            // 
            // GameName
            // 
            this.GameName.AutoSize = true;
            this.GameName.Dock = System.Windows.Forms.DockStyle.Left;
            this.GameName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameName.ForeColor = System.Drawing.Color.Red;
            this.GameName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GameName.Location = new System.Drawing.Point(112, 0);
            this.GameName.Name = "GameName";
            this.GameName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.GameName.Size = new System.Drawing.Size(117, 100);
            this.GameName.TabIndex = 1;
            this.GameName.Text = "Game Name";
            this.GameName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // GameRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GameRowContainer);
            this.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.Name = "GameRow";
            this.Size = new System.Drawing.Size(609, 105);
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
