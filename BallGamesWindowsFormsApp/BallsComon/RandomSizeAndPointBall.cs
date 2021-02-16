using System.Windows.Forms;

namespace BallsCommon
{
    public class RandomSizeAndPointBall : RandomBall
    {
        
        public RandomSizeAndPointBall(Form form) : base(form)
        {
            radius = random.Next(5, 50);

        }

    }
}
