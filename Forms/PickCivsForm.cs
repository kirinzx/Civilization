namespace Civilization; 

public partial class PickCivsForm : Form {
    private List<Player> playersList;
    private List<TableLayoutPanel> civPanelList;
    private TableLayoutPanel playersTable1;
    private TableLayoutPanel playersTable2;
    private Dictionary<Player, Civilization> playerCiv;
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
        InitializeComponent();
        shuffleAgainBtn.BackgroundImage = (Image)ApplicationService.resourceManager.GetObject("refreshIcon");
        shuffleAgainBtn.BackgroundImageLayout = ImageLayout.Zoom;
        playersPanel.Controls.AddRange(new []{playersTable1,playersTable2});
        ApplicationService.setFormSettings(this);
    }

    private void PickCivsForm_Load(object sender,EventArgs e) {
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
            shuffleAgainBtn.Enabled = false;
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
                    playerCiv.Add(playerPick,civPanel);
                    picking();
                }
                catch {
                    foreach (Civilization civ in playerCiv.Values) {
                        civ.isPicked = false;
                    }
                    ApplicationService.playerCiv = this.playerCiv;
                    ApplicationService.openNewForm(new AddSettingsForm(playersTable1,playersTable2),this);
                }
            }
        }
    }

    private void makeOrder() {
        playersList = ApplicationService.getSampleFromList(playersList, playersList.Count);
        ApplicationService.addPlayersToTables(playersList,playersTable1,playersTable2);
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
        else if (numOfCivs == 6) {
            int rowCount = 3;
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
        if (civPanelList.Count == 1) {
            List<Civilization> civControls = new List<Civilization>();
            foreach (string civ in civList) {
                Civilization civPanel = generateCivTable(civ);
                civControls.Add(civPanel);
            }
            civPanelList.First().Controls.AddRange(civControls.ToArray());
        }
        else {
            List<Civilization> civControls1 = new();
            string[] civArr = civList.ToArray();
            int flag = civPanelList.First().ColumnCount * 3;
            foreach (string civ in civArr[..]) {
                Civilization civPanel = generateCivTable(civ);
                civControls1.Add(civPanel);
            }
            civPanelList.First().Controls.AddRange(civControls1.ToArray());
            List<Civilization> civControls2 = new();
            foreach (string civ in civArr[flag..]) {
                Civilization civPanel = generateCivTable(civ);
                civControls2.Add(civPanel);
            }
            civPanelList.Last().Controls.AddRange(civControls2.ToArray());
            
        }
    }
    private Civilization generateCivTable(string civ) {
        Civilization civPanel = new(civ);

        civPanel.Height = playersPanel.Height / 2;
        
        civPanel.Click += new EventHandler(doToCiv);
        foreach (Control control in civPanel.Controls) {
            control.Click += new EventHandler(doToCiv);
        }
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

    private void shuffleAgainBtn_Click(object sender, EventArgs e) {
        civilizationsPanel.Controls.Clear();
        civPanelList.Clear();
        Button btn = sender as Button;
        btn.Enabled = false;
        generateCivs();
    }
}