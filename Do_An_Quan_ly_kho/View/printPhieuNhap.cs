using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Do_An_Quan_ly_kho.View
{
    public partial class printPhieuNhap : Form
    {
        public printPhieuNhap()
        {
            InitializeComponent();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // Tạo Bitmap từ panel1
            Bitmap bm = new Bitmap(this.panel1.Width, this.panel1.Height);
            panel1.DrawToBitmap(bm, new Rectangle(0, 0, this.panel1.Width, this.panel1.Height));

            // Lấy kích thước vùng in
            int docWidth = e.MarginBounds.Width;

            // Tính tọa độ căn giữa theo chiều X
            int centerX = (docWidth - bm.Width) / 2 + e.MarginBounds.Left;

            // Giữ nguyên tọa độ Y
            int centerY = e.MarginBounds.Top;

            // Vẽ hình ảnh tại vị trí đã tính toán
            e.Graphics.DrawImage(bm, centerX, centerY);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }
    }
}
