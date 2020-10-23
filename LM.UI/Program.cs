using LM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LM.UI
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmLogin frm = new frmLogin();
            DialogResult fm= frm.ShowDialog();
            if (fm == DialogResult.OK)
            {
                frmMain obj = new frmMain();
                obj.ShowDialog();
            }
        }
        //定义全局静态变量，存储登录用户信息
        public static SysAdminsModel currentLogin = null;
    }
}
