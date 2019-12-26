using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Tanks
{
    class Tank : IRun, ITurn, ITransparent, ICurrentPictures, ITurnAround
    {
        private TanksIMG tanksIMG = new TanksIMG();        
        private void putImg()
        {
            if (direct_x == 1)
                img = tanksIMG.Right;
            if (direct_x == -1)
                img = tanksIMG.Left;
            if (direct_y == 1)
                img = tanksIMG.Down;
            if (direct_y == -1)
                img = tanksIMG.Up;

        }

        protected Image[] img;
        protected Image currentImg;
        protected int sizeField;
        protected static Random r;
        protected int x,y, direct_x, direct_y;
        protected int k;
        protected void PutCurrentImg()
        {
             currentImg = img[k];
            k++;
            if (k == 4)
                k = 0; 
        }


        public Tank(int sizeField, int x, int y)
        {
            this.sizeField = sizeField;
            r = new Random();
             if (r.Next(5000) < 2500)
            {
                Direct_y = 0;
                loop:
                Direct_x = r.Next(-1, 2);
                if (Direct_x == 0)
                    goto loop;
            }
            else
            {
                Direct_x = 0;
                loop:
                Direct_y = r.Next(-1, 2);
                if (Direct_y == 0)
                    goto loop;
            }
 
            putImg();

            PutCurrentImg();
            this.x = x;
            this.y = y;

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
        public Image CurrentImg { get => currentImg; }
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
                if (r.Next(5000) < 2500)//движение по вертикали
                {
                    if (Direct_y == 0)        
                    {
                        direct_x = 0;
                        while (Direct_y == 0)
                            Direct_y = r.Next(-1, 2);
                    }
                }
                else//двигаемся по горизонтали
                {
                    if (Direct_x == 0)
                    
                    {
                        direct_y = 0;
                        while (Direct_x == 0)
                            Direct_x = r.Next(-1, 2);
                    }
                }
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
        public void TurnAround()
        {
            Direct_x = -1 * Direct_x;
            Direct_y = -1 * Direct_y;
            putImg();
        }
    }
}
