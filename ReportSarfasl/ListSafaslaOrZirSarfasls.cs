using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReportSarfasl.dataLayer;

namespace ReportSarfasl
{
    public class ListSafaslaOrZirSarfasls : System.Windows.Forms.UserControl
    {
        private int _choise;
        public List<int> listSelectes = new List<int>();
        private object dt;
        private bool _isSearch = false, _isKeySpase = false;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.CheckBox chboxSelectedAll;
        private System.Windows.Forms.Label lblTextSelected;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Select;
        private System.Windows.Forms.DataGridViewTextBoxColumn row;
        private System.Windows.Forms.Panel pnlFooter;

        public ListSafaslaOrZirSarfasls(int Choise, List<int> ListSelectes)
        {
            _choise = Choise;
            if (ListSelectes != null)
            {
                listSelectes = ListSelectes;
            }

            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblTextSelected = new System.Windows.Forms.Label();
            this.chboxSelectedAll = new System.Windows.Forms.CheckBox();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.Select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.row = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlHeader.SuspendLayout();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.chboxSelectedAll);
            this.pnlHeader.Controls.Add(this.lblTextSelected);
            this.pnlHeader.Controls.Add(this.txtSearch);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(800, 67);
            this.pnlHeader.TabIndex = 0;
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.dgvList);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 67);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(800, 460);
            this.pnlMain.TabIndex = 0;
            // 
            // pnlFooter
            // 
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 517);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(800, 10);
            this.pnlFooter.TabIndex = 1;
            // 
            // txtSearch
            // 
            this.txtSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtSearch.Location = new System.Drawing.Point(0, 0);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(800, 20);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblTextSelected
            // 
            this.lblTextSelected.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTextSelected.Location = new System.Drawing.Point(0, 20);
            this.lblTextSelected.Name = "lblTextSelected";
            this.lblTextSelected.Size = new System.Drawing.Size(800, 13);
            this.lblTextSelected.TabIndex = 1;
            this.lblTextSelected.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chboxSelectedAll
            // 
            this.chboxSelectedAll.AutoSize = true;
            this.chboxSelectedAll.Location = new System.Drawing.Point(721, 43);
            this.chboxSelectedAll.Name = "chboxSelectedAll";
            this.chboxSelectedAll.Size = new System.Drawing.Size(76, 17);
            this.chboxSelectedAll.TabIndex = 2;
            this.chboxSelectedAll.Text = "انتخاب همه";
            this.chboxSelectedAll.UseVisualStyleBackColor = true;
            this.chboxSelectedAll.CheckedChanged += new System.EventHandler(this.chboxSelectedAll_CheckedChanged);
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.AllowUserToDeleteRows = false;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Select,
            this.row});
            this.dgvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvList.Location = new System.Drawing.Point(0, 0);
            this.dgvList.Name = "dgvList";
            this.dgvList.ReadOnly = true;
            this.dgvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvList.Size = new System.Drawing.Size(800, 460);
            this.dgvList.TabIndex = 0;
            this.dgvList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvList_CellClick);
            this.dgvList.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvList_DataBindingComplete);
            this.dgvList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvList_KeyDown);
            // 
            // Select
            // 
            this.Select.HeaderText = "انتخاب";
            this.Select.Name = "Select";
            this.Select.ReadOnly = true;
            this.Select.Visible = false;
            // 
            // row
            // 
            this.row.HeaderText = "ردیف";
            this.row.Name = "row";
            this.row.ReadOnly = true;
            this.row.Visible = false;
            // 
            // ListSafaslaOrZirSarfasls
            // 
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlHeader);
            this.Name = "ListSafaslaOrZirSarfasls";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(800, 527);
            this.Load += new System.EventHandler(this.ListSafaslaOrZirSarfasls_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.ResumeLayout(false);

        }

        #region Event Controls

        private void ListSafaslaOrZirSarfasls_Load(object sender, EventArgs e)
        {
            // _choise == 1  -->  Sarfasl
            // _choise == 2  -->  Zir Sarfasl
            //لود کردن اطلاعات گرید
            //خواندن لیست و اعمال تیک های لیست

            SetGrid();

        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            search();
        }

        #region Event Control Data Grid View

        private void dgvList_CellClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            if (_isKeySpase)
            {
                _isKeySpase = false;
            }
            else if (e.RowIndex >= 0 && e.ColumnIndex == 0)
            {
                SetCheckBoxColumn();
            }
        }
        private void dgvList_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                _isKeySpase = true;
                SetCheckBoxColumn();
            }
        }

        private void dgvList_DataBindingComplete(object sender, System.Windows.Forms.DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in dgvList.Rows)
            {
                int search = (int)row.Cells["shmo"].Value;
                if (listSelectes.Find(i => i == search) == search)
                {
                    row.Cells["select"].Value = true;
                    row.DefaultCellStyle.BackColor = Color.PaleTurquoise;
                }
                else
                {
                    row.Cells["select"].Value = false;
                    row.DefaultCellStyle.BackColor = Color.White;
                }
            }
        }

        #endregion

        private void chboxSelectedAll_CheckedChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvList.Rows)
            {

                if (chboxSelectedAll.Checked)
                {
                    listSelectes.Add((int)row.Cells["rdf"].Value);
                }
                else
                {
                    listSelectes.Remove((int)row.Cells["rdf"].Value);
                }

            }

            txtSearch.Text = listSelectes.Count.ToString();
            dgvList_DataBindingComplete(sender,
                new DataGridViewBindingCompleteEventArgs(ListChangedType.ItemAdded));
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                //مقدار دهی پارامتر خروجی که همون رشته نام های انتخابی است و لیستی که کلید ردیف های انتخابی 
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        #endregion

        #region Method

        private void SetGrid()
        {
            foreach (DataGridViewColumn col in dgvList.Columns)
            {
                col.Visible = false;
            }
            foreach (DataGridViewRow row in dgvList.Rows)
            {
                row.Cells["row"].Value = row.Index + 1;
            }

            dgvList.Columns["name"].Visible = true;
            dgvList.Columns["name"].HeaderText = "نام";
            dgvList.Columns["name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvList.Columns["row"].Visible = true;

            dgvList.Columns["Select"].Visible = true;
        }

        private void SetCheckBoxColumn()
        {
            var rowIndex = dgvList.CurrentCell.RowIndex;
            if (Convert.ToBoolean(dgvList.SelectedRows[0].Cells["select"].Value) == false)
            {
                dgvList.Rows[rowIndex].Cells["select"].Value = true;
                dgvList.Rows[rowIndex].DefaultCellStyle.BackColor = Color.PaleTurquoise;
                listSelectes.Add((int)dgvList.Rows[rowIndex].Cells["rdf"].Value);
            }
            else
            {
                dgvList.Rows[rowIndex].Cells["select"].Value = false;
                dgvList.Rows[rowIndex].DefaultCellStyle.BackColor = Color.White;
                listSelectes.Remove((int)dgvList.Rows[rowIndex].Cells["rdf"].Value);
            }
        }

        private void search()
        {
            string filter = txtSearch.Text.Trim();
            if (filter == "" && !_isSearch)
            {
                dgvList.DataSource = dt;

            }
            else if (filter != "")
            {
                _isSearch = false;
                switch (_choise)
                {
                    case 1:
                        {
                            dgvList.DataSource = (dt as List<sarfasls>).Where(c => c.name.Contains(filter)).ToList();
                            break;
                        }
                    case 2:
                        {
                            dgvList.DataSource = (dt as List<zirsarfasls>).Where(c => c.name.Contains(filter)).ToList();
                            break;
                        }
                }
            }
        }


        #endregion

    }
}
