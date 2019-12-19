using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tanks_v1._0
{
    class Apple : IPicture
    {
        AppleImg appleImg = new AppleImg();
        Image currentImg;
        int x, y;

        public Apple(int x, int y)
        {
            currentImg = appleImg.Img;
            this.x = x;
            this.y = y;
        }

        public Image CurrentImg
        {
            get => currentImg;
        }
        public int Y { get => y;}
        public int X { get => x;}
    }
}
