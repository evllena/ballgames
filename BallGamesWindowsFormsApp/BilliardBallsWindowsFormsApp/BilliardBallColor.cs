using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BallsCommon;

namespace BilliardBallsWindowsFormsApp
{

    public class BilliardBallColor : BilliardBall
    {
        
        public BilliardBallColor(Form form) : base(form)
        {

        }
        protected override void Go()
        {
            base.Go();
            if (centerX <= LeftSide())
            {
                
                ChangeBallColor();
                
            }
            if (centerX >= RightSide())
            {
                
                ChangeBallColor();
                
            }
            if (centerY <= UpSide())
            {
                
                ChangeBallColor();
                
            }
            if (centerY >= DownSide())
            {
                
                ChangeBallColor();
               
            }
        }

        private void ChangeBallColor()
        {
            color = new SolidBrush(Color.FromArgb(random.Next(256), random.Next(256),random.Next(256)));
        }
    }
}
