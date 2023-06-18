using System.ComponentModel;
using System.Reflection;
using System.Resources;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace Civilization; 

public partial class PickCivsForm : Form {
    private List<Player> playersList;
    private List<TableLayoutPanel> civPanelList;
    private TableLayoutPanel playersTable1;
    private TableLayoutPanel playersTable2;
    private Dictionary<string, string> playerCiv;
    private bool pickingStage;
    private bool banningStage;

    public PickCivsForm(List<Player> playersList, TableLayoutPanel playersTable1,TableLayoutPanel playersTable2) {
        this.playersList = playersList;
        this.pickingStage = false;
        this.banningStage = false;
        playerCiv = new();
        this.civPanelList = new();
        this.playersTable1 = playersTable1;
        this.playersTable2 = playersTable2;
        this.Icon = ApplicationService.icon;
        InitializeComponent();
    }

    private void PickCivsForm_Load(object sender,EventArgs e) {
        MaximizeBox = false;
        MinimizeBox = false;
        playersPanel.Controls.AddRange(new []{playersTable1,playersTable2});
        generateCivs();
        makeOrder();
        banningStage = true;
        banning();
    }

    private void picking() {
        Player playerPick = playersList.Find(x => x.picked == false);
        foreach (Control control in playerPick.Controls) {
            if (control is Label) {
                orderToPickLabel.Text = "Пикает игрок: " + control.Text;
            }
        }
        playerPick.isPicking = true;
    }

    private void banning() {
        Player playerBan = playersList.Find(x => x.banned == false);
        foreach (Control control in playerBan.Controls) {
            if (control is Label) {
                orderToPickLabel.Text = "Банит игрок: " + control.Text;
            }
        }
        playerBan.isBaning = true;
    }
    
    private void doToCiv(object sender,EventArgs e) {
        Civilization civPanel;
        if (sender is Civilization) {
            civPanel = sender as Civilization;
        }
        else {
            civPanel = (Civilization)((Control)sender).Parent;
        }
        if (!civPanel.isBanned) {
            if (banningStage) {
                try {
                    Player playerBan = playersList.Find(x => x.banned == false);
                    playerBan.isBaning = false;
                    playerBan.banned = true;
                    civPanel.isBanned = true;
                    banning();
                }
                catch {
                    banningStage = false;
                    pickingStage = true;
                    picking();
                }
            }
            else if(pickingStage) {
                try {
                    Player playerPick = playersList.Find(x => x.picked == false);
                    playerPick.isPicking = false;
                    playerPick.picked = true;
                    civPanel.isPicked = true;
                    playerCiv.Add(playerPick.name,civPanel.name);
                    picking();
                }
                catch {
                    ApplicationService.playerCiv = this.playerCiv;
                    var AddSettingsForm = new AddSettingsForm();
                    AddSettingsForm.Location = this.Location;
                    AddSettingsForm.StartPosition = FormStartPosition.Manual;
                    AddSettingsForm.FormClosing += delegate { this.Close(); };
                    AddSettingsForm.Text = this.Text;
                    AddSettingsForm.Show();
                    this.Hide();
                }
            }
        }
    }

    private void makeOrder() {
        playersList = ApplicationService.getSampleFromList(playersList, playersList.Count);
        int numOfPlayers = playersList.Count;
        int firstBunchFlag;
        int secondBunchFlag;
        if (numOfPlayers % 2 == 0) {
            firstBunchFlag = numOfPlayers / 2;
            secondBunchFlag = firstBunchFlag;
        }
        else {
            firstBunchFlag = numOfPlayers / 2 + 1;
            secondBunchFlag = numOfPlayers - (numOfPlayers / 2 + 1) + 1;
        }
        Player[] firstBunchPlayers = playersList.ToArray()[..firstBunchFlag];
        Player[] secondBunchPlayers = playersList.ToArray()[secondBunchFlag..];
        
        playersTable1.Controls.Clear();
        playersTable2.Controls.Clear();
        playersTable1.Controls.AddRange(firstBunchPlayers);
        playersTable2.Controls.AddRange(secondBunchPlayers);
    }
    
    private void generateCivs() {
        int numOfCivs = playersList.Count * 2;
        List<string> civList = ApplicationService.getSampleFromList(ApplicationService.allCivsList, numOfCivs);
        addPanelsForCivs(civList.Count);
        renderCivs(civList);
    }
    
    
// == 4 => 2 x 2
// % 4 == 0 && != 8 => составляем из 4 строк
// else => берем ближайщее число, делящееся на 3, такое кол-во заносим в первые 3 строки,
// из исходного вычитаем заполненные ячейки, добавлеем в последнюю
    private void addPanelsForCivs(int numOfCivs) {
        if (numOfCivs == 4) {
            int rowCount = 2;
            int columnCount = 2;
            TableLayoutPanel civsPanel = generateTablePanel(rowCount, columnCount);
            civsPanel.Dock = DockStyle.Fill;
            civPanelList.Add(civsPanel);
            civilizationsPanel.Controls.Add(civsPanel);
        }
        else if (numOfCivs % 4 == 0) {
            int rowCount = 4;
            int columnCount = numOfCivs / 4;
            TableLayoutPanel civsPanel = generateTablePanel(rowCount, columnCount);
            civsPanel.Dock = DockStyle.Fill;
            civPanelList.Add(civsPanel);
            civilizationsPanel.Controls.Add(civsPanel);
        }
        else {
            int rowCount1 = 3;
            int rowCount2 = 1;
            int columnCount1 = getClosestDivededOnThree(numOfCivs) / 3;
            int columnCount2 = numOfCivs - columnCount1 * 3;
            TableLayoutPanel civsPanel1 = generateTablePanel(rowCount1, columnCount1);
            TableLayoutPanel civsPanel2 = generateTablePanel(rowCount2, columnCount2);
            civsPanel1.Dock = DockStyle.Top;
            civsPanel1.Height = civilizationsPanel.Height / 4 * 3;
            civsPanel2.Dock = DockStyle.Bottom;
            civsPanel2.Height = civilizationsPanel.Height / 4;
            civPanelList.Add(civsPanel1);
            civPanelList.Add(civsPanel2);
            civilizationsPanel.Controls.AddRange(new[]{civsPanel1,civsPanel2});
        }
    }

    private TableLayoutPanel generateTablePanel(int rowCount,int columnCount) {
        TableLayoutPanel tablePanel = new() {
            RowCount = rowCount,
            ColumnCount = columnCount,
        };
        tablePanel.ColumnStyles.Clear();
        for (int i = 0; i < columnCount; i++) {
            ColumnStyle cs = new ColumnStyle(SizeType.Percent, 100 / columnCount);
            tablePanel.ColumnStyles.Add(cs);
        }
        tablePanel.RowStyles.Clear();
        for (int i = 0; i < rowCount; i++) {
            RowStyle cs = new RowStyle(SizeType.Percent, 100 / rowCount);
            tablePanel.RowStyles.Add(cs);
        }
        return tablePanel;
    }

    private void renderCivs(List<string> civList) {
        using (ResXResourceSet rxSet = new ResXResourceSet(ApplicationService.ResxFile)) {
            JObject civsJson = ApplicationService.allCivsJson;
            if (civPanelList.Count == 1) {
                List<Civilization> civControls = new List<Civilization>();
                foreach (string civ in civList) {
                    string civFlagPath = civsJson[civ]["Флаг"].Value<string>();
                    Image civFlag = (Image)rxSet.GetObject(civFlagPath.Split("/")[1].Split(".")[0]);
                    Civilization civPanel = generateCivTable(civ, civFlag);
                    civControls.Add(civPanel);
                }
                civPanelList.First().Controls.AddRange(civControls.ToArray());
            }
            else {
                List<Civilization> civControls1 = new();
                string[] civArr = civList.ToArray();
                int flag = civPanelList.First().ColumnCount * 3;
                foreach (string civ in civArr[..]) {
                    string civFlagPath = civsJson[civ]["Флаг"].Value<string>();
                    Image civFlag = (Image)rxSet.GetObject(civFlagPath.Split("/")[1].Split(".")[0]);
                    Civilization civPanel = generateCivTable(civ, civFlag);
                    civControls1.Add(civPanel);
                }
                civPanelList.First().Controls.AddRange(civControls1.ToArray());
                List<Civilization> civControls2 = new();
                foreach (string civ in civArr[flag..]) {
                    string civFlagPath = civsJson[civ]["Флаг"].Value<string>();
                    Image civFlag = (Image)rxSet.GetObject(civFlagPath.Split("/")[1].Split(".")[0]);
                    Civilization civPanel = generateCivTable(civ, civFlag);
                    civControls2.Add(civPanel);
                }
                civPanelList.Last().Controls.AddRange(civControls2.ToArray());
            }
        }
    }
    private Civilization generateCivTable(string civ,Image civImage) {
        Civilization civPanel = new(civ) {
            RowCount = 2,
            ColumnCount = 1,
            BorderStyle = BorderStyle.FixedSingle,
            Margin = new Padding(0),
            Height = playersPanel.Height / 2,
            GrowStyle = TableLayoutPanelGrowStyle.FixedSize,
            Dock = DockStyle.Fill,
        };
        civPanel.Margin = new Padding(3);
        civPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50));
        civPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50));
        
        PictureBox civFlag = new() {
            Image = civImage,
            SizeMode = PictureBoxSizeMode.Zoom,
            Dock = DockStyle.Fill,
        };
        Label civLabel = new();
        civLabel.Text = civ;
        civLabel.TextAlign = ContentAlignment.MiddleCenter;
        civLabel.Dock = DockStyle.Fill;
        civPanel.Controls.Add(civFlag);
        civPanel.Controls.Add(civLabel);
        civPanel.Click += new EventHandler(doToCiv);
        civFlag.Click += new EventHandler(doToCiv);
        civLabel.Click += new EventHandler(doToCiv);
        return civPanel;
    }
    private int getClosestDivededOnThree(int num) {
        int tmpNum = num;
        while (true) {
            if (tmpNum % 3 == 0) {
                return tmpNum;
            }

            tmpNum--;
        }
    }
}