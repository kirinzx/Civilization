namespace Civilization; 

public class Map : Label {
    private bool _isPicked;

    public bool isPicked {
        get {
            return _isPicked;
        }
        set {
            _isPicked = value;
            Refresh();
        }
    }
    public Map(string mapName) {
        _isPicked = false;
        Text = mapName;
        Dock = DockStyle.Fill;
        AutoSize = false;
        TextAlign = ContentAlignment.MiddleCenter;
        Font = new Font("Segoe UI",14);
        BorderStyle = BorderStyle.FixedSingle;
        Margin = new Padding(0);
        Paint += new PaintEventHandler(mapPicked);
    }

    private void mapPicked(object sender, PaintEventArgs e) {
        //Label map = sender as Label;
        if (_isPicked) {
            this.BorderStyle = BorderStyle.None;
            ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle,
                Color.LimeGreen, 2, ButtonBorderStyle.Solid,
                Color.LimeGreen, 2, ButtonBorderStyle.Solid,
                Color.LimeGreen, 2, ButtonBorderStyle.Solid,
                Color.LimeGreen, 2, ButtonBorderStyle.Solid);
        }
        else {
            this.BorderStyle = BorderStyle.FixedSingle;
        }
    }
}