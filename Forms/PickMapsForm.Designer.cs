using System.ComponentModel;

namespace Civilization; 

partial class PickMapsForm {
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
            this.mapsBox = new System.Windows.Forms.GroupBox();
            this.allMapsTable = new System.Windows.Forms.TableLayoutPanel();
            this.secondBunchMapsTable = new System.Windows.Forms.TableLayoutPanel();
            this.firstBunchMapsTable = new System.Windows.Forms.TableLayoutPanel();
            this.gameSettingsBox = new System.Windows.Forms.GroupBox();
            this.settingsTable = new System.Windows.Forms.TableLayoutPanel();
            this.defaultSettingsLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.completeSetUpButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.playersCivsGroupBox.SuspendLayout();
            this.mapsBox.SuspendLayout();
            this.allMapsTable.SuspendLayout();
            this.gameSettingsBox.SuspendLayout();
            this.settingsTable.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.playersCivsGroupBox.TabIndex = 1;
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
            // mapsBox
            // 
            this.mapsBox.Controls.Add(this.allMapsTable);
            this.mapsBox.Location = new System.Drawing.Point(12, 12);
            this.mapsBox.Name = "mapsBox";
            this.mapsBox.Padding = new System.Windows.Forms.Padding(10, 3, 10, 10);
            this.mapsBox.Size = new System.Drawing.Size(551, 370);
            this.mapsBox.TabIndex = 2;
            this.mapsBox.TabStop = false;
            this.mapsBox.Text = "Карты";
            // 
            // allMapsTable
            // 
            this.allMapsTable.ColumnCount = 1;
            this.allMapsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.allMapsTable.Controls.Add(this.secondBunchMapsTable, 0, 1);
            this.allMapsTable.Controls.Add(this.firstBunchMapsTable, 0, 0);
            this.allMapsTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.allMapsTable.Location = new System.Drawing.Point(10, 23);
            this.allMapsTable.Name = "allMapsTable";
            this.allMapsTable.RowCount = 2;
            this.allMapsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.allMapsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.allMapsTable.Size = new System.Drawing.Size(531, 337);
            this.allMapsTable.TabIndex = 0;
            // 
            // secondBunchMapsTable
            // 
            this.secondBunchMapsTable.ColumnCount = 2;
            this.secondBunchMapsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.secondBunchMapsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.secondBunchMapsTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.secondBunchMapsTable.Location = new System.Drawing.Point(0, 168);
            this.secondBunchMapsTable.Margin = new System.Windows.Forms.Padding(0);
            this.secondBunchMapsTable.Name = "secondBunchMapsTable";
            this.secondBunchMapsTable.RowCount = 1;
            this.secondBunchMapsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.secondBunchMapsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.secondBunchMapsTable.Size = new System.Drawing.Size(531, 169);
            this.secondBunchMapsTable.TabIndex = 1;
            // 
            // firstBunchMapsTable
            // 
            this.firstBunchMapsTable.ColumnCount = 3;
            this.firstBunchMapsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.firstBunchMapsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.firstBunchMapsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.firstBunchMapsTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.firstBunchMapsTable.Location = new System.Drawing.Point(0, 0);
            this.firstBunchMapsTable.Margin = new System.Windows.Forms.Padding(0);
            this.firstBunchMapsTable.Name = "firstBunchMapsTable";
            this.firstBunchMapsTable.RowCount = 1;
            this.firstBunchMapsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.firstBunchMapsTable.Size = new System.Drawing.Size(531, 168);
            this.firstBunchMapsTable.TabIndex = 0;
            // 
            // gameSettingsBox
            // 
            this.gameSettingsBox.Controls.Add(this.settingsTable);
            this.gameSettingsBox.Location = new System.Drawing.Point(589, 12);
            this.gameSettingsBox.Name = "gameSettingsBox";
            this.gameSettingsBox.Padding = new System.Windows.Forms.Padding(10, 3, 10, 10);
            this.gameSettingsBox.Size = new System.Drawing.Size(594, 257);
            this.gameSettingsBox.TabIndex = 3;
            this.gameSettingsBox.TabStop = false;
            this.gameSettingsBox.Text = "Настройки";
            // 
            // settingsTable
            // 
            this.settingsTable.ColumnCount = 1;
            this.settingsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.settingsTable.Controls.Add(this.defaultSettingsLabel, 0, 0);
            this.settingsTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingsTable.Location = new System.Drawing.Point(10, 23);
            this.settingsTable.Name = "settingsTable";
            this.settingsTable.RowCount = 3;
            this.settingsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.settingsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.settingsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.settingsTable.Size = new System.Drawing.Size(574, 224);
            this.settingsTable.TabIndex = 0;
            // 
            // defaultSettingsLabel
            // 
            this.defaultSettingsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.defaultSettingsLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.defaultSettingsLabel.Location = new System.Drawing.Point(3, 0);
            this.defaultSettingsLabel.Name = "defaultSettingsLabel";
            this.defaultSettingsLabel.Size = new System.Drawing.Size(568, 74);
            this.defaultSettingsLabel.TabIndex = 0;
            this.defaultSettingsLabel.Text = "Стандартные настройки: Нельзя копить учёных, писателей, художников";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(589, 294);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(460, 88);
            this.panel1.TabIndex = 4;
            // 
            // completeSetUpButton
            // 
            this.completeSetUpButton.Enabled = false;
            this.completeSetUpButton.Location = new System.Drawing.Point(1055, 303);
            this.completeSetUpButton.Name = "completeSetUpButton";
            this.completeSetUpButton.Size = new System.Drawing.Size(130, 59);
            this.completeSetUpButton.TabIndex = 5;
            this.completeSetUpButton.Text = "Подтвердить выбор";
            this.completeSetUpButton.UseVisualStyleBackColor = true;
            this.completeSetUpButton.Click += new EventHandler(goToTheLastStage);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(460, 88);
            this.label1.TabIndex = 0;
            this.label1.Text = "Нажмите на предпочитаемую карту и подтвердите свое решение, кликнув на кнопку";
            // 
            // PickMapsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 765);
            this.Controls.Add(this.completeSetUpButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gameSettingsBox);
            this.Controls.Add(this.mapsBox);
            this.Controls.Add(this.playersCivsGroupBox);
            this.Name = "PickMapsForm";
            this.Text = "PickMapsForm";
            this.Load += new System.EventHandler(this.PickMapsForm_Load);
            this.playersCivsGroupBox.ResumeLayout(false);
            this.mapsBox.ResumeLayout(false);
            this.allMapsTable.ResumeLayout(false);
            this.gameSettingsBox.ResumeLayout(false);
            this.settingsTable.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

    }

    #endregion

    private GroupBox playersCivsGroupBox;
    private Panel playersCivsPanel;
    private GroupBox mapsBox;
    private GroupBox gameSettingsBox;
    private TableLayoutPanel firstBunchMapsTable;
    private TableLayoutPanel allMapsTable;
    private TableLayoutPanel secondBunchMapsTable;
    private TableLayoutPanel settingsTable;
    private Label defaultSettingsLabel;
    private Panel panel1;
    private Label label1;
    private Button completeSetUpButton;
}