namespace Lecteurmp32
{
    partial class mouk
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mouk));
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.next_button = new System.Windows.Forms.Button();
            this.play_button = new System.Windows.Forms.Button();
            this.Pause_button = new System.Windows.Forms.Button();
            this.stop_button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pBar = new System.Windows.Forms.ProgressBar();
            this.track_list = new System.Windows.Forms.ListBox();
            this.pic_Art = new System.Windows.Forms.PictureBox();
            this.track_Volume = new System.Windows.Forms.TrackBar();
            this.label_volume = new System.Windows.Forms.Label();
            this.start_song_label = new System.Windows.Forms.Label();
            this.end_song_label = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Art)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_Volume)).BeginInit();
            this.SuspendLayout();
            // 
            // axWindowsMediaPlayer1
            // 
            resources.ApplyResources(this.axWindowsMediaPlayer1, "axWindowsMediaPlayer1");
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Enter += new System.EventHandler(this.axWindowsMediaPlayer1_Enter);
            // 
            // next_button
            // 
            resources.ApplyResources(this.next_button, "next_button");
            this.next_button.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.next_button.Name = "next_button";
            this.next_button.UseVisualStyleBackColor = true;
            this.next_button.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // play_button
            // 
            resources.ApplyResources(this.play_button, "play_button");
            this.play_button.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.play_button.Name = "play_button";
            this.play_button.UseVisualStyleBackColor = true;
            this.play_button.Click += new System.EventHandler(this.play_button_Click);
            // 
            // Pause_button
            // 
            resources.ApplyResources(this.Pause_button, "Pause_button");
            this.Pause_button.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Pause_button.Name = "Pause_button";
            this.Pause_button.UseVisualStyleBackColor = true;
            this.Pause_button.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // stop_button
            // 
            resources.ApplyResources(this.stop_button, "stop_button");
            this.stop_button.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.stop_button.Name = "stop_button";
            this.stop_button.UseVisualStyleBackColor = true;
            this.stop_button.Click += new System.EventHandler(this.stop_button_Click);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_3);
            // 
            // pBar
            // 
            resources.ApplyResources(this.pBar, "pBar");
            this.pBar.Name = "pBar";
            // 
            // track_list
            // 
            this.track_list.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.track_list.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.track_list.FormattingEnabled = true;
            resources.ApplyResources(this.track_list, "track_list");
            this.track_list.Name = "track_list";
            this.track_list.SelectedIndexChanged += new System.EventHandler(this.track_list_SelectedIndexChanged);
            // 
            // pic_Art
            // 
            resources.ApplyResources(this.pic_Art, "pic_Art");
            this.pic_Art.Name = "pic_Art";
            this.pic_Art.TabStop = false;
            this.pic_Art.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // track_Volume
            // 
            resources.ApplyResources(this.track_Volume, "track_Volume");
            this.track_Volume.Maximum = 100;
            this.track_Volume.Name = "track_Volume";
            this.track_Volume.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.track_Volume.Scroll += new System.EventHandler(this.track_Volume_Scroll);
            // 
            // label_volume
            // 
            resources.ApplyResources(this.label_volume, "label_volume");
            this.label_volume.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_volume.Name = "label_volume";
            this.label_volume.Click += new System.EventHandler(this.label1_Click);
            // 
            // start_song_label
            // 
            resources.ApplyResources(this.start_song_label, "start_song_label");
            this.start_song_label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.start_song_label.Name = "start_song_label";
            // 
            // end_song_label
            // 
            resources.ApplyResources(this.end_song_label, "end_song_label");
            this.end_song_label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.end_song_label.Name = "end_song_label";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // mouk
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.end_song_label);
            this.Controls.Add(this.start_song_label);
            this.Controls.Add(this.label_volume);
            this.Controls.Add(this.track_Volume);
            this.Controls.Add(this.pic_Art);
            this.Controls.Add(this.track_list);
            this.Controls.Add(this.pBar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.stop_button);
            this.Controls.Add(this.Pause_button);
            this.Controls.Add(this.play_button);
            this.Controls.Add(this.next_button);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "mouk";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Art)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_Volume)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Button next_button;
        private System.Windows.Forms.Button play_button;
        private System.Windows.Forms.Button Pause_button;
        private System.Windows.Forms.Button stop_button;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ProgressBar pBar;
        private System.Windows.Forms.ListBox track_list;
        private System.Windows.Forms.PictureBox pic_Art;
        private System.Windows.Forms.TrackBar track_Volume;
        private System.Windows.Forms.Label label_volume;
        private System.Windows.Forms.Label start_song_label;
        private System.Windows.Forms.Label end_song_label;
        private System.Windows.Forms.Timer timer1;
    }
}

