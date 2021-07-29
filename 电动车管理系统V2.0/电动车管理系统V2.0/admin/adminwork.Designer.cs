using System;
using Smobiler.Core;
namespace 电动车管理系统V2._0.admin
{
    partial class adminwork : Smobiler.Core.Controls.MobileForm
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
            Smobiler.Core.Controls.ToolBarItem toolBarItem5 = new Smobiler.Core.Controls.ToolBarItem();
            Smobiler.Core.Controls.ToolBarItem toolBarItem6 = new Smobiler.Core.Controls.ToolBarItem();
            Smobiler.Core.Controls.IconMenuViewGroup iconMenuViewGroup3 = new Smobiler.Core.Controls.IconMenuViewGroup();
            Smobiler.Core.Controls.IconMenuViewItem iconMenuViewItem9 = new Smobiler.Core.Controls.IconMenuViewItem();
            Smobiler.Core.Controls.IconMenuViewItem iconMenuViewItem10 = new Smobiler.Core.Controls.IconMenuViewItem();
            Smobiler.Core.Controls.IconMenuViewItem iconMenuViewItem11 = new Smobiler.Core.Controls.IconMenuViewItem();
            Smobiler.Core.Controls.IconMenuViewItem iconMenuViewItem12 = new Smobiler.Core.Controls.IconMenuViewItem();
            this.title1 = new Smobiler.Core.Controls.Title();
            this.toolBar1 = new Smobiler.Core.Controls.ToolBar();
            this.iconMenuView1 = new Smobiler.Core.Controls.IconMenuView();
            // 
            // title1
            // 
            this.title1.Location = new System.Drawing.Point(36, 34);
            this.title1.Name = "title1";
            this.title1.Size = new System.Drawing.Size(100, 50);
            this.title1.Text = "轻活-校园电动车管理系统-管理员";
            // 
            // toolBar1
            // 
            this.toolBar1.BackColor = System.Drawing.Color.White;
            this.toolBar1.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.toolBar1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            toolBarItem5.IconID = "work2";
            toolBarItem5.MessageText = "2";
            toolBarItem5.Name = "Work";
            toolBarItem5.SelectIconID = "work2";
            toolBarItem6.IconID = "me";
            toolBarItem6.Name = "Me";
            toolBarItem6.SelectIconID = "me";
            this.toolBar1.Items.AddRange(new Smobiler.Core.Controls.ToolBarItem[] {
            toolBarItem5,
            toolBarItem6});
            this.toolBar1.MessageFontSize = 10;
            this.toolBar1.MessageForeColor = System.Drawing.Color.White;
            this.toolBar1.Name = "toolBar1";
            this.toolBar1.Size = new System.Drawing.Size(0, 50);
            this.toolBar1.ToolbarItemClick += new Smobiler.Core.Controls.ToolbarItemClickEventHandler(this.toolBar1_ToolbarItemClick);
            // 
            // iconMenuView1
            // 
            iconMenuViewGroup3.FontSize = 0F;
            iconMenuViewGroup3.IconBorderRadius = 0;
            iconMenuViewGroup3.ItemHeight = 0;
            iconMenuViewItem9.Icon = "xiaofeimuban.png";
            iconMenuViewItem9.ID = "Register";
            iconMenuViewItem9.Text = "登记新车";
            iconMenuViewItem10.Icon = "XZ.png";
            iconMenuViewItem10.ID = "Renew";
            iconMenuViewItem10.Text = "更新车辆";
            iconMenuViewItem11.Icon = "boy.png";
            iconMenuViewItem11.ID = "My";
            iconMenuViewItem11.Text = "本人车辆";
            iconMenuViewItem12.Icon = "IM.png";
            iconMenuViewItem12.ID = "Other";
            iconMenuViewItem12.Text = "查询车辆";
            iconMenuViewGroup3.Items.AddRange(new Smobiler.Core.Controls.IconMenuViewItem[] {
            iconMenuViewItem9,
            iconMenuViewItem10,
            iconMenuViewItem11,
            iconMenuViewItem12});
            this.iconMenuView1.Groups.AddRange(new Smobiler.Core.Controls.IconMenuViewGroup[] {
            iconMenuViewGroup3});
            this.iconMenuView1.Location = new System.Drawing.Point(0, 120);
            this.iconMenuView1.Name = "iconMenuView1";
            this.iconMenuView1.Size = new System.Drawing.Size(300, 311);
            this.iconMenuView1.ItemPress += new Smobiler.Core.Controls.IconMenuViewItemPressClickHandler(this.iconMenuView1_ItemPress);
            // 
            // adminwork
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.toolBar1,
            this.iconMenuView1});
            this.Name = "adminwork";

        }
        #endregion

        private Smobiler.Core.Controls.Title title1;
        private Smobiler.Core.Controls.ToolBar toolBar1;
        private Smobiler.Core.Controls.IconMenuView iconMenuView1;
    }
}