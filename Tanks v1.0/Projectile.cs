using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tanks
{
    class Projectile
    {
        private ProjectileIMG projectileIMG = new ProjectileIMG();
        private int directKM;
        int x, y, direct_x, direct_y;
        private Image currentImg;
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
        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
        public Image CurrentImg { get => currentImg; }
        public Projectile()
        {
            currentImg = projectileIMG.Up;
            defaultSettings();
        }

        public void defaultSettings()
        {
            directKM = 0;
            x = y = -10;
            Direct_x = Direct_y = 0;           
        }

        public void Run()
        {
            if (Direct_x == 0 && Direct_y == 0)
                return;

            directKM += 3;
            putImg();
            x += Direct_x * 3;
            y += Direct_y * 3;

            if (directKM > 160)
            {
                defaultSettings();
            }

        }
        private void putImg()
        {
                if (direct_x == 1)
                    currentImg = projectileIMG.Right;
                if (direct_x == -1)
                    currentImg = projectileIMG.Left;
                if (direct_y == 1)
                    currentImg = projectileIMG.Down;
                if (direct_y == -1)
                    currentImg = projectileIMG.Up;
        }
    }
}
