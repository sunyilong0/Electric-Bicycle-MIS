using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace 电动车管理系统V2._0.User
{
    ////ToolboxItem用于控制是否添加自定义控件到工具箱，true添加，false不添加
    //[System.ComponentModel.ToolboxItem(true)]
    partial class onefrmsile : Smobiler.Core.Controls.MobileUserControl
    {
        public onefrmsile() : base()
        {
            //This call is required by the SmobilerUserControl.
            InitializeComponent();
        }

        private void btnDownload_Press(object sender, EventArgs e)
        {

        }
    }
}