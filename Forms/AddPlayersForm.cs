namespace Civilization {
    public partial class AddPlayersForm : Form {
        private List<Player> playersControlList = new List<Player>();
        private TableLayoutPanel playersTable1 = new TableLayoutPanel();
        private TableLayoutPanel playersTable2 = new TableLayoutPanel();
        public AddPlayersForm() {
            InitializeComponent();
            this.Icon = ApplicationService.icon;
            MaximizeBox = false;
            MinimizeBox = false;
        }

        private void AddPlayersForm_Load(object sender, EventArgs e) {
            playersTable1.RowCount = 1;
            playersTable1.Dock = DockStyle.Top;
            playersTable1.RowStyles.Add(new RowStyle(SizeType.Percent, 100));
            playersTable1.Height = playersPanel.Height / 2;
            
            playersTable2.RowCount = 1;
            playersTable2.Dock = DockStyle.Bottom;
            playersTable2.RowStyles.Add(new RowStyle(SizeType.Percent, 100));
            playersTable2.Height = playersPanel.Height / 2;
            
            playersPanel.Controls.AddRange(new Control[]{playersTable1,playersTable2});
        }

        private void AddPlayersForm_Click(object sender, EventArgs e) {
            addPlayerInput.Enabled = false;
            addPlayerInput_LostFocus(sender,e);
            addPlayerInput.Enabled = true;
        }

        private void addPlayerBox_Click(object sender, EventArgs e) {
            AddPlayersForm_Click(sender,e);
        }
        private void addPlayerButton_Click(object sender, EventArgs e) {
            string playerName = addPlayerInput.Text;
            addPlayer(playerName);
        }
        private void addPlayerInput_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                TextBox textBox = (TextBox)sender;
                addPlayer(textBox.Text);
            }
        }
        private void addPlayerInput_LostFocus(object sender, EventArgs e) {
            if (addPlayerInput.Text == "") {
                addPlayerInput.Text = "Никнейм игрока";
                addPlayerInput.ForeColor = Color.Gray;
            }
        }
        private void addPlayerInput_GotFocus(object sender, EventArgs e) {
            if (addPlayerInput.Text == "Никнейм игрока") {
                addPlayerInput.Text = "";
                addPlayerInput.ForeColor = Color.Black;
            }
        }
        private void addPlayer(string playerName) {
            if (playersControlList.Count < 12) {
                if (playerName.Trim().Length > 0) {
                    playersControlList.Add(createPlayer(playerName));
                    changePlayersPanels();
                    ApplicationService.addPlayersToTables(playersControlList,playersTable1,playersTable2);
                    addPlayerInput.Text = "";
                    if (playersControlList.Count > 1) {
                        startPickingButton.Enabled = true;
                    }
                }
                else {
                    MessageBox.Show("Ошибка! Некорректное имя игрока!");
                }
            }
            else {
                MessageBox.Show("Ошибка! Превышено максимальное число игроков!");
            }
            
        }

        public void changePlayersPanels() {
            int numOfPlayers = playersControlList.Count;
            if (numOfPlayers % 2 == 0) {
                playersTable1.ColumnCount = numOfPlayers / 2;
                playersTable2.ColumnCount = numOfPlayers / 2;
            }
            else {
                playersTable1.ColumnCount = numOfPlayers / 2 + 1;
                playersTable2.ColumnCount = numOfPlayers  - (numOfPlayers / 2 + 1);
            }
            playersTable1.ColumnStyles.Clear();
            for (int i = 0; i < playersTable1.ColumnCount; i++) {
                ColumnStyle cs = new ColumnStyle(SizeType.Percent, 100 / playersTable1.ColumnCount);
                playersTable1.ColumnStyles.Add(cs);
            }
            playersTable2.ColumnStyles.Clear();
            for (int i = 0; i < playersTable2.ColumnCount; i++) {
                ColumnStyle cs = new ColumnStyle(SizeType.Percent, 100 / playersTable2.ColumnCount);
                playersTable2.ColumnStyles.Add(cs);
            }
        }
        
        public Player createPlayer(string playerName) {
            Player player = new(playerName);
            return player;
        }

        private void startPickingButton_Click(object sender, EventArgs e) {
            var addPlayersForm = new PickCivsForm(playersControlList,playersTable1,playersTable2);
            addPlayersForm.Location = this.Location;
            addPlayersForm.StartPosition = FormStartPosition.Manual;
            addPlayersForm.FormClosing += delegate { this.Close(); };
            addPlayersForm.Text = this.Text;
            addPlayersForm.Show();
            this.Hide();
        }
    }
}
