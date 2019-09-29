using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using ReportSarfasl.dataLayer;

namespace ReportSarfasl
{
    public class reportSarfasl : UserControl
    {
        private List<int> _listSar = new List<int>(), _listZirSar = new List<int>();
        private List<sarfasls> dt;
        private bool _isSearch = false, _isKeySpase = false;
        private Button btnPrint;
        private DataGridView dgvSarfasl;
        private Panel pnlFooter;
        private Panel pnlHeader;
        private Panel pnlMain;
        private DataGridViewTextBoxColumn row;
        private GroupBox groupBox1;
        private Button btnShow;
        private TextBox txtZirSarfasl;
        private Label lblZirSarfasl;
        private TextBox txtSarfasl;
        private Label lblSarfasls;
        private TextBox txtFilter;

        public reportSarfasl()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblZirSarfasl = new System.Windows.Forms.Label();
            this.lblSarfasls = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.txtZirSarfasl = new System.Windows.Forms.TextBox();
            this.txtSarfasl = new System.Windows.Forms.TextBox();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.dgvSarfasl = new System.Windows.Forms.DataGridView();
            this.row = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.btnPrint = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSarfasl)).BeginInit();
            this.pnlFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.groupBox1);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1200, 65);
            this.pnlHeader.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblZirSarfasl);
            this.groupBox1.Controls.Add(this.lblSarfasls);
            this.groupBox1.Controls.Add(this.btnShow);
            this.groupBox1.Controls.Add(this.txtZirSarfasl);
            this.groupBox1.Controls.Add(this.txtSarfasl);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1200, 65);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // lblZirSarfasl
            // 
            this.lblZirSarfasl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblZirSarfasl.AutoSize = true;
            this.lblZirSarfasl.Location = new System.Drawing.Point(774, 27);
            this.lblZirSarfasl.Name = "lblZirSarfasl";
            this.lblZirSarfasl.Size = new System.Drawing.Size(80, 13);
            this.lblZirSarfasl.TabIndex = 7;
            this.lblZirSarfasl.Text = "زیر سرفصل ها :";
            // 
            // lblSarfasls
            // 
            this.lblSarfasls.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSarfasls.AutoSize = true;
            this.lblSarfasls.Location = new System.Drawing.Point(1122, 27);
            this.lblSarfasls.Name = "lblSarfasls";
            this.lblSarfasls.Size = new System.Drawing.Size(63, 13);
            this.lblSarfasls.TabIndex = 5;
            this.lblSarfasls.Text = "سرفصل ها :";
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(6, 38);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 9;
            this.btnShow.Text = "نمایش";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // txtZirSarfasl
            // 
            this.txtZirSarfasl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtZirSarfasl.Location = new System.Drawing.Point(528, 24);
            this.txtZirSarfasl.Name = "txtZirSarfasl";
            this.txtZirSarfasl.ReadOnly = true;
            this.txtZirSarfasl.Size = new System.Drawing.Size(240, 20);
            this.txtZirSarfasl.TabIndex = 8;
            this.txtZirSarfasl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtZirSarfasl.Click += new System.EventHandler(this.txtZirSarfasl_Click);
            this.txtZirSarfasl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtZirSarfasl_KeyDown);
            // 
            // txtSarfasl
            // 
            this.txtSarfasl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSarfasl.Location = new System.Drawing.Point(876, 24);
            this.txtSarfasl.Name = "txtSarfasl";
            this.txtSarfasl.ReadOnly = true;
            this.txtSarfasl.Size = new System.Drawing.Size(240, 20);
            this.txtSarfasl.TabIndex = 6;
            this.txtSarfasl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSarfasl.Click += new System.EventHandler(this.txtSarfasl_Click);
            this.txtSarfasl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSarfasl_KeyDown);
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.dgvSarfasl);
            this.pnlMain.Controls.Add(this.txtFilter);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 65);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1200, 462);
            this.pnlMain.TabIndex = 1;
            // 
            // dgvSarfasl
            // 
            this.dgvSarfasl.AllowUserToAddRows = false;
            this.dgvSarfasl.AllowUserToDeleteRows = false;
            this.dgvSarfasl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSarfasl.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.row});
            this.dgvSarfasl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSarfasl.Location = new System.Drawing.Point(0, 20);
            this.dgvSarfasl.Name = "dgvSarfasl";
            this.dgvSarfasl.ReadOnly = true;
            this.dgvSarfasl.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSarfasl.Size = new System.Drawing.Size(1200, 442);
            this.dgvSarfasl.TabIndex = 1;
            this.dgvSarfasl.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSarfasl_CellDoubleClick);
            this.dgvSarfasl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvSarfasl_KeyDown);
            // 
            // row
            // 
            this.row.HeaderText = "ردیف";
            this.row.Name = "row";
            this.row.ReadOnly = true;
            this.row.Visible = false;
            // 
            // txtFilter
            // 
            this.txtFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtFilter.Location = new System.Drawing.Point(0, 0);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(1200, 20);
            this.txtFilter.TabIndex = 0;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            this.txtFilter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFilter_KeyDown);
            // 
            // pnlFooter
            // 
            this.pnlFooter.Controls.Add(this.btnPrint);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 485);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(1200, 42);
            this.pnlFooter.TabIndex = 2;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(42, 9);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 0;
            this.btnPrint.Text = "چاپ";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // ReportSarfasl
            // 
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlHeader);
            this.Name = "ReportSarfasl";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(1200, 527);
            this.pnlHeader.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSarfasl)).EndInit();
            this.pnlFooter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #region Event Controls

        #region Event Control Data Grid View
        private void dgvSarfasl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                _openZirSarfasl(sender, e);
        }
        private void dgvSarfasl_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            _openZirSarfasl(sender, new KeyEventArgs(Keys.A));
        }
        #endregion

        private void txtFilter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                _isSearch = false;
                txtFilter.Text = "";
            }
            else if (dgvSarfasl.Rows.Count > 0)
            {
                int rowIndexSelected = dgvSarfasl.SelectedRows[0].Index;
                if (e.KeyCode == Keys.Up)
                {
                    _isSearch = true;
                    txtFilter.Text = "";
                    if (rowIndexSelected > 0)
                    {
                        dgvSarfasl.Rows[rowIndexSelected - 1].Cells["select"].Selected = true;
                    }
                }
                else if (e.KeyCode == Keys.Down)
                {
                    _isSearch = true;
                    txtFilter.Text = "";
                    if (rowIndexSelected < dgvSarfasl.RowCount - 1)
                    {
                        dgvSarfasl.Rows[rowIndexSelected + 1].Cells["select"].Selected = true;
                    }
                }
            }
            else if (e.KeyCode == Keys.Enter)
            {
                _openZirSarfasl(sender, e);
            }

        }
        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            search();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            //اتصال و اوردن اطلاعات
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            //چاپ
        }
        #endregion

        #region Event Handler

        public event EventHandler txtSarfasl_KeyDownEnter;
        private void txtSarfasl_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (txtSarfasl_KeyDownEnter != null)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtSarfasl_KeyDownEnter(this, e);
                    //var sarfasl = new ListSafaslaOrZirSarfasls(1, _listSar);
                    //sarfasl.Show();
                    //_listSar = sarfasl.listSelectes;
                }
            }
        }
        private void txtSarfasl_Click(object sender, EventArgs e)
        {
            if (txtSarfasl_KeyDownEnter != null)
                txtSarfasl_KeyDownEnter(this, e);
        }

        public event EventHandler txtZirSarfasl_KeyDownEnter;
        private void txtZirSarfasl_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtZirSarfasl_KeyDownEnter != null)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    this.txtZirSarfasl_KeyDownEnter(this, e);
                    //var zirsarfasl = new ListSafaslaOrZirSarfasls(2, _listZirSar);
                    //zirsarfasl.Show();
                    //_listZirSar = zirsarfasl.listSelectes;
                }
            }
        }
        private void txtZirSarfasl_Click(object sender, EventArgs e)
        {
            if (txtZirSarfasl_KeyDownEnter != null)
                txtZirSarfasl_KeyDownEnter(this, e);
        }

        public event EventHandler OpenFormZirSarfasl;
        protected void _openZirSarfasl(object sender, KeyEventArgs e)
        {
            if (dgvSarfasl.SelectedRows.Count > 0)
            {
                this.OpenFormZirSarfasl(this, e);
                //باز کردن زیر سرفصل های سرفصل انتخابی داخل گرید
            }
        }

        #endregion

        #region Method

        public void SetGrid()
        {
            foreach (DataGridViewColumn col in dgvSarfasl.Columns) col.Visible = false;
            foreach (DataGridViewRow row in dgvSarfasl.Rows) row.Cells["row"].Value = row.Index + 1;

            dgvSarfasl.Columns["name"].Visible = true;
            dgvSarfasl.Columns["name"].HeaderText = "نام";
            dgvSarfasl.Columns["name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvSarfasl.Columns["row"].Visible = true;

            dgvSarfasl.Columns["Select"].Visible = true;
        }

        private void search()
        {
            var filter = txtFilter.Text.Trim();
            if (filter == "" && !_isSearch)
            {
                dgvSarfasl.DataSource = dt;
            }
            else if (filter != "")
            {
                _isSearch = false;
                dgvSarfasl.DataSource = dt.Where(c => c.name.Contains(filter)).ToList();
            }
        }
        #endregion
    }
}