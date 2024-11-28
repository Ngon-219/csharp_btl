using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Do_An_Quan_ly_kho.View.PhieuXuat;

namespace Do_An_Quan_ly_kho.View.PhieuXuat
{
    public partial class frmPhieuXuat : Form
    {
        public frmPhieuXuat()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormThemPhieuXuat frm = new FormThemPhieuXuat();
            frm.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            FormSuaPhieuXuat frm = new FormSuaPhieuXuat();
            frm.ShowDialog();
        }
    }
}
