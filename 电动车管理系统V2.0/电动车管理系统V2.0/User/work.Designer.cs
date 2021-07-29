using System;
using Smobiler.Core;
namespace 电动车管理系统V2._0
{
    partial class work : Smobiler.Core.Controls.MobileForm
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
            Smobiler.Core.Controls.IconMenuViewGroup iconMenuViewGroup1 = new Smobiler.Core.Controls.IconMenuViewGroup();
            Smobiler.Core.Controls.IconMenuViewItem iconMenuViewItem1 = new Smobiler.Core.Controls.IconMenuViewItem();
            Smobiler.Core.Controls.IconMenuViewItem iconMenuViewItem2 = new Smobiler.Core.Controls.IconMenuViewItem();
            Smobiler.Core.Controls.IconMenuViewItem iconMenuViewItem3 = new Smobiler.Core.Controls.IconMenuViewItem();
            Smobiler.Core.Controls.IconMenuViewItem iconMenuViewItem4 = new Smobiler.Core.Controls.IconMenuViewItem();
            Smobiler.Core.Controls.IconMenuViewItem iconMenuViewItem5 = new Smobiler.Core.Controls.IconMenuViewItem();
            Smobiler.Core.Controls.IconMenuViewItem iconMenuViewItem6 = new Smobiler.Core.Controls.IconMenuViewItem();
            Smobiler.Core.Controls.ToolBarItem toolBarItem1 = new Smobiler.Core.Controls.ToolBarItem();
            Smobiler.Core.Controls.ToolBarItem toolBarItem2 = new Smobiler.Core.Controls.ToolBarItem();
            this.title1 = new Smobiler.Core.Controls.Title();
            this.iconMenuView1 = new Smobiler.Core.Controls.IconMenuView();
            this.toolBar1 = new Smobiler.Core.Controls.ToolBar();
            this.image1 = new Smobiler.Core.Controls.Image();
            // 
            // title1
            // 
            this.title1.Location = new System.Drawing.Point(36, 34);
            this.title1.Name = "title1";
            this.title1.ResourceID = "CBL";
            this.title1.Size = new System.Drawing.Size(100, 50);
            this.title1.Text = "【用户主页】";
            this.title1.ImagePress += new System.EventHandler(this.title1_ImagePress);
            // 
            // iconMenuView1
            // 
            this.iconMenuView1.ColumnNum = 3;
            iconMenuViewGroup1.FontSize = 0F;
            iconMenuViewGroup1.IconBorderRadius = 0;
            iconMenuViewGroup1.ItemHeight = 0;
            iconMenuViewItem1.Icon = "xiaofeimuban.png";
            iconMenuViewItem1.ID = "Register";
            iconMenuViewItem1.Text = "登记新车";
            iconMenuViewItem2.Icon = "XZ.png";
            iconMenuViewItem2.ID = "Renew";
            iconMenuViewItem2.Text = "更新车辆";
            iconMenuViewItem3.Icon = "boy.png";
            iconMenuViewItem3.ID = "My";
            iconMenuViewItem3.Text = "本人车辆";
            iconMenuViewItem4.Icon = "IM.png";
            iconMenuViewItem4.ID = "Other";
            iconMenuViewItem4.Text = "他人车辆";
            iconMenuViewItem5.Icon = "muban.png";
            iconMenuViewItem5.ID = "Suoyou";
            iconMenuViewItem5.Text = "所有车辆";
            iconMenuViewItem6.Icon = "chengbeng.png";
            iconMenuViewItem6.ID = "Liuyan";
            iconMenuViewItem6.Text = "查看留言";
            iconMenuViewGroup1.Items.AddRange(new Smobiler.Core.Controls.IconMenuViewItem[] {
            iconMenuViewItem1,
            iconMenuViewItem2,
            iconMenuViewItem3,
            iconMenuViewItem4,
            iconMenuViewItem5,
            iconMenuViewItem6});
            this.iconMenuView1.Groups.AddRange(new Smobiler.Core.Controls.IconMenuViewGroup[] {
            iconMenuViewGroup1});
            this.iconMenuView1.Location = new System.Drawing.Point(0, 171);
            this.iconMenuView1.Name = "iconMenuView1";
            this.iconMenuView1.Size = new System.Drawing.Size(300, 279);
            this.iconMenuView1.ItemPress += new Smobiler.Core.Controls.IconMenuViewItemPressClickHandler(this.iconMenuView1_ItemPress);
            // 
            // toolBar1
            // 
            this.toolBar1.BackColor = System.Drawing.Color.White;
            this.toolBar1.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.toolBar1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            toolBarItem1.IconID = "work2";
            toolBarItem1.Name = "Work";
            toolBarItem1.SelectIconID = "work2";
            toolBarItem2.IconID = "me";
            toolBarItem2.Name = "Me";
            toolBarItem2.SelectIconID = "me";
            this.toolBar1.Items.AddRange(new Smobiler.Core.Controls.ToolBarItem[] {
            toolBarItem1,
            toolBarItem2});
            this.toolBar1.MessageFontSize = 10;
            this.toolBar1.MessageForeColor = System.Drawing.Color.White;
            this.toolBar1.Name = "toolBar1";
            this.toolBar1.Size = new System.Drawing.Size(0, 50);
            this.toolBar1.ToolbarItemClick += new Smobiler.Core.Controls.ToolbarItemClickEventHandler(this.toolBar1_ToolbarItemClick);
            // 
            // image1
            // 
            this.image1.Location = new System.Drawing.Point(0, 50);
            this.image1.Name = "image1";
            this.image1.ResourceID = "背景";
            this.image1.Size = new System.Drawing.Size(300, 121);
            // 
            // work
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.title1,
            this.iconMenuView1,
            this.toolBar1,
            this.image1});
            this.DrawerName = "Cebianlan";
            this.KeyDown += new Smobiler.Core.Controls.KeyDownEventHandler(this.work_KeyDown_1);
            this.Name = "work";

        }
        #endregion

        private Smobiler.Core.Controls.Title title1;
        private Smobiler.Core.Controls.IconMenuView iconMenuView1;
        private Smobiler.Core.Controls.ToolBar toolBar1;
        private Smobiler.Core.Controls.Image image1;
    }
}