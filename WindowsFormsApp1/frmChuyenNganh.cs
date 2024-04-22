using OpenLibrary.Bussiness;
using OpenLibrary.Prenstation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenLibrary.DataAccess;
using DevExpress.Xpo.DB.Helpers;

namespace OpenLibrary.Prenstation
{
    public partial class frmChuyenNganh : Form
    {
        CtrChuyenNganh Ctr = new CtrChuyenNganh();
        public frmChuyenNganh()
        {
            InitializeComponent();
        }

        private void frmChuyenNganh_Load(object sender, EventArgs e)
        {
           
            this.cHUYENNGANHTableAdapter.Fill(this.oPENLIBRARYDataSet.CHUYENNGANH);
            dgvChuyenNganh.DataSource = Ctr.laydschuyennganh();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            String s = dgvChuyenNganh.CurrentRow.Cells[0].Value.ToString();
            if (s != null && s != "")
            {
                txtChuyennganh.Text = s;
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa bản ghi có mã là " + s + " hay không?", "Thông báo", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (txtChuyennganh.Text == "") errorProvider1.SetError(txtChuyennganh, "Hãy nhập tên chuyên ngành ");
                    else
                    {
                        if (!Ctr.XoaChuyenNganh(txtChuyennganh.Text = dgvChuyenNganh.CurrentRow.Cells[0].Value.ToString())) MessageBox.Show("Xóa thất bại!");

                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                    return;
                }
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            if (txtChuyennganh.Text == "")
                errorProvider1.SetError(txtChuyennganh, "Hãy nhập tên chuyên ngành ");
            else
            {
                if (Ctr.ThemtenchuyenNganh(txtChuyennganh.Text) == false)
                    MessageBox.Show("Thêm thất bại");

            }
        }

        private void dgvChuyenNganh_SelectionChanged(object sender, EventArgs e)
        {
            String s = dgvChuyenNganh.CurrentRow.Cells[1].Value.ToString();
            if (s != null && s != "") txtChuyennganh.Text = s;
        }

        private void btnCorrect_Click(object sender, EventArgs e)
        {
            if (txtChuyennganh.Text == "")
                errorProvider1.SetError(txtChuyennganh, "Hãy nhập tên cần sửa chuyên ngành!");
            else
            {
                String s = dgvChuyenNganh.CurrentRow.Cells[0].Value.ToString();
                if (Ctr.SuachuyenNganh(txtChuyennganh.Text, s) == false)
                    MessageBox.Show("Sửa thất bại");
                ;

            }
        }

        private void dgvChuyenNganh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    }
