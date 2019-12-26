namespace Tanks
{ 
    partial class ControllerMainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControllerMainForm));
            this.Helper_Ttip = new System.Windows.Forms.ToolTip(this.components);
            this.MainMenu_strpt = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.GameStatus_strt = new System.Windows.Forms.ToolStripStatusLabel();
            this.Start_Stop_pctBox1 = new System.Windows.Forms.PictureBox();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.soundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenu_strpt.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Start_Stop_pctBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Helper_Ttip
            // 
            this.Helper_Ttip.ToolTipTitle = "Tanks 1.0v";
            // 
            // MainMenu_strpt
            // 
            this.MainMenu_strpt.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.MainMenu_strpt.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.MainMenu_strpt.Location = new System.Drawing.Point(0, 0);
            this.MainMenu_strpt.Name = "MainMenu_strpt";
            this.MainMenu_strpt.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.MainMenu_strpt.Size = new System.Drawing.Size(344, 24);
            this.MainMenu_strpt.TabIndex = 1;
            this.MainMenu_strpt.Text = "menuStrip1";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.gameToolStripMenuItem.Text = "Game";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(128, 6);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.soundToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.infoToolStripMenuItem.Text = "Info";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GameStatus_strt});
            this.statusStrip1.Location = new System.Drawing.Point(0, 359);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(344, 22);
            this.statusStrip1.TabIndex = 2;
            // 
            // GameStatus_strt
            // 
            this.GameStatus_strt.ActiveLinkColor = System.Drawing.Color.Red;
            this.GameStatus_strt.BackColor = System.Drawing.SystemColors.Control;
            this.GameStatus_strt.Name = "GameStatus_strt";
            this.GameStatus_strt.Size = new System.Drawing.Size(0, 17);
            // 
            // Start_Stop_pctBox1
            // 
            this.Start_Stop_pctBox1.Image = global::Tanks.Properties.Resources._1486485577_314arrow_film_movie_play_player_start_video_81195;
            this.Start_Stop_pctBox1.Location = new System.Drawing.Point(268, 46);
            this.Start_Stop_pctBox1.Name = "Start_Stop_pctBox1";
            this.Start_Stop_pctBox1.Size = new System.Drawing.Size(64, 64);
            this.Start_Stop_pctBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Start_Stop_pctBox1.TabIndex = 0;
            this.Start_Stop_pctBox1.TabStop = false;
            this.Helper_Ttip.SetToolTip(this.Start_Stop_pctBox1, "Click to play the game");
            this.Start_Stop_pctBox1.Click += new System.EventHandler(this.StartStop_btn_Click);
            this.Start_Stop_pctBox1.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Start_Stop_pctBox1_PreviewKeyDown);
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Image = global::Tanks.Properties.Resources.gamecontroller_23721;
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.newGameToolStripMenuItem.Text = "New game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.NewGameToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::Tanks.Properties.Resources.Delete_80_icon_icons_com_57340;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // soundToolStripMenuItem
            // 
            this.soundToolStripMenuItem.Image = global::Tanks.Properties.Resources.audio_violume_sound_icon_124173;
            this.soundToolStripMenuItem.Name = "soundToolStripMenuItem";
            this.soundToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.soundToolStripMenuItem.Text = "Sound";
            this.soundToolStripMenuItem.Click += new System.EventHandler(this.SoundToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = global::Tanks.Properties.Resources.about_3697;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // ControllerMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(344, 381);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.Start_Stop_pctBox1);
            this.Controls.Add(this.MainMenu_strpt);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MainMenu_strpt;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(360, 420);
            this.MinimumSize = new System.Drawing.Size(360, 420);
            this.Name = "ControllerMainForm";
            this.Text = "Tanks";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ControllerMainForm_FormClosing);
            this.MainMenu_strpt.ResumeLayout(false);
            this.MainMenu_strpt.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Start_Stop_pctBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Start_Stop_pctBox1;
        private System.Windows.Forms.ToolTip Helper_Ttip;
        private System.Windows.Forms.MenuStrip MainMenu_strpt;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem soundToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel GameStatus_strt;
    }
}

