using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tanks_v1._0
{
    class ProjectileIMG
    {
        Image up = Properties.Resources.Projective0_1;
        Image down = Properties.Resources.Projective01;
        Image left = Properties.Resources.Projective_10;
        Image right = Properties.Resources.Projective10;

        public Image Up { get => up; }
        public Image Down { get => down;}
        public Image Left { get => left; }
        public Image Right { get => right;}
    }
}
