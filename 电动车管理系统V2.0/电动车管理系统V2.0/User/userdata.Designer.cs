using System;
using Smobiler.Core;
namespace 电动车管理系统V2._0
{
    partial class userdata : Smobiler.Core.Controls.MobileForm
    {
        #region "SmobilerForm generated code "

        //SmobilerForm overrides dispose to clean up the component list.
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }


        //NOTE: The following procedure is required by the SmobilerForm
        //It can be modified using the SmobilerForm.  
        //Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            Smobiler.Core.Controls.ToolBarItem toolBarItem1 = new Smobiler.Core.Controls.ToolBarItem();
            Smobiler.Core.Controls.ToolBarItem toolBarItem2 = new Smobiler.Core.Controls.ToolBarItem();
            this.title1 = new Smobiler.Core.Controls.Title();
            this.toolBar = new Smobiler.Core.Controls.ToolBar();
            this.spContent = new Smobiler.Core.Controls.Panel();
            this.plPortrait = new Smobiler.Core.Controls.Panel();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.imgPortrait = new Smobiler.Core.Controls.Image();
            this.cameraButton1 = new Smobiler.Core.Controls.CameraButton();
            this.plName = new Smobiler.Core.Controls.Panel();
            this.label2 = new Smobiler.Core.Controls.Label();
            this.btnuid = new Smobiler.Core.Controls.Button();
            this.btnName1 = new Smobiler.Core.Controls.Button();
            this.plSex = new Smobiler.Core.Controls.Panel();
            this.label3 = new Smobiler.Core.Controls.Label();
            this.btnnam = new Smobiler.Core.Controls.Button();
            this.btnSex1 = new Smobiler.Core.Controls.Button();
            this.plBirthday = new Smobiler.Core.Controls.Panel();
            this.label4 = new Smobiler.Core.Controls.Label();
            this.butdep = new Smobiler.Core.Controls.Button();
            this.plEmail = new Smobiler.Core.Controls.Panel();
            this.label5 = new Smobiler.Core.Controls.Label();
            this.btndoc = new Smobiler.Core.Controls.Button();
            this.btnEmail1 = new Smobiler.Core.Controls.Button();
            this.btnPwd = new Smobiler.Core.Controls.Button();
            this.btnExit = new Smobiler.Core.Controls.Button();
            // 
            // title1
            // 
            this.title1.Location = new System.Drawing.Point(52, 27);
            this.title1.Name = "title1";
            this.title1.Size = new System.Drawing.Size(100, 40);
            this.title1.Text = "个人信息";
            // 
            // toolBar
            // 
            this.toolBar.BackColor = System.Drawing.Color.White;
            toolBarItem1.IconID = "work";
            toolBarItem1.Name = "Work";
            toolBarItem1.SelectIconID = "work";
            toolBarItem2.IconID = "me2";
            toolBarItem2.Name = "Me";
            toolBarItem2.SelectIconID = "me2";
            this.toolBar.Items.AddRange(new Smobiler.Core.Controls.ToolBarItem[] {
            toolBarItem1,
            toolBarItem2});
            this.toolBar.Location = new System.Drawing.Point(98, 285);
            this.toolBar.Name = "toolBar";
            this.toolBar.Size = new System.Drawing.Size(100, 50);
            this.toolBar.ToolbarItemClick += new Smobiler.Core.Controls.ToolbarItemClickEventHandler(this.toolBar_ToolbarItemClick);
            // 
            // spContent
            // 
            this.spContent.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.plPortrait,
            this.plName,
            this.plSex,
            this.plBirthday,
            this.plEmail,
            this.btnPwd,
            this.btnExit});
            this.spContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spContent.Location = new System.Drawing.Point(138, 123);
            this.spContent.Margin = new Smobiler.Core.Controls.Margin(0F, 10F, 0F, 0F);
            this.spContent.Name = "spContent";
            this.spContent.Scrollable = true;
            this.spContent.Size = new System.Drawing.Size(100, 30);
            // 
            // plPortrait
            // 
            this.plPortrait.BackColor = System.Drawing.Color.White;
            this.plPortrait.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 1F);
            this.plPortrait.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.plPortrait.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label1,
            this.imgPortrait,
            this.cameraButton1});
            this.plPortrait.Name = "plPortrait";
            this.plPortrait.Size = new System.Drawing.Size(300, 45);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Name = "label1";
            this.label1.Padding = new Smobiler.Core.Controls.Padding(4F, 0F, 0F, 0F);
            this.label1.Size = new System.Drawing.Size(265, 45);
            this.label1.Text = "头像";
            // 
            // imgPortrait
            // 
            this.imgPortrait.BorderRadius = 20;
            this.imgPortrait.Location = new System.Drawing.Point(225, 0);
            this.imgPortrait.Name = "imgPortrait";
            this.imgPortrait.ResourceID = "girl";
            this.imgPortrait.Size = new System.Drawing.Size(39, 40);
            this.imgPortrait.SizeMode = Smobiler.Core.Controls.ImageSizeMode.Cover;
            this.imgPortrait.Visible = false;
            this.imgPortrait.Zooming = true;
            // 
            // cameraButton1
            // 
            this.cameraButton1.AllowEdit = true;
            this.cameraButton1.DataMember = null;
            this.cameraButton1.DisplayFormat = null;
            this.cameraButton1.DisplayMember = null;
            this.cameraButton1.ImageBorderRadius = 18;
            this.cameraButton1.Location = new System.Drawing.Point(254, 4);
            this.cameraButton1.Name = "cameraButton1";
            this.cameraButton1.ResourceID = "IMG_1624812836_dms";
            this.cameraButton1.Size = new System.Drawing.Size(36, 36);
            this.cameraButton1.ImageCaptured += new Smobiler.Core.Controls.CameraOnlineCallBackHandler(this.cameraPortrait_ImageCaptured);
            // 
            // plName
            // 
            this.plName.BackColor = System.Drawing.Color.White;
            this.plName.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.plName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.plName.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label2,
            this.btnuid,
            this.btnName1});
            this.plName.Location = new System.Drawing.Point(0, 45);
            this.plName.Name = "plName";
            this.plName.Size = new System.Drawing.Size(300, 45);
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Name = "label2";
            this.label2.Padding = new Smobiler.Core.Controls.Padding(4F, 0F, 0F, 0F);
            this.label2.Size = new System.Drawing.Size(265, 20);
            this.label2.Text = "用户ID";
            // 
            // btnuid
            // 
            this.btnuid.BackColor = System.Drawing.Color.Transparent;
            this.btnuid.BorderRadius = 0;
            this.btnuid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btnuid.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Left;
            this.btnuid.Location = new System.Drawing.Point(0, 20);
            this.btnuid.Name = "btnuid";
            this.btnuid.Padding = new Smobiler.Core.Controls.Padding(4F, 0F, 0F, 0F);
            this.btnuid.Size = new System.Drawing.Size(265, 25);
            this.btnuid.Press += new System.EventHandler(this.btnName_Press);
            // 
            // btnName1
            // 
            this.btnName1.BackColor = System.Drawing.Color.Transparent;
            this.btnName1.BorderRadius = 0;
            this.btnName1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btnName1.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.btnName1.Location = new System.Drawing.Point(265, 0);
            this.btnName1.Name = "btnName1";
            this.btnName1.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 4F, 0F);
            this.btnName1.Size = new System.Drawing.Size(35, 45);
            this.btnName1.Text = ">";
            this.btnName1.Press += new System.EventHandler(this.btnName_Press);
            // 
            // plSex
            // 
            this.plSex.BackColor = System.Drawing.Color.White;
            this.plSex.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.plSex.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.plSex.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label3,
            this.btnnam,
            this.btnSex1});
            this.plSex.Location = new System.Drawing.Point(0, 90);
            this.plSex.Name = "plSex";
            this.plSex.Size = new System.Drawing.Size(300, 45);
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Name = "label3";
            this.label3.Padding = new Smobiler.Core.Controls.Padding(4F, 0F, 0F, 0F);
            this.label3.Size = new System.Drawing.Size(265, 20);
            this.label3.Text = "姓名";
            // 
            // btnnam
            // 
            this.btnnam.BackColor = System.Drawing.Color.Transparent;
            this.btnnam.BorderRadius = 0;
            this.btnnam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btnnam.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Left;
            this.btnnam.Location = new System.Drawing.Point(0, 20);
            this.btnnam.Name = "btnnam";
            this.btnnam.Padding = new Smobiler.Core.Controls.Padding(4F, 0F, 0F, 0F);
            this.btnnam.Size = new System.Drawing.Size(265, 25);
            this.btnnam.Press += new System.EventHandler(this.btnSex_Press);
            // 
            // btnSex1
            // 
            this.btnSex1.BackColor = System.Drawing.Color.Transparent;
            this.btnSex1.BorderRadius = 0;
            this.btnSex1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btnSex1.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.btnSex1.Location = new System.Drawing.Point(265, 0);
            this.btnSex1.Name = "btnSex1";
            this.btnSex1.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 4F, 0F);
            this.btnSex1.Size = new System.Drawing.Size(35, 45);
            this.btnSex1.Text = ">";
            this.btnSex1.Press += new System.EventHandler(this.btnSex_Press);
            // 
            // plBirthday
            // 
            this.plBirthday.BackColor = System.Drawing.Color.White;
            this.plBirthday.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.plBirthday.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.plBirthday.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label4,
            this.butdep});
            this.plBirthday.Location = new System.Drawing.Point(0, 135);
            this.plBirthday.Name = "plBirthday";
            this.plBirthday.Size = new System.Drawing.Size(300, 45);
            // 
            // label4
            // 
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Name = "label4";
            this.label4.Padding = new Smobiler.Core.Controls.Padding(4F, 0F, 0F, 0F);
            this.label4.Size = new System.Drawing.Size(300, 20);
            this.label4.Text = "班级/部门";
            // 
            // butdep
            // 
            this.butdep.BackColor = System.Drawing.Color.Transparent;
            this.butdep.BorderRadius = 0;
            this.butdep.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.butdep.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Left;
            this.butdep.Location = new System.Drawing.Point(0, 20);
            this.butdep.Name = "butdep";
            this.butdep.Padding = new Smobiler.Core.Controls.Padding(4F, 0F, 0F, 0F);
            this.butdep.Size = new System.Drawing.Size(265, 25);
            this.butdep.Press += new System.EventHandler(this.btnEmail_Press);
            // 
            // plEmail
            // 
            this.plEmail.BackColor = System.Drawing.Color.White;
            this.plEmail.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.plEmail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.plEmail.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label5,
            this.btndoc,
            this.btnEmail1});
            this.plEmail.Location = new System.Drawing.Point(0, 180);
            this.plEmail.Name = "plEmail";
            this.plEmail.Size = new System.Drawing.Size(300, 45);
            // 
            // label5
            // 
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Name = "label5";
            this.label5.Padding = new Smobiler.Core.Controls.Padding(4F, 0F, 0F, 0F);
            this.label5.Size = new System.Drawing.Size(265, 20);
            this.label5.Text = "宿舍";
            // 
            // btndoc
            // 
            this.btndoc.BackColor = System.Drawing.Color.Transparent;
            this.btndoc.BorderRadius = 0;
            this.btndoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btndoc.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Left;
            this.btndoc.Location = new System.Drawing.Point(0, 20);
            this.btndoc.Name = "btndoc";
            this.btndoc.Padding = new Smobiler.Core.Controls.Padding(4F, 0F, 0F, 0F);
            this.btndoc.Size = new System.Drawing.Size(265, 25);
            this.btndoc.Press += new System.EventHandler(this.btnEmail_Press);
            // 
            // btnEmail1
            // 
            this.btnEmail1.BackColor = System.Drawing.Color.Transparent;
            this.btnEmail1.BorderRadius = 0;
            this.btnEmail1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.btnEmail1.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.btnEmail1.Location = new System.Drawing.Point(265, 0);
            this.btnEmail1.Name = "btnEmail1";
            this.btnEmail1.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 4F, 0F);
            this.btnEmail1.Size = new System.Drawing.Size(35, 45);
            this.btnEmail1.Text = ">";
            this.btnEmail1.Press += new System.EventHandler(this.btnEmail_Press);
            // 
            // btnPwd
            // 
            this.btnPwd.BackColor = System.Drawing.Color.White;
            this.btnPwd.BorderColor = System.Drawing.Color.LightGray;
            this.btnPwd.BorderRadius = 0;
            this.btnPwd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.btnPwd.Location = new System.Drawing.Point(0, 235);
            this.btnPwd.Name = "btnPwd";
            this.btnPwd.Size = new System.Drawing.Size(300, 35);
            this.btnPwd.Text = "登录密码修改";
            this.btnPwd.Press += new System.EventHandler(this.btnPwd_Press);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.BorderRadius = 0;
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(0, 280);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(300, 35);
            this.btnExit.Text = "退出";
            this.btnExit.Press += new System.EventHandler(this.btnExit_Press);
            // 
            // userdata
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.toolBar,
            this.spContent});
            this.Name = "userdata";

        }
        #endregion

        private Smobiler.Core.Controls.Title title1;
        private Smobiler.Core.Controls.ToolBar toolBar;
        private Smobiler.Core.Controls.Panel spContent;
        private Smobiler.Core.Controls.Panel plPortrait;
        private Smobiler.Core.Controls.Label label1;
        private Smobiler.Core.Controls.Image imgPortrait;
        private Smobiler.Core.Controls.CameraButton cameraButton1;
        private Smobiler.Core.Controls.Panel plName;
        private Smobiler.Core.Controls.Label label2;
        internal Smobiler.Core.Controls.Button btnuid;
        private Smobiler.Core.Controls.Button btnName1;
        private Smobiler.Core.Controls.Panel plSex;
        private Smobiler.Core.Controls.Label label3;
        private Smobiler.Core.Controls.Button btnnam;
        private Smobiler.Core.Controls.Button btnSex1;
        private Smobiler.Core.Controls.Panel plBirthday;
        private Smobiler.Core.Controls.Label label4;
        private Smobiler.Core.Controls.Panel plEmail;
        private Smobiler.Core.Controls.Label label5;
        internal Smobiler.Core.Controls.Button btndoc;
        private Smobiler.Core.Controls.Button btnEmail1;
        private Smobiler.Core.Controls.Button btnPwd;
        private Smobiler.Core.Controls.Button btnExit;
        internal Smobiler.Core.Controls.Button butdep;
    }
}