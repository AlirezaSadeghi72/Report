using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace ReportSarfasl
{
    public class ReportSarfasl : UserControl
    {
        private List<int> _listSar = new List<int>(), _listZirSar = new List<int>();
        private Button btnPrint;
        private Button btnShow;
        private DataGridView dgvSarfasl;
        private Label lblSarfasls;
        private Label lblZirSarfasl;
        private Panel pnlFooter;
        private Panel pnlHeader;
        private Panel pnlMain;
        private DataGridViewTextBoxColumn row;
        private TextBox txtFilter;
        private TextBox txtSarfasl;
        private TextBox txtZirSarfasl;

        public ReportSarfasl()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnShow = new System.Windows.Forms.Button();
            this.txtZirSarfasl = new System.Windows.Forms.TextBox();
            this.lblZirSarfasl = new System.Windows.Forms.Label();
            this.txtSarfasl = new System.Windows.Forms.TextBox();
            this.lblSarfasls = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.dgvSarfasl = new System.Windows.Forms.DataGridView();
            this.row = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.btnPrint = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSarfasl)).BeginInit();
            this.pnlFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.btnShow);
            this.pnlHeader.Controls.Add(this.txtZirSarfasl);
            this.pnlHeader.Controls.Add(this.lblZirSarfasl);
            this.pnlHeader.Controls.Add(this.txtSarfasl);
            this.pnlHeader.Controls.Add(this.lblSarfasls);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1200, 83);
            this.pnlHeader.TabIndex = 0;
            // 
            // btnShow
            // 
            this.btnShow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShow.Location = new System.Drawing.Point(86, 34);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 4;
            this.btnShow.Text = "نمایش";
            this.btnShow.UseVisualStyleBackColor = true;
            // 
            // txtZirSarfasl
            // 
            this.txtZirSarfasl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtZirSarfasl.Location = new System.Drawing.Point(221, 36);
            this.txtZirSarfasl.Name = "txtZirSarfasl";
            this.txtZirSarfasl.ReadOnly = true;
            this.txtZirSarfasl.Size = new System.Drawing.Size(368, 20);
            this.txtZirSarfasl.TabIndex = 3;
            this.txtZirSarfasl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblZirSarfasl
            // 
            this.lblZirSarfasl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblZirSarfasl.AutoSize = true;
            this.lblZirSarfasl.Location = new System.Drawing.Point(595, 39);
            this.lblZirSarfasl.Name = "lblZirSarfasl";
            this.lblZirSarfasl.Size = new System.Drawing.Size(80, 13);
            this.lblZirSarfasl.TabIndex = 2;
            this.lblZirSarfasl.Text = "زیر سرفصل ها :";
            // 
            // txtSarfasl
            // 
            this.txtSarfasl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSarfasl.Location = new System.Drawing.Point(691, 36);
            this.txtSarfasl.Name = "txtSarfasl";
            this.txtSarfasl.ReadOnly = true;
            this.txtSarfasl.Size = new System.Drawing.Size(368, 20);
            this.txtSarfasl.TabIndex = 1;
            this.txtSarfasl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblSarfasls
            // 
            this.lblSarfasls.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSarfasls.AutoSize = true;
            this.lblSarfasls.Location = new System.Drawing.Point(1065, 39);
            this.lblSarfasls.Name = "lblSarfasls";
            this.lblSarfasls.Size = new System.Drawing.Size(63, 13);
            this.lblSarfasls.TabIndex = 0;
            this.lblSarfasls.Text = "سرفصل ها :";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.dgvSarfasl);
            this.pnlMain.Controls.Add(this.txtFilter);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 83);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1200, 444);
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
            this.dgvSarfasl.Size = new System.Drawing.Size(1200, 424);
            this.dgvSarfasl.TabIndex = 1;
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
            this.pnlHeader.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSarfasl)).EndInit();
            this.pnlFooter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #region Method



        #endregion

        #region Event Controls



        private void btnShow_Click(object sender, EventArgs e)
        {
            //اتصال و اوردن اطلاعات
        }

        #region Event Control Data Grid View

        private void dgvSarfasl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) _openZirSarfasl();
        }

        private void dgvSarfasl_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            _openZirSarfasl();
        }

        #endregion

        #endregion

        #region Event Handler

        public event EventHandler txtSarfasl_KeyDownEnter;
        private void txtSarfasl_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (this.txtSarfasl_KeyDownEnter != null)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    this.txtSarfasl_KeyDownEnter(this, e);
                    //var sarfasl = new ListSafaslaOrZirSarfasls(1, _listSar);
                    //sarfasl.Show();
                    //_listSar = sarfasl.listSelectes;
                }
            }
        }

        public event EventHandler txtZirSarfasl_KeyDownEnter;
        private void txtZirSarfasl_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.txtZirSarfasl_KeyDownEnter != null)
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

        public event EventHandler OpenFormZirSarfasl;
        protected void _openZirSarfasl(object sender = null, KeyEventArgs e=null)
        {
            if (dgvSarfasl.SelectedRows.Count > 0)
            {
                this.OpenFormZirSarfasl(this,e);
                //باز کردن زیر سرفصل های سرفصل انتخابی داخل گرید
            }
        }

        #endregion
    }
}