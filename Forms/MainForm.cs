using System.Resources;
using System.Text;
using KGySoft.Resources;
using Newtonsoft.Json.Linq;

namespace Civilization{
    public partial class MainForm : Form {
        public MainForm(){
            Icon img = (Icon)ApplicationService.resourceManager.GetObject("appIcon");
            ApplicationService.icon = img;
            InitializeComponent();
            CenterToScreen();
            ApplicationService.setFormSettings(this);
        }
        private void MainForm_Load(object sender, EventArgs e) {
            byte[] allCivsBytes =(byte[]) ApplicationService.resourceManager.GetObject("allCivs");
            var allCivsString = Encoding.UTF8.GetString(allCivsBytes, 0, allCivsBytes.Length);
            var allCivsJson = JObject.Parse(allCivsString);
            
            ApplicationService.allCivsJson = allCivsJson;
            
            List<string> allCivsList = new List<string>();
            Civilization[] allCivsControls = new Civilization[43];
            int count = 1;

            foreach (var civilization in allCivsJson) {
                Civilization civPanel = new(civilization.Key, count);
                
                civPanel.Margin = new Padding(0);
                civPanel.Width = allCivsPanel.Width - SystemInformation.VerticalScrollBarWidth;
                civPanel.Click += new EventHandler(civ_Click);
                foreach (Control control in civPanel.Controls) {
                    control.Click += new EventHandler(civ_Click);
                }
                allCivsControls[count - 1] = civPanel;
                allCivsList.Add(civilization.Key);
                count += 1;
            }
            ApplicationService.allCivsList = allCivsList;
            allCivsPanel.Controls.AddRange(allCivsControls);
        }

        private void startGameButton_Click(object sender, EventArgs e) {
            ApplicationService.openNewForm(new AddPlayersForm(),this);
        }

        private void civ_Click(object sender,EventArgs e) {
            Civilization civilization;
            if (sender is Civilization) {
                civilization = sender as Civilization;
            }
            else {
                civilization = (Civilization)((Control)sender).Parent;
            }
            foreach(Civilization civ in allCivsPanel.Controls) {
                civ.BackColor = this.BackColor;
            }
            civilization.BackColor = Color.Gray;
            getCivInfo(civilization);
        }

        private void getCivInfo(Civilization civilization) {
            civInfoTable.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            civInfoTable.Controls.Clear();
            civNameLabel.Text = civilization.name;
            List<CivilizationUnit> civUnitList = civilization.civInfoList;
            foreach (CivilizationUnit civUnit in civUnitList) {
                Panel unitPanel = new() {
                    Dock = DockStyle.Fill
                };
                
                Panel unitLabelPanel = new() {
                    Dock = DockStyle.Top,
                    Height = 29,
                    Margin = new Padding(0,0,0,4)
                };
                
                SplitContainer unitSplitContainer = new() {
                    Dock = DockStyle.Fill
                };
                unitPanel.Controls.Add(unitSplitContainer);
                unitPanel.Controls.Add(unitLabelPanel);
                
                civInfoTable.Controls.Add(unitPanel);
                Label unitName = new Label();
                unitName.Text = civUnit.generalName + ": " + civUnit.name;
                unitName.TextAlign = ContentAlignment.MiddleCenter;
                unitName.Dock = DockStyle.Fill;
                unitName.AutoSize = false;
                
                unitLabelPanel.Controls.Add(unitName);

                PictureBox unitIcon = new() {
                    Image = civUnit.image,
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Dock = DockStyle.Fill
                };
                unitSplitContainer.Panel1.Controls.Add(unitIcon);
                TableLayoutPanel unitInfoTable = new() {
                    Dock = DockStyle.Fill,
                    RowCount = civUnit.info.Count,
                };
                if (civUnit.generalName == "Уникальная постройка") {
                    unitInfoTable.RowStyles.Add(new RowStyle(SizeType.Percent, 75));
                    unitInfoTable.RowStyles.Add(new RowStyle(SizeType.Percent, 25));
                }
                else if (civUnit.generalName == "Уникальное здание") {
                    unitInfoTable.RowStyles.Add(new RowStyle(SizeType.Percent, 25));
                    unitInfoTable.RowStyles.Add(new RowStyle(SizeType.Percent, 75));
                }
                else {
                    for (int i = 0; i < civUnit.info.Count; i++) 
                        unitInfoTable.RowStyles.Add(new RowStyle(SizeType.Percent, 100 / civUnit.info.Count));
                }
                foreach (KeyValuePair<string,string> unitInfo in civUnit.info) {
                    Label tmpLabel = new();
                    tmpLabel.Text = unitInfo.Key + ": " + unitInfo.Value;
                    tmpLabel.Dock = DockStyle.Fill;
                    tmpLabel.AutoSize = false;
                    unitInfoTable.Controls.Add(tmpLabel);
                }
                unitSplitContainer.Panel2.Controls.Add(unitInfoTable);
            }
        }
    }
}