using System.ComponentModel;

namespace Civilization; 

partial class AddSettingsForm {
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
            this.settingsPanel = new System.Windows.Forms.Panel();
            this.nextStageButton = new System.Windows.Forms.Button();
            this.labelPanel = new System.Windows.Forms.Panel();
            this.rulesLabel = new System.Windows.Forms.Label();
            this.victoriesGroupBox = new System.Windows.Forms.GroupBox();
            this.addVictoryButton = new System.Windows.Forms.Button();
            this.victoryTextBox = new System.Windows.Forms.TextBox();
            this.victoriesCheckBoxList = new System.Windows.Forms.CheckedListBox();
            this.settingsGroupBox = new System.Windows.Forms.GroupBox();
            this.addSettingButton = new System.Windows.Forms.Button();
            this.settingTextBox = new System.Windows.Forms.TextBox();
            this.settingsCheckBoxList = new System.Windows.Forms.CheckedListBox();
            this.playersCivsGroupBox.SuspendLayout();
            this.settingsPanel.SuspendLayout();
            this.labelPanel.SuspendLayout();
            this.victoriesGroupBox.SuspendLayout();
            this.settingsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // playersCivsGroupBox
            // 
            this.playersCivsGroupBox.Controls.Add(this.playersCivsPanel);
            this.playersCivsGroupBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.playersCivsGroupBox.Location = new System.Drawing.Point(0, 388);
            this.playersCivsGroupBox.Name = "playersCivsGroupBox";
            this.playersCivsGroupBox.Size = new System.Drawing.Size(1195, 377);
            this.playersCivsGroupBox.TabIndex = 0;
            this.playersCivsGroupBox.TabStop = false;
            this.playersCivsGroupBox.Text = "Игроки и их цивилизации";
            // 
            // playersCivsPanel
            // 
            this.playersCivsPanel.Location = new System.Drawing.Point(12, 26);
            this.playersCivsPanel.Name = "playersCivsPanel";
            this.playersCivsPanel.Size = new System.Drawing.Size(1171, 329);
            this.playersCivsPanel.TabIndex = 0;
            // 
            // settingsPanel
            // 
            this.settingsPanel.Controls.Add(this.nextStageButton);
            this.settingsPanel.Controls.Add(this.labelPanel);
            this.settingsPanel.Controls.Add(this.victoriesGroupBox);
            this.settingsPanel.Controls.Add(this.settingsGroupBox);
            this.settingsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.settingsPanel.Location = new System.Drawing.Point(0, 0);
            this.settingsPanel.Name = "settingsPanel";
            this.settingsPanel.Size = new System.Drawing.Size(1195, 390);
            this.settingsPanel.TabIndex = 1;
            // 
            // nextStageButton
            // 
            this.nextStageButton.Location = new System.Drawing.Point(791, 191);
            this.nextStageButton.Name = "nextStageButton";
            this.nextStageButton.Size = new System.Drawing.Size(226, 72);
            this.nextStageButton.TabIndex = 4;
            this.nextStageButton.Text = "Далее";
            this.nextStageButton.UseVisualStyleBackColor = true;
            this.nextStageButton.Click += new System.EventHandler(this.nextStageButton_Click);
            // 
            // labelPanel
            // 
            this.labelPanel.Controls.Add(this.rulesLabel);
            this.labelPanel.Location = new System.Drawing.Point(668, 38);
            this.labelPanel.Name = "labelPanel";
            this.labelPanel.Size = new System.Drawing.Size(492, 111);
            this.labelPanel.TabIndex = 3;
            // 
            // rulesLabel
            // 
            this.rulesLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rulesLabel.Location = new System.Drawing.Point(0, 0);
            this.rulesLabel.Name = "rulesLabel";
            this.rulesLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rulesLabel.Size = new System.Drawing.Size(492, 111);
            this.rulesLabel.TabIndex = 2;
            this.rulesLabel.Text = "Настройки: Выберите настройки, добавьте свои. Из них выбирается одна.\r\nВарианты п" +
    "обеды: Выберите варианты победы, добавьте свои. Из них выбирается одна, которую " +
    "нужно исключить.";
            this.rulesLabel.UseCompatibleTextRendering = true;
            // 
            // victoriesGroupBox
            // 
            this.victoriesGroupBox.Controls.Add(this.addVictoryButton);
            this.victoriesGroupBox.Controls.Add(this.victoryTextBox);
            this.victoriesGroupBox.Controls.Add(this.victoriesCheckBoxList);
            this.victoriesGroupBox.Location = new System.Drawing.Point(345, 12);
            this.victoriesGroupBox.Name = "victoriesGroupBox";
            this.victoriesGroupBox.Size = new System.Drawing.Size(276, 370);
            this.victoriesGroupBox.TabIndex = 1;
            this.victoriesGroupBox.TabStop = false;
            this.victoriesGroupBox.Text = "Варианты победы";
            // 
            // addVictoryButton
            // 
            this.addVictoryButton.Location = new System.Drawing.Point(156, 309);
            this.addVictoryButton.Margin = new System.Windows.Forms.Padding(0, 0, 3, 3);
            this.addVictoryButton.Name = "addVictoryButton";
            this.addVictoryButton.Size = new System.Drawing.Size(94, 29);
            this.addVictoryButton.TabIndex = 2;
            this.addVictoryButton.Text = "Добавить";
            this.addVictoryButton.UseVisualStyleBackColor = true;
            this.addVictoryButton.Click += new System.EventHandler(this.addVictoryButton_Click);
            // 
            // victoryTextBox
            // 
            this.victoryTextBox.ForeColor = System.Drawing.Color.Gray;
            this.victoryTextBox.Location = new System.Drawing.Point(18, 311);
            this.victoryTextBox.Margin = new System.Windows.Forms.Padding(3, 0, 0, 3);
            this.victoryTextBox.Name = "victoryTextBox";
            this.victoryTextBox.Size = new System.Drawing.Size(138, 27);
            this.victoryTextBox.TabIndex = 1;
            this.victoryTextBox.Text = "Какая-то победа...";
            this.victoryTextBox.GotFocus += new System.EventHandler(this.victoryTextBox_GotFocus);
            this.victoryTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.victoryTextBox_KeyDown);
            this.victoryTextBox.LostFocus += new System.EventHandler(this.victoryTextBox_LostFocus);
            // 
            // victoriesCheckBoxList
            // 
            this.victoriesCheckBoxList.FormattingEnabled = true;
            this.victoriesCheckBoxList.Items.AddRange(new object[] {
            "Территориальная",
            "Научная",
            "Культурная",
            "Религиозная",
            "Дипломатическая"});
            this.victoriesCheckBoxList.Location = new System.Drawing.Point(18, 26);
            this.victoriesCheckBoxList.Name = "victoriesCheckBoxList";
            this.victoriesCheckBoxList.Size = new System.Drawing.Size(232, 312);
            this.victoriesCheckBoxList.TabIndex = 0;
            // 
            // settingsGroupBox
            // 
            this.settingsGroupBox.Controls.Add(this.addSettingButton);
            this.settingsGroupBox.Controls.Add(this.settingTextBox);
            this.settingsGroupBox.Controls.Add(this.settingsCheckBoxList);
            this.settingsGroupBox.Location = new System.Drawing.Point(12, 12);
            this.settingsGroupBox.Name = "settingsGroupBox";
            this.settingsGroupBox.Size = new System.Drawing.Size(276, 370);
            this.settingsGroupBox.TabIndex = 0;
            this.settingsGroupBox.TabStop = false;
            this.settingsGroupBox.Text = "Настройки";
            // 
            // addSettingButton
            // 
            this.addSettingButton.Location = new System.Drawing.Point(156, 309);
            this.addSettingButton.Margin = new System.Windows.Forms.Padding(0, 0, 3, 3);
            this.addSettingButton.Name = "addSettingButton";
            this.addSettingButton.Size = new System.Drawing.Size(94, 29);
            this.addSettingButton.TabIndex = 2;
            this.addSettingButton.Text = "Добавить";
            this.addSettingButton.UseVisualStyleBackColor = true;
            this.addSettingButton.Click += new System.EventHandler(this.addSettingButton_Click);
            // 
            // settingTextBox
            // 
            this.settingTextBox.ForeColor = System.Drawing.Color.Gray;
            this.settingTextBox.Location = new System.Drawing.Point(18, 311);
            this.settingTextBox.Margin = new System.Windows.Forms.Padding(3, 0, 0, 3);
            this.settingTextBox.Name = "settingTextBox";
            this.settingTextBox.Size = new System.Drawing.Size(138, 27);
            this.settingTextBox.TabIndex = 1;
            this.settingTextBox.Text = "Полное уничотожение...";
            this.settingTextBox.GotFocus += new System.EventHandler(this.settingTextBox_GotFocus);
            this.settingTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.settingTextBox_KeyDown);
            this.settingTextBox.LostFocus += new System.EventHandler(this.settingTextBox_LostFocus);
            // 
            // settingsCheckBoxList
            // 
            this.settingsCheckBoxList.FormattingEnabled = true;
            this.settingsCheckBoxList.Items.AddRange(new object[] {
            "Агрессивные варвары",
            "Без руин"});
            this.settingsCheckBoxList.Location = new System.Drawing.Point(18, 26);
            this.settingsCheckBoxList.Name = "settingsCheckBoxList";
            this.settingsCheckBoxList.Size = new System.Drawing.Size(232, 312);
            this.settingsCheckBoxList.TabIndex = 0;
            // 
            // AddSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 765);
            this.Controls.Add(this.settingsPanel);
            this.Controls.Add(this.playersCivsGroupBox);
            this.Name = "AddSettingsForm";
            this.Text = "AddSettingsForm";
            this.Load += new System.EventHandler(this.AddSettingsForm_Load);
            this.playersCivsGroupBox.ResumeLayout(false);
            this.settingsPanel.ResumeLayout(false);
            this.labelPanel.ResumeLayout(false);
            this.victoriesGroupBox.ResumeLayout(false);
            this.victoriesGroupBox.PerformLayout();
            this.settingsGroupBox.ResumeLayout(false);
            this.settingsGroupBox.PerformLayout();
            this.ResumeLayout(false);

    }

    #endregion

    private GroupBox playersCivsGroupBox;
    private Panel settingsPanel;
    private Label rulesLabel;
    private GroupBox victoriesGroupBox;
    private Button addVictoryButton;
    private TextBox victoryTextBox;
    private CheckedListBox victoriesCheckBoxList;
    private GroupBox settingsGroupBox;
    private Button addSettingButton;
    private TextBox settingTextBox;
    private CheckedListBox settingsCheckBoxList;
    private Panel playersCivsPanel;
    private Button nextStageButton;
    private Panel labelPanel;
}