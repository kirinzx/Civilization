using System.ComponentModel;

namespace Civilization; 

partial class PickCivsForm {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

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
            this.orderToPickLabel = new System.Windows.Forms.Label();
            this.civilizationsGroupBox = new System.Windows.Forms.GroupBox();
            this.civilizationsPanel = new System.Windows.Forms.Panel();
            this.playersGroupBox = new System.Windows.Forms.GroupBox();
            this.playersPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.civilizationsGroupBox.SuspendLayout();
            this.playersGroupBox.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // orderToPickLabel
            // 
            this.orderToPickLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderToPickLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.orderToPickLabel.Location = new System.Drawing.Point(0, 0);
            this.orderToPickLabel.Name = "orderToPickLabel";
            this.orderToPickLabel.Size = new System.Drawing.Size(1045, 80);
            this.orderToPickLabel.TabIndex = 5;
            this.orderToPickLabel.Text = "Банит игрок: ";
            this.orderToPickLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // civilizationsGroupBox
            // 
            this.civilizationsGroupBox.Controls.Add(this.civilizationsPanel);
            this.civilizationsGroupBox.Location = new System.Drawing.Point(1, 2);
            this.civilizationsGroupBox.Name = "civilizationsGroupBox";
            this.civilizationsGroupBox.Padding = new System.Windows.Forms.Padding(10, 3, 10, 10);
            this.civilizationsGroupBox.Size = new System.Drawing.Size(1194, 350);
            this.civilizationsGroupBox.TabIndex = 9;
            this.civilizationsGroupBox.TabStop = false;
            this.civilizationsGroupBox.Text = "Цивилизации";
            // 
            // civilizationsPanel
            // 
            this.civilizationsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.civilizationsPanel.Location = new System.Drawing.Point(10, 23);
            this.civilizationsPanel.Name = "civilizationsPanel";
            this.civilizationsPanel.Size = new System.Drawing.Size(1174, 317);
            this.civilizationsPanel.TabIndex = 4;
            // 
            // playersGroupBox
            // 
            this.playersGroupBox.Controls.Add(this.playersPanel);
            this.playersGroupBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.playersGroupBox.Location = new System.Drawing.Point(0, 435);
            this.playersGroupBox.Name = "playersGroupBox";
            this.playersGroupBox.Padding = new System.Windows.Forms.Padding(10, 3, 10, 10);
            this.playersGroupBox.Size = new System.Drawing.Size(1195, 330);
            this.playersGroupBox.TabIndex = 10;
            this.playersGroupBox.TabStop = false;
            this.playersGroupBox.Text = "Игроки";
            // 
            // playersPanel
            // 
            this.playersPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playersPanel.Location = new System.Drawing.Point(10, 23);
            this.playersPanel.Name = "playersPanel";
            this.playersPanel.Size = new System.Drawing.Size(1175, 297);
            this.playersPanel.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.orderToPickLabel);
            this.panel1.Location = new System.Drawing.Point(80, 358);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1045, 80);
            this.panel1.TabIndex = 11;
            // 
            // PickCivsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 765);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.playersGroupBox);
            this.Controls.Add(this.civilizationsGroupBox);
            this.Name = "PickCivsForm";
            this.Text = "PickCivsForm";
            this.Load += new System.EventHandler(this.PickCivsForm_Load);
            this.civilizationsGroupBox.ResumeLayout(false);
            this.playersGroupBox.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

    }

    #endregion
    private Label orderToPickLabel;
    private GroupBox civilizationsGroupBox;
    private Panel civilizationsPanel;
    private GroupBox playersGroupBox;
    private Panel playersPanel;
    private Panel panel1;
}