namespace Civilization
{
    partial class MainForm
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
            this.civInfoPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.startGameButton = new System.Windows.Forms.Button();
            this.allCivsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // civInfoPanel
            // 
            this.civInfoPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.civInfoPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.civInfoPanel.Location = new System.Drawing.Point(455, 3);
            this.civInfoPanel.Margin = new System.Windows.Forms.Padding(0);
            this.civInfoPanel.Name = "civInfoPanel";
            this.civInfoPanel.Size = new System.Drawing.Size(739, 651);
            this.civInfoPanel.TabIndex = 1;
            // 
            // startGameButton
            // 
            this.startGameButton.Location = new System.Drawing.Point(455, 654);
            this.startGameButton.Margin = new System.Windows.Forms.Padding(0);
            this.startGameButton.Name = "startGameButton";
            this.startGameButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.startGameButton.Size = new System.Drawing.Size(739, 108);
            this.startGameButton.TabIndex = 2;
            this.startGameButton.Text = "Начать игру";
            this.startGameButton.UseVisualStyleBackColor = true;
            this.startGameButton.Click += new System.EventHandler(this.startGameButton_Click);
            // 
            // allCivsPanel
            // 
            this.allCivsPanel.AutoScroll = true;
            this.allCivsPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.allCivsPanel.Location = new System.Drawing.Point(1, 3);
            this.allCivsPanel.Margin = new System.Windows.Forms.Padding(0);
            this.allCivsPanel.Name = "allCivsPanel";
            this.allCivsPanel.Size = new System.Drawing.Size(451, 759);
            this.allCivsPanel.TabIndex = 3;
            this.allCivsPanel.WrapContents = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 765);
            this.Controls.Add(this.allCivsPanel);
            this.Controls.Add(this.civInfoPanel);
            this.Controls.Add(this.startGameButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "Civilization";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FlowLayoutPanel civInfoPanel;
        private Button startGameButton;
        private FlowLayoutPanel allCivsPanel;
    }
}