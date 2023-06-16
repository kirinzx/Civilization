using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Resources;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using static System.Windows.Forms.DataFormats;

namespace Civilization{
    public partial class MainForm : Form {
        private const string ResxFile = "Resource1.resx";
        public MainForm(){
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e) {

            MaximizeBox = false;
            MinimizeBox = false;
            CenterToScreen();

            using (ResXResourceSet resxSet = new ResXResourceSet(ResxFile)) { 
                byte[] allCivs =(byte[]) resxSet.GetObject("allCivs");
                var texts = Encoding.UTF8.GetString(allCivs, 0, allCivs.Length);
                var jsonObject = JObject.Parse(texts);
                Control[] allCivsControls = new Control[43];
                int count = 1;
                foreach (var civilization in jsonObject) {
                    FlowLayoutPanel civPanel = new() {
                        FlowDirection = FlowDirection.LeftToRight,
                        Margin = new System.Windows.Forms.Padding(0),
                        BorderStyle = BorderStyle.FixedSingle,
                        Width = allCivsPanel.Width - System.Windows.Forms.SystemInformation.VerticalScrollBarWidth,
                    };
                    civPanel.Click += new EventHandler(getCivInfo);
                    Label numLabel = new();
                    Label civNameLabel = new();
                    JToken civInfo = civilization.Value;
                    PictureBox civFlag = new() {
                        ImageLocation = "Resources/" + civInfo["Флаг"],
                        SizeMode = PictureBoxSizeMode.Zoom,
                        MaximumSize = new Size(civPanel.Width - numLabel.Width - civNameLabel.Width, civPanel.Height)
                    };
                    numLabel.Text = count.ToString() + ".";
                    civNameLabel.Text = civilization.Key;
                    civPanel.Controls.Add(numLabel);
                    civPanel.Controls.Add(civFlag);
                    civPanel.Controls.Add(civNameLabel);
                    allCivsControls[count - 1] = civPanel;
                    count += 1;
                }
                allCivsPanel.Controls.AddRange(allCivsControls);
            }
        }

        private void startGameButton_Click(object sender, EventArgs e) {
            var addPlayersForm = new AddPlayersForm();
            addPlayersForm.Location = this.Location;
            addPlayersForm.StartPosition = FormStartPosition.Manual;
            addPlayersForm.FormClosing += delegate { this.Close(); };
            addPlayersForm.Text = this.Text;
            addPlayersForm.Show();
            this.Hide();
        }

        private void getCivInfo(object sender,EventArgs e) {
            if (sender is Control) {
                civInfoPanel.Controls.Clear();
                Control civ = sender as Control;
                foreach(Control civilization in allCivsPanel.Controls) {
                    civilization.BackColor = this.BackColor;
                }
                civ.BackColor = Color.Gray;
                foreach (Control civControl in civ.Controls) {
                    if (civControl is Label) {
                        string tmp = civControl.Text.Remove(civControl.Text.Length - 1);
                        try {
                            int count = int.Parse(tmp);
                        }
                        catch {
                            Label civName = new();
                            civName.Text = civControl.Text;
                            civInfoPanel.Controls.Add(civName);
                        }
                    }
                }
            }
        }
    }
}