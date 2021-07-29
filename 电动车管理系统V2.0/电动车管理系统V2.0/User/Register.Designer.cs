using System;
using Smobiler.Core;
namespace 电动车管理系统V2._0
{
    partial class Register : Smobiler.Core.Controls.MobileForm
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
            this.title1 = new Smobiler.Core.Controls.Title();
            this.pContent = new Smobiler.Core.Controls.Panel();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.label2 = new Smobiler.Core.Controls.Label();
            this.Label3 = new Smobiler.Core.Controls.Label();
            this.Label4 = new Smobiler.Core.Controls.Label();
            this.txtLday = new Smobiler.Core.Controls.TextBox();
            this.Label5 = new Smobiler.Core.Controls.Label();
            this.lblImg = new Smobiler.Core.Controls.Label();
            this.Label9 = new Smobiler.Core.Controls.Label();
            this.btnupPhoto = new Smobiler.Core.Controls.Button();
            this.btndelPhoto = new Smobiler.Core.Controls.Button();
            this.btnSave = new Smobiler.Core.Controls.Button();
            this.panel1 = new Smobiler.Core.Controls.Panel();
            this.textBox1 = new Smobiler.Core.Controls.TextBox();
            this.textBox2 = new Smobiler.Core.Controls.TextBox();
            this.textBox3 = new Smobiler.Core.Controls.TextBox();
            this.textBox4 = new Smobiler.Core.Controls.TextBox();
            this.imgL = new Smobiler.Core.Controls.Image();
            this.camera1 = new Smobiler.Core.Controls.Camera();
            this.performanceCounter1 = new System.Diagnostics.PerformanceCounter();
            this.popType = new Smobiler.Core.Controls.PopList();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter1)).BeginInit();
            // 
            // title1
            // 
            this.title1.Location = new System.Drawing.Point(159, 46);
            this.title1.Name = "title1";
            this.title1.ResourceID = "返回1";
            this.title1.Size = new System.Drawing.Size(100, 39);
            this.title1.Text = "登记车辆信息";
            this.title1.ImagePress += new System.EventHandler(this.title1_ImagePress);
            // 
            // pContent
            // 
            this.pContent.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label1,
            this.label2,
            this.Label3,
            this.Label4,
            this.txtLday,
            this.Label5,
            this.lblImg,
            this.Label9,
            this.btnupPhoto,
            this.btndelPhoto,
            this.btnSave,
            this.panel1,
            this.textBox1,
            this.textBox2,
            this.textBox3,
            this.textBox4,
            this.imgL});
            this.pContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pContent.Flex = 10000;
            this.pContent.Location = new System.Drawing.Point(0, 50);
            this.pContent.Name = "pContent";
            this.pContent.Scrollable = true;
            this.pContent.Size = new System.Drawing.Size(300, 450);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 1F);
            this.label1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label1.Location = new System.Drawing.Point(11, 106);
            this.label1.Name = "label1";
            this.label1.Padding = new Smobiler.Core.Controls.Padding(4F, 0F, 0F, 0F);
            this.label1.Size = new System.Drawing.Size(116, 35);
            this.label1.Text = "车牌号";
            this.label1.ZIndex = 1;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.label2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label2.Location = new System.Drawing.Point(11, 18);
            this.label2.Name = "label2";
            this.label2.Padding = new Smobiler.Core.Controls.Padding(4F, 0F, 0F, 0F);
            this.label2.Size = new System.Drawing.Size(114, 35);
            this.label2.Text = "电动车校内编号";
            this.label2.ZIndex = 4;
            // 
            // Label3
            // 
            this.Label3.BackColor = System.Drawing.Color.White;
            this.Label3.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 1F);
            this.Label3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label3.Location = new System.Drawing.Point(11, 63);
            this.Label3.Name = "Label3";
            this.Label3.Padding = new Smobiler.Core.Controls.Padding(4F, 0F, 0F, 0F);
            this.Label3.Size = new System.Drawing.Size(114, 35);
            this.Label3.Text = "车架号";
            this.Label3.ZIndex = 6;
            // 
            // Label4
            // 
            this.Label4.BackColor = System.Drawing.Color.White;
            this.Label4.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 1F);
            this.Label4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label4.Location = new System.Drawing.Point(11, 150);
            this.Label4.Name = "Label4";
            this.Label4.Padding = new Smobiler.Core.Controls.Padding(4F, 0F, 0F, 0F);
            this.Label4.Size = new System.Drawing.Size(114, 35);
            this.Label4.Text = "电话";
            this.Label4.ZIndex = 8;
            // 
            // txtLday
            // 
            this.txtLday.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 1F);
            this.txtLday.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtLday.FontSize = 12F;
            this.txtLday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.txtLday.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.txtLday.KeyboardType = Smobiler.Core.Controls.KeyboardType.Numeric;
            this.txtLday.Location = new System.Drawing.Point(125, 18);
            this.txtLday.Name = "txtLday";
            this.txtLday.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 4F, 0F);
            this.txtLday.Size = new System.Drawing.Size(159, 35);
            this.txtLday.WaterMarkText = "（必填）";
            this.txtLday.ZIndex = 9;
            this.txtLday.TextChanged += new System.EventHandler(this.txtLday_TextChanged);
            // 
            // Label5
            // 
            this.Label5.BackColor = System.Drawing.Color.White;
            this.Label5.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 1F);
            this.Label5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label5.Location = new System.Drawing.Point(11, 194);
            this.Label5.Name = "Label5";
            this.Label5.Padding = new Smobiler.Core.Controls.Padding(4F, 5F, 0F, 0F);
            this.Label5.Size = new System.Drawing.Size(114, 35);
            this.Label5.Text = "邮箱";
            this.Label5.VerticalAlignment = Smobiler.Core.Controls.VerticalAlignment.Top;
            this.Label5.ZIndex = 10;
            // 
            // lblImg
            // 
            this.lblImg.BackColor = System.Drawing.Color.White;
            this.lblImg.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 1F);
            this.lblImg.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblImg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblImg.Location = new System.Drawing.Point(11, 240);
            this.lblImg.Name = "lblImg";
            this.lblImg.Padding = new Smobiler.Core.Controls.Padding(4F, 5F, 0F, 0F);
            this.lblImg.Size = new System.Drawing.Size(66, 80);
            this.lblImg.Text = "图片";
            this.lblImg.VerticalAlignment = Smobiler.Core.Controls.VerticalAlignment.Top;
            this.lblImg.ZIndex = 12;
            // 
            // Label9
            // 
            this.Label9.BackColor = System.Drawing.Color.White;
            this.Label9.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.Label9.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label9.Location = new System.Drawing.Point(66, 290);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(207, 30);
            this.Label9.ZIndex = 14;
            // 
            // btnupPhoto
            // 
            this.btnupPhoto.BackColor = System.Drawing.Color.White;
            this.btnupPhoto.Border = new Smobiler.Core.Controls.Border(1F);
            this.btnupPhoto.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btnupPhoto.BorderRadius = 4;
            this.btnupPhoto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btnupPhoto.Location = new System.Drawing.Point(125, 292);
            this.btnupPhoto.Name = "btnupPhoto";
            this.btnupPhoto.Size = new System.Drawing.Size(65, 20);
            this.btnupPhoto.Text = "上传";
            this.btnupPhoto.ZIndex = 15;
            this.btnupPhoto.Press += new System.EventHandler(this.btnupPhoto_Click);
            // 
            // btndelPhoto
            // 
            this.btndelPhoto.BackColor = System.Drawing.Color.White;
            this.btndelPhoto.Border = new Smobiler.Core.Controls.Border(1F);
            this.btndelPhoto.BorderColor = System.Drawing.Color.Red;
            this.btndelPhoto.BorderRadius = 4;
            this.btndelPhoto.ForeColor = System.Drawing.Color.Red;
            this.btndelPhoto.Location = new System.Drawing.Point(200, 292);
            this.btndelPhoto.Name = "btndelPhoto";
            this.btndelPhoto.Size = new System.Drawing.Size(65, 20);
            this.btndelPhoto.Text = "删除";
            this.btndelPhoto.ZIndex = 16;
            this.btndelPhoto.Press += new System.EventHandler(this.btndelPhoto_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.btnSave.FontSize = 17F;
            this.btnSave.Location = new System.Drawing.Point(13, 350);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(260, 35);
            this.btnSave.Text = "提交";
            this.btnSave.Press += new System.EventHandler(this.btnSave_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.panel1.Location = new System.Drawing.Point(77, 270);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(207, 50);
            // 
            // textBox1
            // 
            this.textBox1.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 1F);
            this.textBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.textBox1.FontSize = 12F;
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.textBox1.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.textBox1.KeyboardType = Smobiler.Core.Controls.KeyboardType.Numeric;
            this.textBox1.Location = new System.Drawing.Point(125, 150);
            this.textBox1.Name = "textBox1";
            this.textBox1.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 4F, 0F);
            this.textBox1.Size = new System.Drawing.Size(159, 35);
            this.textBox1.WaterMarkText = "（必填）";
            this.textBox1.ZIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 1F);
            this.textBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.textBox2.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.textBox2.Location = new System.Drawing.Point(125, 63);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(159, 35);
            this.textBox2.WaterMarkText = "（必填）";
            this.textBox2.ZIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 1F);
            this.textBox3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.textBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.textBox3.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.textBox3.Location = new System.Drawing.Point(125, 194);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(159, 35);
            this.textBox3.WaterMarkText = "（必填）";
            this.textBox3.ZIndex = 9;
            // 
            // textBox4
            // 
            this.textBox4.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 1F);
            this.textBox4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.textBox4.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.textBox4.Location = new System.Drawing.Point(127, 106);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(157, 35);
            this.textBox4.WaterMarkText = "（选填）";
            this.textBox4.ZIndex = 9;
            // 
            // imgL
            // 
            this.imgL.BackColor = System.Drawing.Color.White;
            this.imgL.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.imgL.Location = new System.Drawing.Point(77, 239);
            this.imgL.Margin = new Smobiler.Core.Controls.Margin(0F, 1F, 0F, 0F);
            this.imgL.Name = "imgL";
            this.imgL.Size = new System.Drawing.Size(207, 48);
            this.imgL.ZIndex = 13;
            // 
            // camera1
            // 
            this.camera1.Name = "camera1";
            this.camera1.ImageCaptured += new Smobiler.Core.Controls.CameraOnlineCallBackHandler(this.camera1_ImageCaptured);
            // 
            // performanceCounter1
            // 
            this.performanceCounter1.CategoryName = "Processor";
            this.performanceCounter1.CounterName = "% Processor Time";
            this.performanceCounter1.InstanceName = "_Total";
            // 
            // popType
            // 
            this.popType.Name = "popType";
            this.popType.Selected += new System.EventHandler(this.popType_Selected);
            // 
            // Register
            // 
            this.Components.AddRange(new Smobiler.Core.Controls.MobileComponent[] {
            this.camera1,
            this.popType});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.pContent});
            this.Name = "Register";
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter1)).EndInit();

        }
        #endregion

        private Smobiler.Core.Controls.Title title1;
        private Smobiler.Core.Controls.Panel pContent;
        internal Smobiler.Core.Controls.Label label1;
        internal Smobiler.Core.Controls.Label label2;
        internal Smobiler.Core.Controls.Label Label3;
        internal Smobiler.Core.Controls.Label Label4;
        internal Smobiler.Core.Controls.TextBox txtLday;
        internal Smobiler.Core.Controls.Label Label5;
        internal Smobiler.Core.Controls.Label lblImg;
        internal Smobiler.Core.Controls.Label Label9;
        internal Smobiler.Core.Controls.Button btnupPhoto;
        internal Smobiler.Core.Controls.Button btndelPhoto;
        private Smobiler.Core.Controls.Button btnSave;
        private Smobiler.Core.Controls.Panel panel1;
        internal Smobiler.Core.Controls.TextBox textBox1;
        private Smobiler.Core.Controls.TextBox textBox2;
        private Smobiler.Core.Controls.TextBox textBox3;
        private Smobiler.Core.Controls.TextBox textBox4;
        internal Smobiler.Core.Controls.Image imgL;
        private Smobiler.Core.Controls.Camera camera1;
        private System.Diagnostics.PerformanceCounter performanceCounter1;
        private Smobiler.Core.Controls.PopList popType;
    }
}