using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace Tanks
{
    delegate void Invoker();
    public partial class ControllerMainForm : Form
    {      
        View view;
        Model model;
        Thread modelPlay;
        bool isSound;
        SoundPlayer sp;
        string abaut = "Game of Tanks version 1.0\n" +
                "Developer Xinter Daniil.\n" +
                "Controls 'A','S','D','W'; 'F' - Fire" + "Tanks v1.0";

        public ControllerMainForm() : this(300) { }
        public ControllerMainForm(int sizeField): this(sizeField,5) { }
        public ControllerMainForm(int sizeField, int amountTanks) :this(sizeField,amountTanks, 5){ }
        public ControllerMainForm(int sizeField, int amountTanks, int amountApples) : this(sizeField, amountTanks, amountApples, 30) { }
        public ControllerMainForm(int sizeField, int amountTanks, int amountApples, int speedGame)
        {
            InitializeComponent();
            model = new Model(sizeField,amountTanks,amountApples,speedGame);
            model.changeStreep += new STREEP(ChangerStatusLabel);
            isSound =true;
            view = new View(model);
          
            this.Controls.Add(view);         
            sp = new SoundPlayer(Properties.Resources.TankMove1);
        }     
        void ChangerStatusLabel()
        {
            Invoke(new Invoker(SetValueToStrLb1));          
        }
        private void SetValueToStrLb1()
        {
            GameStatus_strt.Text = model.gameStatus.ToString();
            if (isSound)
            {
                if (model.gameStatus == GameStatus.Playing)
                    sp.PlayLooping();
                else
                    sp.Stop();
            }
                        
        }

        private void StartStop_btn_Click(object sender, EventArgs e)
        {
            if (model.gameStatus == GameStatus.Playing)
            {
                modelPlay.Abort();
                model.gameStatus = GameStatus.Stoping;
                Start_Stop_pctBox1.Image = Properties.Resources._1486485577_314arrow_film_movie_play_player_start_video_81195;
                ChangerStatusLabel();
            }
            else
            {
                Start_Stop_pctBox1.Focus();
                model.gameStatus = GameStatus.Playing;
                modelPlay = new Thread(model.Play);
                modelPlay.Start();
                Start_Stop_pctBox1.Image = Properties.Resources.stop_23748;
                ChangerStatusLabel();
                view.Invalidate();
            }
        }
        private void ControllerMainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (modelPlay != null)
            {
                model.gameStatus = GameStatus.Stoping;
                modelPlay.Abort();
            }

            ExitForm(e);
        }

        private static void ExitForm(FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Приложение будет закрыто. Вы уверены?", "Tanks", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
                e.Cancel = false;
            else
                e.Cancel = true;
        }

        private void Start_Stop_pctBox1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyData.ToString())
            {
                case "A":
                    {
                        model.Predator.NextDirect_x = -1;
                        model.Predator.NextDirect_y = 0;
                    }
                    break;
                case "D":
                    {
                        model.Predator.NextDirect_x = 1;
                        model.Predator.NextDirect_y = 0;
                    }
                    break;
                case "W":
                    {
                        model.Predator.NextDirect_x = 0;
                        model.Predator.NextDirect_y = -1;
                    }
                    break;
                case "S":
                    {
                        model.Predator.NextDirect_x = 0;
                        model.Predator.NextDirect_y = 1;
                    }
                    break;
                case "F":
                    {
                        SetProjectile();
                    }
                    break;
            }
        }

        private void SetProjectile()
        {
            //направление танка
            model.Projectile.Direct_x = model.Predator.Direct_x;
            model.Projectile.Direct_y = model.Predator.Direct_y;

            //направление пули
            if (model.Predator.Direct_y == -1)
            {
                model.Projectile.X = model.Predator.X + 10;
                model.Projectile.Y = model.Predator.Y;
            }
            if (model.Predator.Direct_y == 1)
            {
                model.Projectile.X = model.Predator.X + 10;
                model.Projectile.Y = model.Predator.Y + 20;
            }

            if (model.Predator.Direct_x == -1)
            {
                model.Projectile.X = model.Predator.X;
                model.Projectile.Y = model.Predator.Y + 10;
            }
            if (model.Predator.Direct_x == 1)
            {
                model.Projectile.X = model.Predator.X + 20;
                model.Projectile.Y = model.Predator.Y + 10;
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NewGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            model.NewGame();
            Start_Stop_pctBox1.Image = Properties.Resources._1486485577_314arrow_film_movie_play_player_start_video_81195;
            view.Invalidate();
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(abaut,"Info",MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void SoundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isSound = !isSound;
            if (isSound)
                soundToolStripMenuItem.Image = global::Tanks.Properties.Resources.audio_violume_sound_icon_124173;
            else
                soundToolStripMenuItem.Image = global::Tanks.Properties.Resources.sound_mute;
        }
    }
}
