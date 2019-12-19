using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tanks_v1._0
{
    class FairTankIMG
    {
        Image[] fair = new Image[] { Properties.Resources.FairTank_1_, Properties.Resources.FairTank_2_, Properties.Resources.FairTank_3_, Properties.Resources.FairTank_4_, Properties.Resources.FairTank_5_ };
        public Image[] Fair { get => fair;}
    }
}
