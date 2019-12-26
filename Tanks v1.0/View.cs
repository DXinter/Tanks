using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Tanks
{
     partial class View : UserControl
    {
        Model model;
        public View(Model model)
        {
            InitializeComponent();
            this.model = model;

        }
        void Draw(PaintEventArgs e)// метод отвечает за прорисовку графики
        {
            DrawWall(e);
            DrawApples(e);
            DrawFairTank(e);        
            DrawTank(e);        
            DrawPredator(e);
            DrawProjectile(e);
            
       
           if (model.gameStatus != GameStatus.Playing)            
               return;     
            Thread.Sleep(model.speedGame);
            Invalidate();

        }

        private void DrawFairTank(PaintEventArgs e)
        {
            foreach (FairTank ft in model.Fairtank)
                e.Graphics.DrawImage(ft.CurrentImg, new Point(ft.X, ft.Y));
        }

        private void DrawProjectile(PaintEventArgs e)
        {
            e.Graphics.DrawImage(model.Projectile.CurrentImg, new Point(model.Projectile.X, model.Projectile.Y));
        }

        private void DrawPredator(PaintEventArgs e)
        {
            e.Graphics.DrawImage(model.Predator.CurrentImg, new Point(model.Predator.X, model.Predator.Y));
        }

        private void DrawApples(PaintEventArgs e)
        {
            for (int i = 0; i < model.Apples.Count; i++)
                e.Graphics.DrawImage(model.Apples[i].CurrentImg, new Point(model.Apples[i].X, model.Apples[i].Y));           
        }

        private void DrawTank(PaintEventArgs e)
        {
            for (int i = 0; i < model.Tanks.Count; i++)
            e.Graphics.DrawImage(model.Tanks[i].CurrentImg, new Point(model.Tanks[i].X, model.Tanks[i].Y));
        }
        private void DrawWall(PaintEventArgs e)
        {
             for (int y = 20; y <300; y += 40)
                for (int x = 20; x < 240; x += 40)
                    e.Graphics.DrawImage(model.wall.CurrentImg, new Point(x, y));// выводим стены  
        }
        protected override void OnPaint(PaintEventArgs e)// переопределенный метод паинт
        {
            Draw(e);           
        }       
    }
}
