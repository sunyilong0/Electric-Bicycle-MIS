using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using 电动车管理系统V2._0.frmclass;
using 电动车管理系统V2._0.User;

namespace 电动车管理系统V2._0
{
    partial class userdata : Smobiler.Core.Controls.MobileForm
    {
        internal string toolbarItemName = "";
        private int eInfo;
        private DateTime toasttime;//toast时间

        public userdata() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
            try
            {


                string carID = GlobalData.CarID;
                //数据库连接
                string connectionString = "Data Source=DESKTOP-S8S50FR\\SQLEXPRESS;Initial Catalog=EVMS;Integrated Security=True";
                SqlConnection SqlCon = new SqlConnection(connectionString); //数据库连接
                SqlCon.Open(); //打开数据库
                string sql = "Select * from [User] where UID='" + GlobalData.UID + "'";//查找用户sql语句
                //string sql = "select s.* , sc.* from [user_car] as s, [dbo].[User] as sc where s.[UID]=sc.[UID] and s.[UID]='" + GlobalData.UID + "';";
                SqlDataAdapter find = new SqlDataAdapter(sql, SqlCon);
                DataSet save = new DataSet();
                find.Fill(save);

                btnuid.Text = save.Tables[0].Rows[0][0].ToString();
                btnnam.Text = save.Tables[0].Rows[0][1].ToString();
                butdep.Text = save.Tables[0].Rows[0][2].ToString();
                btndoc.Text = save.Tables[0].Rows[0][3].ToString();
                GlobalData.pwd= save.Tables[0].Rows[0][4].ToString();


                //imgL.ResourceMode.ToString()= save.Tables[0].Rows[0][6].ToString();
                SqlCon.Close();


            }
            catch (Exception ex)
            {
                Toast(ex.Message, ToastLength.SHORT);
                Toast("您需要登记一辆车才可以打开本页面。");


            }

        }

        private void cameraPortrait_ImageCaptured(object sender, BinaryResultArgs e)
        {

        }

        private void btnName_Press(object sender, EventArgs e)
        {

        }

        private void btnSex_Press(object sender, EventArgs e)
        {

        }

        private void dpkBirthday_DateChanged(object sender, EventArgs e)
        {

        }

        private void btnEmail_Press(object sender, EventArgs e)
        {

        }

        private void btnPwd_Press(object sender, EventArgs e)
        {
            ShowDialog(new EditPwd());
        }


        private void btnExit_Press(object sender, EventArgs e)
        {
            MessageBox.Show("是否退出当前系统？", MessageBoxButtons.YesNo, (object o, MessageBoxHandlerArgs args) =>
            {
                try
                {
                    if (args.Result == ShowResult.Yes)
                    {
                        //this.Close();
                        SmobilerForm1 frmLogon = new SmobilerForm1();
                        Show(frmLogon);
                        ////退出客户端
                        //this.Client.Exit();
                    }
                }
                catch (Exception ex)
                {
                    Toast(ex.Message, ToastLength.SHORT);
                }
            });
        }

        private void toolBar_ToolbarItemClick(object sender, ToolbarClickEventArgs e)
        {
            toolbarItemName = e.Name;
            switch (e.Name)
            {
                case "Me":
                    break;
                default:
                    this.Close();
                    break;
            }
        }
    }
}