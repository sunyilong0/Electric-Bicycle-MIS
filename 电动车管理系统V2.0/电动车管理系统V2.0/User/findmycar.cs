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

namespace 电动车管理系统V2._0.User
{
    partial class findmycar : Smobiler.Core.Controls.MobileForm
    {
        public findmycar() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
            try
            {


                string carID =GlobalData.CarID ;
                //数据库连接
                string connectionString = "Data Source=DESKTOP-S8S50FR\\SQLEXPRESS;Initial Catalog=EVMS;Integrated Security=True";
                SqlConnection SqlCon = new SqlConnection(connectionString); //数据库连接
                SqlCon.Open(); //打开数据库
                //string sql = "Select * from [User] where UID='" + carID + "'";//查找用户sql语句
                string sql = "select s.* , sc.* from [user_car] as s, [dbo].[User] as sc where s.[UID]=sc.[UID] and [DJID1]='" + carID + "';";
                SqlDataAdapter find = new SqlDataAdapter(sql, SqlCon);
                DataSet save = new DataSet();
                find.Fill(save);
                GlobalData.CarID = carID;
                textBox6.Text = carID;
                textBox2.Text = save.Tables[0].Rows[0][2].ToString();
                textBox5.Text = save.Tables[0].Rows[0][8].ToString();
                txtLday.Text = save.Tables[0].Rows[0][9].ToString();
                textBox4.Text = save.Tables[0].Rows[0][10].ToString();
                textBox1.Text = save.Tables[0].Rows[0][5].ToString();
                textBox3.Text = save.Tables[0].Rows[0][6].ToString();
                //imgL.ResourceMode.ToString()= save.Tables[0].Rows[0][6].ToString();
                SqlCon.Close();


            }
            catch (Exception ex)
            {
                //Toast(ex.Message, ToastLength.SHORT);
                Toast("未找到该车辆编号，请重新输入！");
            }
        }


        private void txtLday_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void title1_ImagePress(object sender, EventArgs e)
        {
            Close();
        }

        private void buttondelete_Press(object sender, EventArgs e)
        {
            MessageBox.Show("您确定要删除该信息吗？", "提示", MessageBoxButtons.YesNo, (obj, args) =>
            {
                if (args.Result == ShowResult.No) { }
                if (args.Result == ShowResult.Yes)
                {
                    string carID = GlobalData.CarID;
                    //数据库连接
                    string connectionString = "Data Source=DESKTOP-S8S50FR\\SQLEXPRESS;Initial Catalog=EVMS;Integrated Security=True";
                    SqlConnection SqlCon = new SqlConnection(connectionString); //数据库连接
                    SqlCon.Open(); //打开数据库
                                   //string sql = "Select * from [User] where UID='" + carID + "'";//查找用户sql语句
                    string sql = "delete 	from  [dbo].[user_car] where [DJID1]='" + carID + "';";
                    SqlCommand mycom = new SqlCommand(sql, SqlCon);
                    int a = mycom.ExecuteNonQuery();
                    SqlCon.Close();
                    show work2 = new show();
                    this.Show(work2);
                    Toast("信息删除成功。");
                }
            });

        }

        private void buttonrefrom_Press(object sender, EventArgs e)
        {
            string carID = GlobalData.CarID;
            //数据库连接
            string connectionString = "Data Source=DESKTOP-S8S50FR\\SQLEXPRESS;Initial Catalog=EVMS;Integrated Security=True";
            SqlConnection SqlCon = new SqlConnection(connectionString); //数据库连接
            SqlCon.Open(); //打开数据库
                           //string sql = "Select * from [User] where UID='" + carID + "'";//查找用户sql语句
            string sql = "update [dbo].[user_car] set[CJID1] = '"+ textBox2.Text.Trim() + "' , [PHONE1]='"+textBox1.Text.Trim() + "',[EMIALL1]='"+textBox3.Text.Trim()+"' where[DJID1] ='"+GlobalData.CarID+"'";
            SqlCommand mycom = new SqlCommand(sql, SqlCon);
            int a = mycom.ExecuteNonQuery();
            SqlCon.Close();
            show work2 = new show();
            this.Show(work2);
            Toast("信息更新成功。");
            
        }

        private void cameraButton1_ImageCaptured(object sender, BinaryResultArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(e.error))
                {
                    string ResourceID = textBox6.Text + ".png";
                    //图片名称/保存图片文件到本地运行项目的image文件夹中
                    e.SaveFile(ResourceID);
// cameraButton1.ResourceID = ResourceID;//赋值|

                }

            }
            catch (Exception ex)
            {
                Toast(ex.Message);
            }
        }
    }
}