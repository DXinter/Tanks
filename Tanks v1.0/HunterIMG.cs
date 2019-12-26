using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tanks
{
    class HunterIMG
    {
        Image[] up = new Image[] { Properties.Resources.Hunter0_1, Properties.Resources.Hunter0_1_1_, Properties.Resources.Hunter0_1_2_, Properties.Resources.Hunter0_1_3_ };
        Image[] down = new Image[] { Properties.Resources.Hunter01, Properties.Resources.Hunter01_1_, Properties.Resources.Hunter01_2_, Properties.Resources.Hunter01_3_ };
        Image[] right = new Image[] { Properties.Resources.Hunter10, Properties.Resources.Hunter10_1_, Properties.Resources.Hunter10_2_, Properties.Resources.Hunter10_3_ };
        Image[] left = new Image[] { Properties.Resources.Hunter_10, Properties.Resources.Hunter_10_1_, Properties.Resources.Hunter_10_2_, Properties.Resources.Hunter_10_3_ };

        public Image[] Up { get => up; }
        public Image[] Down { get => down; }
        public Image[] Right { get => right; }
        public Image[] Left { get => left; }
    }
}
