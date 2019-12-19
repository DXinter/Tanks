using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tanks_v1._0
{
    class Hunter : Tank
    {        
        HunterIMG hunterIMG = new HunterIMG();      
        private void putImg()
        {
            if (direct_x == 1)
                img = hunterIMG.Right;
            if (direct_x == -1)
                img = hunterIMG.Left;
            if (direct_y == 1)
                img = hunterIMG.Down;
            if (direct_y == -1)
                img = hunterIMG.Up;
        }

         public void Turn(int Predator_x, int Predator_y)
         {
            Direct_x = Direct_y = 0;

            if (X > Predator_x)
                Direct_x = -1;
            if (X < Predator_x)
                Direct_x = 1;
            if (Y > Predator_y)
                Direct_y = -1;
            if (Y < Predator_y)
                Direct_y = 1;

            if (Direct_x != 0 && Direct_y != 0)           
                if (r.Next(5000) < 2500)
                Direct_x = 0;
            else
                Direct_y = 0;

            putImg();
         }
         public void Run(int Predator_x, int Predator_y)
         {     
            x += direct_x;
            y += direct_y;
            if (Math.IEEERemainder(x, 40) == 0 && Math.IEEERemainder(y, 40) == 0)
                Turn(Predator_x,Predator_y);

            PutCurrentImg();
            Transparent();
         }
              
        public Hunter(int sizeField, int x, int y) : base(sizeField, x, y)
        {
            putImg(); PutCurrentImg();
        }
        new public void TurnAround()
        {
            Direct_x = -1 * Direct_x;
            Direct_y = -1 * Direct_y;
            putImg();
        }
    }
}
