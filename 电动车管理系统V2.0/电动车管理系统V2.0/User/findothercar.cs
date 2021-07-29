using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using 电动车管理系统V2._0.frmclass;
using 电动车管理系统V2._0.User;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace 电动车管理系统V2._0.User
{
    partial class findothercar : Smobiler.Core.Controls.MobileForm
    {
        public findothercar() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }

        private void txtLday_TextChanged(object sender, EventArgs e)
        {

        }
        public string getStr(string strInput, int intLen)
        {
            strInput = strInput.Trim();
            byte[] myByte = System.Text.Encoding.Default.GetBytes(strInput);
            if (myByte.Length > intLen)
            {
                //截取操作
                string resultStr = "";
                for (int i = 0; i < strInput.Length; i++)
                {
                    byte[] tempByte = System.Text.Encoding.Default.GetBytes(resultStr);
                    if (tempByte.Length < intLen)
                    {
                        resultStr += strInput.Substring(i, 1);
                    }
                    else
                    {
                        break;
                    }
                }
                return resultStr + "...";
            }
            else
            {
                return strInput;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {

                if (textBox6 .Text.Trim().Length <= 0)
                {
                    throw new Exception("请输入校内编号信息！");
                }
                //赋值请假信息

                string carID = textBox6.Text.Trim();
                GlobalData.CarID = carID;
                //数据库连接
                string connectionString = "Data Source=DESKTOP-S8S50FR\\SQLEXPRESS;Initial Catalog=EVMS;Integrated Security=True";
                SqlConnection SqlCon = new SqlConnection(connectionString); //数据库连接
                SqlCon.Open(); //打开数据库
                //string sql = "Select * from [User] where UID='" + carID + "'";//查找用户sql语句
                string sql = "select s.* , sc.* from [user_car] as s, [dbo].[User] as sc where s.[UID]=sc.[UID] and [DJID1]=" + carID + ";";
                SqlDataAdapter find = new SqlDataAdapter(sql, SqlCon);
                DataSet save = new DataSet();
                find.Fill(save);
             
                textBox2.Text = getStr(save.Tables[0].Rows[0][2].ToString(), 3);
                textBox5.Text = getStr(save.Tables[0].Rows[0][8].ToString(),1);
                textBox1.Text = getStr(save.Tables[0].Rows[0][5].ToString(),3);
                textBox3.Text = getStr(save.Tables[0].Rows[0][6].ToString(),3);
                SqlCon.Close();

            }
            catch (Exception ex)
            {
                //Toast(ex.Message, ToastLength.SHORT);
                Toast("未找到该车辆编号，请重新输入！");
            }
        }

        private void buttonLY_Press(object sender, EventArgs e)
        {
            ShowDialog(new sendmesseng());


        }

        private void title1_ImagePress(object sender, EventArgs e)
        {
            Close();

        }
    }
}