namespace ReproductorMp3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            findArchive = new Button();
            listMusic = new ListBox();
            btnPlayMusic = new Button();
            btnPause = new Button();
            barProgress = new TrackBar();
            timerMusic = new System.Windows.Forms.Timer(components);
            lblTimerSong = new Label();
            lblSongDuration = new Label();
            btnQuitMusic = new Button();
            ((System.ComponentModel.ISupportInitialize)barProgress).BeginInit();
            SuspendLayout();
            // 
            // findArchive
            // 
            findArchive.Location = new Point(260, 51);
            findArchive.Name = "findArchive";
            findArchive.Size = new Size(75, 23);
            findArchive.TabIndex = 0;
            findArchive.Text = "Archive";
            findArchive.UseVisualStyleBackColor = true;
            findArchive.Click += findArchive_Click;
            // 
            // listMusic
            // 
            listMusic.FormattingEnabled = true;
            listMusic.ItemHeight = 15;
            listMusic.Location = new Point(125, 80);
            listMusic.Name = "listMusic";
            listMusic.Size = new Size(336, 229);
            listMusic.TabIndex = 1;
            listMusic.SelectedIndexChanged += listMusic_SelectedIndexChanged;
            // 
            // btnPlayMusic
            // 
            btnPlayMusic.Location = new Point(260, 315);
            btnPlayMusic.Name = "btnPlayMusic";
            btnPlayMusic.Size = new Size(75, 23);
            btnPlayMusic.TabIndex = 2;
            btnPlayMusic.Text = "Play";
            btnPlayMusic.UseVisualStyleBackColor = true;
            btnPlayMusic.Click += btnPlayMusic_Click;
            // 
            // btnPause
            // 
            btnPause.Location = new Point(125, 315);
            btnPause.Name = "btnPause";
            btnPause.Size = new Size(75, 23);
            btnPause.TabIndex = 3;
            btnPause.Text = "Pause";
            btnPause.UseVisualStyleBackColor = true;
            btnPause.Click += btnPause_Click;
            // 
            // barProgress
            // 
            barProgress.Location = new Point(38, 355);
            barProgress.Name = "barProgress";
            barProgress.Size = new Size(504, 45);
            barProgress.TabIndex = 4;
            barProgress.Scroll += barProgress_Scroll;
            barProgress.MouseDown += barProgress_MouseDown;
            barProgress.MouseUp += barProgress_MouseUp;
            // 
            // timerMusic
            // 
            timerMusic.Enabled = true;
            timerMusic.Interval = 1000;
            timerMusic.Tick += timer1_Tick;
            // 
            // lblTimerSong
            // 
            lblTimerSong.AutoSize = true;
            lblTimerSong.Location = new Point(38, 337);
            lblTimerSong.Name = "lblTimerSong";
            lblTimerSong.Size = new Size(34, 15);
            lblTimerSong.TabIndex = 5;
            lblTimerSong.Text = "00:00";
            lblTimerSong.Click += label1_Click;
            // 
            // lblSongDuration
            // 
            lblSongDuration.AutoSize = true;
            lblSongDuration.Location = new Point(504, 337);
            lblSongDuration.Name = "lblSongDuration";
            lblSongDuration.Size = new Size(34, 15);
            lblSongDuration.TabIndex = 6;
            lblSongDuration.Text = "00:00";
            lblSongDuration.Click += label1_Click_1;
            // 
            // btnQuitMusic
            // 
            btnQuitMusic.Location = new Point(386, 315);
            btnQuitMusic.Name = "btnQuitMusic";
            btnQuitMusic.Size = new Size(75, 23);
            btnQuitMusic.TabIndex = 7;
            btnQuitMusic.Text = "Quit";
            btnQuitMusic.UseVisualStyleBackColor = true;
            btnQuitMusic.Click += btnQuitMusic_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(596, 450);
            Controls.Add(btnQuitMusic);
            Controls.Add(lblSongDuration);
            Controls.Add(lblTimerSong);
            Controls.Add(barProgress);
            Controls.Add(btnPause);
            Controls.Add(btnPlayMusic);
            Controls.Add(listMusic);
            Controls.Add(findArchive);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)barProgress).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button findArchive;
        private ListBox listMusic;
        private Button btnPlayMusic;
        private Button btnPause;
        private TrackBar barProgress;
        private System.Windows.Forms.Timer timerMusic;
        private Label lblTimerSong;
        private Label lblSongDuration;
        private Button btnQuitMusic;
    }

}
