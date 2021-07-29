using System;
using Smobiler.Core;
namespace 电动车管理系统V2._0.User
{
    partial class EditPwd : Smobiler.Core.Controls.MobileUserControl
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
            this.button1 = new Smobiler.Core.Controls.Button();
            this.button2 = new Smobiler.Core.Controls.Button();
            this.textBox1 = new Smobiler.Core.Controls.TextBox();
            this.label1 = new Smobiler.Core.Controls.Label();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(181, 123);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 35);
            this.button1.Text = "取消";
            this.button1.Press += new System.EventHandler(this.button1_Press);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(35, 123);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 35);
            this.button2.Text = "确定";
            this.button2.Press += new System.EventHandler(this.button2_Press);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = Smobiler.Core.Controls.BorderStyle.Dotted;
            this.textBox1.Location = new System.Drawing.Point(35, 73);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(246, 35);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(35, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 35);
            this.label1.Text = "请输入新密码";
            // 
            // EditPwd
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.button1,
            this.button2,
            this.textBox1,
            this.label1});
            this.Size = new System.Drawing.Size(300, 170);
            this.Name = "EditPwd";

        }
        #endregion

        private Smobiler.Core.Controls.Button button1;
        private Smobiler.Core.Controls.Button button2;
        private Smobiler.Core.Controls.TextBox textBox1;
        private Smobiler.Core.Controls.Label label1;
    }
}