using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Smobiler.Core;
using Smobiler.Core.Controls;
using 电动车管理系统V2._0.frmclass;
using 电动车管理系统V2._0.User;

namespace 电动车管理系统V2._0
{
    partial class Register : Smobiler.Core.Controls.MobileForm
    {
        public Register() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }

        private void txtLday_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnupPhoto_Click(object sender, EventArgs e)
        {
            camera1.GetPhoto();
        }

        private void btndelPhoto_Click(object sender, EventArgs e)
        {
            if (imgL.ResourceID.Length > 0)
            {
                MessageBox.Show("是否确定删除图片？", "删除", Smobiler.Core.Controls.MessageBoxButtons.YesNo, (Object s, MessageBoxHandlerArgs args) =>
                {
                    if (args.Result == Smobiler.Core.Controls.ShowResult.Yes)
                    {
                        imgL.ResourceID = "";
                        imgL.Refresh();
                    }
                }
                       );
            }
            else
            {
                Toast("您没有上传图片，不能删除！", ToastLength.SHORT);
            }
        }

        /// <summary>
        /// 获取图片二进制
        /// </summary>
        /// <param name="pic">存储图片的picturebox控件</param>
        /// <param name="name">图片后缀名</param>
        /// <returns></returns>
        private byte[] getbyte(PictureBox pic, string name)//
        {
            byte[] arr = null;
            MemoryStream ms = new MemoryStream();
            if (name.ToLower() == ".gif")
            {
                pic.Image.Save(ms, ImageFormat.Gif);//指定图片的格式
            }
            else if (name.ToLower() == ".png")
            {
                pic.Image.Save(ms, ImageFormat.Png);
            }
            else if (name.ToLower() == ".bmp")
            {
                pic.Image.Save(ms, ImageFormat.Bmp);
            }
            else if (name.ToLower() == ".jpeg" || name.ToLower() == ".jpg")
            {
                pic.Image.Save(ms, ImageFormat.Jpeg);
            }
            arr = ms.GetBuffer();//主要为这句
            return arr;
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtLday.Text.Trim().Length <= 0 || textBox2.Text.Trim().Length <= 0 
                    ||  textBox1.Text.Trim().Length <= 0 || textBox3.Text.Trim().Length <= 0 )
                {
                    throw new Exception("请输入完整信息！");
                }
                //赋值信息
                string UID;
                if (GlobalData.UID==null)
                {
                     UID = "123456";//测试UID
                }
                else
                {
                    UID = GlobalData.UID;
                }
                string carID = txtLday.Text.Trim();
                string CJID = textBox2.Text.Trim();
                string CPID = textBox4.Text.Trim();
                string PHone = textBox1.Text.Trim();
                string Email = textBox3.Text.Trim();
                string mage=imgL.ResourceMode.ToString();

                //数据库连接
                string connectionString = "Data Source=DESKTOP-S8S50FR\\SQLEXPRESS;Initial Catalog=EVMS;Integrated Security=True";
                SqlConnection SqlCon = new SqlConnection(connectionString); //数据库连接
                SqlCon.Open(); 
                //打开数据库
                string sql = "insert into [dbo].[user_car] ([DJID1],[UID],[CJID1],[CPID1],[PHONE1],[EMIALL1],[CLIMAGE1]) values('"
                    + carID+ "', '" + UID + "', '" + CJID + "', '" + CPID + "', '" + PHone + "', '" + Email + "','"+mage+"'); ";
                SqlCommand mycom = new SqlCommand(sql, SqlCon);
                int a = mycom.ExecuteNonQuery();
                SqlCon.Close();
                MessageBox.Show("登记成功！成功插入"+a+"条数据。");

            }
            catch (Exception ex)
            {
                //Toast(ex.Message, ToastLength.SHORT);
                Toast("该校内编号信息已登记");
            }
        }

        private void popType_Selected(object sender, EventArgs e)
        {

        }

        private void title1_ImagePress(object sender, EventArgs e)
        {
            Close();

        }

        private void camera1_ImageCaptured(object sender, BinaryResultArgs e)
        {
            if (string.IsNullOrEmpty(e.error))
            {

                if (imgL.ResourceID.Trim().Length > 0)
                {
                    e.SaveFile(imgL.ResourceID, MobileResourceManager.DefaultImagePath);
                    //  e.SaveFile(imgL.ResourceID);//保存图片文件到本地运行项目的image文件夹中
                    imgL.Refresh();//当图片上传文件名相同时，刷新界面图片内容
                }
                else
                {
                    e.SaveFile(e.ResourceID, MobileResourceManager.DefaultImagePath);
                    //e.SaveFile(e.ResourceID);//保存图片文件到本地运行项目的image文件夹中
                    imgL.ResourceID = e.ResourceID;

                }
            }
        }
    }
}