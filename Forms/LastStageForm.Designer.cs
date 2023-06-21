using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Civilization; 

partial class LastStageForm {
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
            this.playersCivsGroupBox = new System.Windows.Forms.GroupBox();
            this.playersCivsPanel = new System.Windows.Forms.Panel();
            this.gameSettingsBox = new System.Windows.Forms.GroupBox();
            this.settingsTable = new System.Windows.Forms.TableLayoutPanel();
            this.defaultSettingsLabel = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.toStartButton = new System.Windows.Forms.Button();
            this.labelPanel = new System.Windows.Forms.Panel();
            this.playersCivsGroupBox.SuspendLayout();
            this.gameSettingsBox.SuspendLayout();
            this.settingsTable.SuspendLayout();
            this.labelPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // playersCivsGroupBox
            // 
            this.playersCivsGroupBox.Controls.Add(this.playersCivsPanel);
            this.playersCivsGroupBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.playersCivsGroupBox.Location = new System.Drawing.Point(0, 388);
            this.playersCivsGroupBox.Name = "playersCivsGroupBox";
            this.playersCivsGroupBox.Padding = new System.Windows.Forms.Padding(10, 3, 10, 10);
            this.playersCivsGroupBox.Size = new System.Drawing.Size(1195, 377);
            this.playersCivsGroupBox.TabIndex = 2;
            this.playersCivsGroupBox.TabStop = false;
            this.playersCivsGroupBox.Text = "Игроки и их цивилизации";
            // 
            // playersCivsPanel
            // 
            this.playersCivsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playersCivsPanel.Location = new System.Drawing.Point(10, 23);
            this.playersCivsPanel.Name = "playersCivsPanel";
            this.playersCivsPanel.Size = new System.Drawing.Size(1175, 344);
            this.playersCivsPanel.TabIndex = 0;
            // 
            // gameSettingsBox
            // 
            this.gameSettingsBox.Controls.Add(this.settingsTable);
            this.gameSettingsBox.Location = new System.Drawing.Point(10, 12);
            this.gameSettingsBox.Name = "gameSettingsBox";
            this.gameSettingsBox.Padding = new System.Windows.Forms.Padding(10, 3, 10, 10);
            this.gameSettingsBox.Size = new System.Drawing.Size(594, 370);
            this.gameSettingsBox.TabIndex = 4;
            this.gameSettingsBox.TabStop = false;
            // 
            // settingsTable
            // 
            this.settingsTable.ColumnCount = 1;
            this.settingsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.settingsTable.Controls.Add(this.defaultSettingsLabel, 0, 0);
            this.settingsTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingsTable.Location = new System.Drawing.Point(10, 23);
            this.settingsTable.Name = "settingsTable";
            this.settingsTable.RowCount = 4;
            this.settingsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.settingsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.settingsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.settingsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.settingsTable.Size = new System.Drawing.Size(574, 337);
            this.settingsTable.TabIndex = 0;
            // 
            // defaultSettingsLabel
            // 
            this.defaultSettingsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.defaultSettingsLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.defaultSettingsLabel.Location = new System.Drawing.Point(3, 0);
            this.defaultSettingsLabel.Name = "defaultSettingsLabel";
            this.defaultSettingsLabel.Size = new System.Drawing.Size(568, 84);
            this.defaultSettingsLabel.TabIndex = 0;
            this.defaultSettingsLabel.Text = "Стандартные настройки: Нельзя копить учёных, писателей, художников";
            // 
            // label
            // 
            this.label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label.Location = new System.Drawing.Point(0, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(476, 49);
            this.label.TabIndex = 5;
            this.label.Text = "Ваша игра готова! Удачи и веселой игры!";
            // 
            // toStartButton
            // 
            this.toStartButton.Location = new System.Drawing.Point(965, 320);
            this.toStartButton.Name = "toStartButton";
            this.toStartButton.Size = new System.Drawing.Size(170, 52);
            this.toStartButton.TabIndex = 6;
            this.toStartButton.Text = "На главную";
            this.toStartButton.UseVisualStyleBackColor = true;
            this.toStartButton.Click += new EventHandler(goToStart);
            // 
            // labelPanel
            // 
            this.labelPanel.Controls.Add(this.label);
            this.labelPanel.Location = new System.Drawing.Point(659, 35);
            this.labelPanel.Name = "labelPanel";
            this.labelPanel.Size = new System.Drawing.Size(476, 49);
            this.labelPanel.TabIndex = 7;
            // 
            // LastStageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 765);
            this.Controls.Add(this.labelPanel);
            this.Controls.Add(this.toStartButton);
            this.Controls.Add(this.gameSettingsBox);
            this.Controls.Add(this.playersCivsGroupBox);
            this.Load += new EventHandler(LastStageForm_Load);
            this.Name = "LastStageForm";
            this.Text = "LastStageForm";
            this.playersCivsGroupBox.ResumeLayout(false);
            this.gameSettingsBox.ResumeLayout(false);
            this.settingsTable.ResumeLayout(false);
            this.labelPanel.ResumeLayout(false);
            this.ResumeLayout(false);

    }

    #endregion

    private GroupBox playersCivsGroupBox;
    private Panel playersCivsPanel;
    private GroupBox gameSettingsBox;
    private TableLayoutPanel settingsTable;
    private Label defaultSettingsLabel;
    private Label label;
    private Button toStartButton;
    private Panel labelPanel;
}