using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BallsCommon;

namespace BallGamesWindowsFormsApp
{
    public partial class MainForm : Form
    {
        List<Ball> balls;
        private int buttonClickCount = 0;
        private int countBall;

        public MainForm()
        {
            InitializeComponent();
           
        }

        public void createBallButton_Click(object sender, EventArgs e)
        {
            balls = new List<Ball>();
            for (int i = 0; i < 10; i++)
            {
                var moveBall = new MoveBall(this);
                balls.Add(moveBall);
                moveBall.Start();
            }
            buttonClickCount++;
            roundsLeftLabel.Text = (10 - buttonClickCount).ToString();
            if (buttonClickCount == 11)
            {
                roundsLeftLabel.Text = 0.ToString();
                MessageBox.Show("Поздравляем! Вы поймали " + countBallsLabel.Text + " шариков! Игра окончена.");
                Reset();
            }

        }
        

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < balls.Count; i++)
            {
                if (balls[i].Exists(e.X, e.Y) && balls[i].IsMoving())
                {
                    balls[i].Stop();
                    countBallsLabel.Text = (Convert.ToInt32(countBallsLabel.Text) + 1).ToString();
                    balls[i].Clear();
                }
            }
            
        }

        private void catchBallsButton_Click(object sender, EventArgs e)
        {
            countBall = 0;
            for (int i = 0; i < balls.Count; i++)
            {
                
                balls[i].Stop();
                if (balls[i].OnForm())
                {
                    countBall ++;

                }
                
            }
            countBallsLabel.Text = countBall.ToString();
            MessageBox.Show("Поздравляем! Вы поймали " + countBall.ToString() + " шариков! Игра окончена.");
            Reset();

        }
        public void Reset()
        {
            countBall = 0;
            buttonClickCount = 0;
            roundsLeftLabel.Text = 0.ToString();
            countBallsLabel.Text = 0.ToString();
            for (int i = 0; i < balls.Count; i++)
            {
                balls[i].Clear();
            }
        }
        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void rulesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Добро пожаловать в игру! Для начала игры нажмите кнопку Create balls. Используйте 10 попыток и попытайтесь поймать как можно больше шариков нажатием левой кнопки мыши. Нажимайте Create balls для начала очередной попытки. Или сыграйте быструю игру и поймайте шарики с одной попытки нажатием кнопки Cаtch balls. Удачи!");

        }
    }
}
