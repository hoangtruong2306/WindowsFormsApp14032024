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
    public partial class frmDangNhap : Form
    {
        CtrDangNhap ctrDangNhap = new CtrDangNhap();
        public frmDangNhap()
        {
            InitializeComponent();
        }
        private bool validateData()
        {
            errorProvider1.SetError(txtUserName, (txtUserName.Text == "") ? "Please enter username  " : "");
            errorProvider2.SetError(txtPassword, (txtPassword.Text == "") ? "Please enter Password  " : "");
            return (txtUserName.Text != "" && txtPassword.Text != "");
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (!validateData())
                return;
            bool isAutherticated = ctrDangNhap.login(txtUserName.Text, txtPassword.Text);
            if (isAutherticated)
            {
                var f = (frmTrangChu)this.ParentForm;
                f.xuLyLogin();
                this.Close();
            }

            else
                MessageBox.Show("Wrong username and password", "Error Login", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

       
  
}

