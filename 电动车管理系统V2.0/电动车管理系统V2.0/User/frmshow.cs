using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;
using 电动车管理系统V2._0.frmclass;
using 电动车管理系统V2._0.frmclass;
using 电动车管理系统V2._0.User;
using System.Data;
using System.Data.SqlClient;

namespace 电动车管理系统V2._0.User
{
    partial class show : Smobiler.Core.Controls.MobileForm
    {
        public show() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }

        public SqlConnection Conn { get; private set; }

        private void show_Load(object sender, EventArgs e)
        {
            //数据库连接
            //string connectionString = "Data Source=DESKTOP-S8S50FR\\SQLEXPRESS;Initial Catalog=EVMS;Integrated Security=True";
            //SqlConnection sqlcomnon = new SqlConnection(connectionString); //数据库连接


            //string CommandText = String.Format("select * from [user]");
            //int returnExecuteSelect = DBHelper.ExecuteSelect(CommandText);



            //数据库连接
            //string connectionString = "Data Source=DESKTOP-S8S50FR\\SQLEXPRESS;Initial Catalog=EVMS;Integrated Security=True";
            //SqlConnection SqlCon = new SqlConnection(connectionString); //数据库连接
            //SqlCon.Open(); //打开数据库
            //string sql = "Select * from [user_car] ";//查找用户sql语句
            //SqlDataAdapter table = new SqlDataAdapter(sql, SqlCon);
            //DataTable save = new DataTable();
            //table.Fill(save);
            ////
            ///           syl 无解 

            //ArrayList arr = new ArrayList();
            ////实例化一个SqlCommand对象来执行SQL命令
            // String ConStr = "Data Source=DESKTOP-S8S50FR\\SQLEXPRESS;Initial Catalog=EVMS;Integrated Security=True";
            //SqlConnection conn = new SqlConnection(ConStr);
            //SqlCommand cmd = new SqlCommand("select * from [user_car]", conn);
            //conn.Open();
            //    //声明SqlDataReader对象读取SQL命令返回的数据
            //    SqlDataReader reader = cmd.ExecuteReader();
            //    while (reader.Read())        //逐行读取数据
            //    {
            //        for (int i = 0; i < reader.FieldCount; i++)
            //            arr.Add(reader[i]);
            //    }
            //    //System.Data.DataTable table = ConvertDataReaderToDataTable(arr);
            //    System.Data.DataTable table = ToDataTableTow(arr);
            //    listView1.DataSource = table;
            //    //绑定数据
            //    listView1.DataBind();
            //////连接数据库
            //SqlCommon 1common = new SqlCommon();
            ////查询数据
            //System.Data.DataTable table = 1common.common(" select * from [user_car] ");
            //赋值数据

            //第N方法_成功
            //数据库连接
            string connectionString = "Data Source=DESKTOP-S8S50FR\\SQLEXPRESS;Initial Catalog=EVMS;Integrated Security=True";
            SqlConnection SqlCon = new SqlConnection(connectionString); //数据库连接
            SqlCon.Open(); //打开数据库
            string sql = "Select * from [user_car] where [UID] ='"+GlobalData.UID+"';";//查找用户sql语句
            SqlDataAdapter find = new SqlDataAdapter(sql, SqlCon);
            DataTable save= new DataTable();
            find.Fill(save);
            listView1.DataSource = save;
            //绑定数据
            listView1.DataBind();
            
        }

        public static DataTable ToDataTableTow(IList list)
        {
            DataTable result = new DataTable();

            if (list.Count > 0)
            {
                PropertyInfo[] propertys = list[0].GetType().GetProperties();

                foreach (PropertyInfo pi in propertys)
                {

                    result.Columns.Add(pi.Name, pi.PropertyType);

                }
                for (int i = 0; i < list.Count; i++)
                {

                    ArrayList tempList = new ArrayList();

                    foreach (PropertyInfo pi in propertys)
                    {

                        object obj = pi.GetValue(list[i], null);

                        tempList.Add(obj);
                    }

                    object[] array = tempList.ToArray();

                    result.LoadDataRow(array, true);
                }
            }
            return result;
        }

        public static DataTable ConvertDataReaderToDataTable(SqlDataReader dataReader)
        {
            ///定义DataTable  
            DataTable datatable = new DataTable();

            try
            {    ///动态添加表的数据列  
                for (int i = 0; i < dataReader.FieldCount; i++)
                {
                    DataColumn myDataColumn = new DataColumn();
                    myDataColumn.DataType = dataReader.GetFieldType(i);
                    myDataColumn.ColumnName = dataReader.GetName(i);
                    datatable.Columns.Add(myDataColumn);
                }

                ///添加表的数据  
                while (dataReader.Read())
                {
                    DataRow myDataRow = datatable.NewRow();
                    for (int i = 0; i < dataReader.FieldCount; i++)
                    {
                        myDataRow[i] = dataReader[i].ToString();
                    }
                    datatable.Rows.Add(myDataRow);
                    myDataRow = null;
                }
                ///关闭数据读取器  
                dataReader.Close();
                return datatable;
            }
            catch (Exception ex)
            {
                ///抛出类型转换错误  
                //SystemError.CreateErrorLog(ex.Message);  
                throw new Exception(ex.Message, ex);
            }
        }

        private void title1_ImagePress(object sender, EventArgs e)
        {
            work work1 = new work();
            this.Show(work1);
        }

        private void show_KeyDown(object sender, KeyDownEventArgs e)
        {
            work work1 = new work();
            this.Show(work1);
        }
    }
}