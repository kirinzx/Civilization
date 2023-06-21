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
            this.startGameButton = new System.Windows.Forms.Button();
            this.allCivsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.civInfoPanel = new System.Windows.Forms.Panel();
            this.civNamePanel = new System.Windows.Forms.Panel();
            this.civNameLabel = new System.Windows.Forms.Label();
            this.civInfoTable = new System.Windows.Forms.TableLayoutPanel();
            this.civInfoPanel.SuspendLayout();
            this.civNamePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // civInfoTable
            // 
            civInfoTable.Anchor = System.Windows.Forms.AnchorStyles.None;
            civInfoTable.ColumnCount = 1;
            civInfoTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            civInfoTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            civInfoTable.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            civInfoTable.Location = new System.Drawing.Point(3, 45);
            civInfoTable.Name = "civInfoTable";
            civInfoTable.RowCount = 3;
            civInfoTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            civInfoTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            civInfoTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            civInfoTable.Size = new System.Drawing.Size(736, 603);
            civInfoTable.TabIndex = 3;
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
            // civInfoPanel
            // 
            this.civInfoPanel.Controls.Add(this.civNamePanel);
            this.civInfoPanel.Controls.Add(civInfoTable);
            this.civInfoPanel.Location = new System.Drawing.Point(455, 3);
            this.civInfoPanel.Name = "civInfoPanel";
            this.civInfoPanel.Size = new System.Drawing.Size(739, 648);
            this.civInfoPanel.TabIndex = 4;
            // 
            // civNamePanel
            // 
            this.civNamePanel.Controls.Add(this.civNameLabel);
            this.civNamePanel.Location = new System.Drawing.Point(3, 0);
            this.civNamePanel.Margin = new System.Windows.Forms.Padding(0);
            this.civNamePanel.Name = "civNamePanel";
            this.civNamePanel.Size = new System.Drawing.Size(736, 42);
            this.civNamePanel.TabIndex = 2;
            // 
            // civNameLabel
            // 
            this.civNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.civNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.civNameLabel.Location = new System.Drawing.Point(0, 0);
            this.civNameLabel.Margin = new System.Windows.Forms.Padding(0);
            this.civNameLabel.Name = "civNameLabel";
            this.civNameLabel.Size = new System.Drawing.Size(736, 42);
            this.civNameLabel.TabIndex = 0;
            this.civNameLabel.Text = "Нажмите на цивилазцию и посмотрите её преимущества";
            this.civNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 765);
            this.Controls.Add(this.civInfoPanel);
            this.Controls.Add(this.allCivsPanel);
            this.Controls.Add(this.startGameButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "Civilization";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.civInfoPanel.ResumeLayout(false);
            this.civNamePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel civInfoTable;
        private Button startGameButton;
        private FlowLayoutPanel allCivsPanel;
        private Panel civInfoPanel;
        private Panel civNamePanel;
        private Label civNameLabel;
    }
}