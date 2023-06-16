using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Civilization {
    public partial class AddPlayersForm : Form {
        private List<string> playersList = new List<string>();
        private const string ResxFile = "Resource1.resx";
        public AddPlayersForm() {
            InitializeComponent();
        }

        private void AddPlayersForm_Load(object sender, EventArgs e) {
            MaximizeBox = false;
            MinimizeBox = false;
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
            if (playerName.Trim().Length > 0) {
                createPlayer(playerName);
                addPlayerInput.Text = "";
            }
            else {
                MessageBox.Show("Ошибка! Некорректное имя игрока!");
            }
        }

        private void createPlayer(string playerName) {
            TableLayoutPanel playerPanel = new() {
                RowCount = 2,
                ColumnCount = 1,
                BorderStyle = BorderStyle.FixedSingle,
                Margin = new Padding(0),
                Height = playersPanel.GetRowHeights()[0],
                GrowStyle = TableLayoutPanelGrowStyle.FixedSize,
            };
            playerPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50));
            playerPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50));
            using (ResXResourceSet resxSet = new ResXResourceSet(ResxFile)) {
                PictureBox playerIcon = new() {
                    Image = (Image)resxSet.GetObject("profileIcon2"),
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Size = playerPanel.Size,
                    Dock = DockStyle.Fill,
                };
                playerPanel.Controls.Add(playerIcon);
            }
            Label playerNameLabel = new();
            playerNameLabel.Text = playerName;
            playerNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            playerNameLabel.Dock = DockStyle.Fill;
            playerPanel.Controls.Add(playerNameLabel);
            playersPanel.Controls.Add(playerPanel);
            playersList.Add(playerName);
        }
    }
}
