using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Tanks
{
    public delegate void STREEP();
    class Model
    {
        public event STREEP changeStreep;

        int collectedAplles;
        public int sizeField, amountTanks, amountApples, speedGame;
        List <Tank> tanks;

        public GameStatus gameStatus;
        public Wall wall;
        List<Apple> apples;
        List<FairTank> fairtank;

        Random r;
        ThePredator predator;
        Projectile projectile;
        
        internal List<Tank> Tanks { get => tanks; }
        internal List<Apple> Apples { get => apples;}

        internal ThePredator Predator { get => predator;}
        internal Projectile Projectile { get => projectile; }
        internal List<FairTank> Fairtank { get => fairtank;}

        public Model(int sizeField, int amountTanks, int amountApples, int speedGame)
        {
            r = new Random();
            
            this.sizeField = sizeField;
            this.amountTanks = amountTanks;
            this.amountApples = amountApples;
            this.speedGame = speedGame;

            NewGame();                 
        }
        public void Play()
        {
            while (gameStatus == GameStatus.Playing)
            {
                Thread.Sleep(speedGame);

                RunAllObjectsOnField();
                DestyroyTanks();
                CollisionOfTanks();
                CollisionOfPlayer();
                TakeApples();
                CollectApllesAndWin();

            }

        }
        private void CreateApples()
        {
            CreateApples(0);
        }
        private void CreateApples(int newApples)
        {
            int x, y;
            while (apples.Count < amountApples + newApples)
            {
                x = r.Next(6) * 40;
                y = r.Next(7) * 40;
                bool flag = true;
                foreach(Apple a in apples)
                    if (a.X == x && a.Y == y)
                    {
                        flag = false;
                        break;
                    }
                if (flag == true)
                    apples.Add(new Apple(x, y));
            }
        }
        private void CreateTanks()
        {           
            int x,y;
            while (tanks.Count < amountTanks + 1)
            {
                if (tanks.Count == 0)
                    tanks.Add(new Hunter(sizeField, r.Next(6) * 40, r.Next(8) * 40));
                x = r.Next(6) * 40;
                y = r.Next(7) * 40;

                bool flag = true;

                foreach (Tank t in tanks)
                    if (t.X == x && t.Y == y)
                    {
                        flag = false;
                        break;
                    }
                if (flag == true)
                    tanks.Add(new Tank(sizeField, x, y));
            }
        }      
        private void RunAllObjectsOnField()
        {
            projectile.Run();
            predator.Run();
            ((Hunter)tanks[0]).Run(predator.X, predator.Y);

            for (int i = 1; i < tanks.Count; i++)
                tanks[i].Run();

            foreach (FairTank ft in Fairtank)
                ft.Fair();
        }
        private void CollectApllesAndWin()
        {
            if (collectedAplles > 20)
            {
                gameStatus = GameStatus.Winner;
                changeStreep?.Invoke();
            }
        }
        private void TakeApples()
        {
            for (int i = 0; i < apples.Count; i++)//столкновение яблок с игроком
                if (Math.Abs(predator.X - apples[i].X) < 4 && Math.Abs(predator.Y - apples[i].Y) < 4)
                {
                    apples[i] = new Apple(step += 20, 300);
                    CreateApples(++collectedAplles);
                }
        }
        private void CollisionOfPlayer()
        {
            for (int i = 0; i < tanks.Count; i++) // столкновение танков с игроком
                if (
                      (Math.Abs(tanks[i].X - predator.X) <= 19 && (tanks[i].Y == predator.Y))
                      ||
                      (Math.Abs(tanks[i].Y - predator.Y) <= 19 && (tanks[i].X == predator.X))
                      ||
                      (Math.Abs(tanks[i].X - predator.X) <= 19 && Math.Abs(tanks[i].Y - predator.Y) <= 19)
                       )
                {
                    gameStatus = GameStatus.Loser;
                    changeStreep?.Invoke();
                }
        }
        private void CollisionOfTanks()
        {
            for (int i = 0; i < tanks.Count - 1; i++)// столкновение танков
                for (int j = i + 1; j < tanks.Count; j++)
                    if (
                       (Math.Abs(tanks[i].X - tanks[j].X) <= 20 && (tanks[i].Y == tanks[j].Y))
                       ||
                       (Math.Abs(tanks[i].Y - tanks[j].Y) <= 20 && (tanks[i].X == tanks[j].X))
                       ||
                       (Math.Abs(tanks[i].X - tanks[j].X) <= 20 && Math.Abs(tanks[i].Y - tanks[j].Y) <= 20)
                        )
                    {
                        if (i == 0)
                            ((Hunter)tanks[i]).TurnAround();
                        else
                            tanks[i].TurnAround();

                        tanks[j].TurnAround();
                    }
        }
        private void DestyroyTanks()
        {
            for (int i = 1; i < tanks.Count; i++)// крутим с одного ибо 0 элемент = это хантер, он не попадает под пули
                if ((projectile.X - tanks[i].X) < 15 && (projectile.Y - tanks[i].Y) < 15// столкновение с пулей
                    && (projectile.X - tanks[i].X) > 6 && (projectile.Y - tanks[i].Y) > 7)
                {
                    Fairtank.Add(new FairTank(tanks[i].X, tanks[i].Y));
                    tanks.RemoveAt(i);
                    projectile.defaultSettings();
                }
        }

        int step;
        internal void NewGame()
        {
            step = -20;
            collectedAplles = 0;
            predator = new ThePredator(sizeField);
            projectile = new Projectile();

            tanks = new List<Tank>();
            apples = new List<Apple>();
            fairtank = new List<FairTank>();

            CreateTanks();
            CreateApples();

            wall = new Wall();

            gameStatus = GameStatus.Stoping;
        }
    }
}
