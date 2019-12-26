using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tanks
{
    class ThePredator: IRun, ITurn, ITransparent, ICurrentPictures
    {
        PredatorIMG predatorIMG = new PredatorIMG();
        Image[] img;
        Image currentImg;

        public Image CurrentImg { get => currentImg; }

        int sizeField;

        int x, y, direct_x, direct_y, nextDirect_x, nextDirect_y;

        public ThePredator(int sizeField)
        {
            this.sizeField = sizeField;
            this.y = 280;
            this.x = 120;

            this.NextDirect_y = -1;           
            this.Direct_y = -1;
            this.Direct_x = 0;

            putImg();
            PutCurrentImg();
  
        }

        public int X { get => x; }
        public int Y { get => y; }
        public int Direct_x
        {
            get => direct_x;
            set
            {
                if (value == 0 || value == 1 || value == -1)
                    direct_x = value;
                else
                    direct_x = 0;
            }
        }
        public int Direct_y
        {
            get => direct_y;
            set
            {
                if (value == 0 || value == 1 || value == -1)
                    direct_y = value;
                else
                    direct_y = 0;
            }

        }

        public int NextDirect_x { get => nextDirect_x; set
            {
                if (value == 0 || value == 1 || value == -1)
                    nextDirect_x = value;
                else
                    nextDirect_x = 0;
            }
        }
        public int NextDirect_y { get => nextDirect_y; set
            {
                if (value == 0 || value == 1 || value == -1)
                    nextDirect_y = value;
                else
                    nextDirect_y = 0;
            }
        }

        int k;
        private void PutCurrentImg()
        {
            currentImg = img[k];
            k++;
            if (k == 4)
                k = 0;
        }
        void putImg()
        {
            if (direct_x == 1)
                img = predatorIMG.Right;
            if (direct_x == -1)
                img = predatorIMG.Left;
            if (direct_y == 1)
                img = predatorIMG.Down;
            if (direct_y == -1)
                img = predatorIMG.Up;
        }
        public void Run()
        {
            x += direct_x;
            y += direct_y;
            if (Math.IEEERemainder(x, 40) == 0 && Math.IEEERemainder(y, 40) == 0)
                Turn();

            PutCurrentImg();
            Transparent();
        }
        public void Turn()
        {
            Direct_x = NextDirect_x;
            Direct_y = NextDirect_y;
            putImg();
        }
        public void Transparent()
        {
            if (x == -1)
                x = sizeField - 21;
            if (x == sizeField - 19)
                x = 1;

            if (y == -1)
                y = sizeField - 21;
            if (y == sizeField - 19)
                y = 1;
        }

    }
}
