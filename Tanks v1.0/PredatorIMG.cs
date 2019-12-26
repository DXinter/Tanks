using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tanks
{
    class PredatorIMG
    {
        Image[] up = new Image[] { Properties.Resources.ThePredator0_1, Properties.Resources.ThePredator0_1_1_, Properties.Resources.ThePredator0_1_2_, Properties.Resources.ThePredator0_1_3_ };
        Image[] down = new Image[] { Properties.Resources.ThePredator01, Properties.Resources.ThePredator01_1_, Properties.Resources.ThePredator01_2_, Properties.Resources.ThePredator01_3_ };
        Image[] right = new Image[] { Properties.Resources.ThePredator10, Properties.Resources.ThePredator10_1_, Properties.Resources.ThePredator10_2_, Properties.Resources.ThePredator10_3_ };
        Image[] left = new Image[] { Properties.Resources.ThePredator_10, Properties.Resources.ThePredator_10_1_, Properties.Resources.ThePredator_10_2_, Properties.Resources.ThePredator_10_3_ };

        public Image[] Up { get => up; }
        public Image[] Down { get => down; }
        public Image[] Right { get => right; }
        public Image[] Left { get => left; }
    }
}
