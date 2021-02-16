using BallsCommon;
using System.Drawing;
using System.Windows.Forms;

namespace FruitNinjaWindowsFormsApp
{
    class FruitBall : MoveBall
    {
        private float g = 0.1f;

        public FruitBall(Form form) : base(form)
        {

            centerY = DownSide() + radius;
            vy = -((float)(random.NextDouble() * 8 + 5));

            radius = random.Next(20, 30);

            color = new SolidBrush(Color.FromArgb(random.Next(1, 255), random.Next(1, 255), random.Next(1, 255)));

        }

        protected override void Go()
        {
            base.Go();
            vy += g;
        }

        public void Slow()
        {
            timer.Interval = 100;
        }
        
    }
}
