namespace Client_OnlineTeaching
{
    partial class FrmMainScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMainScreen));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBook = new DevExpress.XtraEditors.SimpleButton();
            this.btnVideo = new DevExpress.XtraEditors.SimpleButton();
            this.btnAudio = new DevExpress.XtraEditors.SimpleButton();
            this.btnChat = new DevExpress.XtraEditors.SimpleButton();
            this.btnCall = new DevExpress.XtraEditors.SimpleButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Audio = new System.Windows.Forms.GroupBox();
            this.btnSoundMic = new DevExpress.XtraEditors.SimpleButton();
            this.btnSoundAudio = new DevExpress.XtraEditors.SimpleButton();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.rtbShowText = new System.Windows.Forms.RichTextBox();
            this.rtbEnterText = new System.Windows.Forms.RichTextBox();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.txtIpAddress = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.time = new DevExpress.XtraGrid.Columns.GridColumn();
            this.userame = new DevExpress.XtraGrid.Columns.GridColumn();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton6 = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.Audio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1030, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingToolStripMenuItem
            // 
            this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            this.settingToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.settingToolStripMenuItem.Text = "Setting";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBook);
            this.groupBox1.Controls.Add(this.btnVideo);
            this.groupBox1.Controls.Add(this.btnAudio);
            this.groupBox1.Controls.Add(this.btnChat);
            this.groupBox1.Controls.Add(this.btnCall);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(222, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(547, 120);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connection";
            // 
            // btnBook
            // 
            this.btnBook.Location = new System.Drawing.Point(422, 19);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(75, 31);
            this.btnBook.TabIndex = 11;
            this.btnBook.Text = "Book";
            // 
            // btnVideo
            // 
            this.btnVideo.Location = new System.Drawing.Point(422, 72);
            this.btnVideo.Name = "btnVideo";
            this.btnVideo.Size = new System.Drawing.Size(75, 31);
            this.btnVideo.TabIndex = 10;
            this.btnVideo.Text = "Video (5)";
            this.btnVideo.Click += new System.EventHandler(this.btnVideo_Click);
            // 
            // btnAudio
            // 
            this.btnAudio.Location = new System.Drawing.Point(295, 72);
            this.btnAudio.Name = "btnAudio";
            this.btnAudio.Size = new System.Drawing.Size(75, 31);
            this.btnAudio.TabIndex = 9;
            this.btnAudio.Text = "Audio (4)";
            this.btnAudio.Click += new System.EventHandler(this.btnAudio_Click);
            // 
            // btnChat
            // 
            this.btnChat.Location = new System.Drawing.Point(169, 72);
            this.btnChat.Name = "btnChat";
            this.btnChat.Size = new System.Drawing.Size(75, 31);
            this.btnChat.TabIndex = 8;
            this.btnChat.Text = "Chat (3)";
            this.btnChat.Click += new System.EventHandler(this.btnChat_Click);
            // 
            // btnCall
            // 
            this.btnCall.Location = new System.Drawing.Point(36, 71);
            this.btnCall.Name = "btnCall";
            this.btnCall.Size = new System.Drawing.Size(75, 32);
            this.btnCall.TabIndex = 7;
            this.btnCall.Text = "Call (2)";
            this.btnCall.Click += new System.EventHandler(this.btnCall_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(169, 26);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(220, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Call to ( Host / IP / Alias) :";
            // 
            // Audio
            // 
            this.Audio.Controls.Add(this.btnSoundMic);
            this.Audio.Controls.Add(this.btnSoundAudio);
            this.Audio.Controls.Add(this.trackBar2);
            this.Audio.Controls.Add(this.trackBar1);
            this.Audio.Location = new System.Drawing.Point(222, 164);
            this.Audio.Name = "Audio";
            this.Audio.Size = new System.Drawing.Size(546, 74);
            this.Audio.TabIndex = 2;
            this.Audio.TabStop = false;
            this.Audio.Text = "Audio";
            // 
            // btnSoundMic
            // 
            this.btnSoundMic.Appearance.ForeColor = System.Drawing.Color.Transparent;
            this.btnSoundMic.Appearance.Options.UseForeColor = true;
            this.btnSoundMic.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSoundMic.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnSoundMic.Location = new System.Drawing.Point(306, 19);
            this.btnSoundMic.Name = "btnSoundMic";
            this.btnSoundMic.Size = new System.Drawing.Size(36, 32);
            this.btnSoundMic.TabIndex = 9;
            this.btnSoundMic.Text = "mic";
            // 
            // btnSoundAudio
            // 
            this.btnSoundAudio.Image = ((System.Drawing.Image)(resources.GetObject("btnSoundAudio.Image")));
            this.btnSoundAudio.Location = new System.Drawing.Point(36, 19);
            this.btnSoundAudio.Name = "btnSoundAudio";
            this.btnSoundAudio.Size = new System.Drawing.Size(36, 32);
            this.btnSoundAudio.TabIndex = 8;
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(348, 19);
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(165, 45);
            this.trackBar2.TabIndex = 1;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(79, 19);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(165, 45);
            this.trackBar1.TabIndex = 0;
            // 
            // rtbShowText
            // 
            this.rtbShowText.Location = new System.Drawing.Point(223, 245);
            this.rtbShowText.Name = "rtbShowText";
            this.rtbShowText.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbShowText.Size = new System.Drawing.Size(544, 149);
            this.rtbShowText.TabIndex = 3;
            this.rtbShowText.Text = "";
            // 
            // rtbEnterText
            // 
            this.rtbEnterText.Location = new System.Drawing.Point(223, 404);
            this.rtbEnterText.Name = "rtbEnterText";
            this.rtbEnterText.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbEnterText.Size = new System.Drawing.Size(543, 67);
            this.rtbEnterText.TabIndex = 4;
            this.rtbEnterText.Text = "Your text messages....(Ctrl + Enter to send)";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.Image")));
            this.simpleButton1.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.simpleButton1.Location = new System.Drawing.Point(222, 477);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(60, 28);
            this.simpleButton1.TabIndex = 5;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.Image")));
            this.simpleButton2.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.simpleButton2.Location = new System.Drawing.Point(707, 477);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(62, 28);
            this.simpleButton2.TabIndex = 6;
            // 
            // txtIpAddress
            // 
            this.txtIpAddress.Enabled = false;
            this.txtIpAddress.Location = new System.Drawing.Point(292, 483);
            this.txtIpAddress.Name = "txtIpAddress";
            this.txtIpAddress.Size = new System.Drawing.Size(409, 20);
            this.txtIpAddress.TabIndex = 7;
            this.txtIpAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(793, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(225, 473);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Video";
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(12, 38);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(203, 256);
            this.gridControl1.TabIndex = 9;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.time,
            this.userame});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // time
            // 
            this.time.Caption = "Time";
            this.time.Name = "time";
            this.time.Visible = true;
            this.time.VisibleIndex = 1;
            // 
            // userame
            // 
            this.userame.Caption = "Username";
            this.userame.Name = "userame";
            this.userame.Visible = true;
            this.userame.VisibleIndex = 0;
            // 
            // simpleButton3
            // 
            this.simpleButton3.Location = new System.Drawing.Point(12, 300);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(39, 38);
            this.simpleButton3.TabIndex = 0;
            // 
            // simpleButton4
            // 
            this.simpleButton4.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton4.Image")));
            this.simpleButton4.Location = new System.Drawing.Point(67, 300);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(39, 38);
            this.simpleButton4.TabIndex = 10;
            // 
            // simpleButton5
            // 
            this.simpleButton5.Location = new System.Drawing.Point(122, 300);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Size = new System.Drawing.Size(39, 38);
            this.simpleButton5.TabIndex = 11;
            // 
            // simpleButton6
            // 
            this.simpleButton6.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton6.Image")));
            this.simpleButton6.Location = new System.Drawing.Point(176, 300);
            this.simpleButton6.Name = "simpleButton6";
            this.simpleButton6.Size = new System.Drawing.Size(39, 38);
            this.simpleButton6.TabIndex = 12;
            // 
            // gridControl2
            // 
            this.gridControl2.Location = new System.Drawing.Point(14, 348);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(203, 154);
            this.gridControl2.TabIndex = 13;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Username";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Time";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // FrmMainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 526);
            this.Controls.Add(this.gridControl2);
            this.Controls.Add(this.simpleButton6);
            this.Controls.Add(this.simpleButton5);
            this.Controls.Add(this.simpleButton4);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtIpAddress);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.rtbEnterText);
            this.Controls.Add(this.rtbShowText);
            this.Controls.Add(this.Audio);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMainScreen";
            this.Text = "MainScreen";
            this.Load += new System.EventHandler(this.FrmMainScreen_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Audio.ResumeLayout(false);
            this.Audio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox Audio;
        private System.Windows.Forms.RichTextBox rtbShowText;
        private System.Windows.Forms.RichTextBox rtbEnterText;
        private DevExpress.XtraEditors.SimpleButton btnCall;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton btnBook;
        private DevExpress.XtraEditors.SimpleButton btnVideo;
        private DevExpress.XtraEditors.SimpleButton btnAudio;
        private DevExpress.XtraEditors.SimpleButton btnChat;
        private DevExpress.XtraEditors.SimpleButton btnSoundMic;
        private DevExpress.XtraEditors.SimpleButton btnSoundAudio;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TextBox txtIpAddress;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn time;
        private DevExpress.XtraGrid.Columns.GridColumn userame;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
        private DevExpress.XtraEditors.SimpleButton simpleButton6;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
    }
}