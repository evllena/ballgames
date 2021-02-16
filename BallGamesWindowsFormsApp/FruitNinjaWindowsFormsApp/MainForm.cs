using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FruitNinjaWindowsFormsApp
{
    public partial class MainForm : Form
    {
        static Random random = new Random();
        List<FruitBall> fruits = new List<FruitBall>();
        
        Timer showFruitTimer = new Timer();
        
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            showFruitTimer.Start();
            showFruitTimer.Interval = 1000;
            showFruitTimer.Tick += ShowFruitTimer_Tick;


        }


        private void ShowFruitTimer_Tick(object sender, EventArgs e)
        {
            var countFruits = random.Next(1, 5);
            for(int i = 0; i<=countFruits; i++)
            { 
            FruitBall fruitBall = new FruitBall(this);
                
                    
                fruitBall.Start();
                fruits.Add(fruitBall);
            }

            var randomBomb= random.Next(1, 10);
            if (randomBomb == 7)
                {
                BombBall bomb = new BombBall(this);
                bomb.Start();
                fruits.Add(bomb);
             }
            if (randomBomb == 6)
            {
                BananaBall banana = new BananaBall(this);
                banana.Start();
                fruits.Add(banana);
            }
            showFruitTimer.Interval = random.Next(1000, 1500);
        }

       
        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < fruits.Count; i++)
            {
                if (fruits[i].Exists(e.X, e.Y) && fruits[i].IsMoving())
                {
                    if (fruits[i] is BombBall)
                    {
                        showFruitTimer.Stop();
                        MessageBox.Show("Game over! Your score is " + scoreLabel.Text + "!");
                        var result = MessageBox.Show("Хотите начать заново?", "Игра окончена!",MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            Application.Restart();
                        }
                        if (result == DialogResult.No)
                        {
                            Application.Exit();
                        }

                    }
                    if (fruits[i] is BananaBall)
                    {
                       
                        foreach(var ball in fruits)
                        {
                            ball.Slow();
                        }

                    }
                    fruits[i].Stop();
                    fruits[i].Clear();
                    scoreLabel.Text = (Convert.ToInt32(scoreLabel.Text) + 1).ToString();

                }
            }

            
        }

        private void rulesButton_Click(object sender, EventArgs e)
        {
            Pause();
            
        }
        public void Pause()
        {
            showFruitTimer.Stop();
            
            var result = MessageBox.Show("Проведите по шарику мышкой, чтобы разрезать его. Если Вы разрежете банан - самый крупный желтый шарик - шарики на время замедлятся. Если разрежете бомбу - черный шарик - игра будет окончена.");
            if(result == DialogResult.OK)
            {
                showFruitTimer.Start();
            }

        }
    }
}
