using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace 电动车管理系统V2._0
{
    partial class Findall : Smobiler.Core.Controls.MobileForm
    {
        public Findall() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }

        private void txtLday_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnupPhoto_Click(object sender, EventArgs e)
        {

        }

        private void btndelPhoto_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {

                //if (txtLday.Text.Trim().Length <= 0)
                //{
                //    throw new Exception("请输入完整信息！");
                //}
                ////赋值请假信息

                string carID = textBox6.Text.Trim();
                //数据库连接
                string connectionString = "Data Source=DESKTOP-S8S50FR\\SQLEXPRESS;Initial Catalog=EVMS;Integrated Security=True";
                SqlConnection SqlCon = new SqlConnection(connectionString); //数据库连接
                SqlCon.Open(); //打开数据库
                //string sql = "Select * from [User] where UID='" + carID + "'";//查找用户sql语句
                string sql = "select s.* , sc.* from [user_car] as s, [dbo].[User] as sc where s.[UID]=sc.[UID] and [DJID1]="+ carID + ";";
                SqlDataAdapter find = new SqlDataAdapter(sql, SqlCon);
                DataSet save = new DataSet();
                find.Fill(save);
                textBox2.Text = save.Tables[0].Rows[0][2].ToString();
                textBox5.Text = save.Tables[0].Rows[0][8].ToString();
                txtLday.Text = save.Tables[0].Rows[0][9].ToString();
                textBox4.Text = save.Tables[0].Rows[0][10].ToString();
                textBox1.Text = save.Tables[0].Rows[0][5].ToString();
                textBox3.Text = save.Tables[0].Rows[0][6].ToString();
                SqlCon.Close();
                //leave.L_CCTo = CCToUsers;
                //ReturnInfo result;
                //if (string.IsNullOrEmpty(LID) == false)
                //{
                //    leave.L_ID = LID;
                //    leave.L_UpdateUser = Client.Session["U_ID"].ToString();
                //    //更新请假信息
                //    result = AutofacConfig.leaveService.UpdateLeave(leave);
                //}
                //else
                //{
                //    //创建请假
                //    leave.L_CreateUser = Client.Session["U_ID"].ToString();
                //    result = AutofacConfig.leaveService.AddLeave(leave);
                //}
                ////如果返回值true表示请假信息创建或更新成功，否则失败并抛出错误
                //if (result.IsSuccess == true)
                //{
                //    ShowResult = ShowResult.Yes;
                //    //if (string.IsNullOrEmpty(LID) == true)
                //    //{
                //    Close();
                //    //}
                //    Toast("您的请假条已成功提交！", ToastLength.SHORT);

                //}
                //else
                //{
                //    throw new Exception(result.ErrorInfo);
                //}

            }
            catch (Exception ex)
            {
                //Toast(ex.Message, ToastLength.SHORT);
                Toast("未找到该车辆编号，请重新输入！");
            }


        }

        private void button1_Press(object sender, EventArgs e)
        {
            Client.TelCall(textBox1.Text);
        }

        private void 查询电动车所有信息_ImagePress(object sender, EventArgs e)
        {
            Close();
        }
    }
}