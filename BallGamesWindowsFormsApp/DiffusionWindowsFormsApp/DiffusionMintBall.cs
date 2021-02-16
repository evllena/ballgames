using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BallsCommon;

namespace DiffusionWindowsFormsApp
{
    class DiffusionMintBall: BilliardBall
    {
        public DiffusionMintBall(Form form) : base(form)
        {
            color = Brushes.DarkCyan;
            centerX = random.Next(MiddleWidth(), RightSide() );
        }
    }
}
