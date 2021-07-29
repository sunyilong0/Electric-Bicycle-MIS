using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using 电动车管理系统V2._0.User;
using 电动车管理系统V2._0.frmclass;
using 电动车管理系统V2._0.admin;

namespace 电动车管理系统V2._0
{
    partial class SmobilerForm1 : Smobiler.Core.Controls.MobileForm
    {
        public SmobilerForm1() : base()
        {
            InitializeComponent();
            txtTel.Text = "123456";
            txtPwd.Text = "123456";//测试使用，运营一定要删除syl

        }


        private void btnLogon_Click(object sender, EventArgs e)
        {
            //uSID = txtTel.Text.Trim();
            GlobalData.UID = txtTel.Text.Trim();//保存传递的字符串
            try
            {
                
                string userID = txtTel.Text.Trim();
                string Pwd = txtPwd.Text.Trim();
                if (string.IsNullOrEmpty(userID))
                    throw new Exception("请输入用户名！");
                if (string.IsNullOrEmpty(Pwd))
                    throw new Exception("请输入密码！");
                //数据库连接
                string connectionString = "Data Source=DESKTOP-S8S50FR\\SQLEXPRESS;Initial Catalog=EVMS;Integrated Security=True";
                SqlConnection SqlCon = new SqlConnection(connectionString); //数据库连接
                SqlCon.Open(); //打开数据库
                string sql = "Select * from [User] where UID='" + userID + "'" ;//查找用户sql语句
                SqlDataAdapter find = new SqlDataAdapter(sql, SqlCon);
                DataSet save = new DataSet();
                find.Fill(save);


                GlobalData.administrator = save.Tables[0].Rows[0][5].ToString();
                if (save.Tables[0].Rows.Count <= 0)
                    throw new Exception("用户不存在，请重新输入!");
                string pwd = save.Tables[0].Rows[0][4].ToString();
                //密码第五行row是4
                if (pwd ==Pwd)
                {
                    MessageBox.Show("登录成功");
                    GlobalData.administrator = save.Tables[0].Rows[0][5].ToString();
                        work work1 = new work();
                        this.Show(work1);

                }
                else
                {
                    throw new Exception("密码不正确，请重试!");
                }
                SqlCon.Close();
                if (chkRememberPwd.Checked==true)
                {
                    LoadClientData("pwd", Pwd);
                    ReadClientData("pwd", (object s, ClientDataResultHandlerArgs args) =>
                     {
                         if (string.IsNullOrEmpty(args.error))
                         {
                             Toast("密码为：" + args);
                         }
                     });

                }
            }
            catch(Exception ex)
            {
                Toast(ex.Message);
            }

        }

        private void button1_Press(object sender, EventArgs e)
        {

        }

        private void work_Press(object sender, EventArgs e)
        {
            Findall work2 = new Findall();
            this.Show(work2);

        }

        private void button1_Press_1(object sender, EventArgs e)
        {
            _0.User.show show1 = new _0.User.show();
            this.Show(show1);
           
        }

        private void 登记_Press(object sender, EventArgs e)
        {
            Register work2 = new Register();
            this.Show(work2);
        }

        private void SmobilerForm1_KeyDown(object sender, KeyDownEventArgs e)
        {
            if (e.KeyCode == KeyCode.Back)
            {
                HandleToast();
            }
        }
        private DateTime toasttime;//toast时间

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
    }
}