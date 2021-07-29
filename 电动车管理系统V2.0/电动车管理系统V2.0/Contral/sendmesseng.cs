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
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class sendmesseng : Smobiler.Core.Controls.MobileUserControl
    {
        public sendmesseng() : base()
        {
            //This call is required by the SmobilerUserControl.
            InitializeComponent();
        }

        private void butNo_Press(object sender, EventArgs e)
        {
            Close();
        }

        private void butYes_Press(object sender, EventArgs e)
        {
            try
            {

                if (textBox1.Text.Trim().Length <= 5 )
                {
                    throw new Exception("请输入5个字以上的信息！");
                }
                //赋值信息
               
                string messe = textBox1.Text.Trim();
       

                //数据库连接
                string connectionString = "Data Source=DESKTOP-S8S50FR\\SQLEXPRESS;Initial Catalog=EVMS;Integrated Security=True";
                SqlConnection SqlCon = new SqlConnection(connectionString); //数据库连接
                SqlCon.Open();
                //打开数据库
                string sql = "insert into [dbo].[message board] ([DJID1],[NR]) values('"+GlobalData.CarID+"','"+messe+"');";
                SqlCommand mycom = new SqlCommand(sql, SqlCon);
                int a = mycom.ExecuteNonQuery();
                SqlCon.Close();
                Toast("留言成功！");
                Close();

            }
            catch (Exception ex)
            {
                Toast(ex.Message, ToastLength.SHORT);
               
            }
        }
    }
}