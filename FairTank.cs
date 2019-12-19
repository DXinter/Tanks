using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tanks_v1._0
{
    class FairTank
    {
        FairTankIMG FairtankIMG = new FairTankIMG();
        Image currentImg;
        Image[] img;
        int x, y;
        public int X { get => x; }
        public int Y { get => y; }
        public Image CurrentImg { get => currentImg; }

        public FairTank(int x_Tanks, int y_Tanks)
        {
            x = x_Tanks;
            y = y_Tanks;
            img = FairtankIMG.Fair;
            PutCurrentImg();
        }

        int k;
        protected void PutCurrentImg()
        {
            currentImg = img[k];
            k++;
            if (k == 5)
                k = 0;
        }
        public void Fair()
        {
            PutCurrentImg();
        }

    }
}
