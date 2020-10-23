using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LM.Common
{
    public class EmptyDataRow : DataGridViewRow
    {
        protected override void Paint(Graphics graphics, Rectangle clipBounds, Rectangle rowBounds, int rowIndex, DataGridViewElementStates rowState, bool isFirstDisplayedRow, bool isLastVisibleRow)
        {
            var grid = this.DataGridView;
            int rowHeadersWidth = grid.RowHeadersVisible ? grid.RowHeadersWidth : 0;
            string s = "没有可显示的记录";
            Brush brush = SystemBrushes.Control;
            graphics.FillRectangle(brush, rowBounds);
            graphics.DrawString(s, grid.Font, Brushes.Black, grid.Width / 2 - (s.Length) * 4, rowBounds.Bottom - 18);
        }
    }
}
