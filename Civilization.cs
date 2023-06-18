namespace Civilization; 

public class Civilization : TableLayoutPanel {
    private bool _isBanned;
    private bool _isPicked;
    private string _name;

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
        _isBanned = isBanned;
        _isPicked = isPicked;
        _name = name;
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
    }
}