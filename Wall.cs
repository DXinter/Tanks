using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tanks_v1._0
{
    class Wall: IPicture
    {
        WallImg wallImg = new WallImg();
        Image img;
        public Wall()
        {
            img = wallImg.Img;
        }

        public Image CurrentImg
        {
            get => img;
        }
    }
}
