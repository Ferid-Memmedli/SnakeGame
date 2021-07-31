using System.Drawing;
using System.Windows.Forms;

namespace SnakeGame
{
    public class SnakeBody
    {
        public SnakeBody(int _locationX, int _locationY, bool _head)
        {
            Head = _head;
            LocationY = _locationY;
            LocationX = _locationX;
        }
        public int LocationX { get; set; } = 0;
        public int LocationY { get; set; } = 0;
        public bool Head { get; set; } = false;
        Label snakShow = null;
        public Label GetBody()
        {
            if (snakShow != null)
                snakShow.Dispose();
            snakShow = new Label()
            {
                Location = new Point(LocationX, LocationY),
                Size = new Size(10, 10),
                BackColor = Head is false ? Color.LightBlue : Color.Blue
            };
            return snakShow;
        }
        public Label GetLabel()
        {
            return snakShow;
        }
    }
}
