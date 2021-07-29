using System;
using Smobiler.Core;
namespace 电动车管理系统V2._0.User
{
    partial class Onebikeshow : Smobiler.Core.Controls.MobileUserControl
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
            this.image1 = new Smobiler.Core.Controls.Image();
            this.lbluser = new Smobiler.Core.Controls.Label();
            this.lblother = new Smobiler.Core.Controls.Label();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.label2 = new Smobiler.Core.Controls.Label();
            this.label3 = new Smobiler.Core.Controls.Label();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.image1,
            this.lbluser,
            this.lblother,
            this.label1,
            this.label2,
            this.label3});
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 50);
            this.panel1.Touchable = true;
            this.panel1.Press += new System.EventHandler(this.panel1_Press);
            // 
            // image1
            // 
            this.image1.BorderRadius = 20;
            this.image1.Location = new System.Drawing.Point(11, 5);
            this.image1.Name = "image1";
            this.image1.ResourceID = "电动车";
            this.image1.Size = new System.Drawing.Size(40, 40);
            // 
            // lbluser
            // 
            this.lbluser.DataMember = "DJID1";
            this.lbluser.DisplayMember = "DJID1";
            this.lbluser.Location = new System.Drawing.Point(110, 0);
            this.lbluser.Name = "lbluser";
            this.lbluser.Size = new System.Drawing.Size(190, 30);
            this.lbluser.Text = "label1";
            // 
            // lblother
            // 
            this.lblother.DisplayMember = "PHONE1";
            this.lblother.ForeColor = System.Drawing.Color.Silver;
            this.lblother.Location = new System.Drawing.Point(110, 30);
            this.lblother.Name = "lblother";
            this.lblother.Size = new System.Drawing.Size(190, 20);
            this.lblother.Text = "label1";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(60, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.Text = "电话：";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(60, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.Text = "电话：";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(60, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.Text = "登记号：";
            // 
            // Onebikeshow
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel1});
            this.Size = new System.Drawing.Size(300, 50);
            this.Name = "Onebikeshow";

        }
        #endregion

        private Smobiler.Core.Controls.Panel panel1;
        private Smobiler.Core.Controls.Image image1;
        private Smobiler.Core.Controls.Label lbluser;
        private Smobiler.Core.Controls.Label lblother;
        private Smobiler.Core.Controls.Label label1;
        private Smobiler.Core.Controls.Label label2;
        private Smobiler.Core.Controls.Label label3;
    }
}