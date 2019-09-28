using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
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
            pnlHeader = new Panel();
            pnlMain = new Panel();
            pnlFooter = new Panel();
            txtFilter = new TextBox();
            dgvSarfasl = new DataGridView();
            txtSarfasl = new TextBox();
            txtZirSarfasl = new TextBox();
            lblZirSarfasl = new Label();
            btnShow = new Button();
            btnPrint = new Button();
            row = new DataGridViewTextBoxColumn();
            lblSarfasls = new Label();
            pnlHeader.SuspendLayout();
            pnlMain.SuspendLayout();
            pnlFooter.SuspendLayout();
            ((ISupportInitialize) dgvSarfasl).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.Controls.Add(btnShow);
            pnlHeader.Controls.Add(txtZirSarfasl);
            pnlHeader.Controls.Add(lblZirSarfasl);
            pnlHeader.Controls.Add(txtSarfasl);
            pnlHeader.Controls.Add(lblSarfasls);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1200, 83);
            pnlHeader.TabIndex = 0;
            // 
            // pnlMain
            // 
            pnlMain.Controls.Add(dgvSarfasl);
            pnlMain.Controls.Add(txtFilter);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(0, 83);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(1200, 444);
            pnlMain.TabIndex = 1;
            // 
            // pnlFooter
            // 
            pnlFooter.Controls.Add(btnPrint);
            pnlFooter.Dock = DockStyle.Bottom;
            pnlFooter.Location = new Point(0, 485);
            pnlFooter.Name = "pnlFooter";
            pnlFooter.Size = new Size(1200, 42);
            pnlFooter.TabIndex = 2;
            // 
            // txtFilter
            // 
            txtFilter.Dock = DockStyle.Top;
            txtFilter.Location = new Point(0, 0);
            txtFilter.Name = "txtFilter";
            txtFilter.Size = new Size(1200, 20);
            txtFilter.TabIndex = 0;
            // 
            // dgvSarfasl
            // 
            dgvSarfasl.AllowUserToAddRows = false;
            dgvSarfasl.AllowUserToDeleteRows = false;
            dgvSarfasl.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSarfasl.Columns.AddRange(row);
            dgvSarfasl.Dock = DockStyle.Fill;
            dgvSarfasl.Location = new Point(0, 20);
            dgvSarfasl.Name = "dgvSarfasl";
            dgvSarfasl.ReadOnly = true;
            dgvSarfasl.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSarfasl.Size = new Size(1200, 424);
            dgvSarfasl.TabIndex = 1;
            dgvSarfasl.CellDoubleClick += dgvSarfasl_CellDoubleClick;
            dgvSarfasl.KeyDown += dgvSarfasl_KeyDown;
            // 
            // txtSarfasl
            // 
            txtSarfasl.Location = new Point(691, 36);
            txtSarfasl.Name = "txtSarfasl";
            txtSarfasl.ReadOnly = true;
            txtSarfasl.Size = new Size(368, 20);
            txtSarfasl.TabIndex = 1;
            txtSarfasl.TextAlign = HorizontalAlignment.Center;
            txtSarfasl.KeyDown += this.txtSarfasl_KeyDown;
            // 
            // txtZirSarfasl
            // 
            txtZirSarfasl.Location = new Point(221, 36);
            txtZirSarfasl.Name = "txtZirSarfasl";
            txtZirSarfasl.ReadOnly = true;
            txtZirSarfasl.Size = new Size(368, 20);
            txtZirSarfasl.TabIndex = 3;
            txtZirSarfasl.TextAlign = HorizontalAlignment.Center;
            txtZirSarfasl.KeyDown += this.txtZirSarfasl_KeyDown;
            // 
            // lblZirSarfasl
            // 
            lblZirSarfasl.AutoSize = true;
            lblZirSarfasl.Location = new Point(595, 39);
            lblZirSarfasl.Name = "lblZirSarfasl";
            lblZirSarfasl.Size = new Size(80, 13);
            lblZirSarfasl.TabIndex = 2;
            lblZirSarfasl.Text = "زیر سرفصل ها :";
            // 
            // btnShow
            // 
            btnShow.Location = new Point(86, 34);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(75, 23);
            btnShow.TabIndex = 4;
            btnShow.Text = "نمایش";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShow_Click;
            // 
            // btnPrint
            // 
            btnPrint.Location = new Point(42, 9);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(75, 23);
            btnPrint.TabIndex = 0;
            btnPrint.Text = "چاپ";
            btnPrint.UseVisualStyleBackColor = true;
            // 
            // row
            // 
            row.HeaderText = "ردیف";
            row.Name = "row";
            row.ReadOnly = true;
            row.Visible = false;
            // 
            // lblSarfasls
            // 
            lblSarfasls.AutoSize = true;
            lblSarfasls.Location = new Point(1065, 39);
            lblSarfasls.Name = "lblSarfasls";
            lblSarfasls.Size = new Size(63, 13);
            lblSarfasls.TabIndex = 0;
            lblSarfasls.Text = "سرفصل ها :";
            // 
            // ReportSarfasl
            // 
            Controls.Add(pnlFooter);
            Controls.Add(pnlMain);
            Controls.Add(pnlHeader);
            Name = "ReportSarfasl";
            RightToLeft = RightToLeft.Yes;
            Size = new Size(1200, 527);
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlMain.ResumeLayout(false);
            pnlMain.PerformLayout();
            pnlFooter.ResumeLayout(false);
            ((ISupportInitialize) dgvSarfasl).EndInit();
            ResumeLayout(false);
        }

        #region Method

        protected virtual void OpenZirSarfasl()
        {
            //if (dgvSarfasl.SelectedRows.Count > 0)
            //{
            //    //باز کردن زیر سرفصل های سرفصل انتخابی داخل گرید
            //}
        }

        #endregion

        #region Event Controls

        //private void txtSarfasl_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        //{
        //    if (e.KeyCode == Keys.Enter)
        //    {
        //        var sarfasl = new ListSafaslaOrZirSarfasls(1,  _listSar);
        //        sarfasl.Show();
        //        _listSar = sarfasl.listSelectes;
        //    }
        //}

        //private void txtZirSarfasl_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode == Keys.Enter)
        //    {
        //        var zirsarfasl = new ListSafaslaOrZirSarfasls(2 ,_listZirSar);
        //        zirsarfasl.Show();
        //        _listZirSar = zirsarfasl.listSelectes;
        //    }
        //}

        private void btnShow_Click(object sender, EventArgs e)
        {
            //اتصال و اوردن اطلاعات
        }

        #region Event Control Data Grid View

        private void dgvSarfasl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) OpenZirSarfasl();
        }

        private void dgvSarfasl_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            OpenZirSarfasl();
        }

        #endregion

        #endregion
    }
}