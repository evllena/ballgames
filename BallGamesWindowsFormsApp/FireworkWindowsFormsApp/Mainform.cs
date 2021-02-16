using System;
using System.Drawing;
using System.Windows.Forms;

namespace FireworkWindowsFormsApp
{
    public partial class MainForm : Form
    {
        private FirstSalutBall firstSalut;
        private Timer firingTimer = new Timer();
        static Random random = new Random();

        public MainForm()
        {
            InitializeComponent();
            
            firingTimer.Interval = 100;
            firingTimer.Tick += FiringTimer_Tick;
            firingTimer.Start();
        }

        private void FiringTimer_Tick(object sender, EventArgs e)
        {
            firstSalut = new FirstSalutBall(this);
            firstSalut.OnEndFiring += FirstBall_OnEndFiring;
            firstSalut.Start();

            firingTimer.Interval = random.Next(500, 1000);
        }


        private void FirstBall_OnEndFiring(object sender, PointF e)
        {
            
            
            var random = new Random();
            var count = random.Next(8, 20);

            for (int i = 0; i < count; i++)
            {
                var salut = new SalutBall(this, e.X, e.Y);
                salut.Start();
            }
            
        }
    }
}
