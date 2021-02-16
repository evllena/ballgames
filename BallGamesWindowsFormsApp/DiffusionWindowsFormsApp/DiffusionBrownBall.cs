using BallsCommon;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace DiffusionWindowsFormsApp
{
    public class DiffusionBrownBall : BilliardBall
    {
        public int leftBrownCount;
        public int rightBrownCount;
        public DiffusionBrownBall(Form form) : base(form)
        {
            color = Brushes.Sienna;
            centerX = random.Next(LeftSide(), MiddleWidth());
        }
        
    }

}
