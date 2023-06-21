using System.Resources;
using System.Runtime;
using Newtonsoft.Json.Linq;
using KGySoft.Resources;
using Microsoft.VisualBasic;

namespace Civilization; 

public class Civilization : TableLayoutPanel {
    private bool _isBanned;
    private bool _isPicked;
    private string _name;
    private GCLargeObjectHeapCompactionMode compact { get; set; }
    public List<CivilizationUnit> civInfoList{get;set;}
    public string name {
        get {
            return _name;
        }
    }

    public bool isBanned {
        get {
            return _isBanned;
        }
        set {
            _isBanned = value;
            Refresh();
        }
    }

    public bool isPicked {
        get {
            return _isPicked;
        }
        set {
            _isPicked = value;
            Refresh();
        }
    }
    public Civilization(string name,bool isBanned=false,bool isPicked=false) {
        compact = GCLargeObjectHeapCompactionMode.CompactOnce;
        _isBanned = isBanned;
        _isPicked = isPicked;
        _name = name;
        RowCount = 2;
        ColumnCount = 1;
        BorderStyle = BorderStyle.FixedSingle;
        GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
        Dock = DockStyle.Fill;

        RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50));
        RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50));
        
        string civFlagPath = ApplicationService.allCivsJson[name]["Флаг"].Value<string>();
        Image civImage = (Image)ApplicationService.resourceManager.GetObject(civFlagPath.Split("/")[1].Split(".")[0]);
        PictureBox civFlag = new() {
            Image = civImage,
            SizeMode = PictureBoxSizeMode.Zoom,
            Dock = DockStyle.Fill,
        };
        civFlag.Dock = DockStyle.Fill;
        Controls.Add(civFlag);
        
        Label civLabel = new();
        civLabel.Text = name;
        civLabel.TextAlign = ContentAlignment.MiddleCenter;
        civLabel.Dock = DockStyle.Fill;
        
        Controls.Add(civLabel);
        this.Paint += new PaintEventHandler(paint);
    }
    public Civilization(string name, int count, bool isBanned = false, bool isPicked = false) {
        civInfoList = new();
        compact = GCLargeObjectHeapCompactionMode.CompactOnce;
        _isBanned = isBanned;
        _isPicked = isPicked;
        _name = name;
        getInfo();
        RowCount = 1;
        ColumnCount = 3;
        for (int i = 0; i < ColumnCount; i++) {
            ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100 / ColumnCount));
        }
        BorderStyle = BorderStyle.FixedSingle;
        Label countLab = new();
        countLab.Text = count + ".";
        countLab.Dock = DockStyle.Fill;
        countLab.TextAlign = ContentAlignment.MiddleCenter;
        
        string civFlagPath = ApplicationService.allCivsJson[name]["Флаг"].Value<string>();
        Image civImage = (Image)ApplicationService.resourceManager.GetObject(civFlagPath.Split("/")[1].Split(".")[0]);
        PictureBox civFlag = new() {
            Image = civImage,
            SizeMode = PictureBoxSizeMode.Zoom,
            Dock = DockStyle.Fill
        };
        civFlag.Dock = DockStyle.Fill;
        
        Label civNameLabel = new();
        civNameLabel.Text = name;
        civNameLabel.TextAlign = ContentAlignment.MiddleCenter;
        civNameLabel.Dock = DockStyle.Fill;
        
        Controls.Add(countLab);
        Controls.Add(civFlag);
        Controls.Add(civNameLabel);
        this.Paint += new PaintEventHandler(paint);
    }

    private void paint(object sender, PaintEventArgs e) {
        if (_isBanned) {
            ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle,
                Color.Red, 2, ButtonBorderStyle.Solid,
                Color.Red, 2, ButtonBorderStyle.Solid,
                Color.Red, 2, ButtonBorderStyle.Solid,
                Color.Red, 2, ButtonBorderStyle.Solid);
        }
        else if (_isPicked) {
            ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle,
                Color.LimeGreen, 2, ButtonBorderStyle.Solid,
                Color.LimeGreen, 2, ButtonBorderStyle.Solid,
                Color.LimeGreen, 2, ButtonBorderStyle.Solid,
                Color.LimeGreen, 2, ButtonBorderStyle.Solid);
        }
        else {
            ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, this.BackColor, ButtonBorderStyle.None);
        }
    }

    private void getInfo() {
        foreach(JProperty smth in ApplicationService.allCivsJson[name]) {
            string unitGeneralName = smth.Name;
            if (unitGeneralName == "Флаг") {
                continue;
            }
            foreach (JObject unit in smth.Value) {
                string image = "";
                string unitName = "";
                Dictionary<string,string> unitInfo = new();
                foreach (KeyValuePair<string, JToken> info in unit) {
                    if (info.Key == "image") {
                        image = info.Value.ToString();
                    }
                    else {
                        unitName = info.Key;
                        /*unitInfo = (JObject)info.Value;*/
                        foreach (KeyValuePair<string, JToken> certainInfo in (JObject)info.Value) {
                            string unitChar = certainInfo.Key;
                            string unitCharInfo = certainInfo.Value.ToString();
                            unitInfo.Add(unitChar,unitCharInfo);
                        }
                    }
                }

                civInfoList.Add(new CivilizationUnit(unitGeneralName, unitName, image, unitInfo));
            }
        }
    }
}