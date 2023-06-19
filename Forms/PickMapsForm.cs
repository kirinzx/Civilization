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
        
    }
}