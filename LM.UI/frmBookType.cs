using LM.BLL;
using LM.Model;
using LM.Model.Extension;
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
    public partial class frmBookType : Form
    {
        private static BookTypeManager btbll = new BookTypeManager();
        private List<BookTypeModel> btlist = btbll.GetAllBookTypes();
        //定义变量，代表操作类型(1代表添加，2代表修改)
        private int actionFlag=1;
        public frmBookType()
        {
            InitializeComponent();
            if (btlist.Count > 0)
            {
                btnAddRootNode.Visible = false;
            }
        }
        #region 关闭事件
        /// <summary>
        /// 关闭事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        } 
        #endregion
        #region 窗体加载事件
        /// <summary>
        /// 窗体加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmBookType_Load(object sender, EventArgs e)
        {
            actionFlag = 0;
            tvBookType.Nodes.Clear();
            TreeNode root = new TreeNode();
            root.Text = "所有分类";
            root.Tag = 1;
            LoadTyBookType(root);//加载图书类别
            tvBookType.Nodes.Add(root);
            tvBookType.Nodes[0].ExpandAll();//展开一级节点
            //禁用文本框输入
            txtParentTypeId.ReadOnly = true;
            txtParentTypeName.ReadOnly = true;
            txtTypeId.ReadOnly = true;
            txtTypeName.ReadOnly = true;
            txtDESC.ReadOnly = true;
        } 
        #endregion
        #region 加载图片类别方法
        /// <summary>
        /// 加载图书类别方法
        /// </summary>
        private void LoadTyBookType(TreeNode node)
        {
            List<BookTypeModel> nodelist = btlist.FindAll(x => x.ParentTypeId == Convert.ToInt32(node.Tag.ToString()));
            foreach (BookTypeModel item in nodelist)
            {
                //创建节点，并且绑定问文本及标识
                TreeNode tn = new TreeNode();
                tn.Text = item.TypeName;
                tn.Tag = item.TypeId;
                LoadTyBookType(tn);//递归调用
                node.Nodes.Add(tn);
            }
        } 
        #endregion
        #region 选择节点事件
        /// <summary>
        /// 选择节点事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tvBookType_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //获取当前选择节点
            TreeNode tn = tvBookType.SelectedNode;
            int typeid = Convert.ToInt32(tn.Tag.ToString());
            BookTypeExtModel model = btbll.GetBookTypeId(typeid);
            if (model == null)
            {
                MessageBox.Show("获取图书类别信息出错");
                return;
            }
            else
            {
                if (model.ParentTypeId == 0)
                {
                    txtParentTypeId.Text = "NULL";
                    txtParentTypeName.Text = "NULL";

                }
                else
                {
                    txtParentTypeId.Text = model.ParentTypeId2.ToString();
                    txtParentTypeName.Text = model.ParentTypeName;
                }
                txtTypeId.Text = model.TypeId.ToString();
                txtTypeName.Text = model.TypeName;
                txtDESC.Text = model.TypeDESC;
            }
        } 
        #endregion
        #region 添加根节点
        /// <summary>
        /// 添加根节点
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddRootNode_Click(object sender, EventArgs e)
        {

        } 
        #endregion
        #region 添加子节点
        /// <summary>
        /// 添加子节点
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddSubNode_Click_1(object sender, EventArgs e)
        {
            txtTypeName.ReadOnly = false;
            txtDESC.ReadOnly = false;
            actionFlag = 1;
            TreeNode tn = tvBookType.SelectedNode;
            if (tn == null)
            {
                MessageBox.Show("您没有选择节点");
                return;
            }
            string typeid = (tn.Tag.ToString());
            if (typeid.Length == 5)
            {
                MessageBox.Show("不能在二级节点下添加子节点");
                return;
            }
            //产生新节点编号
            string newid = btbll.CreateNewTypeId(Convert.ToInt32(tn.Tag.ToString()));
            txtTypeId.Text = newid;
            txtTypeName.ReadOnly = txtDESC.ReadOnly = false;
        } 
        #endregion
        #region 提交事件
        /// <summary>
        /// 提交事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCommit_Click(object sender, EventArgs e)
        {
            TreeNode tn = tvBookType.SelectedNode;
            if (tn == null)
            {
                MessageBox.Show("您还没有选择节点");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtTypeName.Text))
            {
                MessageBox.Show("名称不能为空");
                return;
            }
            switch (actionFlag)
            {
                case 0:
                    MessageBox.Show("操作被中止，请选择相关操作");
                    break;
                case 1://添加
                    string typeid = tn.Tag.ToString();
                    BookTypeModel model = new BookTypeModel();
                    model.ParentTypeId = Convert.ToInt32(typeid);
                    model.TypeName = txtTypeName.Text.Trim();
                    model.TypeDESC = txtDESC.Text.Trim();
                    model.TypeId = int.Parse(txtTypeId.Text.Trim());
                    int rst = btbll.AddBookType(model);
                    if (rst == 1)
                    {
                        MessageBox.Show("类别添加成功");
                        //刷新页面
                        btlist = btbll.GetAllBookTypes();
                        frmBookType_Load(null, null);
                        btnCancel_Click(null, null);
                    }
                    else
                    {
                        MessageBox.Show("类别添加失败");
                        return;
                    }
                    break;
                case 2://修改
                    BookTypeModel mode2 = new BookTypeModel();
                    mode2.ParentTypeId = int.Parse(txtParentTypeId.Text.Trim());
                    mode2.TypeName = txtTypeName.Text.Trim();
                    mode2.TypeDESC = txtDESC.Text.Trim();
                    mode2.TypeId = int.Parse(txtTypeId.Text.Trim());
                    int rst2 = btbll.UpdateBookType(mode2);
                    if (rst2 == 1)
                    {
                        MessageBox.Show("类别修改成功");
                        //刷新页面
                        btlist = btbll.GetAllBookTypes();
                        frmBookType_Load(null, null);
                        btnCancel_Click(null, null);
                    }
                    else
                    {
                        MessageBox.Show("类别修改失败");
                        return;
                    }
                    break;
            }
        } 
        #endregion
        #region 删除事件
        /// <summary>
        /// 删除事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeleteNode_Click(object sender, EventArgs e)
        {
            TreeNode tn = tvBookType.SelectedNode;
            if (tn == null)
            {
                MessageBox.Show("您没有选择节点，不能执行相关操作");
                return;
            }
            //判断是1级还是2级的节点类别
            if (tn.Tag.ToString().Length == 3)
            {
                MessageBox.Show("只能选择二级类别");
                return;
            }
            DialogResult dr = MessageBox.Show("您确定要删除吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                int typeid = int.Parse(tn.Tag.ToString());
                int rst = btbll.DeleteBookType(typeid);
                if (rst == 1)
                {
                    MessageBox.Show("类别删除成功");
                    btlist = btbll.GetAllBookTypes();
                    btnCancel_Click(null, null);
                }
                else if (rst == 0)
                {
                    MessageBox.Show("类别删除失败");
                    return;
                }
                else
                {
                    MessageBox.Show("该类别下还有图书，不能删除");
                    return;
                }
            }
            else
            {
                return;
            }
        } 
        #endregion
        #region 取消事件
        /// <summary>
        /// 取消事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            TreeNode tn = tvBookType.SelectedNode;
            tn = null;
            txtTypeName.ReadOnly = true;
            txtDESC.ReadOnly = true;
            txtParentTypeId.Text = null;
            txtParentTypeName.Text = null;
            txtTypeId.Text = null;
            txtTypeName.Text = null;
            txtDESC.Text = null;
            this.tvBookType.SelectedNode = null;
        }
        #endregion
        #region 修改节点
        /// <summary>
        /// 修改节点
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdateNode_Click(object sender, EventArgs e)
        {
            txtTypeName.ReadOnly = false;
            txtDESC.ReadOnly = false;
            actionFlag = 2;
        }
        #endregion
    }
}
