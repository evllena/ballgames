using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BallsCommon;

namespace FireworkWindowsFormsApp
{
    class FirstSalutBall : RandomBall
    {
        public event EventHandler<PointF> OnEndFiring;
        public FirstSalutBall(Form form) : base(form)
        {
            radius = 12;
            centerY = DownSide()+radius;
            vx = 0;
            vy = -3;
            color = new SolidBrush(Color.DarkGray);

        }
        protected override void Go()
        {
            base.Go();
            if(centerY < MiddleHeight())
            {
                Stop();
                Clear();
                OnEndFiring(this, new PointF(centerX, centerY));
            }
        }
    }
}
