using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using 电动车管理系统V2._0.frmclass;
using 电动车管理系统V2._0.User;

namespace 电动车管理系统V2._0.User
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class Onebikeshow : Smobiler.Core.Controls.MobileUserControl
    {
        public Onebikeshow() : base()
        {
            //This call is required by the SmobilerUserControl.
            InitializeComponent();
   

        }

        private void panel1_Press(object sender, EventArgs e)
        {
            //string userid = lbluser.BindDataValue.ToString();// 获取绑定数据值
            //string username = lbluser.BindDisplayValue.ToString();// 获取数据绑定显示值
            //MessageBox.Show("数据值:"+ userid +",数据显示:"+ username+ "，行项点击");//弹出框
            GlobalData.CarID = lbluser.BindDataValue.ToString();
            findmycar work6 = new findmycar();
            this.Form.Show(work6); //非窗口中的弹出窗口



        }
    }
}