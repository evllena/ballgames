using System.Windows.Forms;

namespace BallsCommon
{

    public class MoveBall: RandomBall
    {
        protected int min = 2;
        protected int max = 4;

        public MoveBall(Form form) :base(form)
        {
            vx = GenerateRandomProjection();
            vy = GenerateRandomProjection();
        }
        
        protected virtual int GenerateRandomProjection()
        {
            double randomDouble = random.NextDouble();
            var sign = 1;
            if (randomDouble < 0.5)
            {
                sign = -1;
            }
            return random.Next(min, max) * sign;
        }
        
    }
}
