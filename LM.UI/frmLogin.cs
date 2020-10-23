using LM.BLL;
using LM.Common;
using LM.Model;
using My.Validater;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LM.UI
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            //让账号文本框成为焦点
            txtLoginId.Focus();
        }
        private ToolTip tt = new ToolTip();
        
        #region 窗体加载事件
        private void frmLogin_Load(object sender, EventArgs e)
        {
            CreateValidation();//产生验证码
            //动态地添加提示信息
            tt.SetToolTip(txtLoginId, "请输入账号(纯数字)");
            tt.SetToolTip(txtLoginPwd, "请输入密码");
            tt.SetToolTip(txtCode, "请输入验证码");
            tt.SetToolTip(pictureBox2, "单击跟换验证码");
        }
        #endregion
        
        #region 产生验证码方法
        private void CreateValidation()
        {
            VerifyCodeHelper helper = new VerifyCodeHelper();
            pictureBox2.Image = helper.CreateImage();
            lblCode.Text = helper.CreateRandomCode();
        } 
        #endregion

        #region 窗体随鼠标移动事件
        private Point mouseOff;//位置变量
        private bool leftFlag;//是否左键
        private void frmLogin_MouseMove(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                Point mouseSet = Control.MousePosition;
                mouseSet.Offset(mouseOff.X, mouseOff.Y);
                Location = mouseSet;
            }
        }
        private void frmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseOff = new Point(-e.X, -e.Y);//得到变量的值
                leftFlag = true;
            }
        }
        private void frmLogin_MouseUp(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                leftFlag = false;
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseOff = new Point(-e.X, -e.Y);//得到变量的值
                leftFlag = true;
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                Point mouseSet = Control.MousePosition;
                mouseSet.Offset(mouseOff.X, mouseOff.Y);
                Location = mouseSet;
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                leftFlag = false;
            }
        }
        #endregion

        #region 提示信息进行闪烁
        Thread th;
        int i;
        private void run()
        {
            while (true)
            {
                if (i == 0)
                {
                    i++;
                    lblInfo.ForeColor = Color.White;
                }
                else
                {
                    i++;
                    lblInfo.ForeColor = Color.Yellow;
                }
                if (i > 1)
                {
                    i = 0;
                }
                Thread.Sleep(500);
            }
        }
        public void fang()
        {
            if (th == null || !th.IsAlive)
            {
                th = new Thread(run);
                th.IsBackground = true;
                th.Start();
            }
        }
        #endregion

        #region 窗体关闭
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region 焦点事件
        private void txtLoginId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)//13代表回车键
            {
                
                if (txtLoginId.Text.Trim().Length == 0)//不能为空
                {
                    txtLoginId.Focus();//账号框成为焦点
                }
                if (txtLoginPwd.Text.Trim().Length == 0)
                {
                    txtLoginPwd.Focus();//密码框成为焦点
                }
                if (txtCode.Text.Trim().Length == 0)
                {
                    txtCode.Focus();//验证码框成为焦点
                }
            }
            
        } 
        #endregion

        #region 登陆事件
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //1、数据有效性验证
            #region 验证账号
            if (txtLoginId.Text.Length == 0)
            {
                lblInfo.Visible = true;
                lblInfo.Text = "账号不能为空！";
                this.txtLoginId.Focus();
                //开始闪烁
                fang();
                return;
            }
            if (!ValidateInput.IsInteger(txtLoginId.Text.Trim()))
            {
                lblInfo.Visible = true;
                lblInfo.Text = "账号必须是正整数！";
                this.txtLoginId.Focus();
                //开始闪烁
                if (th == null || !th.IsAlive)
                {
                    th = new Thread(run);
                    th.IsBackground = true;
                    th.Start();
                }
                return;
            }
            #endregion
            #region 验证密码
            if (txtLoginPwd.Text.Length == 0)
            {
                lblInfo.Visible = true;
                lblInfo.Text = "密码不能为空！";
                this.txtLoginPwd.Focus();
                //开始闪烁
                fang();
                return;
            }
            #endregion
            #region 验证验证码
            if (txtCode.Text.Length == 0)
            {
                lblInfo.Visible = true;
                lblInfo.Text = "验证码不能为空";
                this.txtCode.Focus();
                //开始闪烁
                fang();
                return;
            }
            //验证验证码
            if (lblCode.Text != txtCode.Text.Trim())
            {
                lblInfo.Visible = true;
                lblInfo.Text = "验证码不正确";
                this.txtCode.Focus();
                CreateValidation();
                txtCode.Text = "";
                //开始闪烁
                fang();
                return;
            }
            #endregion
            //2、提交数据库验证
            //构建登陆对象
            SysAdminsModel loginModel = new SysAdminsModel();
            loginModel.LoginId = Convert.ToInt32(txtLoginId.Text.Trim());
            loginModel.LoginPwd = EncryptHelper.EncryptByMd5(txtLoginPwd.Text.Trim());
            SysAdminsManager bll = new SysAdminsManager();
            SysAdminsModel loginInfo = bll.QueryLoginAccount(loginModel);
            //3.根据结果来判断(账号禁用,账号密码错误,账号密码不存在)
            if (loginInfo == null)
            {
                lblInfo.Visible = true;
                lblInfo.Text = "账号密码错误！";
                this.txtLoginId.Focus();
                //开始闪烁
                fang();
                return;
            }
            else if (loginInfo.IsDisable == true)
            {
                lblInfo.Visible = true;
                lblInfo.Text = "账号被禁用,请与管理员联系！";
                this.txtLoginId.Focus();
                //开始闪烁
                fang();
                return;
            }
            else//账号是正常的
            {
                //1.处理后面的逻辑(1=更新登录时间)
                int rst = bll.UpdateLoginTime(loginInfo.LoginId);
                if (rst != 1)
                {
                    MessageBox.Show("更新登录时间失败");
                }
                //2.写入登录日志
                LoginLogsManager logbll = new LoginLogsManager();
                LoginLogsModel logmodel = new LoginLogsModel()
                {
                    LoginId = loginInfo.LoginId,
                    UserName = loginInfo.UserName,
                    LoginComputer = Dns.GetHostName(),
                    LoginTime = logbll.GetServerTime()
                };
                int result = logbll.WriteLoginLogs(logmodel);
                if (result != 1)
                {
                    MessageBox.Show("写入登录日志失败");
                    return;
                }
                //3.写入全局变量
                Program.currentLogin = loginInfo;
                //4.设置窗体的状态值为ok
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
        #endregion

        #region 键盘按钮事件
        private void txtLoginId_KeyPress(object sender, KeyPressEventArgs e)
        {
            lblInfo.Visible = false;
        } 
        private void txtLoginPwd_KeyPress(object sender, KeyPressEventArgs e)
        {
            lblInfo.Visible = false;
        }
        #endregion
        
        #region 窗体进去时产生验证码
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            CreateValidation();
        } 
        #endregion

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_KeyDown(object sender, KeyEventArgs e)
        {
            
        }
    }
}
