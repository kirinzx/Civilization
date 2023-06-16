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
            this.addPlayerInput = new System.Windows.Forms.TextBox();
            this.addPlayerButton = new System.Windows.Forms.Button();
            this.playersPanel = new System.Windows.Forms.TableLayoutPanel();
            this.addPlayerBox.SuspendLayout();
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
            this.playersPanel.ColumnCount = 6;
            this.playersPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.playersPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.playersPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.playersPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.playersPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.playersPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.playersPanel.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.playersPanel.Location = new System.Drawing.Point(0, 473);
            this.playersPanel.Name = "playersPanel";
            this.playersPanel.RowCount = 2;
            this.playersPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.playersPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.playersPanel.Size = new System.Drawing.Size(1197, 294);
            this.playersPanel.TabIndex = 3;
            this.playersPanel.Visible = true;
            this.playersPanel.Margin = new System.Windows.Forms.Padding(10,0,10,0);
            // 
            // AddPlayersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 765);
            this.Controls.Add(this.playersPanel);
            this.Controls.Add(this.addPlayerBox);
            this.Name = "AddPlayersForm";
            this.Text = "AddPlayersForm";
            this.Click += new System.EventHandler(this.AddPlayersForm_Click);
            this.Load += new System.EventHandler(this.AddPlayersForm_Load);
            this.addPlayerBox.ResumeLayout(false);
            this.addPlayerBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Label titleLabel;
        private GroupBox addPlayerBox;
        private TextBox addPlayerInput;
        private Button addPlayerButton;
        private TableLayoutPanel playersPanel;
    }
}