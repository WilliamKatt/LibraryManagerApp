using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LM.Common
{
    /// <summary>
    /// DataGridView帮助类
    /// </summary>
    public static class DataGridViewHelper
    {
        /// <summary>
        /// 普通的样式
        /// </summary>        
        public static void DgvStyle1(DataGridView dgv)
        {
            //奇数行的背景色
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dgv.AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.Blue;
            dgv.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dgv.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            //默认的行样式
            dgv.RowsDefaultCellStyle.BackColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dgv.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dgv.RowsDefaultCellStyle.SelectionForeColor = Color.Blue;
            //数据网格颜色
            dgv.GridColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            //列标题的宽度
            dgv.ColumnHeadersHeight = 28;

        }

        /// <summary>
        /// 凹凸样式
        /// </summary>
        /// 需要手动设置this.RowTemplate.DividerHeight = 2;    
        public static void DgvStyle2(DataGridView dgv)
        {
            dgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            //列标题的边框样式
            dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dgv.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dgv.ColumnHeadersHeight = 28;
            //行的边框样式
            dgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dgv.DefaultCellStyle.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dgv.RowTemplate.DividerHeight = 1;
            ////禁止当前默认的视觉样式
            dgv.EnableHeadersVisualStyles = false;
        }

        /// <summary>
        /// 给DataGridView添加行号
        /// </summary>
        /// <param name="dgv"></param>
        /// <param name="e"></param>
        public static void DgvRowPostPaint(DataGridView dgv, DataGridViewRowPostPaintEventArgs e)
        {
            try
            {
                //添加行号 
                SolidBrush v_SolidBrush = new SolidBrush(dgv.RowHeadersDefaultCellStyle.ForeColor);
                int v_LineNo = 0;
                v_LineNo = e.RowIndex + 1;
                string v_Line = v_LineNo.ToString();
                e.Graphics.DrawString(v_Line, e.InheritedRowStyle.Font, v_SolidBrush, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + 5);
            }
            catch (Exception ex)
            {
                MessageBox.Show("添加行号时发生错误，错误信息：" + ex.Message, "操作失败");
            }
        }

        /// <summary>
        /// 导出到excel
        /// </summary>
        /// <param name="dgv">dgv控件id</param>
        /// <param name="filestream">文件流</param>
        public static void DataGridViewToExcel(DataGridView dgv, Stream filestream)
        {
            Stream saveStream = filestream;//打开要保存的excel文件
            StreamWriter sw = new StreamWriter(saveStream, Encoding.GetEncoding(-0));//以特定的编码向流中插入字符，GetEncoding（-0）<br>首选编码的代码页标识符。- 或 - 0
            string columnTitle = "";
            try
            {
                //构建excel表格标题
                for (int i = 0; i < dgv.ColumnCount; i++)
                {
                    if (i > 0)
                    {
                        columnTitle += "\t";
                    }
                    columnTitle += dgv.Columns[i].HeaderText;
                }
                sw.WriteLine(columnTitle);//写入标题行
                //遍历dg控件所有行数据并写入EXCEL 
                for (int j = 0; j < dgv.RowCount; j++)
                {
                    string columnValue = "";
                    for (int k = 0; k < dgv.ColumnCount; k++)
                    {
                        if (k > 0)
                        {
                            columnValue += "\t";
                        }
                        if (dgv.Rows[j].Cells[k].Value.ToString() == "")
                        {
                            columnValue += "";
                        }
                        else
                        {
                            columnValue += dgv.Rows[j].Cells[k].Value.ToString().Trim();
                        }
                    }
                    sw.WriteLine(columnValue);//将信息逐条的写入excel文件
                }
                sw.Close();
                saveStream.Close();
                MessageBox.Show("导出成功！");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
