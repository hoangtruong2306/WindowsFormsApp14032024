namespace OpenLibrary.Prenstation
{
    partial class frmChuyenNganh
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChuyenNganh));
            this.lblChuyennganh = new System.Windows.Forms.Label();
            this.txtChuyennganh = new System.Windows.Forms.TextBox();
            this.dgvChuyenNganh = new System.Windows.Forms.DataGridView();
            this.maCNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenCNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cHUYENNGANHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oPENLIBRARYDataSet = new OpenLibrary.Prenstation.OPENLIBRARYDataSet();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnCorrect = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.cHUYENNGANHTableAdapter = new OpenLibrary.Prenstation.OPENLIBRARYDataSetTableAdapters.CHUYENNGANHTableAdapter();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChuyenNganh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHUYENNGANHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oPENLIBRARYDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblChuyennganh
            // 
            this.lblChuyennganh.AutoSize = true;
            this.lblChuyennganh.Location = new System.Drawing.Point(61, 72);
            this.lblChuyennganh.Name = "lblChuyennganh";
            this.lblChuyennganh.Size = new System.Drawing.Size(95, 16);
            this.lblChuyennganh.TabIndex = 0;
            this.lblChuyennganh.Text = "Chuyên Ngành";
            // 
            // txtChuyennganh
            // 
            this.txtChuyennganh.Location = new System.Drawing.Point(193, 69);
            this.txtChuyennganh.Name = "txtChuyennganh";
            this.txtChuyennganh.Size = new System.Drawing.Size(320, 22);
            this.txtChuyennganh.TabIndex = 1;
            // 
            // dgvChuyenNganh
            // 
            this.dgvChuyenNganh.AutoGenerateColumns = false;
            this.dgvChuyenNganh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChuyenNganh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maCNDataGridViewTextBoxColumn,
            this.tenCNDataGridViewTextBoxColumn});
            this.dgvChuyenNganh.DataSource = this.cHUYENNGANHBindingSource;
            this.dgvChuyenNganh.Location = new System.Drawing.Point(64, 189);
            this.dgvChuyenNganh.Name = "dgvChuyenNganh";
            this.dgvChuyenNganh.RowHeadersWidth = 51;
            this.dgvChuyenNganh.RowTemplate.Height = 24;
            this.dgvChuyenNganh.Size = new System.Drawing.Size(512, 249);
            this.dgvChuyenNganh.TabIndex = 3;
            this.dgvChuyenNganh.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChuyenNganh_CellContentClick);
            this.dgvChuyenNganh.SelectionChanged += new System.EventHandler(this.dgvChuyenNganh_SelectionChanged);
            // 
            // maCNDataGridViewTextBoxColumn
            // 
            this.maCNDataGridViewTextBoxColumn.DataPropertyName = "MaCN";
            this.maCNDataGridViewTextBoxColumn.HeaderText = "Mã chuyên ngành";
            this.maCNDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maCNDataGridViewTextBoxColumn.Name = "maCNDataGridViewTextBoxColumn";
            this.maCNDataGridViewTextBoxColumn.ReadOnly = true;
            this.maCNDataGridViewTextBoxColumn.Width = 125;
            // 
            // tenCNDataGridViewTextBoxColumn
            // 
            this.tenCNDataGridViewTextBoxColumn.DataPropertyName = "TenCN";
            this.tenCNDataGridViewTextBoxColumn.HeaderText = "Tên chuyên ngành";
            this.tenCNDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenCNDataGridViewTextBoxColumn.Name = "tenCNDataGridViewTextBoxColumn";
            this.tenCNDataGridViewTextBoxColumn.Width = 125;
            // 
            // cHUYENNGANHBindingSource
            // 
            this.cHUYENNGANHBindingSource.DataMember = "CHUYENNGANH";
            this.cHUYENNGANHBindingSource.DataSource = this.oPENLIBRARYDataSet;
            // 
            // oPENLIBRARYDataSet
            // 
            this.oPENLIBRARYDataSet.DataSetName = "OPENLIBRARYDataSet";
            this.oPENLIBRARYDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnAdd
            // 
            this.btnAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.ImageOptions.Image")));
            this.btnAdd.Location = new System.Drawing.Point(64, 114);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(134, 40);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCorrect
            // 
            this.btnCorrect.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCorrect.ImageOptions.Image")));
            this.btnCorrect.Location = new System.Drawing.Point(233, 114);
            this.btnCorrect.Name = "btnCorrect";
            this.btnCorrect.Size = new System.Drawing.Size(153, 40);
            this.btnCorrect.TabIndex = 7;
            this.btnCorrect.Text = "Sửa";
            this.btnCorrect.Click += new System.EventHandler(this.btnCorrect_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.Image")));
            this.btnDelete.Location = new System.Drawing.Point(423, 114);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(153, 40);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cHUYENNGANHTableAdapter
            // 
            this.cHUYENNGANHTableAdapter.ClearBeforeFill = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmChuyenNganh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 530);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCorrect);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvChuyenNganh);
            this.Controls.Add(this.txtChuyennganh);
            this.Controls.Add(this.lblChuyennganh);
            this.Name = "frmChuyenNganh";
            this.Text = "frmChuyenNganh";
            this.Load += new System.EventHandler(this.frmChuyenNganh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChuyenNganh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHUYENNGANHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oPENLIBRARYDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblChuyennganh;
        private System.Windows.Forms.TextBox txtChuyennganh;
        private System.Windows.Forms.DataGridView dgvChuyenNganh;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SimpleButton btnCorrect;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private OPENLIBRARYDataSet oPENLIBRARYDataSet;
        private System.Windows.Forms.BindingSource cHUYENNGANHBindingSource;
        private OPENLIBRARYDataSetTableAdapters.CHUYENNGANHTableAdapter cHUYENNGANHTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maCNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenCNDataGridViewTextBoxColumn;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}