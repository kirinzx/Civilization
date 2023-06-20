namespace Civilization {
    partial class AddPlayersForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.titleLabel = new System.Windows.Forms.Label();
            this.addPlayerBox = new System.Windows.Forms.GroupBox();
            this.startPickingButton = new System.Windows.Forms.Button();
            this.addPlayerInput = new System.Windows.Forms.TextBox();
            this.addPlayerButton = new System.Windows.Forms.Button();
            this.playersPanel = new System.Windows.Forms.Panel();
            this.playersGroupBox = new System.Windows.Forms.GroupBox();
            this.addPlayerBox.SuspendLayout();
            this.playersGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titleLabel.Location = new System.Drawing.Point(23, 23);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(481, 54);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Добавить игроков в игру";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addPlayerBox
            // 
            this.addPlayerBox.Controls.Add(this.startPickingButton);
            this.addPlayerBox.Controls.Add(this.addPlayerInput);
            this.addPlayerBox.Controls.Add(this.titleLabel);
            this.addPlayerBox.Controls.Add(this.addPlayerButton);
            this.addPlayerBox.Location = new System.Drawing.Point(345, 69);
            this.addPlayerBox.Name = "addPlayerBox";
            this.addPlayerBox.Size = new System.Drawing.Size(523, 316);
            this.addPlayerBox.TabIndex = 2;
            this.addPlayerBox.TabStop = false;
            this.addPlayerBox.Click += new System.EventHandler(this.addPlayerBox_Click);
            // 
            // startPickingButton
            // 
            this.startPickingButton.Enabled = false;
            this.startPickingButton.Location = new System.Drawing.Point(279, 214);
            this.startPickingButton.Name = "startPickingButton";
            this.startPickingButton.Size = new System.Drawing.Size(147, 48);
            this.startPickingButton.TabIndex = 2;
            this.startPickingButton.Text = "Перейти к пикам";
            this.startPickingButton.UseVisualStyleBackColor = true;
            this.startPickingButton.Click += new System.EventHandler(this.startPickingButton_Click);
            // 
            // addPlayerInput
            // 
            this.addPlayerInput.ForeColor = System.Drawing.Color.Gray;
            this.addPlayerInput.Location = new System.Drawing.Point(56, 123);
            this.addPlayerInput.Name = "addPlayerInput";
            this.addPlayerInput.Size = new System.Drawing.Size(370, 27);
            this.addPlayerInput.TabIndex = 1;
            this.addPlayerInput.Text = "Никнейм игрока";
            this.addPlayerInput.GotFocus += new System.EventHandler(this.addPlayerInput_GotFocus);
            this.addPlayerInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.addPlayerInput_KeyDown);
            this.addPlayerInput.LostFocus += new System.EventHandler(this.addPlayerInput_LostFocus);
            // 
            // addPlayerButton
            // 
            this.addPlayerButton.Location = new System.Drawing.Point(56, 214);
            this.addPlayerButton.Name = "addPlayerButton";
            this.addPlayerButton.Size = new System.Drawing.Size(147, 48);
            this.addPlayerButton.TabIndex = 0;
            this.addPlayerButton.Text = "Добавить игрока";
            this.addPlayerButton.UseVisualStyleBackColor = true;
            this.addPlayerButton.Click += new System.EventHandler(this.addPlayerButton_Click);
            // 
            // playersPanel
            // 
            this.playersPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playersPanel.Location = new System.Drawing.Point(10, 23);
            this.playersPanel.Name = "playersPanel";
            this.playersPanel.Size = new System.Drawing.Size(1175, 297);
            this.playersPanel.TabIndex = 3;
            // 
            // playersGroupBox
            // 
            this.playersGroupBox.Controls.Add(this.playersPanel);
            this.playersGroupBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.playersGroupBox.Location = new System.Drawing.Point(0, 435);
            this.playersGroupBox.Name = "playersGroupBox";
            this.playersGroupBox.Padding = new System.Windows.Forms.Padding(10, 3, 10, 10);
            this.playersGroupBox.Size = new System.Drawing.Size(1195, 330);
            this.playersGroupBox.TabIndex = 4;
            this.playersGroupBox.TabStop = false;
            this.playersGroupBox.Text = "Игроки";
            // 
            // AddPlayersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 765);
            this.Controls.Add(this.playersGroupBox);
            this.Controls.Add(this.addPlayerBox);
            this.Name = "AddPlayersForm";
            this.Text = "AddPlayersForm";
            this.Load += new System.EventHandler(this.AddPlayersForm_Load);
            this.Click += new System.EventHandler(this.AddPlayersForm_Click);
            this.addPlayerBox.ResumeLayout(false);
            this.addPlayerBox.PerformLayout();
            this.playersGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Label titleLabel;
        private GroupBox addPlayerBox;
        private TextBox addPlayerInput;
        private Button addPlayerButton;
        private Panel playersPanel;
        private Button startPickingButton;
        private GroupBox playersGroupBox;
    }
}