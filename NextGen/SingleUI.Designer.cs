﻿namespace YAMP
{
    partial class SingleUI
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SingleUI));
            this.sampleRateLabel = new System.Windows.Forms.Label();
            this.totalTimeLabel = new System.Windows.Forms.Label();
            this.coverBox = new System.Windows.Forms.PictureBox();
            this.visualBox = new System.Windows.Forms.PictureBox();
            this.chanLabel = new System.Windows.Forms.Label();
            this.mainLabel = new libZoi.MarqueeLabel();
            this.volLabel = new System.Windows.Forms.Label();
            this.mainSkin = new System.Windows.Forms.PictureBox();
            this.opacityDn = new System.Windows.Forms.Button();
            this.bitRateLabel = new System.Windows.Forms.Label();
            this.aboutBtn = new System.Windows.Forms.Button();
            this.opacityUp = new System.Windows.Forms.Button();
            this.volumeUp = new System.Windows.Forms.Button();
            this.volumeDn = new System.Windows.Forms.Button();
            this.tagfmBtn = new System.Windows.Forms.Button();
            this.prevBtn = new System.Windows.Forms.Button();
            this.nextBtn = new System.Windows.Forms.Button();
            this.plistBtn = new System.Windows.Forms.Button();
            this.shufLabel = new System.Windows.Forms.Label();
            this.repLabel = new System.Windows.Forms.Label();
            this.repeatBtn = new System.Windows.Forms.Button();
            this.openBtn = new System.Windows.Forms.Button();
            this.currentTimeLabel = new System.Windows.Forms.Label();
            this.stopBtn = new System.Windows.Forms.Button();
            this.pauseBtn = new System.Windows.Forms.Button();
            this.playBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.minBtn = new System.Windows.Forms.Button();
            this.topSwitchBtn = new System.Windows.Forms.Button();
            this.titIco = new System.Windows.Forms.PictureBox();
            this.albIco = new System.Windows.Forms.PictureBox();
            this.artIco = new System.Windows.Forms.PictureBox();
            this.fileLabel = new System.Windows.Forms.Label();
            this.visSetBtn = new System.Windows.Forms.Button();
            this.openMedia = new System.Windows.Forms.OpenFileDialog();
            this.scrollTimer = new System.Windows.Forms.Timer(this.components);
            this.mainTimer = new System.Windows.Forms.Timer(this.components);
            this.seekBar = new System.Windows.Forms.ProgressBar();
            this.titleBox = new System.Windows.Forms.Label();
            this.artistBox = new System.Windows.Forms.Label();
            this.albumBox = new System.Windows.Forms.Label();
            this.fileBox = new System.Windows.Forms.Label();
            this.allToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.searchBox = new System.Windows.Forms.ToolStripTextBox();
            this.selectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.folderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.playList = new System.Windows.Forms.ListBox();
            this.hintLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.coverBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visualBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainSkin)).BeginInit();
            this.mainSkin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.titIco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.albIco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artIco)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sampleRateLabel
            // 
            this.sampleRateLabel.AutoSize = true;
            this.sampleRateLabel.BackColor = System.Drawing.Color.Transparent;
            this.sampleRateLabel.Font = new System.Drawing.Font("Tahoma", 7F);
            this.sampleRateLabel.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.sampleRateLabel.Location = new System.Drawing.Point(129, 48);
            this.sampleRateLabel.MinimumSize = new System.Drawing.Size(10, 10);
            this.sampleRateLabel.Name = "sampleRateLabel";
            this.sampleRateLabel.Size = new System.Drawing.Size(10, 12);
            this.sampleRateLabel.TabIndex = 6;
            this.sampleRateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // totalTimeLabel
            // 
            this.totalTimeLabel.AutoSize = true;
            this.totalTimeLabel.BackColor = System.Drawing.Color.Transparent;
            this.totalTimeLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.totalTimeLabel.ForeColor = System.Drawing.Color.Orange;
            this.totalTimeLabel.Location = new System.Drawing.Point(225, 28);
            this.totalTimeLabel.MinimumSize = new System.Drawing.Size(10, 10);
            this.totalTimeLabel.Name = "totalTimeLabel";
            this.totalTimeLabel.Size = new System.Drawing.Size(10, 13);
            this.totalTimeLabel.TabIndex = 8;
            this.totalTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // coverBox
            // 
            this.coverBox.BackColor = System.Drawing.Color.Transparent;
            this.coverBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("coverBox.BackgroundImage")));
            this.coverBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.coverBox.Location = new System.Drawing.Point(258, 188);
            this.coverBox.Name = "coverBox";
            this.coverBox.Size = new System.Drawing.Size(72, 72);
            this.coverBox.TabIndex = 50;
            this.coverBox.TabStop = false;
            // 
            // visualBox
            // 
            this.visualBox.BackColor = System.Drawing.Color.Transparent;
            this.visualBox.Location = new System.Drawing.Point(29, 46);
            this.visualBox.Name = "visualBox";
            this.visualBox.Size = new System.Drawing.Size(90, 25);
            this.visualBox.TabIndex = 1;
            this.visualBox.TabStop = false;
            this.visualBox.Click += new System.EventHandler(this.visualBox_Click);
            // 
            // chanLabel
            // 
            this.chanLabel.AutoSize = true;
            this.chanLabel.BackColor = System.Drawing.Color.Transparent;
            this.chanLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chanLabel.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.chanLabel.Location = new System.Drawing.Point(90, 28);
            this.chanLabel.Name = "chanLabel";
            this.chanLabel.Size = new System.Drawing.Size(0, 13);
            this.chanLabel.TabIndex = 38;
            // 
            // mainLabel
            // 
            this.mainLabel.BackColor = System.Drawing.Color.DarkGray;
            this.mainLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mainLabel.ForeColor = System.Drawing.Color.Gold;
            this.mainLabel.Location = new System.Drawing.Point(20, 28);
            this.mainLabel.Name = "mainLabel";
            this.mainLabel.Size = new System.Drawing.Size(270, 13);
            this.mainLabel.TabIndex = 60;
            this.mainLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mainLabel.UseCompatibleTextRendering = true;
            this.mainLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.startDragging);
            this.mainLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMovementHandler);
            this.mainLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.endDragging);
            // 
            // volLabel
            // 
            this.volLabel.AutoSize = true;
            this.volLabel.BackColor = System.Drawing.Color.Transparent;
            this.volLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.volLabel.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.volLabel.Location = new System.Drawing.Point(16, 28);
            this.volLabel.Name = "volLabel";
            this.volLabel.Size = new System.Drawing.Size(0, 13);
            this.volLabel.TabIndex = 39;
            // 
            // mainSkin
            // 
            this.mainSkin.BackgroundImage = global::YAMP.Properties.Resources.main;
            this.mainSkin.Controls.Add(this.opacityDn);
            this.mainSkin.Controls.Add(this.bitRateLabel);
            this.mainSkin.Controls.Add(this.sampleRateLabel);
            this.mainSkin.Controls.Add(this.totalTimeLabel);
            this.mainSkin.Controls.Add(this.visualBox);
            this.mainSkin.Controls.Add(this.chanLabel);
            this.mainSkin.Controls.Add(this.volLabel);
            this.mainSkin.Controls.Add(this.aboutBtn);
            this.mainSkin.Controls.Add(this.opacityUp);
            this.mainSkin.Controls.Add(this.volumeUp);
            this.mainSkin.Controls.Add(this.volumeDn);
            this.mainSkin.Controls.Add(this.tagfmBtn);
            this.mainSkin.Controls.Add(this.prevBtn);
            this.mainSkin.Controls.Add(this.nextBtn);
            this.mainSkin.Controls.Add(this.plistBtn);
            this.mainSkin.Controls.Add(this.shufLabel);
            this.mainSkin.Controls.Add(this.repLabel);
            this.mainSkin.Controls.Add(this.repeatBtn);
            this.mainSkin.Controls.Add(this.openBtn);
            this.mainSkin.Controls.Add(this.currentTimeLabel);
            this.mainSkin.Controls.Add(this.stopBtn);
            this.mainSkin.Controls.Add(this.pauseBtn);
            this.mainSkin.Controls.Add(this.playBtn);
            this.mainSkin.Controls.Add(this.closeBtn);
            this.mainSkin.Controls.Add(this.minBtn);
            this.mainSkin.Controls.Add(this.topSwitchBtn);
            this.mainSkin.Location = new System.Drawing.Point(0, 24);
            this.mainSkin.Name = "mainSkin";
            this.mainSkin.Size = new System.Drawing.Size(330, 140);
            this.mainSkin.TabIndex = 25;
            this.mainSkin.TabStop = false;
            this.mainSkin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.startDragging);
            this.mainSkin.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMovementHandler);
            this.mainSkin.MouseUp += new System.Windows.Forms.MouseEventHandler(this.endDragging);
            // 
            // opacityDn
            // 
            this.opacityDn.BackColor = System.Drawing.Color.Transparent;
            this.opacityDn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.opacityDn.ForeColor = System.Drawing.Color.Transparent;
            this.opacityDn.Location = new System.Drawing.Point(226, 83);
            this.opacityDn.Name = "opacityDn";
            this.opacityDn.Size = new System.Drawing.Size(24, 12);
            this.opacityDn.TabIndex = 39;
            this.opacityDn.UseVisualStyleBackColor = true;
            this.opacityDn.Click += new System.EventHandler(this.opacityDn_Click);
            this.opacityDn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.opacityDn_MouseDown);
            // 
            // bitRateLabel
            // 
            this.bitRateLabel.AutoSize = true;
            this.bitRateLabel.BackColor = System.Drawing.Color.Transparent;
            this.bitRateLabel.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bitRateLabel.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.bitRateLabel.Location = new System.Drawing.Point(175, 47);
            this.bitRateLabel.MinimumSize = new System.Drawing.Size(10, 10);
            this.bitRateLabel.Name = "bitRateLabel";
            this.bitRateLabel.Size = new System.Drawing.Size(10, 12);
            this.bitRateLabel.TabIndex = 7;
            this.bitRateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // aboutBtn
            // 
            this.aboutBtn.BackColor = System.Drawing.Color.Transparent;
            this.aboutBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.aboutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.aboutBtn.ForeColor = System.Drawing.Color.Transparent;
            this.aboutBtn.Location = new System.Drawing.Point(285, 101);
            this.aboutBtn.Margin = new System.Windows.Forms.Padding(0);
            this.aboutBtn.Name = "aboutBtn";
            this.aboutBtn.Size = new System.Drawing.Size(30, 30);
            this.aboutBtn.TabIndex = 24;
            this.aboutBtn.UseVisualStyleBackColor = true;
            this.aboutBtn.Click += new System.EventHandler(this.aboutBtn_Click);
            // 
            // opacityUp
            // 
            this.opacityUp.BackColor = System.Drawing.Color.Transparent;
            this.opacityUp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.opacityUp.ForeColor = System.Drawing.Color.Transparent;
            this.opacityUp.Location = new System.Drawing.Point(226, 71);
            this.opacityUp.Name = "opacityUp";
            this.opacityUp.Size = new System.Drawing.Size(24, 12);
            this.opacityUp.TabIndex = 23;
            this.opacityUp.UseVisualStyleBackColor = true;
            this.opacityUp.Click += new System.EventHandler(this.opacityUp_Click);
            this.opacityUp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.opacityUp_MouseDown);
            // 
            // volumeUp
            // 
            this.volumeUp.BackColor = System.Drawing.Color.Transparent;
            this.volumeUp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.volumeUp.ForeColor = System.Drawing.Color.Transparent;
            this.volumeUp.Location = new System.Drawing.Point(147, 66);
            this.volumeUp.Name = "volumeUp";
            this.volumeUp.Size = new System.Drawing.Size(36, 18);
            this.volumeUp.TabIndex = 22;
            this.volumeUp.UseVisualStyleBackColor = true;
            this.volumeUp.Click += new System.EventHandler(this.volumeUp_Click);
            this.volumeUp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.volumeUp_MouseDown);
            // 
            // volumeDn
            // 
            this.volumeDn.BackColor = System.Drawing.Color.Transparent;
            this.volumeDn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.volumeDn.ForeColor = System.Drawing.Color.Transparent;
            this.volumeDn.Location = new System.Drawing.Point(147, 83);
            this.volumeDn.Name = "volumeDn";
            this.volumeDn.Size = new System.Drawing.Size(36, 18);
            this.volumeDn.TabIndex = 40;
            this.volumeDn.UseVisualStyleBackColor = true;
            this.volumeDn.Click += new System.EventHandler(this.volumeDn_Click);
            this.volumeDn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.volumeDn_MouseDown);
            // 
            // tagfmBtn
            // 
            this.tagfmBtn.BackColor = System.Drawing.Color.Transparent;
            this.tagfmBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tagfmBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tagfmBtn.ForeColor = System.Drawing.Color.Transparent;
            this.tagfmBtn.Location = new System.Drawing.Point(275, 70);
            this.tagfmBtn.Name = "tagfmBtn";
            this.tagfmBtn.Size = new System.Drawing.Size(15, 15);
            this.tagfmBtn.TabIndex = 21;
            this.tagfmBtn.UseVisualStyleBackColor = true;
            this.tagfmBtn.Click += new System.EventHandler(this.tagfmBtn_Click);
            // 
            // prevBtn
            // 
            this.prevBtn.BackColor = System.Drawing.Color.Transparent;
            this.prevBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.prevBtn.ForeColor = System.Drawing.Color.Transparent;
            this.prevBtn.Location = new System.Drawing.Point(19, 104);
            this.prevBtn.Name = "prevBtn";
            this.prevBtn.Size = new System.Drawing.Size(28, 28);
            this.prevBtn.TabIndex = 20;
            this.prevBtn.UseVisualStyleBackColor = true;
            this.prevBtn.Click += new System.EventHandler(this.prevBtn_Click);
            // 
            // nextBtn
            // 
            this.nextBtn.BackColor = System.Drawing.Color.Transparent;
            this.nextBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.nextBtn.ForeColor = System.Drawing.Color.Transparent;
            this.nextBtn.Location = new System.Drawing.Point(131, 104);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(28, 28);
            this.nextBtn.TabIndex = 19;
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // plistBtn
            // 
            this.plistBtn.BackColor = System.Drawing.Color.Transparent;
            this.plistBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.plistBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.plistBtn.ForeColor = System.Drawing.Color.Transparent;
            this.plistBtn.Location = new System.Drawing.Point(293, 70);
            this.plistBtn.Name = "plistBtn";
            this.plistBtn.Size = new System.Drawing.Size(15, 15);
            this.plistBtn.TabIndex = 18;
            this.plistBtn.UseVisualStyleBackColor = true;
            this.plistBtn.Click += new System.EventHandler(this.plistBtn_Click);
            // 
            // shufLabel
            // 
            this.shufLabel.AutoSize = true;
            this.shufLabel.BackColor = System.Drawing.Color.Transparent;
            this.shufLabel.Font = new System.Drawing.Font("Tahoma", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.shufLabel.ForeColor = System.Drawing.Color.Gray;
            this.shufLabel.Location = new System.Drawing.Point(170, 36);
            this.shufLabel.Name = "shufLabel";
            this.shufLabel.Size = new System.Drawing.Size(50, 11);
            this.shufLabel.TabIndex = 13;
            this.shufLabel.Text = "{●} Shuffle";
            this.shufLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.shufLabel.Visible = false;
            // 
            // repLabel
            // 
            this.repLabel.AutoSize = true;
            this.repLabel.BackColor = System.Drawing.Color.Transparent;
            this.repLabel.Font = new System.Drawing.Font("Tahoma", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.repLabel.ForeColor = System.Drawing.Color.Gray;
            this.repLabel.Location = new System.Drawing.Point(170, 24);
            this.repLabel.Name = "repLabel";
            this.repLabel.Size = new System.Drawing.Size(48, 11);
            this.repLabel.TabIndex = 12;
            this.repLabel.Text = "{ } Repeat";
            this.repLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // repeatBtn
            // 
            this.repeatBtn.BackColor = System.Drawing.Color.Transparent;
            this.repeatBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.repeatBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.repeatBtn.ForeColor = System.Drawing.Color.Transparent;
            this.repeatBtn.Location = new System.Drawing.Point(250, 106);
            this.repeatBtn.Name = "repeatBtn";
            this.repeatBtn.Size = new System.Drawing.Size(28, 23);
            this.repeatBtn.TabIndex = 11;
            this.repeatBtn.UseVisualStyleBackColor = true;
            this.repeatBtn.Click += new System.EventHandler(this.repeatBtn_Click);
            // 
            // openBtn
            // 
            this.openBtn.BackColor = System.Drawing.Color.Transparent;
            this.openBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.openBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.openBtn.ForeColor = System.Drawing.Color.Transparent;
            this.openBtn.Location = new System.Drawing.Point(169, 106);
            this.openBtn.Name = "openBtn";
            this.openBtn.Size = new System.Drawing.Size(28, 23);
            this.openBtn.TabIndex = 0;
            this.openBtn.UseVisualStyleBackColor = true;
            this.openBtn.Click += new System.EventHandler(this.openBtn_Click);
            // 
            // currentTimeLabel
            // 
            this.currentTimeLabel.AutoSize = true;
            this.currentTimeLabel.BackColor = System.Drawing.Color.Transparent;
            this.currentTimeLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.currentTimeLabel.ForeColor = System.Drawing.Color.Orange;
            this.currentTimeLabel.Location = new System.Drawing.Point(225, 42);
            this.currentTimeLabel.MinimumSize = new System.Drawing.Size(10, 10);
            this.currentTimeLabel.Name = "currentTimeLabel";
            this.currentTimeLabel.Size = new System.Drawing.Size(10, 13);
            this.currentTimeLabel.TabIndex = 9;
            this.currentTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // stopBtn
            // 
            this.stopBtn.BackColor = System.Drawing.Color.Transparent;
            this.stopBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.stopBtn.ForeColor = System.Drawing.Color.Transparent;
            this.stopBtn.Location = new System.Drawing.Point(103, 104);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(28, 28);
            this.stopBtn.TabIndex = 5;
            this.stopBtn.UseVisualStyleBackColor = true;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // pauseBtn
            // 
            this.pauseBtn.BackColor = System.Drawing.Color.Transparent;
            this.pauseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.pauseBtn.ForeColor = System.Drawing.Color.Transparent;
            this.pauseBtn.Location = new System.Drawing.Point(75, 104);
            this.pauseBtn.Name = "pauseBtn";
            this.pauseBtn.Size = new System.Drawing.Size(28, 28);
            this.pauseBtn.TabIndex = 4;
            this.pauseBtn.UseVisualStyleBackColor = true;
            this.pauseBtn.Click += new System.EventHandler(this.pauseBtn_Click);
            // 
            // playBtn
            // 
            this.playBtn.BackColor = System.Drawing.Color.Transparent;
            this.playBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.playBtn.ForeColor = System.Drawing.Color.Transparent;
            this.playBtn.Location = new System.Drawing.Point(47, 104);
            this.playBtn.Name = "playBtn";
            this.playBtn.Size = new System.Drawing.Size(28, 28);
            this.playBtn.TabIndex = 3;
            this.playBtn.UseVisualStyleBackColor = true;
            this.playBtn.Click += new System.EventHandler(this.playBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.Transparent;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.closeBtn.ForeColor = System.Drawing.Color.Transparent;
            this.closeBtn.Location = new System.Drawing.Point(315, 4);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(10, 10);
            this.closeBtn.TabIndex = 2;
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // minBtn
            // 
            this.minBtn.BackColor = System.Drawing.Color.Transparent;
            this.minBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.minBtn.ForeColor = System.Drawing.Color.Transparent;
            this.minBtn.Location = new System.Drawing.Point(295, 4);
            this.minBtn.Name = "minBtn";
            this.minBtn.Size = new System.Drawing.Size(10, 10);
            this.minBtn.TabIndex = 38;
            this.minBtn.UseVisualStyleBackColor = false;
            this.minBtn.Click += new System.EventHandler(this.minBtn_Click);
            // 
            // topSwitchBtn
            // 
            this.topSwitchBtn.BackColor = System.Drawing.Color.Transparent;
            this.topSwitchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.topSwitchBtn.ForeColor = System.Drawing.Color.Transparent;
            this.topSwitchBtn.Location = new System.Drawing.Point(305, 4);
            this.topSwitchBtn.Name = "topSwitchBtn";
            this.topSwitchBtn.Size = new System.Drawing.Size(10, 10);
            this.topSwitchBtn.TabIndex = 38;
            this.topSwitchBtn.UseVisualStyleBackColor = false;
            this.topSwitchBtn.Click += new System.EventHandler(this.topSwitchBtn_Click);
            // 
            // titIco
            // 
            this.titIco.BackColor = System.Drawing.Color.Transparent;
            this.titIco.BackgroundImage = global::YAMP.Properties.Resources.TitleIcon;
            this.titIco.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.titIco.Location = new System.Drawing.Point(12, 192);
            this.titIco.Name = "titIco";
            this.titIco.Size = new System.Drawing.Size(20, 20);
            this.titIco.TabIndex = 59;
            this.titIco.TabStop = false;
            // 
            // albIco
            // 
            this.albIco.BackColor = System.Drawing.Color.Transparent;
            this.albIco.BackgroundImage = global::YAMP.Properties.Resources.AlbumIcon;
            this.albIco.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.albIco.Location = new System.Drawing.Point(12, 244);
            this.albIco.Name = "albIco";
            this.albIco.Size = new System.Drawing.Size(20, 20);
            this.albIco.TabIndex = 58;
            this.albIco.TabStop = false;
            // 
            // artIco
            // 
            this.artIco.BackColor = System.Drawing.Color.Transparent;
            this.artIco.BackgroundImage = global::YAMP.Properties.Resources.ArtistIcon;
            this.artIco.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.artIco.Location = new System.Drawing.Point(12, 218);
            this.artIco.Name = "artIco";
            this.artIco.Size = new System.Drawing.Size(20, 20);
            this.artIco.TabIndex = 57;
            this.artIco.TabStop = false;
            // 
            // fileLabel
            // 
            this.fileLabel.BackColor = System.Drawing.Color.Transparent;
            this.fileLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fileLabel.ForeColor = System.Drawing.Color.Black;
            this.fileLabel.Location = new System.Drawing.Point(12, 273);
            this.fileLabel.Name = "fileLabel";
            this.fileLabel.Size = new System.Drawing.Size(28, 13);
            this.fileLabel.TabIndex = 54;
            this.fileLabel.Text = "File:";
            // 
            // visSetBtn
            // 
            this.visSetBtn.Location = new System.Drawing.Point(14, 72);
            this.visSetBtn.Name = "visSetBtn";
            this.visSetBtn.Size = new System.Drawing.Size(8, 24);
            this.visSetBtn.TabIndex = 53;
            this.visSetBtn.UseVisualStyleBackColor = true;
            this.visSetBtn.Click += new System.EventHandler(this.colorSetBtn_Click);
            // 
            // mainTimer
            // 
            this.mainTimer.Interval = 500;
            this.mainTimer.Tick += new System.EventHandler(this.mainTimer_Tick);
            // 
            // seekBar
            // 
            this.seekBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(114)))), ((int)(((byte)(124)))));
            this.seekBar.ForeColor = System.Drawing.Color.Goldenrod;
            this.seekBar.Location = new System.Drawing.Point(12, 162);
            this.seekBar.Name = "seekBar";
            this.seekBar.Size = new System.Drawing.Size(318, 20);
            this.seekBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.seekBar.TabIndex = 48;
            this.seekBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.startSeeking);
            this.seekBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMovementHandler);
            this.seekBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.endSeeking);
            // 
            // titleBox
            // 
            this.titleBox.BackColor = System.Drawing.Color.Transparent;
            this.titleBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.titleBox.Location = new System.Drawing.Point(36, 192);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(210, 18);
            this.titleBox.TabIndex = 62;
            // 
            // artistBox
            // 
            this.artistBox.BackColor = System.Drawing.Color.Transparent;
            this.artistBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.artistBox.Location = new System.Drawing.Point(36, 218);
            this.artistBox.Name = "artistBox";
            this.artistBox.Size = new System.Drawing.Size(210, 18);
            this.artistBox.TabIndex = 63;
            // 
            // albumBox
            // 
            this.albumBox.BackColor = System.Drawing.Color.Transparent;
            this.albumBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.albumBox.Location = new System.Drawing.Point(36, 244);
            this.albumBox.Name = "albumBox";
            this.albumBox.Size = new System.Drawing.Size(210, 18);
            this.albumBox.TabIndex = 64;
            // 
            // fileBox
            // 
            this.fileBox.BackColor = System.Drawing.Color.Transparent;
            this.fileBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fileBox.Location = new System.Drawing.Point(38, 273);
            this.fileBox.Name = "fileBox";
            this.fileBox.Size = new System.Drawing.Size(284, 13);
            this.fileBox.TabIndex = 65;
            // 
            // allToolStripMenuItem
            // 
            this.allToolStripMenuItem.Name = "allToolStripMenuItem";
            this.allToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.allToolStripMenuItem.Text = "All";
            this.allToolStripMenuItem.Click += new System.EventHandler(this.allToolStripMenuItem_Click);
            // 
            // listToolStripMenuItem
            // 
            this.listToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem1,
            this.saveToolStripMenuItem1});
            this.listToolStripMenuItem.Name = "listToolStripMenuItem";
            this.listToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.listToolStripMenuItem.Text = "List";
            // 
            // loadToolStripMenuItem1
            // 
            this.loadToolStripMenuItem1.Name = "loadToolStripMenuItem1";
            this.loadToolStripMenuItem1.Size = new System.Drawing.Size(100, 22);
            this.loadToolStripMenuItem1.Text = "Load";
            this.loadToolStripMenuItem1.Click += new System.EventHandler(this.loadToolStripMenuItem1_Click);
            // 
            // saveToolStripMenuItem1
            // 
            this.saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
            this.saveToolStripMenuItem1.Size = new System.Drawing.Size(100, 22);
            this.saveToolStripMenuItem1.Text = "Save";
            this.saveToolStripMenuItem1.Click += new System.EventHandler(this.saveToolStripMenuItem1_Click);
            // 
            // searchBox
            // 
            this.searchBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.searchBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.searchBox.AutoToolTip = true;
            this.searchBox.Font = new System.Drawing.Font("Tahoma", 8F);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(296, 20);
            this.searchBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchBox_KeyDown);
            this.searchBox.Click += new System.EventHandler(this.searchBox_Click);
            this.searchBox.MouseEnter += new System.EventHandler(this.searchBox_MouseEnter);
            this.searchBox.MouseLeave += new System.EventHandler(this.searchBox_MouseLeave);
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // selectedToolStripMenuItem
            // 
            this.selectedToolStripMenuItem.Name = "selectedToolStripMenuItem";
            this.selectedToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.selectedToolStripMenuItem.Text = "Selected";
            this.selectedToolStripMenuItem.Click += new System.EventHandler(this.selectedToolStripMenuItem_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectedToolStripMenuItem,
            this.allToolStripMenuItem});
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.removeToolStripMenuItem.Text = "Remove";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.removeToolStripMenuItem,
            this.listToolStripMenuItem,
            this.toolStripMenuItem2,
            this.searchBox});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(640, 24);
            this.menuStrip1.TabIndex = 67;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.folderToolStripMenuItem});
            this.toolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(41, 20);
            this.toolStripMenuItem1.Text = "Add";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // folderToolStripMenuItem
            // 
            this.folderToolStripMenuItem.Name = "folderToolStripMenuItem";
            this.folderToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.folderToolStripMenuItem.Text = "Folder";
            this.folderToolStripMenuItem.Click += new System.EventHandler(this.folderToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.AutoSize = false;
            this.toolStripMenuItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(185, 20);
            this.toolStripMenuItem2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.startDragging);
            this.toolStripMenuItem2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMovementHandler);
            this.toolStripMenuItem2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.endDragging);
            // 
            // playList
            // 
            this.playList.AllowDrop = true;
            this.playList.BackColor = System.Drawing.Color.Silver;
            this.playList.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.playList.ForeColor = System.Drawing.SystemColors.WindowText;
            this.playList.FormattingEnabled = true;
            this.playList.HorizontalScrollbar = true;
            this.playList.Location = new System.Drawing.Point(330, 24);
            this.playList.Margin = new System.Windows.Forms.Padding(10);
            this.playList.Name = "playList";
            this.playList.Size = new System.Drawing.Size(298, 264);
            this.playList.TabIndex = 68;
            this.playList.DragDrop += new System.Windows.Forms.DragEventHandler(this.playList_DragDrop);
            this.playList.DragEnter += new System.Windows.Forms.DragEventHandler(this.playList_DragEnter);
            this.playList.DoubleClick += new System.EventHandler(this.playList_DoubleClick);
            this.playList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.playList_KeyDown);
            this.playList.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.playList_KeyPress);
            this.playList.MouseEnter += new System.EventHandler(this.playList_MouseEnter);
            this.playList.MouseLeave += new System.EventHandler(this.playList_MouseLeave);
            // 
            // hintLabel
            // 
            this.hintLabel.BackColor = System.Drawing.Color.Transparent;
            this.hintLabel.Location = new System.Drawing.Point(184, 289);
            this.hintLabel.Name = "hintLabel";
            this.hintLabel.Size = new System.Drawing.Size(300, 13);
            this.hintLabel.TabIndex = 69;
            this.hintLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SingleUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::YAMP.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(640, 310);
            this.Controls.Add(this.hintLabel);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.playList);
            this.Controls.Add(this.fileBox);
            this.Controls.Add(this.albumBox);
            this.Controls.Add(this.artistBox);
            this.Controls.Add(this.titleBox);
            this.Controls.Add(this.coverBox);
            this.Controls.Add(this.mainLabel);
            this.Controls.Add(this.titIco);
            this.Controls.Add(this.albIco);
            this.Controls.Add(this.artIco);
            this.Controls.Add(this.fileLabel);
            this.Controls.Add(this.visSetBtn);
            this.Controls.Add(this.seekBar);
            this.Controls.Add(this.mainSkin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SingleUI";
            this.Text = "YAMP";
            this.TransparencyKey = System.Drawing.Color.Magenta;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ShutDown);
            this.Shown += new System.EventHandler(this.MainWindow_Shown);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainWindow_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.playList_DragEnter);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.playList_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.startDragging);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMovementHandler);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.endDragging);
            ((System.ComponentModel.ISupportInitialize)(this.coverBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visualBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainSkin)).EndInit();
            this.mainSkin.ResumeLayout(false);
            this.mainSkin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.titIco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.albIco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artIco)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label sampleRateLabel;
        private System.Windows.Forms.Label totalTimeLabel;
        private System.Windows.Forms.PictureBox coverBox;
        private System.Windows.Forms.PictureBox visualBox;
        private System.Windows.Forms.Label chanLabel;
        private libZoi.MarqueeLabel mainLabel;
        private System.Windows.Forms.Label volLabel;
        private System.Windows.Forms.PictureBox mainSkin;
        private System.Windows.Forms.Button aboutBtn;
        private System.Windows.Forms.Button opacityUp;
        private System.Windows.Forms.Button volumeUp;
        private System.Windows.Forms.Button volumeDn;
        private System.Windows.Forms.Button tagfmBtn;
        private System.Windows.Forms.Button prevBtn;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.Button plistBtn;
        private System.Windows.Forms.Label shufLabel;
        private System.Windows.Forms.Label repLabel;
        private System.Windows.Forms.Button repeatBtn;
        private System.Windows.Forms.Button openBtn;
        private System.Windows.Forms.Label currentTimeLabel;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.Button pauseBtn;
        private System.Windows.Forms.Button playBtn;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button minBtn;
        private System.Windows.Forms.Button topSwitchBtn;
        private System.Windows.Forms.PictureBox titIco;
        private System.Windows.Forms.PictureBox albIco;
        private System.Windows.Forms.PictureBox artIco;
        private System.Windows.Forms.Label fileLabel;
        private System.Windows.Forms.Button visSetBtn;
        public System.Windows.Forms.OpenFileDialog openMedia;
        private System.Windows.Forms.Timer scrollTimer;
        private System.Windows.Forms.Timer mainTimer;
        private System.Windows.Forms.ProgressBar seekBar;
        private System.Windows.Forms.Label titleBox;
        private System.Windows.Forms.Label artistBox;
        private System.Windows.Forms.Label albumBox;
        private System.Windows.Forms.Label fileBox;
        private System.Windows.Forms.ToolStripMenuItem allToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem1;
        private System.Windows.Forms.ToolStripTextBox searchBox;
        private System.Windows.Forms.ToolStripMenuItem selectedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem folderToolStripMenuItem;
        public System.Windows.Forms.ListBox playList;
        private System.Windows.Forms.Label bitRateLabel;
        private System.Windows.Forms.Button opacityDn;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.Label hintLabel;
    }
}