using System;
using System.Drawing;
using System.Windows.Forms;

namespace BallsCommon
{
    public class Ball
    {
        protected float centerX = 150;
        protected float centerY = 150;
        protected int radius = 20;
        protected float vx = 1;
        protected float vy = 1;
        protected Brush color = Brushes.DarkSlateBlue;
        private Form form;
        protected Timer timer;

        public Ball(Form form)
        {
            this.form = form;
            timer = new Timer();
            timer.Interval = 20;
            timer.Tick += Timer_Tick;
        }
        protected virtual void Timer_Tick(object sender, EventArgs e)
        {
            Move();
        }
        public int Radius()
        {
            return radius;
        }
        public bool IsMoving()
        {
            return timer.Enabled;
        }
        public void Start()
        {

            timer.Start();
        }
        
        public void Stop()
        {
            timer.Stop();

        }
        public void Show()
        {
            Draw(color);
        }

        public void Move()
        {
            Clear();
            Go();
            Show();
        }

        public bool OnForm()
        {
            return centerX >= LeftSide() && centerY >= UpSide() && centerX <= RightSide() && centerY <= DownSide();
            
        }

        public bool OnLeft()
        {
            return centerX >= LeftSide() && centerX <= MiddleWidth();
        }
        
        public bool OnTop()
        {
            return centerY >= UpSide() && centerY <= MiddleHeight();

        }
        

        public bool Exists(int pointx, int pointy)
        {
           

            var dx = (pointx - centerX);
            var dy = (pointy - centerY);
            return dx * dx + dy * dy <= radius * radius;
        }
        protected virtual void Go()
        {
            centerX += vx;
            centerY += vy;
        }

        public void Clear()
        {
            
            var brush = new SolidBrush(form.BackColor);
            Draw(brush);
        }

        public int LeftSide()
        {
            return radius;
        }

        public int RightSide()
        {
            return form.ClientSize.Width - radius;
        }

        public int MiddleWidth()
        {
            return form.ClientSize.Width / 2;
        }

        public int MiddleHeight()
        {
            return form.ClientSize.Height / 2;
        }

        public int UpSide()
        {
            return radius;
        }
        public int DownSide()
        {
            return form.ClientSize.Height - radius;
        }
        private void Draw(Brush brush)
        {
            var graphics = form.CreateGraphics();
            
            var rectange = new RectangleF(centerX - radius, centerY - radius, radius * 2, radius * 2);
            graphics.FillEllipse(brush, rectange);
        }
    }
}
