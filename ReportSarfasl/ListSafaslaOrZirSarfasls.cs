using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ReportSarfasl.dataLayer;
using ReportSarfasl.Services;

namespace ReportSarfasl
{
    public class ListSafaslaOrZirSarfasls : UserControl
    {
        public int Choise;
        public List<int> listSelected = new List<int>(), listSarfsl = new List<int>();
        private bool _isSearch, _isKeySpase;
        private CheckBox chboxSelectedAll;
        private DataGridView dgvList;
        private object dt;
        public Label lblTextSelected;
        private Panel pnlFooter;
        private Panel pnlHeader;
        private Panel pnlMain;
        private DataGridViewCheckBoxColumn Select;
        private TextBox txtFilter;

        public ListSafaslaOrZirSarfasls()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.chboxSelectedAll = new System.Windows.Forms.CheckBox();
            this.lblTextSelected = new System.Windows.Forms.Label();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.Select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.pnlHeader.SuspendLayout();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.chboxSelectedAll);
            this.pnlHeader.Controls.Add(this.lblTextSelected);
            this.pnlHeader.Controls.Add(this.txtFilter);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(900, 82);
            this.pnlHeader.TabIndex = 0;
            // 
            // chboxSelectedAll
            // 
            this.chboxSelectedAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chboxSelectedAll.AutoSize = true;
            this.chboxSelectedAll.Location = new System.Drawing.Point(810, 52);
            this.chboxSelectedAll.Name = "chboxSelectedAll";
            this.chboxSelectedAll.Size = new System.Drawing.Size(86, 24);
            this.chboxSelectedAll.TabIndex = 2;
            this.chboxSelectedAll.Text = "انتخاب همه";
            this.chboxSelectedAll.UseVisualStyleBackColor = true;
            this.chboxSelectedAll.CheckedChanged += new System.EventHandler(this.chboxSelectedAll_CheckedChanged);
            // 
            // lblTextSelected
            // 
            this.lblTextSelected.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTextSelected.Location = new System.Drawing.Point(0, 28);
            this.lblTextSelected.Name = "lblTextSelected";
            this.lblTextSelected.Size = new System.Drawing.Size(900, 21);
            this.lblTextSelected.TabIndex = 1;
            this.lblTextSelected.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtFilter
            // 
            this.txtFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtFilter.Location = new System.Drawing.Point(0, 0);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(900, 28);
            this.txtFilter.TabIndex = 0;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            this.txtFilter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFilter_KeyDown);
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.dgvList);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 82);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(900, 518);
            this.pnlMain.TabIndex = 0;
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.AllowUserToDeleteRows = false;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Select});
            this.dgvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvList.Location = new System.Drawing.Point(0, 0);
            this.dgvList.MultiSelect = false;
            this.dgvList.Name = "dgvList";
            this.dgvList.ReadOnly = true;
            this.dgvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvList.Size = new System.Drawing.Size(900, 518);
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
            // pnlFooter
            // 
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 590);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(900, 10);
            this.pnlFooter.TabIndex = 1;
            // 
            // ListSafaslaOrZirSarfasls
            // 
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("IRANSans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Name = "ListSafaslaOrZirSarfasls";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(900, 600);
            this.Load += new System.EventHandler(this.ListSafaslaOrZirSarfasls_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.ResumeLayout(false);

        }

        private void ListSafaslaOrZirSarfasls_Load(object sender, EventArgs e)
        {
            // _choise == 1  -->  Sarfasl
            // _choise == 2  -->  Zir Sarfasl
            if (!DesignMode)
            {
                if (Choise == 1)
                {
                    //اتصال
                    dgvList.DataSource = dt = conection.GetSarfaslses();
                }
                else if (Choise == 2)
                {
                    //اتصال
                    if (listSarfsl.Any())
                    {
                        dgvList.DataSource = dt = conection.GetZirSarfasls();
                    }
                    else
                    {
                        dgvList.DataSource = dt = conection.GetZirSarfasls(z => listSarfsl.Contains(z.rdf_sarfasl));
                    }
                }

                SetGrid();

                txtFilter.Focus();
            }
        }
        #region Event Controls

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            search();
        }
        private void txtFilter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                _isSearch = false;
                txtFilter.Text = "";
            }
            else if (e.KeyCode == Keys.Space)
            {
                if ((txtFilter.Text.Trim() == "" && _isSearch)|| (dgvList.Rows.Count == 1))
                {
                    _isKeySpase = true;
                    txtFilter.Text = "";
                    SetCheckBoxColumn();
                }
            }
            else if (dgvList.Rows.Count > 0)
            {
                int rowIndexSelected = dgvList.SelectedRows[0].Index;
                if (e.KeyCode == Keys.Up)
                {
                    _isSearch = true;
                    txtFilter.Text = "";
                    if (rowIndexSelected > 0)
                    {
                        dgvList.Rows[rowIndexSelected - 1].Cells["select"].Selected = true;
                    }
                }
                else if (e.KeyCode == Keys.Down)
                {
                    _isSearch = true;
                    txtFilter.Text = "";
                    if (rowIndexSelected < dgvList.RowCount - 1)
                    {
                        dgvList.Rows[rowIndexSelected + 1].Cells["select"].Selected = true;
                    }
                }
            }
        }

        private void chboxSelectedAll_CheckedChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvList.Rows)
            {
                if (chboxSelectedAll.Checked)
                    AddOrRemoveInListAndTextSelected(row.Index, true);
                else
                    AddOrRemoveInListAndTextSelected(row.Index, false);
            }

            dgvList_DataBindingComplete(sender,
                new DataGridViewBindingCompleteEventArgs(ListChangedType.ItemAdded));
        }

        #region Event Control Data Grid View
        private void dgvList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!_isKeySpase && e.RowIndex >= 0 && e.ColumnIndex == 0)
                SetCheckBoxColumn();

            _isKeySpase = false;

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
                var search = (int)row.Cells["ID"].Value;
                if (listSelected.Any(i => i == search))
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

        #endregion

        #region Event Handler

        public event EventHandler CloseUserControl;
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                if (CloseUserControl != null)
                {
                    CloseUserControl(this,EventArgs.Empty);
                }
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        #endregion

        #region Method

        public void GetData()
        {

        }

        public void SetGrid()
        {
            foreach (DataGridViewColumn col in dgvList.Columns) col.Visible = false;
            //foreach (DataGridViewRow row in dgvList.Rows) row.Cells["row"].Value = row.Index + 1;

            dgvList.Columns["Select"].Visible = true;

            dgvList.Columns["row"].Visible = true;
            dgvList.Columns["row"].HeaderText = "رديف";

            dgvList.Columns["Name"].Visible = true;
            dgvList.Columns["Name"].HeaderText = "نام";
            dgvList.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


        }

        private void SetCheckBoxColumn()
        {
            var rowIndex = dgvList.CurrentCell.RowIndex;
            if (Convert.ToBoolean(dgvList.SelectedRows[0].Cells["select"].Value) == false)
            {
                dgvList.Rows[rowIndex].Cells["select"].Value = true;
                dgvList.Rows[rowIndex].DefaultCellStyle.BackColor = Color.PaleTurquoise;
                AddOrRemoveInListAndTextSelected(rowIndex, true);
            }
            else
            {
                dgvList.Rows[rowIndex].Cells["select"].Value = false;
                dgvList.Rows[rowIndex].DefaultCellStyle.BackColor = Color.White;
                AddOrRemoveInListAndTextSelected(rowIndex, false);
            }
        }


        private void AddOrRemoveInListAndTextSelected(int rowData, bool isAdded)
        {
            lblTextSelected.Text = lblTextSelected.Text.Replace(dgvList.Rows[rowData].Cells["Name"].Value.ToString() + " , ", "");
            listSelected.RemoveAll(i => i == (int)dgvList.Rows[rowData].Cells["ID"].Value);

            if (isAdded)
            {
                listSelected.Add((int)dgvList.Rows[rowData].Cells["ID"].Value);
                lblTextSelected.Text += dgvList.Rows[rowData].Cells["Name"].Value + " , ";
            }
        }

        private void search()
        {
            if (dt!= null)
            {
                var filter = txtFilter.Text.Trim();
                if (filter == "" && !_isSearch)
                {
                    dgvList.DataSource = dt;
                }
                else if (filter != "")
                {
                    _isSearch = false;
                    switch (Choise)
                    {
                        case 1:
                            {
                                dgvList.DataSource = (dt as List<SarfaslService>).Where(c => c.Name.Contains(filter))
                                    .ToList();
                                break;
                            }
                        case 2:
                            {
                                dgvList.DataSource = (dt as List<ZirSarfaslService>).Where(c => c.Name.Contains(filter))
                                    .ToList();
                                break;
                            }
                        default:
                            {
                                throw new Exception("choised parametr (Chois in {1 -> Sarfasl. or 2 -> ZirSarfasl})");
                            }
                    }
                }
            }
        }

        #endregion
    }
}