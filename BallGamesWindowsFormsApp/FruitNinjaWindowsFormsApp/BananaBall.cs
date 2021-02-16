using System.Drawing;
using System.Windows.Forms;

namespace FruitNinjaWindowsFormsApp
{
    class BananaBall: FruitBall
    {
        public BananaBall(Form form) : base(form)
        {
            color = new SolidBrush(Color.Yellow);
            radius = 35;
        }
    }
}
