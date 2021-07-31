using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;

namespace SnakeGame
{
    public class Snake
    {
        public static List<SnakeBody> snakeList = null;

        int x = 0;
        int y = 0;
        bool up = false;
        bool down = false;
        bool right = true;
        bool left = false;
        Eat eat = new Eat();
        Label label = null;

        public Snake(Panel _panel)
        {
            snakeList = new List<SnakeBody>() { new SnakeBody(200, 200, true) };
            eat.ProduceFeed(_panel);
        }
        public void SnakeShow(Panel panel)
        {
            for (int i = 0; i < snakeList.Count(); i++)
            {
                label = snakeList[i].GetBody();
                panel.Controls.Add(label);
            }
        }
        public void SnakeLetsGo(Kontrol kontrol, Panel panel)
        {
            int bodyLocX = 0;
            int bodyLocY = 0;
            int temp = 0;
            for (int i = 0; i < snakeList.Count(); i++)
            {
                SnakeBody snake = snakeList[i];
                if (snake.Head is true)
                {
                    BoundaryKontrol(snake);
                    bodyLocX = snake.LocationX;
                    bodyLocY = snake.LocationY;

                    if (eat.FeedFoodControl(snake))
                    {
                        int son = snakeList.Count - 1;
                        SnakeBody snakeBody = snakeList[son];
                        eat.ProduceFeed(panel);
                        snakeList.Add(new SnakeBody(snakeBody.LocationX, snakeBody.LocationY, false));
                    }
                    if (kontrol == Kontrol.UP && up)
                    {
                        x = 0; y = -10;
                        up = true;
                        down = false;
                        right = true;
                        left = true;
                    }
                    else if (kontrol == Kontrol.DOWN && down)
                    {
                        x = 0; y = 10;
                        up = false;
                        down = true;
                        right = true;
                        left = true;
                    }
                    else if (kontrol == Kontrol.LEFT && left)
                    {
                        x = -10; y = 0;
                        up = true;
                        down = true;
                        right = false;
                        left = true;
                    }
                    else if (kontrol == Kontrol.RIGHT && right)
                    {
                        x = 10; y = 0;
                        up = true;
                        down = true;
                        right = true;
                        left = false;
                    }
                    snake.LocationX = bodyLocX + x;
                    snake.LocationY = bodyLocY + y;
                }
                else
                {
                    temp = snake.LocationX;
                    snake.LocationX = bodyLocX;
                    bodyLocX = temp;

                    temp = snake.LocationY;
                    snake.LocationY = bodyLocY;
                    bodyLocY = temp;
                }
            }
        }
        private void BoundaryKontrol(SnakeBody snake)
        {
            if (snake.LocationX > 560)
                snake.LocationX = 0;
            else if (snake.LocationX < 0)
                snake.LocationX = 560;
            if (400 < snake.LocationY)
                snake.LocationY = 0;
            else if (0 > snake.LocationY)
                snake.LocationY = 400;
        }
        public void SnakeEatİtself(FormSnakeGame form,string  Show)
        {
            SnakeBody snakeBody = snakeList[0];
            for (int i = 1; i < snakeList.Count; i++)
            {
                int locX = snakeList[i].LocationX;
                int LocY = snakeList[i].LocationY;
                if (snakeBody.LocationX == locX && snakeBody.LocationY == LocY)
                {
                    form.timer1.Stop();
                    DialogResult dialogResult = MessageBox.Show($"Sizin Puan : { Show}\n Yeniden Oynamaq isdeyirsizmi?", "Uduzduz", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.OK)
                    {
                        for (int j = 0; j < snakeList.Count; j++)
                            snakeList[j].GetLabel().Dispose();
                        snakeList = new List<SnakeBody>() { new SnakeBody(200, 200, true) };
                        form.timer1.Start();
                    }
                    else
                        Application.Exit();
                }
            }
        }
    }
}
