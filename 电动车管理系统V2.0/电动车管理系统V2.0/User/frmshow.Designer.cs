using System;
using Smobiler.Core;
namespace 电动车管理系统V2._0.User
{
    partial class show : Smobiler.Core.Controls.MobileForm
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
            this.listView1 = new Smobiler.Core.Controls.ListView();
            // 
            // title1
            // 
            this.title1.Location = new System.Drawing.Point(83, 25);
            this.title1.Name = "title1";
            this.title1.ResourceID = "返回1";
            this.title1.Size = new System.Drawing.Size(100, 49);
            this.title1.Text = "本人车辆列表";
            this.title1.ImagePress += new System.EventHandler(this.title1_ImagePress);
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(0, 49);
            this.listView1.Name = "listView1";
            this.listView1.PageSizeBackColor = System.Drawing.Color.White;
            this.listView1.PageSizeTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.listView1.ShowSplitLine = true;
            this.listView1.Size = new System.Drawing.Size(300, 457);
            this.listView1.SplitLineColor = System.Drawing.Color.Silver;
            this.listView1.TemplateControlName = "Onebikeshow";
            // 
            // show
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.listView1});
            this.Name = "show";
            this.KeyDown += new Smobiler.Core.Controls.KeyDownEventHandler(this.show_KeyDown);
            this.Load += new System.EventHandler(this.show_Load);
            this.Name = "show";

        }
        #endregion

        private Smobiler.Core.Controls.Title title1;
        private Smobiler.Core.Controls.ListView listView1;
    }
}