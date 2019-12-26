using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tanks
{
    class TanksIMG
    {
        Image[] up = new Image[] { Properties.Resources.Tank0_1, Properties.Resources.Tank0_1_1_,Properties.Resources.Tank0_1_2_,Properties.Resources.Tank0_1_3_};
        Image[] down = new Image[] { Properties.Resources.Tank01, Properties.Resources.Tank01_1_,Properties.Resources.Tank01_2_,Properties.Resources.Tank01_3_};
        Image[] right = new Image[] { Properties.Resources.Tank10, Properties.Resources.Tank10_1_, Properties.Resources.Tank10_2_,Properties.Resources.Tank10_3_ };
        Image[] left = new Image[] { Properties.Resources.Tank_10, Properties.Resources.Tank_10_1_,Properties.Resources.Tank_10_2_,Properties.Resources.Tank_10_3_ };

        public Image[] Up { get => up;}
        public Image[] Down { get => down;}
        public Image[] Right { get => right;}
        public Image[] Left { get => left;}
    }
}
