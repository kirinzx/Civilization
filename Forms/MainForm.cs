using System.Resources;
using System.Text;
using KGySoft.Resources;
using Newtonsoft.Json.Linq;

namespace Civilization{
    public partial class MainForm : Form {
        public MainForm(){
            Image img = (Image)ApplicationService.resourceManager.GetObject("appIcon");
            Icon ico = new Icon(IconFromImage(img), new Size(64,64));
            ApplicationService.icon = ico;
            InitializeComponent();
            MaximizeBox = false;
            MinimizeBox = false;
            Icon = ApplicationService.icon;
        }
        private void MainForm_Load(object sender, EventArgs e) {
            CenterToScreen();
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
                civPanel.Click += new EventHandler(getCivInfo);
                foreach (Control control in civPanel.Controls) {
                    control.Click += new EventHandler(getCivInfo);
                }
                allCivsControls[count - 1] = civPanel;
                allCivsList.Add(civilization.Key);
                count += 1;
            }
            ApplicationService.allCivsList = allCivsList;
            allCivsPanel.Controls.AddRange(allCivsControls);
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
            Civilization civilization;
            if (sender is Civilization) {
                civilization = sender as Civilization;
            }
            else {
                civilization = (Civilization)((Control)sender).Parent;
            }
            civInfoPanel.Controls.Clear();
            foreach(Civilization civ in allCivsPanel.Controls) {
                civ.BackColor = this.BackColor;
            }
            civilization.BackColor = Color.Gray;
            Label civName = new();
            civName.Text = civilization.name;
            civInfoPanel.Controls.Add(civName);
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