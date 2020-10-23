using LM.BLL;
using LM.Common;
using LM.Model;
using LM.Model.Extension;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LM.UI
{
    public partial class frmBookManage : Form
    {
        private static BookManage bkbll = new BookManage();
        //定义图书的全局变量
        private List<BookExtModel> bklist = bkbll.GetAllBooks();
        //定义出版社的全局变量
        private List<PressModel> presslist = bkbll.GetBookPress();
        public frmBookManage()
        {
            InitializeComponent();
        }

        private void frmBookManage_Load(object sender, EventArgs e)
        {
            BindBook(bklist);
            BindPress(presslist);
            cmbPressName.SelectedIndexChanged += CmbPressName_SelectedIndexChanged;
        }

        private void CmbPressName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPressName.SelectedValue != null)
            {
                int pid = int.Parse(cmbPressName.SelectedValue.ToString());//获取下拉框选择项的文本
                //过滤集合中的指定条件
                List<BookExtModel> bkdata = bklist.FindAll(x => x.BookPress == pid);
                BindBook(bkdata);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="presslist"></param>
        private void BindPress(List<PressModel> data)
        {
            if (data.Count > 0)
            {
                cmbPressName.DataSource = data;
                cmbPressName.DisplayMember = "PressName";
                cmbPressName.ValueMember = "PressId";
                cmbPressName.SelectedIndex = -1;//不选任何一个
            }
        }

        /// <summary>
        /// 绑定图书信息
        /// </summary>
        /// <param name="bklist"></param>
        private void BindBook(List<BookExtModel> data)
        {
            if (data.Count > 0)
            {
                dgvBook.DataSource = null;
                dgvBook.AutoGenerateColumns = false;//禁用自动产生列
                dgvBook.DataSource = data;
                
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbPressName_SelectedIndexChanged_1(object sender, EventArgs e)
        {
           
        }

        private void btnCloseCode_Click(object sender, EventArgs e)
        {
            txtBookName.Text = txtBookCode.Text = string.Empty;
            frmBookManage_Load(null, null);
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            string ctrl = txtBookName.Text.Trim();
            string ctr2 = txtBookCode.Text.Trim();
            //提前采用lamdba表达
            List<BookExtModel> bkinfo = bklist.FindAll(s => s.BookId.Contains(ctrl));
            List<BookExtModel> bkinfo2 = bkinfo.FindAll(x => x.BookName.Contains(ctr2));
            BindBook(bkinfo2);
        }

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //获取当前dgv选择中的行图书编号 
            frmBookDetail objfrm = new frmBookDetail();
            objfrm.actionflag = 1;
            DialogResult dr = objfrm.ShowDialog();
            if (dr == DialogResult.OK)
            {
                List<BookExtModel> data = bkbll.GetAllBooks();
                BindBook(data);
            }
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //获取当前dgv选择中的行图书编号 
            string bkid = dgvBook.CurrentRow.Cells[0].Value.ToString();
            frmBookDetail objfrm = new frmBookDetail();
            objfrm.bookid = bkid;
            objfrm.actionflag = 2;
            DialogResult dr = objfrm.ShowDialog();
            if (dr == DialogResult.OK)
            {
                List<BookExtModel> data = bkbll.GetAllBooks();
                BindBook(data);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "Excel Filles(*,xls)|*.xls";
            sf.CheckFileExists = false;
            sf.CheckPathExists = false;
            sf.FilterIndex = 0;
            sf.RestoreDirectory = true;
            sf.CreatePrompt = true;
            if (sf.ShowDialog() == DialogResult.OK)
            {
                Stream savestr = sf.OpenFile();
                DataGridViewHelper.DataGridViewToExcel(dgvBook, savestr);
            }
        }
    }
}
