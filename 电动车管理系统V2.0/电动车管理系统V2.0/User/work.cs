using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using 电动车管理系统V2._0.frmclass;
using 电动车管理系统V2._0.User;

namespace 电动车管理系统V2._0 
{
    partial class work : Smobiler.Core.Controls.MobileForm
    {
        public work() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
            if(GlobalData.administrator=="1")
            {
                title1.Text = "【管理员主页】";
            }
        }
        private DateTime toasttime;//toast时间
        public work(string uID) : this()
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
                    findothercar work5 = new findothercar();
                    this.Show(work5);
                    break;

                case "Liuyan":
                    leaveMessageshow work6 = new leaveMessageshow();
                    this.Show(work6);
                    break;

                case "Suoyou":
                    {
                        if (GlobalData.administrator == "1")
                        {
                            Findall work8 = new Findall();
                            this.Show(work8);
                            
                        }
                        else
                        {
                            Toast("非管理员不允许查询，如需查询更多信息请联系保卫处");
                        }
                        break;
                    }
            }
        }

        private void toolBar1_ToolbarItemClick(object sender, ToolbarClickEventArgs e)
        {
            ProcessToolbarFormName(e.Name);
        }
        private void ProcessToolbarFormName(string toolbarItemName)
        {
            try
            {
                switch (toolbarItemName)
                {
                    case "":
                        this.Close();
                        break;
                    case "Me":
                       userdata work2 = new userdata();
                        this.Show(work2);
                        break;
                        //frmUser frm = new frmUser();
                        //this.Show(frm, (MobileForm sender1, object args) =>
                        //{
                        //    ProcessToolbarFormName(frm.toolbarItemName);
                        //    UI.Layout.LeftPage lp = this.Drawer as UI.Layout.LeftPage;
                        //    lp.getUser();
                        //}
                        //);
                        //break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 手机自带回退按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Work_KeyDown(object sender, KeyDownEventArgs e)
        {
            if (e.KeyCode == KeyCode.Back)
            {
                HandleToast();
            }
        }
        /// <summary>
        /// Toast
        /// </summary>
        private void HandleToast()
        {
            if (toasttime.AddSeconds(3) >= DateTime.Now)
            {
                this.Client.Exit();
            }
            else
            {
                toasttime = DateTime.Now;
                this.Toast("再按一次退出系统", ToastLength.SHORT);
            }
        }

        private void button1_Press(object sender, EventArgs e)
        {

            

            Toast(GlobalData.UID);
        }

        private void title1_ImagePress(object sender, EventArgs e)
        {
            OpenDrawer();
        }

        private void work_KeyDown_1(object sender, KeyDownEventArgs e)
        {
            if (e.KeyCode == KeyCode.Back)
            {
                HandleToast();
            }
        }
    }
}