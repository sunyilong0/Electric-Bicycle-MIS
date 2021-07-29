using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using 电动车管理系统V2._0.frmclass;
using 电动车管理系统V2._0.User;

namespace 电动车管理系统V2._0.admin
{
    partial class adminwork : Smobiler.Core.Controls.MobileForm
    {
        public adminwork() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }

        private void button1_Press(object sender, EventArgs e)
        {

        }

        private void toolBar1_ToolbarItemClick(object sender, ToolbarClickEventArgs e)
        {

        }

        private void iconMenuView1_ItemPress(object sender, IconMenuViewItemPressEventArgs e)
        {

            switch (e.Item.ID)
            {
                case "Register":
                    Register Register1 = new Register();
                    this.Show(Register1);
                    break;
                case "Renew":
                    work work2 = new work();
                    this.Show(work2);
                    break;
                case "My":
                    show work3 = new show();
                    this.Show(work3);
                    break;
                case "Other":
                    Findall work5 = new Findall();
                    this.Show(work5);
                    break;
            }
        }
    }
}