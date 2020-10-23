using LM.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LM.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 加密数据库连接字符串
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            //获取
            string mingwen = textBox1.Text.Trim();
            //加密
            string miwen = EncryptHelper.AESEncrypt(mingwen);
            //赋值
            textBox2.Text = miwen;
        }
        /// <summary>
        /// 测试连接
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            //获取
            string miwen = textBox2.Text.Trim();
            //解密
            string mingwen = EncryptHelper.AESDecrypt(miwen);
            //测试
            SqlConnection conn = new SqlConnection(mingwen);
            conn.Open();
            if (ConnectionState.Open == conn.State)
            {
                MessageBox.Show("连接成功");
            }
            else
            {
                MessageBox.Show("连接失败");
            }
            conn.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
