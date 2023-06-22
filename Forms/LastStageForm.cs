using System.Windows.Forms;

namespace Civilization; 

public partial class LastStageForm : Form {
    public LastStageForm() {
        InitializeComponent();
        ApplicationService.setFormSettings(this);
    }

    private void LastStageForm_Load(object sender, EventArgs e) {
        playersCivsPanel.Controls.Add(ApplicationService.playerCiv1);
        playersCivsPanel.Controls.Add(ApplicationService.playerCiv2);
        settingsTable.Controls.Add(ApplicationService.setting);
        settingsTable.Controls.Add(ApplicationService.victory);
        Label map = new();
        map.Text = "Карта: " + ApplicationService.gameMap;
        map.Dock = DockStyle.Fill;
        map.AutoSize = false;
        settingsTable.Controls.Add(map);
    }

    private void goToStart(object sender, EventArgs e) {
        ApplicationService.openNewForm(new MainForm(),this);
    }
}