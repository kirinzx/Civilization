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
        public MainForm(){
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e) {

            MaximizeBox = false;
            MinimizeBox = false;
            CenterToScreen();
            
            using (ResXResourceSet resxSet = new ResXResourceSet(ApplicationService.ResxFile)) {
                Image img = (Image)resxSet.GetObject("appIcon");
                Icon ico = new Icon(IconFromImage(img), new Size(64,64));
                ApplicationService.icon = IconFromImage(img);
                this.Icon = ApplicationService.icon;

                byte[] allCivsBytes =(byte[]) resxSet.GetObject("allCivs");
                var allCivsString = Encoding.UTF8.GetString(allCivsBytes, 0, allCivsBytes.Length);
                var allCivsJson = JObject.Parse(allCivsString);
                
                ApplicationService.allCivsJson = allCivsJson;
                List<string> allCivsList = new List<string>();
                Control[] allCivsControls = new Control[43];
                int count = 1;
                
                foreach (var civilization in allCivsJson) {
                    FlowLayoutPanel civPanel = new() {
                        FlowDirection = FlowDirection.LeftToRight,
                        Margin = new System.Windows.Forms.Padding(0),
                        BorderStyle = BorderStyle.FixedSingle,
                        Width = allCivsPanel.Width - System.Windows.Forms.SystemInformation.VerticalScrollBarWidth,
                    };
                    civPanel.Click += new EventHandler(getCivInfo);
                    Label numLabel = new();
                    Label civNameLabel = new();
                    string civFlag = civilization.Value["Флаг"].Value<string>();
                    
                    PictureBox civFlagPictureBox = new() {
                        Image = (Image)resxSet.GetObject(civFlag.Split("/")[1].Split(".")[0]),
                        SizeMode = PictureBoxSizeMode.Zoom,
                        MaximumSize = new Size(civPanel.Width - numLabel.Width - civNameLabel.Width, civPanel.Height)
                    };
                    
                    numLabel.Text = count.ToString() + ".";
                    civNameLabel.Text = civilization.Key;
                    
                    civPanel.Controls.Add(numLabel);
                    civPanel.Controls.Add(civFlagPictureBox);
                    civPanel.Controls.Add(civNameLabel);
                    
                    allCivsControls[count - 1] = civPanel;
                    allCivsList.Add(civilization.Key);
                    
                    count += 1;
                }

                ApplicationService.allCivsList = allCivsList;
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
        public static Icon IconFromImage(Image img) {
            var ms = new System.IO.MemoryStream();
            var bw = new System.IO.BinaryWriter(ms);
            // Header
            bw.Write((short)0);   // 0 : reserved
            bw.Write((short)1);   // 2 : 1=ico, 2=cur
            bw.Write((short)1);   // 4 : number of images
            // Image directory
            var w = img.Width;
            if (w >= 256) w = 0;
            bw.Write((byte)w);    // 0 : width of image
            var h = img.Height;
            if (h >= 256) h = 0;
            bw.Write((byte)h);    // 1 : height of image
            bw.Write((byte)0);    // 2 : number of colors in palette
            bw.Write((byte)0);    // 3 : reserved
            bw.Write((short)0);   // 4 : number of color planes
            bw.Write((short)0);   // 6 : bits per pixel
            var sizeHere = ms.Position;
            bw.Write((int)0);     // 8 : image size
            var start = (int)ms.Position + 4;
            bw.Write(start);      // 12: offset of image data
            // Image data
            img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            var imageSize = (int)ms.Position - start;
            ms.Seek(sizeHere, System.IO.SeekOrigin.Begin);
            bw.Write(imageSize);
            ms.Seek(0, System.IO.SeekOrigin.Begin);

            // And load it
            return new Icon(ms);
        }
    }
}