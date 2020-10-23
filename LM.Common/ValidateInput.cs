using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LM.Common
{
    /// <summary>
    /// 输入校验帮助类
    /// </summary>
    public static class ValidateInput
    {
        //是否是数字
        public static bool IsInteger(string txt)
        {
            Regex objRegex = new Regex(@"^[0-9]*$");
            return objRegex.IsMatch(txt);
        }
        //是否是邮箱地址
        public static bool IsEmail(string txt)
        {
            Regex objRegex = new Regex(@"^\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$");
            return objRegex.IsMatch(txt);
        }
        //是否是手机号码 
        public static bool IsMobile(string txt)
        {
            Regex objRegex = new Regex(@"^[1][3578]\d{9}$");
            return objRegex.IsMatch(txt);
        }
        //是否是汉字
        public static bool IsChinese(string txt)
        {
            Regex objRegex = new Regex(@"^[\u4e00-\u9fa5]{0,}$");
            return objRegex.IsMatch(txt);
        }
    }
}
