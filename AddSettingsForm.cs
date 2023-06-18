using System.Windows.Forms;

namespace Civilization; 

public partial class AddSettingsForm : Form {
    public AddSettingsForm() {
        this.Icon = ApplicationService.icon;
        InitializeComponent();
    }

    private void AddSettingsForm_Load(object sender, EventArgs e) {
        MaximizeBox = false;
        MinimizeBox = false;
        CenterToScreen();
        List<Control> labels = new List<Control>();
        foreach (string player in ApplicationService.playerCiv.Keys) {
            string txt;
            ApplicationService.playerCiv.TryGetValue(player, out txt);
            Label l = new();
            l.Text = player + ": " + txt;
            labels.Add(l);
        }
        this.Controls.AddRange(labels.ToArray());
    }
}