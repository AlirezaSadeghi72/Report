using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReportSarfasl
{
    public class ReportZirSarfasl : System.Windows.Forms.UserControl
    {
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.DataGridView dgvSarfasl;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.TextBox txtZirSarfasl;
        private System.Windows.Forms.Label lblZirSarfasl;
        private System.Windows.Forms.TextBox txtSarfasl;
        private System.Windows.Forms.Label lblSarfasls;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnPrint;
        private DataGridViewTextBoxColumn row;
        private System.Windows.Forms.Panel pnlFooter;

        public ReportZirSarfasl()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.dgvSarfasl = new System.Windows.Forms.DataGridView();
            this.lblSarfasls = new System.Windows.Forms.Label();
            this.txtSarfasl = new System.Windows.Forms.TextBox();
            this.txtZirSarfasl = new System.Windows.Forms.TextBox();
            this.lblZirSarfasl = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.row = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlHeader.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSarfasl)).BeginInit();
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
            // pnlFooter
            // 
            this.pnlFooter.Controls.Add(this.btnPrint);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 485);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(1200, 42);
            this.pnlFooter.TabIndex = 2;
            // 
            // txtFilter
            // 
            this.txtFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtFilter.Location = new System.Drawing.Point(0, 0);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(1200, 20);
            this.txtFilter.TabIndex = 0;
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
            this.dgvSarfasl.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSarfasl_CellDoubleClick);
            this.dgvSarfasl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvSarfasl_KeyDown);
            // 
            // lblSarfasls
            // 
            this.lblSarfasls.AutoSize = true;
            this.lblSarfasls.Location = new System.Drawing.Point(1065, 39);
            this.lblSarfasls.Name = "lblSarfasls";
            this.lblSarfasls.Size = new System.Drawing.Size(63, 13);
            this.lblSarfasls.TabIndex = 0;
            this.lblSarfasls.Text = "سرفصل ها :";
            // 
            // txtSarfasl
            // 
            this.txtSarfasl.Location = new System.Drawing.Point(691, 36);
            this.txtSarfasl.Name = "txtSarfasl";
            this.txtSarfasl.ReadOnly = true;
            this.txtSarfasl.Size = new System.Drawing.Size(368, 20);
            this.txtSarfasl.TabIndex = 1;
            this.txtSarfasl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSarfasl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSarfasl_KeyDown);
            // 
            // txtZirSarfasl
            // 
            this.txtZirSarfasl.Location = new System.Drawing.Point(221, 36);
            this.txtZirSarfasl.Name = "txtZirSarfasl";
            this.txtZirSarfasl.ReadOnly = true;
            this.txtZirSarfasl.Size = new System.Drawing.Size(368, 20);
            this.txtZirSarfasl.TabIndex = 3;
            this.txtZirSarfasl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtZirSarfasl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtZirSarfasl_KeyDown);
            // 
            // lblZirSarfasl
            // 
            this.lblZirSarfasl.AutoSize = true;
            this.lblZirSarfasl.Location = new System.Drawing.Point(595, 39);
            this.lblZirSarfasl.Name = "lblZirSarfasl";
            this.lblZirSarfasl.Size = new System.Drawing.Size(80, 13);
            this.lblZirSarfasl.TabIndex = 2;
            this.lblZirSarfasl.Text = "زیر سرفصل ها :";
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(86, 34);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 4;
            this.btnShow.Text = "نمایش";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
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
            // row
            // 
            this.row.HeaderText = "ردیف";
            this.row.Name = "row";
            this.row.ReadOnly = true;
            this.row.Visible = false;
            // 
            // ReportZirSarfasl
            // 
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlHeader);
            this.Name = "ReportZirSarfasl";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(1200, 527);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlFooter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSarfasl)).EndInit();
            this.ResumeLayout(false);

        }

        #region Event Controls

        private void txtSarfasl_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //باز کردن لیست سرفصل
            }
        }

        private void txtZirSarfasl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //باز کردن لیست زیر سرفصل
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            //اتصال و اوردن اطلاعات
        }

        #region Event Control Data Grid View
        private void dgvSarfasl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                OpenZirSarfasl();
            }
        }

        private void dgvSarfasl_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            OpenZirSarfasl();
        }

        #endregion

        #endregion

        #region Method

        private void OpenZirSarfasl()
        {
            if (dgvSarfasl.SelectedRows.Count > 0)
            {
                //باز کردن زیر سرفصل های سرفصل انتخابی داخل گرید
            }
        }

        #endregion

    }
}
