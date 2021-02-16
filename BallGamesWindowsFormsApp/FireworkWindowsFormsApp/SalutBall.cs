using System;
using System.Drawing;
using System.Windows.Forms;
using BallsCommon;

namespace FireworkWindowsFormsApp
{
    public class SalutBall : MoveBall
    {
        private float g = 0.125f;
        public SalutBall(Form form, float centerX, float centerY) : base(form)
        {
            this.centerX = centerX;
            this.centerY = centerY;
            vy = -Math.Abs(vy);
            
            radius = 12;

            color = new SolidBrush(Color.FromArgb(random.Next(255), random.Next(255), random.Next(255)));
        }

        protected override void Go()
        {
            base.Go();
            vy += g;
        }
        
    }

}
