using System;
using System.Windows.Forms;

namespace SnakeGame
{
    public partial class FormSnakeGame : Form
    {
        public FormSnakeGame()
        {
            InitializeComponent();
        }
        Kontrol kontrol = Kontrol.RIGHT;
        Snake snake;
        private void timer1_Tick(object sender, EventArgs e)
        {
            snake.SnakeShow(panelGameArena);
            snake.SnakeEatİtself(this, labelScoreShow.Text);
            snake.SnakeLetsGo(kontrol, panelGameArena);
            labelScoreShow.Text = ((Snake.snakeList.Count - 1) * 10).ToString();
        }
        private void FormSnakeGame_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
                kontrol = Kontrol.UP;
            else if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
                kontrol = Kontrol.DOWN;
            else if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
                kontrol = Kontrol.LEFT;
            else if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
                kontrol = Kontrol.RIGHT;
        }
        private void FormSnakeGame_Load(object sender, EventArgs e)
        {
            timer1.Start();
            snake = new Snake(panelGameArena);
        }
    }
}
