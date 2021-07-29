using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 电动车管理系统V2._0.frmclass
{
    class FunctionMY
    {
        public string GetStr(string strInput, int intLen)
        {
            strInput = strInput.Trim();
            byte[] myByte = System.Text.Encoding.Default.GetBytes(strInput);
            //Response.Write("getStr Function is::" + myByte.Length.ToString());
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
    }
}
