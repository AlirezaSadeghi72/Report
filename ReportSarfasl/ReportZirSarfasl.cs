﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReportSarfasl.dataLayer;
using ReportSarfasl.Forms;
using ReportSarfasl.Services;

namespace ReportSarfasl
{
    public class ReportZirSarfasl : UserControl
    {

        private List<int> _listZirSar = new List<int>();
        private int _sarfaslID, _zirSarfaslIdSelected;
        private List<ZirSarfaslService> dt;
        private bool _isSearch = false;//, _isKeySpase = false;
        private Panel pnlMain;
        private GroupBox groupBox1;
        private Button btnCancel;
        private Button btnPrint;
        private TextBox txtFilter;
        private Label lblFooter;
        private DataGridView dgvZirSarfal;
        private Panel pnlFooter;

        public ReportZirSarfasl(List<int> ListZirSar, int sarfaslID)
        {
            InitializeComponent();
            _listZirSar = ListZirSar;
            _sarfaslID = sarfaslID;
        }
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvZirSarfal = new System.Windows.Forms.DataGridView();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.lblFooter = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.pnlMain.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZirSarfal)).BeginInit();
            this.pnlFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.groupBox1);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(800, 500);
            this.pnlMain.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvZirSarfal);
            this.groupBox1.Controls.Add(this.txtFilter);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 500);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ليست زيرسرفصل هاي      سرفصل :   ";
            // 
            // dgvZirSarfal
            // 
            this.dgvZirSarfal.AllowUserToAddRows = false;
            this.dgvZirSarfal.AllowUserToDeleteRows = false;
            this.dgvZirSarfal.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(160)))), ((int)(((byte)(200)))));
            this.dgvZirSarfal.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(26)))), ((int)(((byte)(71)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("IRANSans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvZirSarfal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvZirSarfal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("IRANSans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvZirSarfal.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvZirSarfal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvZirSarfal.EnableHeadersVisualStyles = false;
            this.dgvZirSarfal.Location = new System.Drawing.Point(3, 52);
            this.dgvZirSarfal.MultiSelect = false;
            this.dgvZirSarfal.Name = "dgvZirSarfal";
            this.dgvZirSarfal.ReadOnly = true;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            this.dgvZirSarfal.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvZirSarfal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvZirSarfal.Size = new System.Drawing.Size(794, 445);
            this.dgvZirSarfal.TabIndex = 2;
            this.dgvZirSarfal.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvZirSarfal_CellDoubleClick);
            this.dgvZirSarfal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvZirSarfal_KeyDown);
            // 
            // txtFilter
            // 
            this.txtFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtFilter.Location = new System.Drawing.Point(3, 24);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(794, 28);
            this.txtFilter.TabIndex = 1;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            this.txtFilter.Enter += new System.EventHandler(this.txtFilter_Enter);
            this.txtFilter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFilter_KeyDown);
            this.txtFilter.Leave += new System.EventHandler(this.txtFilter_Leave);
            // 
            // pnlFooter
            // 
            this.pnlFooter.Controls.Add(this.lblFooter);
            this.pnlFooter.Controls.Add(this.btnCancel);
            this.pnlFooter.Controls.Add(this.btnPrint);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 442);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(800, 58);
            this.pnlFooter.TabIndex = 2;
            // 
            // lblFooter
            // 
            this.lblFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblFooter.Location = new System.Drawing.Point(0, 38);
            this.lblFooter.Name = "lblFooter";
            this.lblFooter.Size = new System.Drawing.Size(800, 20);
            this.lblFooter.TabIndex = 9;
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Location = new System.Drawing.Point(24, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 30);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "انصراف";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.Indigo;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(99, 6);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 30);
            this.btnPrint.TabIndex = 1;
            this.btnPrint.Text = "چاپ";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // ReportZirSarfasl
            // 
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.pnlMain);
            this.Font = new System.Drawing.Font("IRANSans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Name = "ReportZirSarfasl";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(800, 500);
            this.Load += new System.EventHandler(this.ReportZirSarfasl_Load);
            this.pnlMain.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZirSarfal)).EndInit();
            this.pnlFooter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void ReportZirSarfasl_Load(object sender, EventArgs e)
        {
            dgvZirSarfal.DataSource = dt = conection.GetZirSarfaslServices(_listZirSar, _sarfaslID);

            SetTextLabelFooter(dt.Count, dt.Sum(d => d.Man));
            
            SetGrid();

            txtFilter.Focus();
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
            else if (e.KeyCode == Keys.Enter)
            {
                OpenActZirSarfasl();
            }
            else if (dgvZirSarfal.Rows.Count > 0)
            {
                int countRowGrid = dgvZirSarfal.Rows.Count;
                int rowIndexSelected = dgvZirSarfal.SelectedRows[0].Index;
                if (e.KeyCode == Keys.Up)
                {
                    if (rowIndexSelected == 0)
                    {
                        dgvZirSarfal.Rows[countRowGrid - 1].Selected = true;
                    }
                    else
                    {
                        dgvZirSarfal.Rows[rowIndexSelected - 1].Selected = true;
                    }
                }
                else if (e.KeyCode == Keys.Down)
                {
                    dgvZirSarfal.Rows[(rowIndexSelected + 1) % countRowGrid].Selected = true;
                }
            }
        }

        #region Event Control Data Grid View

        private void dgvZirSarfal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                OpenActZirSarfasl();
            }
        }

        private void dgvZirSarfal_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            OpenActZirSarfasl();
        }

        #endregion

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ((Form)this.TopLevelControl).Close();
            //بستن فرم
        }

        private void txtFilter_Enter(object sender, EventArgs e)
        {
            txtFilter.BackColor = Color.Bisque;
        }
        private void txtFilter_Leave(object sender, EventArgs e)
        {
            txtFilter.BackColor = Color.White;
        }

        #endregion
        #region Event override
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape && !txtFilter.Focused)
            {
                ((Form)this.TopLevelControl).Close();
                return false;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        #endregion
        #region Method

        private void SetGrid()
        {
            foreach (DataGridViewColumn col in dgvZirSarfal.Columns) col.Visible = false;
            //foreach (DataGridViewRow row in dgvSarfasl.Rows) row.Cells["row"].Value = row.Index + 1;

            dgvZirSarfal.Columns["row"].Visible = true;
            dgvZirSarfal.Columns["row"].HeaderText = "رديف";

            dgvZirSarfal.Columns["Name"].Visible = true;
            dgvZirSarfal.Columns["Name"].HeaderText = "نام";
            dgvZirSarfal.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvZirSarfal.Columns["Man"].Visible = true;
            dgvZirSarfal.Columns["Man"].HeaderText = "مانده";
            dgvZirSarfal.Columns["Man"].DefaultCellStyle.Format = "#,0";
            dgvZirSarfal.Columns["Man"].DefaultCellStyle.Font = new Font("IRANSans(FaNum)", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dgvZirSarfal.Columns["Man"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }

        private void search()
        {
            if (dt != null)
            {
                var filter = txtFilter.Text.Trim();

                var dt1 = dt.Where(c => c.Name.Contains(filter)).ToList();
                dgvZirSarfal.DataSource = dt1;

                SetTextLabelFooter(dt1.Count, dt1.Sum(d => d.Man));
            }
        }

        private void OpenActZirSarfasl()
        {
            if (dgvZirSarfal.SelectedRows.Count > 0)
            {
                _zirSarfaslIdSelected = (int)dgvZirSarfal.SelectedRows[0].Cells["ID"].Value;
                DefultForm reportZirSarfasl = new DefultForm();
                reportZirSarfasl.ShowDialog(new ReportActZirSarfasl(zirSarfaslID: _zirSarfaslIdSelected), new Size(700, 400));
                //باز کردن زیر سرفصل های سرفصل انتخابی داخل گرید
            }
        }

        private void SetTextLabelFooter(int number, decimal sum)
        {
            string status = (sum > 0) ? "بدهكار" : (sum == 0) ? "--" : "بستانكار";
            lblFooter.Text =
                $"تعداد: {number}    اختلاف: {Math.Abs(sum).ToMan()}  ({status})";
        }
        
        #endregion

    }
}
