using System;
using Smobiler.Core;
namespace 电动车管理系统V2._0.User
{
    partial class sendmesseng : Smobiler.Core.Controls.MobileUserControl
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
            this.panel1 = new Smobiler.Core.Controls.Panel();
            this.textBox1 = new Smobiler.Core.Controls.TextBox();
            this.butYes = new Smobiler.Core.Controls.Button();
            this.butNo = new Smobiler.Core.Controls.Button();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.label2 = new Smobiler.Core.Controls.Label();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.textBox1,
            this.butYes,
            this.butNo,
            this.label1,
            this.label2});
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 200);
            // 
            // textBox1
            // 
            this.textBox1.BorderRadius = 3;
            this.textBox1.BorderStyle = Smobiler.Core.Controls.BorderStyle.Dotted;
            this.textBox1.Location = new System.Drawing.Point(12, 46);
            this.textBox1.Margin = new Smobiler.Core.Controls.Margin(1F);
            this.textBox1.MaxLength = 120;
            this.textBox1.Name = "textBox1";
            this.textBox1.Padding = new Smobiler.Core.Controls.Padding(1F);
            this.textBox1.Size = new System.Drawing.Size(276, 109);
            this.textBox1.WaterMarkText = "100字以内";
            this.textBox1.ZIndex = 3;
            // 
            // butYes
            // 
            this.butYes.Location = new System.Drawing.Point(19, 161);
            this.butYes.Name = "butYes";
            this.butYes.Size = new System.Drawing.Size(100, 35);
            this.butYes.Text = "确定留言";
            this.butYes.Press += new System.EventHandler(this.butYes_Press);
            // 
            // butNo
            // 
            this.butNo.Location = new System.Drawing.Point(162, 160);
            this.butNo.Name = "butNo";
            this.butNo.Size = new System.Drawing.Size(100, 35);
            this.butNo.Text = "取消留言";
            this.butNo.Press += new System.EventHandler(this.butNo_Press);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 35);
            this.label1.Text = "我想对车主说：";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(319, 35);
            this.label2.Text = "（注意礼貌用语，如有需要可以留下联系方式）";
            // 
            // sendmesseng
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel1});
            this.Margin = new Smobiler.Core.Controls.Margin(1F);
            this.Padding = new Smobiler.Core.Controls.Padding(1F);
            this.Size = new System.Drawing.Size(300, 200);
            this.Name = "sendmesseng";

        }
        #endregion

        private Smobiler.Core.Controls.Panel panel1;
        private Smobiler.Core.Controls.TextBox textBox1;
        private Smobiler.Core.Controls.Button butYes;
        private Smobiler.Core.Controls.Button butNo;
        private Smobiler.Core.Controls.Label label1;
        private Smobiler.Core.Controls.Label label2;
    }
}