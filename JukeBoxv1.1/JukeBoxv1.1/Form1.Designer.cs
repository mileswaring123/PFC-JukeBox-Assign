namespace JukeBoxv1._1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbl_Copyright = new System.Windows.Forms.Label();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.setUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GenreTitle_txt = new System.Windows.Forms.TextBox();
            this.GenreList_lst = new System.Windows.Forms.ListBox();
            this.HScrollBar = new System.Windows.Forms.HScrollBar();
            this.PresentlyPlaying_txt = new System.Windows.Forms.TextBox();
            this.Playlist_lst = new System.Windows.Forms.ListBox();
            this.Mediaplayer_wmp = new AxWMPLib.AxWindowsMediaPlayer();
            this.MenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Mediaplayer_wmp)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Copyright
            // 
            this.lbl_Copyright.AutoSize = true;
            this.lbl_Copyright.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lbl_Copyright.Location = new System.Drawing.Point(210, 9);
            this.lbl_Copyright.Name = "lbl_Copyright";
            this.lbl_Copyright.Size = new System.Drawing.Size(195, 13);
            this.lbl_Copyright.TabIndex = 0;
            this.lbl_Copyright.Text = "Copyright © 2018 Miles Ejgierd - Waring";
            // 
            // MenuStrip
            // 
            this.MenuStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setUpToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 434);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(405, 24);
            this.MenuStrip.TabIndex = 1;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // setUpToolStripMenuItem
            // 
            this.setUpToolStripMenuItem.Name = "setUpToolStripMenuItem";
            this.setUpToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.setUpToolStripMenuItem.Text = "Set Up";
            this.setUpToolStripMenuItem.Click += new System.EventHandler(this.setUpToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // GenreTitle_txt
            // 
            this.GenreTitle_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.GenreTitle_txt.Location = new System.Drawing.Point(125, 108);
            this.GenreTitle_txt.Name = "GenreTitle_txt";
            this.GenreTitle_txt.Size = new System.Drawing.Size(155, 20);
            this.GenreTitle_txt.TabIndex = 2;
            // 
            // GenreList_lst
            // 
            this.GenreList_lst.BackColor = System.Drawing.Color.White;
            this.GenreList_lst.FormattingEnabled = true;
            this.GenreList_lst.Location = new System.Drawing.Point(125, 125);
            this.GenreList_lst.Name = "GenreList_lst";
            this.GenreList_lst.Size = new System.Drawing.Size(155, 95);
            this.GenreList_lst.TabIndex = 3;
            this.GenreList_lst.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.GenreList_lst_MouseDoubleClick);
            // 
            // HScrollBar
            // 
            this.HScrollBar.Location = new System.Drawing.Point(125, 223);
            this.HScrollBar.Name = "HScrollBar";
            this.HScrollBar.Size = new System.Drawing.Size(155, 20);
            this.HScrollBar.TabIndex = 4;
           
            // 
            // PresentlyPlaying_txt
            // 
            this.PresentlyPlaying_txt.BackColor = System.Drawing.Color.LawnGreen;
            this.PresentlyPlaying_txt.Location = new System.Drawing.Point(125, 246);
            this.PresentlyPlaying_txt.Name = "PresentlyPlaying_txt";
            this.PresentlyPlaying_txt.Size = new System.Drawing.Size(155, 20);
            this.PresentlyPlaying_txt.TabIndex = 5;
            // 
            // Playlist_lst
            // 
            this.Playlist_lst.BackColor = System.Drawing.SystemColors.Info;
            this.Playlist_lst.FormattingEnabled = true;
            this.Playlist_lst.Location = new System.Drawing.Point(140, 281);
            this.Playlist_lst.Name = "Playlist_lst";
            this.Playlist_lst.Size = new System.Drawing.Size(120, 95);
            this.Playlist_lst.TabIndex = 6;
            // 
            // Mediaplayer_wmp
            // 
            this.Mediaplayer_wmp.Enabled = true;
            this.Mediaplayer_wmp.Location = new System.Drawing.Point(0, -1);
            this.Mediaplayer_wmp.Name = "Mediaplayer_wmp";
            this.Mediaplayer_wmp.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Mediaplayer_wmp.OcxState")));
            this.Mediaplayer_wmp.Size = new System.Drawing.Size(75, 23);
            this.Mediaplayer_wmp.TabIndex = 7;
            this.Mediaplayer_wmp.Visible = false;
            this.Mediaplayer_wmp.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.Mediaplayer_wmp_PlayStateChange);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(405, 458);
            this.Controls.Add(this.Mediaplayer_wmp);
            this.Controls.Add(this.Playlist_lst);
            this.Controls.Add(this.PresentlyPlaying_txt);
            this.Controls.Add(this.HScrollBar);
            this.Controls.Add(this.GenreList_lst);
            this.Controls.Add(this.GenreTitle_txt);
            this.Controls.Add(this.lbl_Copyright);
            this.Controls.Add(this.MenuStrip);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Mediaplayer_wmp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Copyright;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem setUpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TextBox GenreTitle_txt;
        private System.Windows.Forms.ListBox GenreList_lst;
        private System.Windows.Forms.HScrollBar HScrollBar;
        private System.Windows.Forms.TextBox PresentlyPlaying_txt;
        private System.Windows.Forms.ListBox Playlist_lst;
        private AxWMPLib.AxWindowsMediaPlayer Mediaplayer_wmp;
    }
}

