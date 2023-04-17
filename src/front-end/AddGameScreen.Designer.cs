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
            ClearAddGameButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddGameScreenLabel
            // 
            this.AddGameScreenLabel.AutoSize = true;
            this.AddGameScreenLabel.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddGameScreenLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AddGameScreenLabel.Location = new System.Drawing.Point(155, 84);
            this.AddGameScreenLabel.Name = "AddGameScreenLabel";
            this.AddGameScreenLabel.Size = new System.Drawing.Size(145, 33);
            this.AddGameScreenLabel.TabIndex = 0;
            this.AddGameScreenLabel.Text = "Add a game";
            this.AddGameScreenLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // GameNameTextBox
            // 
            this.GameNameTextBox.Location = new System.Drawing.Point(106, 188);
            this.GameNameTextBox.Name = "GameNameTextBox";
            this.GameNameTextBox.Size = new System.Drawing.Size(236, 22);
            this.GameNameTextBox.TabIndex = 1;
            this.GameNameTextBox.Text = "Game Name";
            // 
            // GamePathTextBox
            // 
            this.GamePathTextBox.Location = new System.Drawing.Point(106, 247);
            this.GamePathTextBox.Name = "GamePathTextBox";
            this.GamePathTextBox.Size = new System.Drawing.Size(236, 22);
            this.GamePathTextBox.TabIndex = 2;
            this.GamePathTextBox.Text = "Game Path";
            this.GamePathTextBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // ConfirmAddGameButton
            // 
            this.ConfirmAddGameButton.Location = new System.Drawing.Point(267, 317);
            this.ConfirmAddGameButton.Name = "ConfirmAddGameButton";
            this.ConfirmAddGameButton.Size = new System.Drawing.Size(75, 23);
            this.ConfirmAddGameButton.TabIndex = 3;
            this.ConfirmAddGameButton.Text = "Add Game";
            this.ConfirmAddGameButton.UseVisualStyleBackColor = true;
            // 
            // ClearAddGameButton
            // 
            ClearAddGameButton.Location = new System.Drawing.Point(106, 317);
            ClearAddGameButton.Name = "ClearAddGameButton";
            ClearAddGameButton.Size = new System.Drawing.Size(75, 23);
            ClearAddGameButton.TabIndex = 4;
            ClearAddGameButton.Text = "Clear";
            ClearAddGameButton.UseVisualStyleBackColor = true;
            // 
            // ExitAddGameButton
            // 
            this.ExitAddGameButton.Location = new System.Drawing.Point(361, 16);
            this.ExitAddGameButton.Name = "ExitAddGameButton";
            this.ExitAddGameButton.Size = new System.Drawing.Size(75, 23);
            this.ExitAddGameButton.TabIndex = 5;
            this.ExitAddGameButton.Text = "Exit";
            this.ExitAddGameButton.UseVisualStyleBackColor = true;
            this.ExitAddGameButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddGameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.ExitAddGameButton);
            this.Controls.Add(ClearAddGameButton);
            this.Controls.Add(this.ConfirmAddGameButton);
            this.Controls.Add(this.GamePathTextBox);
            this.Controls.Add(this.GameNameTextBox);
            this.Controls.Add(this.AddGameScreenLabel);
            this.Name = "AddGameScreen";
            this.Size = new System.Drawing.Size(455, 421);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AddGameScreenLabel;
        private System.Windows.Forms.TextBox GameNameTextBox;
        private System.Windows.Forms.MaskedTextBox GamePathTextBox;
        private System.Windows.Forms.Button ConfirmAddGameButton;
        private System.Windows.Forms.Button ExitAddGameButton;
    }
}
