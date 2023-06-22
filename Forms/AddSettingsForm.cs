namespace Civilization; 

public partial class AddSettingsForm : Form {
    private TableLayoutPanel playersTable1;
    private TableLayoutPanel playersTable2;
    public AddSettingsForm(TableLayoutPanel playersTable1,TableLayoutPanel playersTable2) {
        this.playersTable1 = playersTable1;
        this.playersTable2 = playersTable2;
        InitializeComponent();
        this.playersTable1.Height = playersCivsPanel.Height / 2;
        this.playersTable2.Height = playersCivsPanel.Height / 2;
        ApplicationService.setFormSettings(this);
    }

    private void AddSettingsForm_Load(object sender, EventArgs e) {
        renderPlayersCivs();
    }

    private void addVictoryButton_Click(object sender, EventArgs e) {
        string victory = victoryTextBox.Text.Trim();
        addVictory(victory);
    }

    private void addSettingButton_Click(object sender, EventArgs e) {
        string setting = settingTextBox.Text.Trim();
        addSetting(setting);
    }

    private void nextStageButton_Click(object sender, EventArgs e) {
        List<string> settings = new();
        foreach (object setting in settingsCheckBoxList.CheckedItems) {
            settings.Add(setting.ToString());
        }

        List<string> victories = new();
        foreach (object victory in victoriesCheckBoxList.CheckedItems) {
            victories.Add(victory.ToString());
        }
        ApplicationService.openNewForm(new PickMapsForm(settings,victories),this);
    }

    private void victoryTextBox_GotFocus(object sender, EventArgs e) {
        if (victoryTextBox.Text == "Какая-то победа...") {
            victoryTextBox.Text = "";
            victoryTextBox.ForeColor = Color.Black;
        }
    }
    private void settingTextBox_GotFocus(object sender, EventArgs e) {
        if (settingTextBox.Text == "Полное уничотожение...") {
            settingTextBox.Text = "";
            settingTextBox.ForeColor = Color.Black;
        }
    }
    private void settingTextBox_KeyDown(object sender, KeyEventArgs e) {
        if (e.KeyCode == Keys.Enter) {
            TextBox textBox = (TextBox)sender;
            addSetting(textBox.Text);
        }
    }
    private void victoryTextBox_KeyDown(object sender, KeyEventArgs e) {
        if (e.KeyCode == Keys.Enter) {
            TextBox textBox = (TextBox)sender;
            addVictory(textBox.Text);
        }
    }
    private void settingTextBox_LostFocus(object sender, EventArgs e) {
        if (settingTextBox.Text == "") {
            settingTextBox.Text = "Полное уничотожение...";
            settingTextBox.ForeColor = Color.Gray;
        }
    }
    private void victoryTextBox_LostFocus(object sender, EventArgs e) {
        if (victoryTextBox.Text == "") {
            victoryTextBox.Text = "Какая-то победа...";
            victoryTextBox.ForeColor = Color.Gray;
        }
    }
    private void addSetting(string setting) {
        settingTextBox.Text = "";
        if (setting.Length > 0 && !IsDigitsOnly(setting)) {
            settingsCheckBoxList.Items.Add(setting);
        }
        else {
            MessageBox.Show("Ошибка! Некорректный вариант настройки");
        }
    }
    private void addVictory(string victory) {
        victoryTextBox.Text = "";
        if (victory.Length > 0 && !IsDigitsOnly(victory)) {
            victoriesCheckBoxList.Items.Add(victory);
        }
        else {
            MessageBox.Show("Ошибка! Некорректный вариант победы");
        }
    }
    private void renderPlayersCivs() {
        List<TableLayoutPanel> playerCivList = new();
        foreach (KeyValuePair<Player,Civilization> playerCivPair in ApplicationService.playerCiv) {
            TableLayoutPanel tmpTable = new() {
                RowCount = 1,
                ColumnCount = 2,
                GrowStyle = TableLayoutPanelGrowStyle.FixedSize,
                Dock = DockStyle.Fill,
            };
            tmpTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
            tmpTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
            Player player = playerCivPair.Key;
            player.Margin = new Padding(0);
            Civilization civilization = playerCivPair.Value;
            civilization.Margin = new Padding(0);
            tmpTable.Controls.Add(player);
            tmpTable.Controls.Add(civilization);
            playerCivList.Add(tmpTable);
        }
        ApplicationService.addPlayersToTables(playerCivList,playersTable1,playersTable2);
        ApplicationService.playerCiv1 = playersTable1;
        ApplicationService.playerCiv2 = playersTable2;
        playersCivsPanel.Controls.Add(playersTable1);
        playersCivsPanel.Controls.Add(playersTable2);
    }
    private bool IsDigitsOnly(string str) {
        foreach (char c in str) {
            if (c < '0' || c > '9')
                return false;
        }
        return true;
    }
}