using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using 电动车管理系统V2._0.frmclass;
using 电动车管理系统V2._0.User;
using System.Data;
using System.Data.SqlClient;
using Smobiler.Core.Controls;

namespace 电动车管理系统V2._0.User
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class EditPwd : Smobiler.Core.Controls.MobileUserControl
    {
        public EditPwd() : base()
        {
            //This call is required by the SmobilerUserControl.
            InitializeComponent();
        }

        private void button2_Press(object sender, EventArgs e)
        {
            string pwd = textBox1.Text;
            //数据库连接
            string connectionString = "Data Source=DESKTOP-S8S50FR\\SQLEXPRESS;Initial Catalog=EVMS;Integrated Security=True";
            SqlConnection SqlCon = new SqlConnection(connectionString); //数据库连接
            SqlCon.Open(); //打开数据库
                           //string sql = "Select * from [User] where UID='" + carID + "'";//查找用户sql语句
            string sql = "update [dbo].[User] set[pwd] = '"+pwd+"'  where [UID] ='"+GlobalData.UID+"';";
            SqlCommand mycom = new SqlCommand(sql, SqlCon);
            int a = mycom.ExecuteNonQuery();
            SqlCon.Close();
            Close();
            Toast("信息更新成功。");
        }

        private void button1_Press(object sender, EventArgs e)
        {
            Close();
        }
    }
}