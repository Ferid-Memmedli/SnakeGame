using System;
using System.Drawing;
using System.Windows.Forms;

namespace SnakeGame
{
    public class Eat
    {
        int locX = 0;
        int locY = 0;
        Label _eat = null;
        Random random = new Random();
        public void ProduceFeed(Panel panel)
        {
            locX = random.Next(0, 56) * 10;
            locY = random.Next(0, 40) * 10;
            if (_eat != null)
                _eat.Dispose();
            _eat = new Label
            {
                Size = new Size(10, 10),
                BackColor = Color.Red,
                Location = new Point(locX, locY)
            };
            panel.Controls.Add(_eat);
        }
        public bool FeedFoodControl(SnakeBody head)
        {
            return head.LocationX == locX && head.LocationY == locY ? true : false;
        }
    }
}
