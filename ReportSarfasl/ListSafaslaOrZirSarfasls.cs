using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ReportSarfasl.dataLayer;

namespace ReportSarfasl
{
    public class ListSafaslaOrZirSarfasls : UserControl
    {
        private readonly int _choise;
        private bool _isSearch, _isKeySpase;
        private CheckBox chboxSelectedAll;
        private DataGridView dgvList;
        private object dt;
        private Label lblTextSelected;
        public List<int> listSelectes = new List<int>();
        private Panel pnlFooter;
        private Panel pnlHeader;
        private Panel pnlMain;
        private DataGridViewTextBoxColumn row;
        private DataGridViewCheckBoxColumn Select;
        private TextBox txtSearch;

        public ListSafaslaOrZirSarfasls(int Choise, List<int> ListSelectes)
        {
            _choise = Choise;
            if (ListSelectes != null) listSelectes = ListSelectes;

            InitializeComponent();
        }

        private void InitializeComponent()
        {
            pnlHeader = new Panel();
            pnlMain = new Panel();
            pnlFooter = new Panel();
            txtSearch = new TextBox();
            lblTextSelected = new Label();
            chboxSelectedAll = new CheckBox();
            dgvList = new DataGridView();
            Select = new DataGridViewCheckBoxColumn();
            row = new DataGridViewTextBoxColumn();
            pnlHeader.SuspendLayout();
            pnlMain.SuspendLayout();
            ((ISupportInitialize) dgvList).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.Controls.Add(chboxSelectedAll);
            pnlHeader.Controls.Add(lblTextSelected);
            pnlHeader.Controls.Add(txtSearch);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(800, 67);
            pnlHeader.TabIndex = 0;
            // 
            // pnlMain
            // 
            pnlMain.Controls.Add(dgvList);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(0, 67);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(800, 460);
            pnlMain.TabIndex = 0;
            // 
            // pnlFooter
            // 
            pnlFooter.Dock = DockStyle.Bottom;
            pnlFooter.Location = new Point(0, 517);
            pnlFooter.Name = "pnlFooter";
            pnlFooter.Size = new Size(800, 10);
            pnlFooter.TabIndex = 1;
            // 
            // txtSearch
            // 
            txtSearch.Dock = DockStyle.Top;
            txtSearch.Location = new Point(0, 0);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(800, 20);
            txtSearch.TabIndex = 0;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // lblTextSelected
            // 
            lblTextSelected.Dock = DockStyle.Top;
            lblTextSelected.Location = new Point(0, 20);
            lblTextSelected.Name = "lblTextSelected";
            lblTextSelected.Size = new Size(800, 13);
            lblTextSelected.TabIndex = 1;
            lblTextSelected.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // chboxSelectedAll
            // 
            chboxSelectedAll.AutoSize = true;
            chboxSelectedAll.Location = new Point(721, 43);
            chboxSelectedAll.Name = "chboxSelectedAll";
            chboxSelectedAll.Size = new Size(76, 17);
            chboxSelectedAll.TabIndex = 2;
            chboxSelectedAll.Text = "انتخاب همه";
            chboxSelectedAll.UseVisualStyleBackColor = true;
            chboxSelectedAll.CheckedChanged += chboxSelectedAll_CheckedChanged;
            // 
            // dgvList
            // 
            dgvList.AllowUserToAddRows = false;
            dgvList.AllowUserToDeleteRows = false;
            dgvList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvList.Columns.AddRange(Select, row);
            dgvList.Dock = DockStyle.Fill;
            dgvList.Location = new Point(0, 0);
            dgvList.Name = "dgvList";
            dgvList.ReadOnly = true;
            dgvList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvList.Size = new Size(800, 460);
            dgvList.TabIndex = 0;
            dgvList.CellClick += dgvList_CellClick;
            dgvList.DataBindingComplete += dgvList_DataBindingComplete;
            dgvList.KeyDown += dgvList_KeyDown;
            // 
            // Select
            // 
            Select.HeaderText = "انتخاب";
            Select.Name = "Select";
            Select.ReadOnly = true;
            Select.Visible = false;
            // 
            // row
            // 
            row.HeaderText = "ردیف";
            row.Name = "row";
            row.ReadOnly = true;
            row.Visible = false;
            // 
            // ListSafaslaOrZirSarfasls
            // 
            Controls.Add(pnlFooter);
            Controls.Add(pnlMain);
            Controls.Add(pnlHeader);
            Name = "ListSafaslaOrZirSarfasls";
            RightToLeft = RightToLeft.Yes;
            Size = new Size(800, 527);
            Load += ListSafaslaOrZirSarfasls_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlMain.ResumeLayout(false);
            ((ISupportInitialize) dgvList).EndInit();
            ResumeLayout(false);
        }

        #region Event Controls

        private void ListSafaslaOrZirSarfasls_Load(object sender, EventArgs e)
        {
            // _choise == 1  -->  Sarfasl
            // _choise == 2  -->  Zir Sarfasl

            if (_choise == 1)
            {
                //خواندن لیست و اعمال تیک های لیست
            }
            else if (_choise == 2)
            {
                //خواندن لیست و اعمال تیک های لیست
            }
            else
            {
                throw new Exception("_chois in (1 or 2)");
            }

            SetGrid();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            search();
        }

        #region Event Control Data Grid View

        private void dgvList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (_isKeySpase)
                _isKeySpase = false;
            else if (e.RowIndex >= 0 && e.ColumnIndex == 0) SetCheckBoxColumn();
        }

        private void dgvList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                _isKeySpase = true;
                SetCheckBoxColumn();
            }
        }

        private void dgvList_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in dgvList.Rows)
            {
                var search = (int) row.Cells["shmo"].Value;
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
                if (chboxSelectedAll.Checked)
                    listSelectes.Add((int) row.Cells["rdf"].Value);
                else
                    listSelectes.Remove((int) row.Cells["rdf"].Value);

            txtSearch.Text = listSelectes.Count.ToString();
            dgvList_DataBindingComplete(sender,
                new DataGridViewBindingCompleteEventArgs(ListChangedType.ItemAdded));
        }

        //protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        //{
        //    if (keyData == Keys.Enter)
        //    {
        //        this.close
        //        //مقدار دهی پارامتر خروجی که همون رشته نام های انتخابی است و لیستی که کلید ردیف های انتخابی 
        //        return true;
        //    }
        //    return base.ProcessCmdKey(ref msg, keyData);
        //}

        #endregion

        #region Method

        private void SetGrid()
        {
            foreach (DataGridViewColumn col in dgvList.Columns) col.Visible = false;
            foreach (DataGridViewRow row in dgvList.Rows) row.Cells["row"].Value = row.Index + 1;

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
                listSelectes.Add((int) dgvList.Rows[rowIndex].Cells["rdf"].Value);
            }
            else
            {
                dgvList.Rows[rowIndex].Cells["select"].Value = false;
                dgvList.Rows[rowIndex].DefaultCellStyle.BackColor = Color.White;
                listSelectes.Remove((int) dgvList.Rows[rowIndex].Cells["rdf"].Value);
            }
        }

        private void search()
        {
            var filter = txtSearch.Text.Trim();
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