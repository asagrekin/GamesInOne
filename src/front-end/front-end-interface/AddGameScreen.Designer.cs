using System.Windows.Forms;

namespace Games_In_One
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
            this.AddGameScreenLabel = new System.Windows.Forms.Label();
            this.GameNameTextBox = new System.Windows.Forms.TextBox();
            this.GamePathTextBox = new System.Windows.Forms.MaskedTextBox();
            this.ConfirmAddGameButton = new System.Windows.Forms.Button();
            this.ExitAddGameButton = new System.Windows.Forms.Button();
            this.AddGameNameLabel = new System.Windows.Forms.Label();
            this.AddGamePathLabel = new System.Windows.Forms.Label();
            this.AddGameImagePathLabel = new System.Windows.Forms.Label();
            this.GameImagePathTextBox = new System.Windows.Forms.MaskedTextBox();
            this.GamePathFileExplorer = new System.Windows.Forms.OpenFileDialog();
            this.GamePathFileExplorerButton = new System.Windows.Forms.Button();
            this.GameImagePathFileExplorer = new System.Windows.Forms.OpenFileDialog();
            this.GameImagePathExplorerButton = new System.Windows.Forms.Button();
            this.ClearAddGameButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ClearAddGameButton
            // 
            this.ClearAddGameButton.Location = new System.Drawing.Point(80, 258);
            this.ClearAddGameButton.Margin = new System.Windows.Forms.Padding(2);
            this.ClearAddGameButton.Name = "ClearAddGameButton";
            this.ClearAddGameButton.Size = new System.Drawing.Size(56, 19);
            this.ClearAddGameButton.TabIndex = 4;
            this.ClearAddGameButton.Text = "Clear";
            this.ClearAddGameButton.UseVisualStyleBackColor = true;
            this.ClearAddGameButton.Click += new System.EventHandler(this.ClearAddGameButton_Click);
            // 
            // AddGameScreenLabel
            // 
            this.AddGameScreenLabel.AutoSize = true;
            this.AddGameScreenLabel.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddGameScreenLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AddGameScreenLabel.Location = new System.Drawing.Point(43, 21);
            this.AddGameScreenLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AddGameScreenLabel.Name = "AddGameScreenLabel";
            this.AddGameScreenLabel.Size = new System.Drawing.Size(114, 26);
            this.AddGameScreenLabel.TabIndex = 0;
            this.AddGameScreenLabel.Text = "Add a game";
            // 
            // GameNameTextBox
            // 
            this.GameNameTextBox.ForeColor = System.Drawing.Color.Gray;
            this.GameNameTextBox.Location = new System.Drawing.Point(47, 97);
            this.GameNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.GameNameTextBox.Name = "GameNameTextBox";
            this.GameNameTextBox.Size = new System.Drawing.Size(242, 20);
            this.GameNameTextBox.TabIndex = 1;
            this.GameNameTextBox.Text = "Name";
            this.GameNameTextBox.TextChanged += new System.EventHandler(this.GameNameTextBox_TextChanged);
            this.GameNameTextBox.Enter += new System.EventHandler(this.GameNameTextBox_Enter);
            this.GameNameTextBox.Leave += new System.EventHandler(this.GameNameTextBox_Exit);
            // 
            // GamePathTextBox
            // 
            this.GamePathTextBox.ForeColor = System.Drawing.Color.Gray;
            this.GamePathTextBox.Location = new System.Drawing.Point(47, 150);
            this.GamePathTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.GamePathTextBox.Name = "GamePathTextBox";
            this.GamePathTextBox.Size = new System.Drawing.Size(209, 20);
            this.GamePathTextBox.TabIndex = 2;
            this.GamePathTextBox.Text = "Game Path";
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
            this.AddGameNameLabel.Location = new System.Drawing.Point(47, 79);
            this.AddGameNameLabel.Name = "AddGameNameLabel";
            this.AddGameNameLabel.Size = new System.Drawing.Size(163, 13);
            this.AddGameNameLabel.TabIndex = 6;
            this.AddGameNameLabel.Text = "Game Name (Max 16 characters)";
            // 
            // AddGamePathLabel
            // 
            this.AddGamePathLabel.AutoSize = true;
            this.AddGamePathLabel.Location = new System.Drawing.Point(47, 135);
            this.AddGamePathLabel.Name = "AddGamePathLabel";
            this.AddGamePathLabel.Size = new System.Drawing.Size(60, 13);
            this.AddGamePathLabel.TabIndex = 7;
            this.AddGamePathLabel.Text = "Game Path";
            // 
            // AddGameImagePathLabel
            // 
            this.AddGameImagePathLabel.AutoSize = true;
            this.AddGameImagePathLabel.Location = new System.Drawing.Point(47, 189);
            this.AddGameImagePathLabel.Name = "AddGameImagePathLabel";
            this.AddGameImagePathLabel.Size = new System.Drawing.Size(109, 13);
            this.AddGameImagePathLabel.TabIndex = 9;
            this.AddGameImagePathLabel.Text = "Image Path (Optional)";
            // 
            // GameImagePathTextBox
            // 
            this.GameImagePathTextBox.ForeColor = System.Drawing.Color.Gray;
            this.GameImagePathTextBox.Location = new System.Drawing.Point(47, 205);
            this.GameImagePathTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.GameImagePathTextBox.Name = "GameImagePathTextBox";
            this.GameImagePathTextBox.Size = new System.Drawing.Size(209, 20);
            this.GameImagePathTextBox.TabIndex = 8;
            this.GameImagePathTextBox.Text = "Image Path";
            this.GameImagePathTextBox.Enter += new System.EventHandler(this.GameImagePathTextBox_Enter);
            this.GameImagePathTextBox.Leave += new System.EventHandler(this.GameImagePathTextBox_Exit);
            // 
            // GamePathFileExplorer
            // 
            this.GamePathFileExplorer.DefaultExt = "exe";
            this.GamePathFileExplorer.FileName = "Game Path";
            this.GamePathFileExplorer.Filter = "Executable files (*.exe)|*.exe|All files (*.*)|*.*";
            this.GamePathFileExplorer.FileOk += new System.ComponentModel.CancelEventHandler(this.GamePathFileExplorer_FileOk);
            // 
            // GamePathFileExplorerButton
            // 
            this.GamePathFileExplorerButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.GamePathFileExplorerButton.BackgroundImage = global::Games_In_One.Properties.Resources.file_explorer_icon;
            this.GamePathFileExplorerButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GamePathFileExplorerButton.Location = new System.Drawing.Point(266, 144);
            this.GamePathFileExplorerButton.Name = "GamePathFileExplorerButton";
            this.GamePathFileExplorerButton.Size = new System.Drawing.Size(28, 32);
            this.GamePathFileExplorerButton.TabIndex = 10;
            this.GamePathFileExplorerButton.UseVisualStyleBackColor = true;
            this.GamePathFileExplorerButton.Click += new System.EventHandler(this.GamePathFileExplorerButton_Click);
            // 
            // GameImagePathFileExplorer
            // 
            this.GameImagePathFileExplorer.FileName = "Game Image Path";
            this.GameImagePathFileExplorer.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
            this.GameImagePathFileExplorer.FileOk += new System.ComponentModel.CancelEventHandler(this.GameImagePathFileExplorer_FileOk);
            // 
            // GameImagePathExplorerButton
            // 
            this.GameImagePathExplorerButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.GameImagePathExplorerButton.BackgroundImage = global::Games_In_One.Properties.Resources.file_explorer_icon;
            this.GameImagePathExplorerButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GameImagePathExplorerButton.Location = new System.Drawing.Point(266, 198);
            this.GameImagePathExplorerButton.Name = "GameImagePathExplorerButton";
            this.GameImagePathExplorerButton.Size = new System.Drawing.Size(28, 32);
            this.GameImagePathExplorerButton.TabIndex = 11;
            this.GameImagePathExplorerButton.UseVisualStyleBackColor = true;
            this.GameImagePathExplorerButton.Click += new System.EventHandler(this.GameImagePathExplorerButton_Click);
            // 
            // AddGameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.GameImagePathExplorerButton);
            this.Controls.Add(this.GamePathFileExplorerButton);
            this.Controls.Add(this.AddGameImagePathLabel);
            this.Controls.Add(this.GameImagePathTextBox);
            this.Controls.Add(this.AddGamePathLabel);
            this.Controls.Add(this.AddGameNameLabel);
            this.Controls.Add(this.ExitAddGameButton);
            this.Controls.Add(this.ClearAddGameButton);
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
        private System.Windows.Forms.Button ClearAddGameButton;
        private System.Windows.Forms.Label AddGameNameLabel;
        private System.Windows.Forms.Label AddGamePathLabel;
        private System.Windows.Forms.Label AddGameImagePathLabel;
        private System.Windows.Forms.MaskedTextBox GameImagePathTextBox;
        private System.Windows.Forms.OpenFileDialog GamePathFileExplorer;
        private System.Windows.Forms.Button GamePathFileExplorerButton;
        private OpenFileDialog GameImagePathFileExplorer;
        private Button GameImagePathExplorerButton;
    }
}
