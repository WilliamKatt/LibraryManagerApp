using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LM.UI
{
    public partial class frmMain : Form
    {
        //定义全局的窗体变量
        private Form objFrm = null;

        public frmMain()
        {
            InitializeComponent();
           
        }
        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        #region 关闭本窗体
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确认退出吗?", "操作提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
            else
            {
                return;
            }
        }
        #endregion

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        #region 类别管理
        public void btnBookType_Click_1(object sender, EventArgs e)
        {
            objFrm = new frmBookType();
            splitContainer1.Panel2.Controls.Clear();
            //加载新窗体
            OpenNewFrm(objFrm);
        }
        #endregion

        #region 打开新窗体
        private void OpenNewFrm(Form objFrm)
        {
            objFrm.TopLevel = false;//指定窗体不是顶级窗体
            objFrm.WindowState = FormWindowState.Maximized;//让窗体最大化
            objFrm.FormBorderStyle = FormBorderStyle.None;//无边框
            objFrm.Parent = splitContainer1.Panel2;//指定新窗体的父窗体是Panel2
            objFrm.Show();
        }
        #endregion

        #region 最小化本窗体
        private void btnlast_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        #region 加载新窗体
        private void button2_Click(object sender, EventArgs e)
        {
            objFrm = new frmBookManage();
            splitContainer1.Panel2.Controls.Clear();
            //加载新窗体
            OpenNewFrm(objFrm);
        } 
        #endregion
    }
}
