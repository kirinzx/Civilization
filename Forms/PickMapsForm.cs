using System.Text;
using System.Windows.Forms;

namespace Civilization; 

public partial class PickMapsForm : Form {
    private List<string> settings;
    private List<string> victories;
    public PickMapsForm(List<string> settings,List<string> victories) {
        this.settings = settings;
        this.victories = victories;
        InitializeComponent();
        MaximizeBox = false;
        MinimizeBox = false;
        Icon = ApplicationService.icon;
    }

    private void PickMapsForm_Load(object sender, EventArgs e) {
        playersCivsPanel.Controls.Add(ApplicationService.playerCiv1);
        playersCivsPanel.Controls.Add(ApplicationService.playerCiv2);
        addSettings();
        renderMaps();
    }

    private void goToTheLastStage(object sender,EventArgs e) {
        string gameMap = "";
        foreach (Map map in firstBunchMapsTable.Controls) {
            if (map.isPicked)
                gameMap = map.Text;
        }

        if (gameMap == "") {
            foreach (Map map in secondBunchMapsTable.Controls) {
                if (map.isPicked)
                    gameMap = map.Text;
            }
        }

        ApplicationService.gameMap = gameMap;
        ApplicationService.openNewForm(new LastStageForm(),this);
    }
    
    private void renderMaps() {
        string allMaps = (string)ApplicationService.resourceManager.GetObject("allMaps");
        string[] allMapsArr = allMaps.Split("\r\n");
        string[] gameMaps = ApplicationService.getSampleFromArr(allMapsArr,5);
        Label[] mapsLabels = new Label[5];
        for(int i = 0;i<gameMaps.Length;i++) {
            Map tmpLabel = new(gameMaps[i]);
            tmpLabel.Click += new EventHandler(pickMap);
            mapsLabels[i] = tmpLabel;
        }
        firstBunchMapsTable.Controls.AddRange(mapsLabels[..3]);
        secondBunchMapsTable.Controls.AddRange(mapsLabels[3..]);
    }
    
    private void addSettings() {
        Random random = new();
        
        Label settingLabel = new();
        if (settings.Count > 0) {
            string setting = settings.ToArray()[random.Next(0, settings.Count)];
            settingLabel.Text = "Доп. Настройки: " + setting;
        }
        else {
            settingLabel.Text = "Доп. Настройки:";
        }
        
        settingLabel.Dock = DockStyle.Fill;
        settingLabel.AutoSize = false;
        ApplicationService.setting = settingLabel;
        settingsTable.Controls.Add(settingLabel);
        
        
        Label victoryLabel = new();
        if (victories.Count > 0) {
            string victory = victories.ToArray()[random.Next(0, victories.Count)];
            victoryLabel.Text = "Исключаемая победа: " + victory;
        }
        
        else {
            victoryLabel.Text = "Исключаемая победа: ";
        }
        
        victoryLabel.Dock = DockStyle.Fill;
        victoryLabel.AutoSize = false;
        ApplicationService.victory = victoryLabel;
        settingsTable.Controls.Add(victoryLabel);
        
    }

    private void pickMap(object sender, EventArgs e) {
        foreach (Map mapTmp in firstBunchMapsTable.Controls) {
            mapTmp.isPicked = false;
        }
        foreach (Map mapTmp in secondBunchMapsTable.Controls) {
            mapTmp.isPicked = false;
        }
        Map map = sender as Map;
        map.isPicked = true;
        completeSetUpButton.Enabled = true;
    }
}