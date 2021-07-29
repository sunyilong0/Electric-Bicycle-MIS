using System;
using Smobiler.Core;
namespace 电动车管理系统V2._0.User
{
    partial class findothercar : Smobiler.Core.Controls.MobileForm
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
            this.Label3 = new Smobiler.Core.Controls.Label();
            this.Label4 = new Smobiler.Core.Controls.Label();
            this.Label5 = new Smobiler.Core.Controls.Label();
            this.btnSave = new Smobiler.Core.Controls.Button();
            this.textBox1 = new Smobiler.Core.Controls.TextBox();
            this.textBox2 = new Smobiler.Core.Controls.TextBox();
            this.textBox3 = new Smobiler.Core.Controls.TextBox();
            this.textBox5 = new Smobiler.Core.Controls.TextBox();
            this.label6 = new Smobiler.Core.Controls.Label();
            this.label7 = new Smobiler.Core.Controls.Label();
            this.textBox6 = new Smobiler.Core.Controls.TextBox();
            this.buttonLY = new Smobiler.Core.Controls.Button();
            // 
            // title1
            // 
            this.title1.Location = new System.Drawing.Point(60, 24);
            this.title1.Name = "title1";
            this.title1.ResourceID = "返回1";
            this.title1.Size = new System.Drawing.Size(100, 39);
            this.title1.Text = "查询其他车辆";
            this.title1.ImagePress += new System.EventHandler(this.title1_ImagePress);
            // 
            // pContent
            // 
            this.pContent.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Label3,
            this.Label4,
            this.Label5,
            this.btnSave,
            this.textBox1,
            this.textBox2,
            this.textBox3,
            this.textBox5,
            this.label6,
            this.label7,
            this.textBox6,
            this.buttonLY});
            this.pContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pContent.Flex = 10000;
            this.pContent.Location = new System.Drawing.Point(0, 50);
            this.pContent.Name = "pContent";
            this.pContent.Scrollable = true;
            this.pContent.Size = new System.Drawing.Size(300, 450);
            // 
            // Label3
            // 
            this.Label3.BackColor = System.Drawing.Color.White;
            this.Label3.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 1F);
            this.Label3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label3.Location = new System.Drawing.Point(9, 77);
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
            this.Label4.Location = new System.Drawing.Point(9, 164);
            this.Label4.Name = "Label4";
            this.Label4.Padding = new Smobiler.Core.Controls.Padding(4F, 0F, 0F, 0F);
            this.Label4.Size = new System.Drawing.Size(106, 35);
            this.Label4.Text = "电话";
            this.Label4.ZIndex = 8;
            // 
            // Label5
            // 
            this.Label5.BackColor = System.Drawing.Color.White;
            this.Label5.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 1F);
            this.Label5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Label5.Location = new System.Drawing.Point(9, 208);
            this.Label5.Name = "Label5";
            this.Label5.Padding = new Smobiler.Core.Controls.Padding(4F, 5F, 0F, 0F);
            this.Label5.Size = new System.Drawing.Size(106, 35);
            this.Label5.Text = "邮箱";
            this.Label5.VerticalAlignment = Smobiler.Core.Controls.VerticalAlignment.Top;
            this.Label5.ZIndex = 10;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(146)))), ((int)(((byte)(223)))));
            this.btnSave.FontSize = 17F;
            this.btnSave.Location = new System.Drawing.Point(14, 413);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(280, 35);
            this.btnSave.Text = "查询";
            this.btnSave.Press += new System.EventHandler(this.btnSave_Click);
            // 
            // textBox1
            // 
            this.textBox1.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 1F);
            this.textBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.textBox1.FontSize = 18F;
            this.textBox1.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.textBox1.KeyboardType = Smobiler.Core.Controls.KeyboardType.Numeric;
            this.textBox1.Location = new System.Drawing.Point(115, 164);
            this.textBox1.Name = "textBox1";
            this.textBox1.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 4F, 0F);
            this.textBox1.Size = new System.Drawing.Size(169, 35);
            this.textBox1.ZIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 1F);
            this.textBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.textBox2.FontSize = 18F;
            this.textBox2.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.textBox2.Location = new System.Drawing.Point(115, 77);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(169, 35);
            this.textBox2.ZIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 1F);
            this.textBox3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.textBox3.FontSize = 18F;
            this.textBox3.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.textBox3.Location = new System.Drawing.Point(115, 208);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(169, 35);
            this.textBox3.ZIndex = 9;
            // 
            // textBox5
            // 
            this.textBox5.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 1F);
            this.textBox5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.textBox5.FontSize = 18F;
            this.textBox5.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.textBox5.KeyboardType = Smobiler.Core.Controls.KeyboardType.Numeric;
            this.textBox5.Location = new System.Drawing.Point(113, 120);
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
            this.label6.Location = new System.Drawing.Point(7, 120);
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
            this.label7.Location = new System.Drawing.Point(7, 16);
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
            this.textBox6.Location = new System.Drawing.Point(113, 16);
            this.textBox6.Name = "textBox6";
            this.textBox6.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 4F, 0F);
            this.textBox6.Size = new System.Drawing.Size(171, 35);
            this.textBox6.WaterMarkText = "（必填）";
            this.textBox6.ZIndex = 9;
            this.textBox6.TextChanged += new System.EventHandler(this.txtLday_TextChanged);
            // 
            // buttonLY
            // 
            this.buttonLY.FontSize = 17F;
            this.buttonLY.Location = new System.Drawing.Point(15, 360);
            this.buttonLY.Name = "buttonLY";
            this.buttonLY.Size = new System.Drawing.Size(279, 35);
            this.buttonLY.Text = "给该车留言";
            this.buttonLY.Press += new System.EventHandler(this.buttonLY_Press);
            // 
            // findothercar
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.pContent});
            this.Name = "findothercar";

        }
        #endregion

        private Smobiler.Core.Controls.Title title1;
        private Smobiler.Core.Controls.Panel pContent;
        internal Smobiler.Core.Controls.Label Label3;
        internal Smobiler.Core.Controls.Label Label4;
        internal Smobiler.Core.Controls.Label Label5;
        private Smobiler.Core.Controls.Button btnSave;
        internal Smobiler.Core.Controls.TextBox textBox1;
        private Smobiler.Core.Controls.TextBox textBox2;
        private Smobiler.Core.Controls.TextBox textBox3;
        internal Smobiler.Core.Controls.TextBox textBox5;
        internal Smobiler.Core.Controls.Label label6;
        internal Smobiler.Core.Controls.Label label7;
        internal Smobiler.Core.Controls.TextBox textBox6;
        private Smobiler.Core.Controls.Button buttonLY;
    }
}