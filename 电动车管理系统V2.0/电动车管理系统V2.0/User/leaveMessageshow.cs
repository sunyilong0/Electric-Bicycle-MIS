using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using 电动车管理系统V2._0.frmclass;
using 电动车管理系统V2._0.User;
using System.Data;
using System.Data.SqlClient;

namespace 电动车管理系统V2._0.User
{
    partial class leaveMessageshow : Smobiler.Core.Controls.MobileForm
    {
        public leaveMessageshow() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();

            string connectionString = "Data Source=DESKTOP-S8S50FR\\SQLEXPRESS;Initial Catalog=EVMS;Integrated Security=True";
            SqlConnection SqlCon = new SqlConnection(connectionString); //数据库连接
            SqlCon.Open(); //打开数据库
            string sql = "Select  s.* , sc.* from [dbo].[message board] as s, [dbo].[user_car] as sc where s.[DJID1]=sc.[DJID1] and sc.[UID]='" +GlobalData.UID+
                "' order by s.[LYBID] desc;";//查找用户sql语句
            SqlDataAdapter find = new SqlDataAdapter(sql, SqlCon);
            DataTable save = new DataTable();
            find.Fill(save);
            listView1.DataSource = save;
            //绑定数据
            listView1.DataBind();
        }

        private void title1_ImagePress(object sender, EventArgs e)
        {
            Close();

        }
    }
}