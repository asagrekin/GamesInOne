using System.Drawing;

namespace Games_In_One_App
{
    partial class AddGameScreen
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
            System.Windows.Forms.Button ClearAddGameButton;
            this.AddGameScreenLabel = new System.Windows.Forms.Label();
            this.GameNameTextBox = new System.Windows.Forms.TextBox();
            this.GamePathTextBox = new System.Windows.Forms.MaskedTextBox();
            this.ConfirmAddGameButton = new System.Windows.Forms.Button();
            this.ExitAddGameButton = new System.Windows.Forms.Button();
            this.AddGameNameLabel = new System.Windows.Forms.Label();
            this.AddGamePathLabel = new System.Windows.Forms.Label();
            ClearAddGameButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ClearAddGameButton
            // 
            ClearAddGameButton.Location = new System.Drawing.Point(80, 258);
            ClearAddGameButton.Margin = new System.Windows.Forms.Padding(2);
            ClearAddGameButton.Name = "ClearAddGameButton";
            ClearAddGameButton.Size = new System.Drawing.Size(56, 19);
            ClearAddGameButton.TabIndex = 4;
            ClearAddGameButton.Text = "Clear";
            ClearAddGameButton.UseVisualStyleBackColor = true;
            // 
            // AddGameScreenLabel
            // 
            this.AddGameScreenLabel.AutoSize = true;
            this.AddGameScreenLabel.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddGameScreenLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AddGameScreenLabel.Location = new System.Drawing.Point(116, 68);
            this.AddGameScreenLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AddGameScreenLabel.Name = "AddGameScreenLabel";
            this.AddGameScreenLabel.Size = new System.Drawing.Size(114, 26);
            this.AddGameScreenLabel.TabIndex = 0;
            this.AddGameScreenLabel.Text = "Add a game";
            // 
            // GameNameTextBox
            // 
            this.GameNameTextBox.ForeColor = System.Drawing.Color.Gray;
            this.GameNameTextBox.Location = new System.Drawing.Point(47, 158);
            this.GameNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.GameNameTextBox.Name = "GameNameTextBox";
            this.GameNameTextBox.Size = new System.Drawing.Size(242, 20);
            this.GameNameTextBox.TabIndex = 1;
            this.GameNameTextBox.Text = "Name";
            this.GameNameTextBox.Enter += new System.EventHandler(this.GameNameTextBox_Enter);
            this.GameNameTextBox.Leave += new System.EventHandler(this.GameNameTextBox_Exit);
            // 
            // GamePathTextBox
            // 
            this.GamePathTextBox.ForeColor = System.Drawing.Color.Gray;
            this.GamePathTextBox.Location = new System.Drawing.Point(47, 211);
            this.GamePathTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.GamePathTextBox.Name = "GamePathTextBox";
            this.GamePathTextBox.Size = new System.Drawing.Size(242, 20);
            this.GamePathTextBox.TabIndex = 2;
            this.GamePathTextBox.Text = "Path";
            this.GamePathTextBox.Enter += new System.EventHandler(this.GamePathTextBox_Enter);
            this.GamePathTextBox.Leave += new System.EventHandler(this.GamePathTextBox_Exit);
            // 
            // ConfirmAddGameButton
            // 
            this.ConfirmAddGameButton.Location = new System.Drawing.Point(200, 258);
            this.ConfirmAddGameButton.Margin = new System.Windows.Forms.Padding(2);
            this.ConfirmAddGameButton.Name = "ConfirmAddGameButton";
            this.ConfirmAddGameButton.Size = new System.Drawing.Size(56, 19);
            this.ConfirmAddGameButton.TabIndex = 3;
            this.ConfirmAddGameButton.Text = "Add Game";
            this.ConfirmAddGameButton.UseVisualStyleBackColor = true;
            this.ConfirmAddGameButton.Click += new System.EventHandler(this.ConfirmAddGameButton_Click);
            // 
            // ExitAddGameButton
            // 
            this.ExitAddGameButton.Location = new System.Drawing.Point(271, 13);
            this.ExitAddGameButton.Margin = new System.Windows.Forms.Padding(2);
            this.ExitAddGameButton.Name = "ExitAddGameButton";
            this.ExitAddGameButton.Size = new System.Drawing.Size(56, 19);
            this.ExitAddGameButton.TabIndex = 5;
            this.ExitAddGameButton.Text = "Exit";
            this.ExitAddGameButton.UseVisualStyleBackColor = true;
            this.ExitAddGameButton.Click += new System.EventHandler(this.ExitAddGameButton_Click);
            // 
            // AddGameNameLabel
            // 
            this.AddGameNameLabel.AutoSize = true;
            this.AddGameNameLabel.Location = new System.Drawing.Point(47, 140);
            this.AddGameNameLabel.Name = "AddGameNameLabel";
            this.AddGameNameLabel.Size = new System.Drawing.Size(66, 13);
            this.AddGameNameLabel.TabIndex = 6;
            this.AddGameNameLabel.Text = "Game Name";
            // 
            // AddGamePathLabel
            // 
            this.AddGamePathLabel.AutoSize = true;
            this.AddGamePathLabel.Location = new System.Drawing.Point(47, 196);
            this.AddGamePathLabel.Name = "AddGamePathLabel";
            this.AddGamePathLabel.Size = new System.Drawing.Size(60, 13);
            this.AddGamePathLabel.TabIndex = 7;
            this.AddGamePathLabel.Text = "Game Path";
            // 
            // AddGameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.AddGamePathLabel);
            this.Controls.Add(this.AddGameNameLabel);
            this.Controls.Add(this.ExitAddGameButton);
            this.Controls.Add(ClearAddGameButton);
            this.Controls.Add(this.ConfirmAddGameButton);
            this.Controls.Add(this.GamePathTextBox);
            this.Controls.Add(this.GameNameTextBox);
            this.Controls.Add(this.AddGameScreenLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddGameScreen";
            this.Size = new System.Drawing.Size(341, 342);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AddGameScreenLabel;
        private System.Windows.Forms.TextBox GameNameTextBox;
        private System.Windows.Forms.MaskedTextBox GamePathTextBox;
        private System.Windows.Forms.Button ConfirmAddGameButton;
        private System.Windows.Forms.Button ExitAddGameButton;
        private System.Windows.Forms.Label AddGameNameLabel;
        private System.Windows.Forms.Label AddGamePathLabel;
    }
}
