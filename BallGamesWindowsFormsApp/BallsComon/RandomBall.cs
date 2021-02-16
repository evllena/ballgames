using System;
using System.Windows.Forms;

namespace BallsCommon
{
    public class RandomBall: Ball
    {
        protected static Random random = new Random();
        public RandomBall(Form form):base(form)
        {
            
            centerX = random.Next(LeftSide(), RightSide());
            centerY = random.Next(UpSide(), DownSide());
            

        }

    }
}
