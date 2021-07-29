using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using 电动车管理系统V2._0.frmclass;

namespace 电动车管理系统V2._0.User
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class Cebianlan : Smobiler.Core.Controls.MobileUserControl
    {
        public Cebianlan() : base()
        {
            //This call is required by the SmobilerUserControl.
            InitializeComponent();
            try
            {


                string carID = GlobalData.CarID;
                //数据库连接
                string connectionString = "Data Source=DESKTOP-S8S50FR\\SQLEXPRESS;Initial Catalog=EVMS;Integrated Security=True";
                SqlConnection SqlCon = new SqlConnection(connectionString); //数据库连接
                SqlCon.Open(); //打开数据库
                //string sql = "Select * from [User] where UID='" + carID + "'";//查找用户sql语句
                string sql = "select s.* , sc.* from [user_car] as s, [dbo].[User] as sc where s.[UID]=sc.[UID] and s.[UID]='" + GlobalData.UID + "';";
                SqlDataAdapter find = new SqlDataAdapter(sql, SqlCon);
                DataSet save = new DataSet();
                find.Fill(save);
                label4.Text = save.Tables[0].Rows[0][8].ToString();
                lblTelShow.Text = save.Tables[0].Rows[0][5].ToString();
                lblBirShow.Text = save.Tables[0].Rows[0][9].ToString();
                lblEmailShow.Text = save.Tables[0].Rows[0][10].ToString();

                //imgL.ResourceMode.ToString()= save.Tables[0].Rows[0][6].ToString();
                SqlCon.Close();


            }
            catch (Exception ex)
            {
                Toast(ex.Message, ToastLength.SHORT);
                Toast("您需要登记一辆车才可以打开本页面。");


            }
        }

        private void tpTel_Press(object sender, EventArgs e)
        {
            Client.TelCall(label4.Text);
        }

        private void tpMes_Press(object sender, EventArgs e)
        {
            Client.SendSMS("", label4.Text);
        }

        private void tpEmail_Press(object sender, EventArgs e)
        {
            Client.SendEmail("", "", "1731714633@qq.com");
        }

        private void phoneButton1_Press(object sender, EventArgs e)
        {

        }
    }
}