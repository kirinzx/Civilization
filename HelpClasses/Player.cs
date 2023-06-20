using System.Resources;
using KGySoft.Resources;

namespace Civilization; 

public class Player : TableLayoutPanel {
    private bool _picked;
    private bool _banned;
    private bool _isPicking;
    private bool _isBaning;
    private string _name;

    public string name {
        get {
            return _name;
        }
    }
    public bool isPicking {
        get {
            return _isPicking;
        }
        set {
            _isPicking = value;
            Refresh();
        }
    }

    public bool isBaning {
        get {
            return _isBaning;
        }
        set {
            _isBaning = value;
            Refresh();
        }
    }
    public bool banned {
        get {
            return _banned;
        }
        set {
            _banned = value;
        }
    }
    public bool picked {
        get {
            return _picked;
        }
        set {
            _picked = value;
        }
    }
    public Player(string name,bool picked=false, bool banned=false) {
        this._picked = picked;
        this._banned = banned;
        this._name = name;
        RowCount = 2;
        ColumnCount = 1;
        BorderStyle = BorderStyle.FixedSingle;
        GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
        Dock = DockStyle.Fill;
        RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50));
        RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50));
        PictureBox playerIcon = new() {
            Image = (Image)ApplicationService.resourceManager.GetObject("profileIcon2"),
            SizeMode = PictureBoxSizeMode.Zoom,
            Dock = DockStyle.Fill,
        };
        Controls.Add(playerIcon);
        Label playerNameLabel = new();
        playerNameLabel.Text = name;
        playerNameLabel.TextAlign = ContentAlignment.MiddleCenter;
        playerNameLabel.Dock = DockStyle.Fill;
        Controls.Add(playerNameLabel);
        this.Paint += new PaintEventHandler(paint);
    }

    private void paint(object sender, PaintEventArgs e) {
        if (_isPicking) {
            ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle,
                Color.LimeGreen, 2, ButtonBorderStyle.Solid,
                Color.LimeGreen, 2, ButtonBorderStyle.Solid,
                Color.LimeGreen, 2, ButtonBorderStyle.Solid,
                Color.LimeGreen, 2, ButtonBorderStyle.Solid);
        }
        else if (_isBaning) {
            ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle,
                Color.Red, 2, ButtonBorderStyle.Solid,
                Color.Red, 2, ButtonBorderStyle.Solid,
                Color.Red, 2, ButtonBorderStyle.Solid,
                Color.Red, 2, ButtonBorderStyle.Solid);
        }
        else {
            ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, this.BackColor, ButtonBorderStyle.None);
        }
    }
}