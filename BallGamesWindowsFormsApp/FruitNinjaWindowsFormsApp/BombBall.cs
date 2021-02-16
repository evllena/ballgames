using System.Drawing;
using System.Windows.Forms;

namespace FruitNinjaWindowsFormsApp
{
    class BombBall : FruitBall
    {
        public BombBall(Form form) : base(form)
        {
            color = new SolidBrush(Color.Black);
            radius = 25;
        }
    }
}
