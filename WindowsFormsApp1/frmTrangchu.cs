using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenLibrary.Bussiness;

namespace OpenLibrary.Prenstation
{
    public partial class frmTrangChu : Form
    {
        CtrTrangchu ctr = new CtrTrangchu();
        public frmTrangChu()
        {
            InitializeComponent();
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (LoginInfo.MaNV == -1)
             {
                frmDangNhap f = new frmDangNhap();
                f.MdiParent = this;
                f.StartPosition = FormStartPosition.CenterScreen;
                f.Show();
            }
            else
            {
                ctr.logout();
                xuLyLogin();
            }               
        }

        private void bBI1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }
        public void xuLyLogin()
        {
            this.Text = (LoginInfo.HoTenNV != "") ? "OpenLibrary" : "Open Library – Xin Chao " + LoginInfo.HoTenNV;
            btnDangNhap.Caption = LoginInfo.MaNV == -1 ? "DangNhap" :  "DangXuat";
            btnDangNhap.ImageOptions.LargeImage = (LoginInfo.MaNV != -1) ?   Properties.Resources.close_32x32 : Properties.Resources.next_32x32;
            btnThongtincanhan.Enabled = LoginInfo.MaNV == 1;
            btnDoimatkhau.Enabled = LoginInfo.MaNV == 1;
            rpg4.Visible = LoginInfo.MaLoaiNV == 1;
            rpg2.Visible = LoginInfo.MaLoaiNV == 1;
            rpg3.Visible = LoginInfo.MaLoaiNV == 1;
        }

        private void frmTrangChu_Load(object sender, EventArgs e)
        {
            xuLyLogin();
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmChuyenNganh f = (frmChuyenNganh)this.MdiChildren.FirstOrDefault(k => k is frmChuyenNganh);
            if (f == null)
            {
                f = new frmChuyenNganh();
                f.MdiParent = this;
                f.WindowState = FormWindowState.Maximized;
                f.Show();
            }
        }
    }
 }
