using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace BaiTapLon.Models.Process
{
    public class StringProcess
    {
        public string AutoGenerateKey(string strInput)
        {
            //khai báo biến
            string strResult = "", numPart, strPart;
            int intPart;
            //StrInput = KH001
            //tách phần số 
            numPart = Regex.Match(strInput, @"\d+").Value;
            // tách phần chữ
            strPart = Regex.Match(strInput, @"\D+").Value;
            //chuyển phần số sang kiểu int và tăng lên 1 đơn vị
            intPart = Convert.ToInt32(numPart) + 1;

            //kết hợp phần số và chữ để trả về mã tự động sinh
            strResult = strPart + intPart;
            return strResult;
        }
    }
}