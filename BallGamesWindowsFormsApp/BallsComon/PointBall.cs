using System.Windows.Forms;

namespace BallsCommon
{
    public class PointBall : Ball
    {
        
        public PointBall(Form form, int x, int y): base(form)
        {
            centerX = x;
            centerY = y;
        }

    }
}
