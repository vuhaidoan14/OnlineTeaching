namespace Client_OnlineTeaching
{
    partial class FrmClassList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmClassList));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Class = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Number = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Teacher = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsernameAuto = new System.Windows.Forms.TextBox();
            this.txtClassPass = new System.Windows.Forms.TextBox();
            this.btnFrmClassList_JoinIn = new DevExpress.XtraEditors.SimpleButton();
            this.btnFrmClassList_User = new DevExpress.XtraEditors.SimpleButton();
            this.btnFrmClassList_Room = new DevExpress.XtraEditors.SimpleButton();
            this.btnFrmClassList_Close = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(26, 60);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(289, 328);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Class,
            this.Number,
            this.Teacher});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // Class
            // 
            this.Class.Caption = "Class";
            this.Class.Name = "Class";
            this.Class.Visible = true;
            this.Class.VisibleIndex = 0;
            // 
            // Number
            // 
            this.Number.Caption = "Number";
            this.Number.Name = "Number";
            this.Number.Visible = true;
            this.Number.VisibleIndex = 1;
            // 
            // Teacher
            // 
            this.Teacher.Caption = "Teacher";
            this.Teacher.Name = "Teacher";
            this.Teacher.Visible = true;
            this.Teacher.VisibleIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(335, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(337, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password:";
            // 
            // txtUsernameAuto
            // 
            this.txtUsernameAuto.Location = new System.Drawing.Point(367, 109);
            this.txtUsernameAuto.Name = "txtUsernameAuto";
            this.txtUsernameAuto.Size = new System.Drawing.Size(144, 20);
            this.txtUsernameAuto.TabIndex = 3;
            // 
            // txtClassPass
            // 
            this.txtClassPass.Location = new System.Drawing.Point(367, 174);
            this.txtClassPass.Name = "txtClassPass";
            this.txtClassPass.PasswordChar = '*';
            this.txtClassPass.Size = new System.Drawing.Size(144, 20);
            this.txtClassPass.TabIndex = 4;
            // 
            // btnFrmClassList_JoinIn
            // 
            this.btnFrmClassList_JoinIn.Image = ((System.Drawing.Image)(resources.GetObject("btnFrmClassList_JoinIn.Image")));
            this.btnFrmClassList_JoinIn.Location = new System.Drawing.Point(325, 217);
            this.btnFrmClassList_JoinIn.Name = "btnFrmClassList_JoinIn";
            this.btnFrmClassList_JoinIn.Size = new System.Drawing.Size(88, 47);
            this.btnFrmClassList_JoinIn.TabIndex = 5;
            this.btnFrmClassList_JoinIn.Text = "Join In";
            // 
            // btnFrmClassList_User
            // 
            this.btnFrmClassList_User.Image = ((System.Drawing.Image)(resources.GetObject("btnFrmClassList_User.Image")));
            this.btnFrmClassList_User.Location = new System.Drawing.Point(434, 217);
            this.btnFrmClassList_User.Name = "btnFrmClassList_User";
            this.btnFrmClassList_User.Size = new System.Drawing.Size(87, 47);
            this.btnFrmClassList_User.TabIndex = 6;
            this.btnFrmClassList_User.Text = "User";
            this.btnFrmClassList_User.Click += new System.EventHandler(this.btnFrmClassList_User_Click);
            // 
            // btnFrmClassList_Room
            // 
            this.btnFrmClassList_Room.Image = ((System.Drawing.Image)(resources.GetObject("btnFrmClassList_Room.Image")));
            this.btnFrmClassList_Room.Location = new System.Drawing.Point(325, 282);
            this.btnFrmClassList_Room.Name = "btnFrmClassList_Room";
            this.btnFrmClassList_Room.Size = new System.Drawing.Size(88, 44);
            this.btnFrmClassList_Room.TabIndex = 7;
            this.btnFrmClassList_Room.Text = "Room";
            this.btnFrmClassList_Room.Click += new System.EventHandler(this.btnFrmClassList_Room_Click);
            // 
            // btnFrmClassList_Close
            // 
            this.btnFrmClassList_Close.Image = ((System.Drawing.Image)(resources.GetObject("btnFrmClassList_Close.Image")));
            this.btnFrmClassList_Close.Location = new System.Drawing.Point(434, 282);
            this.btnFrmClassList_Close.Name = "btnFrmClassList_Close";
            this.btnFrmClassList_Close.Size = new System.Drawing.Size(87, 44);
            this.btnFrmClassList_Close.TabIndex = 8;
            this.btnFrmClassList_Close.Text = "Close";
            // 
            // FrmClassList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 458);
            this.Controls.Add(this.btnFrmClassList_Close);
            this.Controls.Add(this.btnFrmClassList_Room);
            this.Controls.Add(this.btnFrmClassList_User);
            this.Controls.Add(this.btnFrmClassList_JoinIn);
            this.Controls.Add(this.txtClassPass);
            this.Controls.Add(this.txtUsernameAuto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridControl1);
            this.Name = "FrmClassList";
            this.Text = "FormClassList";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn Class;
        private DevExpress.XtraGrid.Columns.GridColumn Number;
        private DevExpress.XtraGrid.Columns.GridColumn Teacher;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsernameAuto;
        private System.Windows.Forms.TextBox txtClassPass;
        private DevExpress.XtraEditors.SimpleButton btnFrmClassList_JoinIn;
        private DevExpress.XtraEditors.SimpleButton btnFrmClassList_User;
        private DevExpress.XtraEditors.SimpleButton btnFrmClassList_Room;
        private DevExpress.XtraEditors.SimpleButton btnFrmClassList_Close;
    }
}