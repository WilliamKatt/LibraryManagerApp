using LM.BLL;
using LM.Common;
using LM.Model;
using LM.Model.Extension;
using MyVideo;
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
    public partial class frmBookDetail : Form
    {
        //定义全局的变量
        public string bookid = "";
        //1代表添加,2代表修改,3代表查看
        public int actionflag = 1;
        //定义相关的业务操作类
        private static BookManage bkbll = new BookManage();
        private static BookPressManager bpbll = new BookPressManager();
        private static BookTypeManager btbll = new BookTypeManager();
        //所有的出版社集合
        public List<PressModel> presslist = bpbll.GetAllBookPress();
        //所有的类别集合
        public List<BookTypeModel> typelist = btbll.GetAllBookTypes();
        //摄像头操作类
        private Video objVideo = null;
        public frmBookDetail()
        {
            InitializeComponent();
            //填充出版社下拉框
            BindPress();
            //填充图书类别下拉框
            BindOneType();
        }

        private void BindOneType()
        {
            if (typelist.Count > 0)
            {
                cboBookTypeOne.DataSource = typelist;
                cboBookTypeOne.DisplayMember = "TypeName";
                cboBookTypeOne.ValueMember = "TypeId";
                cboBookTypeOne.SelectedIndex = -1;
                cboBookTypeOne.SelectedIndexChanged += CboBookTypeOne_SelectedIndexChanged;

            }
        }

        private void CboBookTypeOne_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboBookTypeOne.SelectedItem != null)
            {
                BookTypeModel btype = (BookTypeModel)cboBookTypeOne.SelectedItem;
                List<BookTypeModel> typetwo = typelist.FindAll(x => x.ParentTypeId == btype.TypeId);
                if (typetwo.Count > 0)
                {
                    cboBookTypeTwo.DataSource = null;
                    cboBookTypeTwo.DataSource = typetwo;
                    cboBookTypeTwo.DisplayMember = "TypeName";
                    cboBookTypeTwo.ValueMember = "TypeId";
                    cboBookTypeTwo.SelectedIndex = -1;
                }
            }
        }

        private void BindPress()
        {
            if (presslist.Count > 0)
            {
                cboBookPress.DataSource = presslist;
                cboBookPress.DisplayMember = "PressName";
                cboBookPress.ValueMember = "PressId";
                cboBookPress.SelectedIndex = -1;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cmbPressName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 重启摄像头
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStartCamera_Click(object sender, EventArgs e)
        {
            //启动摄像头
            try
            {
                objVideo = new Video(pbImage.Handle, pbImage.Left, pbImage.Top, pbImage.Width, (short)pbImage.Height);
                objVideo.OpenVideo();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
        /// <summary>
        /// 关闭摄像头
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCloseCamera_Click(object sender, EventArgs e)
        {
            objVideo.CloseVideo();
        }
        /// <summary>
        /// 开始拍照
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStartPhoto_Click(object sender, EventArgs e)
        {
            pbCurrentImage.BackgroundImage = objVideo.CatchVideo();
        }
        /// <summary>
        /// 清除选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClearPhoto_Click(object sender, EventArgs e)
        {
            pbCurrentImage.BackgroundImage = null;
        }
        /// <summary>
        /// 选择图片
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelect_Click(object sender, EventArgs e)
        {
            //打开对话框
            OpenFileDialog objOpenFile = new OpenFileDialog();
            //设定文件类型
            objOpenFile.Filter = "图片文件|*.jpg;*.png;*.bmp";
            //如果选择好文件，展示图片
            if (objOpenFile.ShowDialog() == DialogResult.OK)
            {
                pbCurrentImage.BackgroundImage = Image.FromFile(objOpenFile.FileName);
            }
        }

        private void frmBookDetail_Load(object sender, EventArgs e)
        {
            switch (actionflag)
            {
                case 1://添加
                    Addbkfrm();
                    break;
                case 2://修改
                    Editbkfrm();
                    break;
                case 3://查看
                    Viewbkfrm();
                    break;
            }
        }

        private void Viewbkfrm()
        {

        }

        private void Addbkfrm()
        {
            lblTiele.Text = "【添加图书】";
            txtBookId.Text = bkbll.CreateNewBookId();
            txtBookId.ReadOnly = true;
        }
        private void Editbkfrm()
        {
            lblTiele.Text = "【修改图书】";
            BookExtModel bkinfo = bkbll.GetBookModelById(bookid);
            if (bkinfo != null)
            {
                //页面控件赋值
                txtBookId.Text = bkinfo.BookId;
                txtBookId.ReadOnly = true;
                txtBookISBN.Text = bkinfo.ISBN;
                txtBookName.Text = bkinfo.BookName;
                txtBookAuthor.Text = bkinfo.BookAuthor;
                txtBookPrice.Text = bkinfo.BookPrice.ToString();
                cboBookPress.Text = bkinfo.BookPress.ToString();
                dtpPublishDate.Text = bkinfo.BookPublishDate.ToString();
                lblStorageInDate.Text = bkinfo.StorageInDate.ToString();
                txtStorageInNum.Value = bkinfo.StorageInNum;
                lblInventoryNum.Value = bkinfo.InventoryNum;
                lblBorrowedNum.Value = bkinfo.BorrowedNum;
                //把文本转成图片
                if (string.IsNullOrWhiteSpace(bkinfo.BookImage))
                {
                    pbCurrentImage.Image = null;
                }
                else
                {
                    pbCurrentImage.Image = (Image)SerializeObjectToString.DeserializeObject(bkinfo.BookImage);
                }
                //处理下拉框
                cboBookPress.SelectedItem = presslist.Find(x => x.PressId == bkinfo.BookPress);
                //得到当前书类别信息
                BookTypeExtModel currenttype = btbll.GetBookTypeId(bkinfo.BookType);
                BookTypeModel typeone = typelist.Find(x => x.TypeId == currenttype.ParentTypeId);
                cboBookTypeOne.SelectedItem = typeone;
            }
        }

        private void btnClose1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// 提交
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCommit_Click(object sender, EventArgs e)
        {
            //输入验证
            //图书类别验证
            if (cboBookTypeOne.SelectedItem == null)
            {
                MessageBox.Show("请选择图书一级类别");
                return;
            }
            if (cboBookTypeTwo.SelectedItem == null)
            {
                MessageBox.Show("请选择图书二级类别");
                return;
            }
            //isban长度必须是纯数字且13位
            if (!ValidateInput.IsInteger(txtBookISBN.Text.Trim()))
            {
                MessageBox.Show("图书的ISBN编号必须是纯数字");
                return;
            }
            if (txtBookISBN.Text.Trim().Length!= 13)
            {
                MessageBox.Show("图书的ISBN编号长度必须是13位");
                return;
            }
            //名称和作者不能为空
            if (string.IsNullOrWhiteSpace(txtBookAuthor.Text.Trim()))
            {
                MessageBox.Show("图书作者不能为空");
                return;
            }
            BookModel bkmodel = new BookModel();
            bkmodel.BookId = txtBookId.Text.Trim();
            bkmodel.BookName = txtBookName.Text.Trim();
            bkmodel.BookType =Convert.ToInt32(cboBookTypeTwo.SelectedValue);
            bkmodel.BookAuthor = txtBookAuthor.Text.Trim();
            bkmodel.BookPrice = Convert.ToDecimal(txtBookPrice.Text.Trim());
            bkmodel.ISBN = txtBookISBN.Text.Trim();
            bkmodel.BookPress = Convert.ToInt32(cboBookPress.SelectedValue);
            bkmodel.BookPublishDate = dtpPublishDate.Value;
            bkmodel.StorageInNum = Convert.ToInt32(txtStorageInNum.Value);
            bkmodel.StorageInDate = lblStorageInDate.Value;
            bkmodel.InventoryNum = Convert.ToInt32(lblInventoryNum.Value);
            bkmodel.BorrowedNum = Convert.ToInt32(lblBorrowedNum.Value);
            if (pbCurrentImage.Image != null)
            {
                bkmodel.BookImage = SerializeObjectToString.SerializeObject(pbCurrentImage.Image);
            }
            switch (actionflag)
            {
                case 1:
                    int result2 = bkbll.InsertBook(bkmodel);
                    if (result2 == 1)
                    {
                        MessageBox.Show("图书添加成功");
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    break;
                case 2:
                    int result = bkbll.UpdateBook(bkmodel);
                    if (result == 1)
                    {
                        MessageBox.Show("图书修改成功");
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("图书修改失败");
                        return;
                    }
                    break;
            }
        }

        private void txtBookAuthor_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
