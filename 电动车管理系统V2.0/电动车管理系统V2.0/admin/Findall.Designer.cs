using System;
using Smobiler.Core;
namespace 电动车管理系统V2._0
{
    partial class Findall : Smobiler.Core.Controls.MobileForm
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
            this.查询电动车所有信息 = new Smobiler.Core.Controls.Title();
            this.pContent = new Smobiler.Core.Controls.Panel();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.label2 = new Smobiler.Core.Controls.Label();
            this.Label3 = new Smobiler.Core.Controls.Label();
            this.Label4 = new Smobiler.Core.Controls.Label();
            this.txtLday = new Smobiler.Core.Controls.TextBox();
            this.Label5 = new Smobiler.Core.Controls.Label();
            this.lblImg = new Smobiler.Core.Controls.Label();
            this.btnSave = new Smobiler.Core.Controls.Button();
            this.textBox1 = new Smobiler.Core.Controls.TextBox();
            this.textBox2 = new Smobiler.Core.Controls.TextBox();
            this.textBox3 = new Smobiler.Core.Controls.TextBox();
            this.textBox4 = new Smobiler.Core.Controls.TextBox();
            this.imgL = new Smobiler.Core.Controls.Image();
            this.textBox5 = new Smobiler.Core.Controls.TextBox();
            this.label6 = new Smobiler.Core.Controls.Label();
            this.label7 = new Smobiler.Core.Controls.Label();
            this.textBox6 = new Smobiler.Core.Controls.TextBox();
            this.button1 = new Smobiler.Core.Controls.Button();
            // 
            // 查询电动车所有信息
            // 
            this.查询电动车所有信息.Location = new System.Drawing.Point(164, 29);
            this.查询电动车所有信息.Name = "查询电动车所有信息";
            this.查询电动车所有信息.ResourceID = "返回1";
            this.查询电动车所有信息.Size = new System.Drawing.Size(100, 43);
            this.查询电动车所有信息.ImagePress += new System.EventHandler(this.查询电动车所有信息_ImagePress);
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
            this.btnSave,
            this.textBox1,
            this.textBox2,
            this.textBox3,
            this.textBox4,
            this.imgL,
            this.textBox5,
            this.label6,
            this.label7,
            this.textBox6,
            this.button1});
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
            this.label1.Location = new System.Drawing.Point(11, 181);
            this.label1.Name = "label1";
            this.label1.Padding = new Smobiler.Core.Controls.Padding(4F, 0F, 0F, 0F);
            this.label1.Size = new System.Drawing.Size(108, 35);
            this.label1.Text = "宿舍号";
            this.label1.ZIndex = 1;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.label2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label2.Location = new System.Drawing.Point(11, 136);
            this.label2.Name = "label2";
            this.label2.Padding = new Smobiler.Core.Controls.Padding(4F, 0F, 0F, 0F);
            this.label2.Size = new System.Drawing.Size(106, 35);
            this.label2.Text = "所属";
            this.label2.ZIndex = 4;
            // 
            // Label3
            // 
            this.Label3.BackColor = System.Drawing.Color.White;
            this.Label3.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 1F);
            this.Label3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label3.Location = new System.Drawing.Point(13, 52);
            this.Label3.Name = "Label3";
            this.Label3.Padding = new Smobiler.Core.Controls.Padding(4F, 0F, 0F, 0F);
            this.Label3.Size = new System.Drawing.Size(106, 35);
            this.Label3.Text = "车架号";
            this.Label3.ZIndex = 6;
            // 
            // Label4
            // 
            this.Label4.BackColor = System.Drawing.Color.White;
            this.Label4.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 1F);
            this.Label4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label4.Location = new System.Drawing.Point(11, 225);
            this.Label4.Name = "Label4";
            this.Label4.Padding = new Smobiler.Core.Controls.Padding(4F, 0F, 0F, 0F);
            this.Label4.Size = new System.Drawing.Size(106, 35);
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
            this.txtLday.Location = new System.Drawing.Point(117, 136);
            this.txtLday.Name = "txtLday";
            this.txtLday.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 4F, 0F);
            this.txtLday.ReadOnly = true;
            this.txtLday.Size = new System.Drawing.Size(169, 35);
            this.txtLday.ZIndex = 9;
            this.txtLday.TextChanged += new System.EventHandler(this.txtLday_TextChanged);
            // 
            // Label5
            // 
            this.Label5.BackColor = System.Drawing.Color.White;
            this.Label5.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 1F);
            this.Label5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label5.Location = new System.Drawing.Point(11, 269);
            this.Label5.Name = "Label5";
            this.Label5.Padding = new Smobiler.Core.Controls.Padding(4F, 5F, 0F, 0F);
            this.Label5.Size = new System.Drawing.Size(106, 35);
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
            this.lblImg.Location = new System.Drawing.Point(0, 314);
            this.lblImg.Name = "lblImg";
            this.lblImg.Padding = new Smobiler.Core.Controls.Padding(4F, 5F, 0F, 0F);
            this.lblImg.Size = new System.Drawing.Size(66, 80);
            this.lblImg.Text = "图片";
            this.lblImg.VerticalAlignment = Smobiler.Core.Controls.VerticalAlignment.Top;
            this.lblImg.ZIndex = 12;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.btnSave.FontSize = 17F;
            this.btnSave.Location = new System.Drawing.Point(14, 413);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(123, 35);
            this.btnSave.Text = "查询";
            this.btnSave.Press += new System.EventHandler(this.btnSave_Click);
            // 
            // textBox1
            // 
            this.textBox1.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 1F);
            this.textBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.textBox1.FontSize = 12F;
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.textBox1.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.textBox1.KeyboardType = Smobiler.Core.Controls.KeyboardType.Numeric;
            this.textBox1.Location = new System.Drawing.Point(117, 225);
            this.textBox1.Name = "textBox1";
            this.textBox1.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 4F, 0F);
            this.textBox1.Size = new System.Drawing.Size(169, 35);
            this.textBox1.ZIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 1F);
            this.textBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.textBox2.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.textBox2.Location = new System.Drawing.Point(119, 52);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(169, 35);
            this.textBox2.ZIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 1F);
            this.textBox3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.textBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.textBox3.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.textBox3.Location = new System.Drawing.Point(117, 269);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(169, 35);
            this.textBox3.ZIndex = 9;
            // 
            // textBox4
            // 
            this.textBox4.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 1F);
            this.textBox4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.textBox4.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.textBox4.Location = new System.Drawing.Point(119, 181);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(167, 35);
            this.textBox4.ZIndex = 9;
            // 
            // imgL
            // 
            this.imgL.BackColor = System.Drawing.Color.White;
            this.imgL.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.imgL.Location = new System.Drawing.Point(65, 313);
            this.imgL.Margin = new Smobiler.Core.Controls.Margin(0F, 1F, 0F, 0F);
            this.imgL.Name = "imgL";
            this.imgL.Size = new System.Drawing.Size(235, 80);
            this.imgL.ZIndex = 13;
            // 
            // textBox5
            // 
            this.textBox5.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 1F);
            this.textBox5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.textBox5.FontSize = 12F;
            this.textBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.textBox5.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.textBox5.KeyboardType = Smobiler.Core.Controls.KeyboardType.Numeric;
            this.textBox5.Location = new System.Drawing.Point(117, 95);
            this.textBox5.Name = "textBox5";
            this.textBox5.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 4F, 0F);
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(169, 35);
            this.textBox5.ZIndex = 9;
            this.textBox5.TextChanged += new System.EventHandler(this.txtLday_TextChanged);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.label6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label6.Location = new System.Drawing.Point(11, 95);
            this.label6.Name = "label6";
            this.label6.Padding = new Smobiler.Core.Controls.Padding(4F, 0F, 0F, 0F);
            this.label6.Size = new System.Drawing.Size(106, 35);
            this.label6.Text = "姓名";
            this.label6.ZIndex = 4;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.label7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label7.Location = new System.Drawing.Point(11, 7);
            this.label7.Name = "label7";
            this.label7.Padding = new Smobiler.Core.Controls.Padding(4F, 0F, 0F, 0F);
            this.label7.Size = new System.Drawing.Size(106, 35);
            this.label7.Text = "电动车校内编号";
            this.label7.ZIndex = 4;
            // 
            // textBox6
            // 
            this.textBox6.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 1F);
            this.textBox6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.textBox6.FontSize = 12F;
            this.textBox6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.textBox6.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.textBox6.KeyboardType = Smobiler.Core.Controls.KeyboardType.Numeric;
            this.textBox6.Location = new System.Drawing.Point(117, 7);
            this.textBox6.Name = "textBox6";
            this.textBox6.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 4F, 0F);
            this.textBox6.Size = new System.Drawing.Size(171, 35);
            this.textBox6.WaterMarkText = "（必填）";
            this.textBox6.ZIndex = 9;
            this.textBox6.TextChanged += new System.EventHandler(this.txtLday_TextChanged);
            // 
            // button1
            // 
            this.button1.FontSize = 17F;
            this.button1.Location = new System.Drawing.Point(163, 413);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 35);
            this.button1.Text = "电话联系";
            this.button1.Press += new System.EventHandler(this.button1_Press);
            // 
            // Findall
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.查询电动车所有信息,
            this.pContent});
            this.Name = "Findall";

        }
        #endregion

        private Smobiler.Core.Controls.Title 查询电动车所有信息;
        private Smobiler.Core.Controls.Panel pContent;
        internal Smobiler.Core.Controls.Label label1;
        internal Smobiler.Core.Controls.Label label2;
        internal Smobiler.Core.Controls.Label Label3;
        internal Smobiler.Core.Controls.Label Label4;
        internal Smobiler.Core.Controls.TextBox txtLday;
        internal Smobiler.Core.Controls.Label Label5;
        internal Smobiler.Core.Controls.Label lblImg;
        private Smobiler.Core.Controls.Button btnSave;
        internal Smobiler.Core.Controls.TextBox textBox1;
        private Smobiler.Core.Controls.TextBox textBox2;
        private Smobiler.Core.Controls.TextBox textBox3;
        private Smobiler.Core.Controls.TextBox textBox4;
        internal Smobiler.Core.Controls.Image imgL;
        internal Smobiler.Core.Controls.TextBox textBox5;
        internal Smobiler.Core.Controls.Label label6;
        internal Smobiler.Core.Controls.Label label7;
        internal Smobiler.Core.Controls.TextBox textBox6;
        private Smobiler.Core.Controls.Button button1;
    }
}