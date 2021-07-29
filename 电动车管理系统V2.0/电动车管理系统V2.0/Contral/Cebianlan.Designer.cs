using System;
using Smobiler.Core;
namespace 电动车管理系统V2._0.User
{
    partial class Cebianlan : Smobiler.Core.Controls.MobileUserControl
    {
        #region "SmobilerUserControl generated code "

        //SmobilerUserControl overrides dispose to clean up the component list.
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        //NOTE: The following procedure is required by the SmobilerUserControl
        //It can be modified using the SmobilerUserControl.  
        //Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.title1 = new Smobiler.Core.Controls.Title();
            this.spContent = new Smobiler.Core.Controls.Panel();
            this.imgPortrait = new Smobiler.Core.Controls.Image();
            this.plAction = new Smobiler.Core.Controls.Panel();
            this.tpTel = new Smobiler.Core.Controls.Panel();
            this.fontTel = new Smobiler.Core.Controls.FontIcon();
            this.lblTel = new Smobiler.Core.Controls.Label();
            this.tpMes = new Smobiler.Core.Controls.Panel();
            this.fontMes = new Smobiler.Core.Controls.FontIcon();
            this.lblMes = new Smobiler.Core.Controls.Label();
            this.tpEmail = new Smobiler.Core.Controls.Panel();
            this.fontEmail = new Smobiler.Core.Controls.FontIcon();
            this.lblEmail = new Smobiler.Core.Controls.Label();
            this.plTel = new Smobiler.Core.Controls.Panel();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.lblTelShow = new Smobiler.Core.Controls.Label();
            this.phoneButton1 = new Smobiler.Core.Controls.PhoneButton();
            this.plBirShow = new Smobiler.Core.Controls.Panel();
            this.label2 = new Smobiler.Core.Controls.Label();
            this.lblBirShow = new Smobiler.Core.Controls.Label();
            this.plEmail = new Smobiler.Core.Controls.Panel();
            this.label3 = new Smobiler.Core.Controls.Label();
            this.lblEmailShow = new Smobiler.Core.Controls.Label();
            this.lblName = new Smobiler.Core.Controls.Label();
            this.label4 = new Smobiler.Core.Controls.Label();
            // 
            // title1
            // 
            this.title1.Location = new System.Drawing.Point(47, 20);
            this.title1.Name = "title1";
            this.title1.Size = new System.Drawing.Size(100, 39);
            this.title1.Text = "欢迎您！";
            this.title1.TextAlign = Smobiler.Core.Controls.HorizontalAlignment.Left;
            // 
            // spContent
            // 
            this.spContent.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.imgPortrait,
            this.plAction,
            this.plTel,
            this.plBirShow,
            this.plEmail,
            this.lblName,
            this.label4});
            this.spContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spContent.Flex = 10000;
            this.spContent.Location = new System.Drawing.Point(206, 254);
            this.spContent.Name = "spContent";
            this.spContent.Scrollable = true;
            this.spContent.Size = new System.Drawing.Size(100, 30);
            // 
            // imgPortrait
            // 
            this.imgPortrait.BorderRadius = 40;
            this.imgPortrait.Location = new System.Drawing.Point(58, 20);
            this.imgPortrait.Name = "imgPortrait";
            this.imgPortrait.ResourceID = "boy";
            this.imgPortrait.Size = new System.Drawing.Size(80, 80);
            this.imgPortrait.SizeMode = Smobiler.Core.Controls.ImageSizeMode.Cover;
            this.imgPortrait.Zooming = true;
            // 
            // plAction
            // 
            this.plAction.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.tpTel,
            this.tpMes,
            this.tpEmail});
            this.plAction.Location = new System.Drawing.Point(0, 145);
            this.plAction.Name = "plAction";
            this.plAction.Size = new System.Drawing.Size(300, 65);
            // 
            // tpTel
            // 
            this.tpTel.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.fontTel,
            this.lblTel});
            this.tpTel.Name = "tpTel";
            this.tpTel.Size = new System.Drawing.Size(100, 65);
            this.tpTel.Touchable = true;
            this.tpTel.Press += new System.EventHandler(this.tpTel_Press);
            // 
            // fontTel
            // 
            this.fontTel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.fontTel.BorderRadius = 17;
            this.fontTel.ForeColor = System.Drawing.Color.White;
            this.fontTel.Location = new System.Drawing.Point(32, 0);
            this.fontTel.Name = "fontTel";
            this.fontTel.Padding = new Smobiler.Core.Controls.Padding(6F);
            this.fontTel.ResourceID = "phone";
            this.fontTel.Size = new System.Drawing.Size(35, 35);
            // 
            // lblTel
            // 
            this.lblTel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.lblTel.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.lblTel.Location = new System.Drawing.Point(0, 35);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(100, 30);
            this.lblTel.Text = "打电话";
            // 
            // tpMes
            // 
            this.tpMes.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.fontMes,
            this.lblMes});
            this.tpMes.Location = new System.Drawing.Point(100, 0);
            this.tpMes.Name = "tpMes";
            this.tpMes.Size = new System.Drawing.Size(100, 65);
            this.tpMes.Touchable = true;
            this.tpMes.Press += new System.EventHandler(this.tpMes_Press);
            // 
            // fontMes
            // 
            this.fontMes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.fontMes.BorderRadius = 17;
            this.fontMes.ForeColor = System.Drawing.Color.White;
            this.fontMes.Location = new System.Drawing.Point(32, 0);
            this.fontMes.Name = "fontMes";
            this.fontMes.Padding = new Smobiler.Core.Controls.Padding(6F);
            this.fontMes.ResourceID = "comments";
            this.fontMes.Size = new System.Drawing.Size(35, 35);
            // 
            // lblMes
            // 
            this.lblMes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.lblMes.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.lblMes.Location = new System.Drawing.Point(0, 35);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(100, 30);
            this.lblMes.Text = "发短信";
            // 
            // tpEmail
            // 
            this.tpEmail.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.fontEmail,
            this.lblEmail});
            this.tpEmail.Location = new System.Drawing.Point(200, 0);
            this.tpEmail.Name = "tpEmail";
            this.tpEmail.Size = new System.Drawing.Size(100, 65);
            this.tpEmail.Touchable = true;
            this.tpEmail.Press += new System.EventHandler(this.tpEmail_Press);
            // 
            // fontEmail
            // 
            this.fontEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.fontEmail.BorderRadius = 17;
            this.fontEmail.ForeColor = System.Drawing.Color.White;
            this.fontEmail.Location = new System.Drawing.Point(32, 0);
            this.fontEmail.Name = "fontEmail";
            this.fontEmail.Padding = new Smobiler.Core.Controls.Padding(6F);
            this.fontEmail.ResourceID = "envelope";
            this.fontEmail.Size = new System.Drawing.Size(35, 35);
            // 
            // lblEmail
            // 
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.lblEmail.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.lblEmail.Location = new System.Drawing.Point(0, 35);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(100, 30);
            this.lblEmail.Text = "发邮件";
            // 
            // plTel
            // 
            this.plTel.BackColor = System.Drawing.Color.White;
            this.plTel.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 1F);
            this.plTel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.plTel.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label1,
            this.lblTelShow,
            this.phoneButton1});
            this.plTel.Location = new System.Drawing.Point(0, 220);
            this.plTel.Name = "plTel";
            this.plTel.Size = new System.Drawing.Size(300, 50);
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 20);
            this.label1.Text = "电话";
            // 
            // lblTelShow
            // 
            this.lblTelShow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.lblTelShow.Location = new System.Drawing.Point(0, 20);
            this.lblTelShow.Name = "lblTelShow";
            this.lblTelShow.Padding = new Smobiler.Core.Controls.Padding(4F, 0F, 0F, 0F);
            this.lblTelShow.Size = new System.Drawing.Size(261, 30);
            this.lblTelShow.Text = "暂未登记车辆";
            // 
            // phoneButton1
            // 
            this.phoneButton1.DataMember = null;
            this.phoneButton1.DisplayFormat = null;
            this.phoneButton1.DisplayMember = null;
            this.phoneButton1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.phoneButton1.ImageType = Smobiler.Core.Controls.ImageEx.ImageStyle.FontIcon;
            this.phoneButton1.Location = new System.Drawing.Point(261, 20);
            this.phoneButton1.Name = "phoneButton1";
            this.phoneButton1.ResourceID = "phone";
            this.phoneButton1.Size = new System.Drawing.Size(35, 30);
            this.phoneButton1.Press += new System.EventHandler(this.phoneButton1_Press);
            // 
            // plBirShow
            // 
            this.plBirShow.BackColor = System.Drawing.Color.White;
            this.plBirShow.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.plBirShow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.plBirShow.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label2,
            this.lblBirShow});
            this.plBirShow.Location = new System.Drawing.Point(0, 270);
            this.plBirShow.Name = "plBirShow";
            this.plBirShow.Size = new System.Drawing.Size(300, 50);
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(300, 20);
            this.label2.Text = "班级";
            // 
            // lblBirShow
            // 
            this.lblBirShow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.lblBirShow.Location = new System.Drawing.Point(0, 20);
            this.lblBirShow.Name = "lblBirShow";
            this.lblBirShow.Padding = new Smobiler.Core.Controls.Padding(4F, 0F, 0F, 0F);
            this.lblBirShow.Size = new System.Drawing.Size(300, 30);
            this.lblBirShow.Text = "暂未登记车辆";
            // 
            // plEmail
            // 
            this.plEmail.BackColor = System.Drawing.Color.White;
            this.plEmail.Border = new Smobiler.Core.Controls.Border(0F, 0F, 0F, 1F);
            this.plEmail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.plEmail.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label3,
            this.lblEmailShow});
            this.plEmail.Location = new System.Drawing.Point(0, 320);
            this.plEmail.Name = "plEmail";
            this.plEmail.Size = new System.Drawing.Size(300, 50);
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(300, 20);
            this.label3.Text = "宿舍";
            // 
            // lblEmailShow
            // 
            this.lblEmailShow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.lblEmailShow.Location = new System.Drawing.Point(0, 20);
            this.lblEmailShow.Name = "lblEmailShow";
            this.lblEmailShow.Padding = new Smobiler.Core.Controls.Padding(4F, 0F, 0F, 0F);
            this.lblEmailShow.Size = new System.Drawing.Size(300, 30);
            this.lblEmailShow.Text = "暂未登记车辆";
            // 
            // lblName
            // 
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblName.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.lblName.Location = new System.Drawing.Point(0, 100);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(300, 25);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(72, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 35);
            this.label4.Text = "暂未登记车辆";
            // 
            // Cebianlan
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.spContent});
            this.Flex = 2;
            this.Name = "Cebianlan";

        }
        #endregion

        private Smobiler.Core.Controls.Title title1;
        private Smobiler.Core.Controls.Panel spContent;
        private Smobiler.Core.Controls.Image imgPortrait;
        private Smobiler.Core.Controls.Panel plAction;
        private Smobiler.Core.Controls.Panel tpTel;
        private Smobiler.Core.Controls.FontIcon fontTel;
        private Smobiler.Core.Controls.Label lblTel;
        private Smobiler.Core.Controls.Panel tpMes;
        private Smobiler.Core.Controls.FontIcon fontMes;
        private Smobiler.Core.Controls.Label lblMes;
        private Smobiler.Core.Controls.Panel tpEmail;
        private Smobiler.Core.Controls.FontIcon fontEmail;
        private Smobiler.Core.Controls.Label lblEmail;
        private Smobiler.Core.Controls.Panel plTel;
        private Smobiler.Core.Controls.Label label1;
        private Smobiler.Core.Controls.Label lblTelShow;
        private Smobiler.Core.Controls.PhoneButton phoneButton1;
        private Smobiler.Core.Controls.Panel plBirShow;
        private Smobiler.Core.Controls.Label label2;
        private Smobiler.Core.Controls.Label lblBirShow;
        private Smobiler.Core.Controls.Panel plEmail;
        private Smobiler.Core.Controls.Label label3;
        private Smobiler.Core.Controls.Label lblEmailShow;
        private Smobiler.Core.Controls.Label lblName;
        private Smobiler.Core.Controls.Label label4;
    }
}