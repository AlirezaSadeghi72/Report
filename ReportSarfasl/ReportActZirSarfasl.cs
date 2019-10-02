﻿using ReportSarfasl.dataLayer;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReportSarfasl.Services;

namespace ReportSarfasl
{
    public class ReportActZirSarfasl : UserControl
    {
        private int _zirSarfaslID, _sarfaslID;
        private List<int> _listZirSar = new List<int>();
        private bool _isActForSarfasl;
        private List<ActZirSarfaslService> dt;
        private Panel pnlHeader;
        private Panel pnlMain;
        private Button btnCancel;
        private Button btnPrint;
        private TextBox txtFilter;
        private GroupBox groupBox2;
        private Label label2;
        private GroupBox groupBox1;
        private Label lblFooter;
        private DataGridView dgvActZirSarfasl;
        private Panel pnlFooter;

        public ReportActZirSarfasl(int zirSarfaslID =-1, int sarfaslID = -1, List<int> listZirsarfasl = null)
        {
            InitializeComponent();
            if (zirSarfaslID != -1)
            {
                _zirSarfaslID = zirSarfaslID;
                _isActForSarfasl = false;
            }
            else if (sarfaslID != -1)
            {
                _sarfaslID = sarfaslID;
                _listZirSar = listZirsarfasl;
                _isActForSarfasl = true;
            }
            else
            {
                throw new NullReferenceException();
            }
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvActZirSarfasl = new System.Windows.Forms.DataGridView();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.lblFooter = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActZirSarfasl)).BeginInit();
            this.pnlFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.groupBox2);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(700, 54);
            this.pnlHeader.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(700, 54);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "جزييات زيرسرفصل";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(747, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "label2";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.groupBox1);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 54);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(700, 346);
            this.pnlMain.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvActZirSarfasl);
            this.groupBox1.Controls.Add(this.txtFilter);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(700, 346);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "عملكرد هاي  زيرسرفصل";
            // 
            // dgvActZirSarfasl
            // 
            this.dgvActZirSarfasl.AllowUserToAddRows = false;
            this.dgvActZirSarfasl.AllowUserToDeleteRows = false;
            this.dgvActZirSarfasl.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(160)))), ((int)(((byte)(200)))));
            this.dgvActZirSarfasl.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(26)))), ((int)(((byte)(71)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("IRANSans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvActZirSarfasl.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvActZirSarfasl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("IRANSans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvActZirSarfasl.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvActZirSarfasl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvActZirSarfasl.EnableHeadersVisualStyles = false;
            this.dgvActZirSarfasl.Location = new System.Drawing.Point(3, 52);
            this.dgvActZirSarfasl.MultiSelect = false;
            this.dgvActZirSarfasl.Name = "dgvActZirSarfasl";
            this.dgvActZirSarfasl.ReadOnly = true;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            this.dgvActZirSarfasl.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvActZirSarfasl.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvActZirSarfasl.Size = new System.Drawing.Size(694, 291);
            this.dgvActZirSarfasl.TabIndex = 6;
            // 
            // txtFilter
            // 
            this.txtFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtFilter.Location = new System.Drawing.Point(3, 24);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(694, 28);
            this.txtFilter.TabIndex = 5;
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
            this.pnlFooter.Location = new System.Drawing.Point(0, 344);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(700, 56);
            this.pnlFooter.TabIndex = 3;
            // 
            // lblFooter
            // 
            this.lblFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblFooter.Location = new System.Drawing.Point(0, 36);
            this.lblFooter.Name = "lblFooter";
            this.lblFooter.Size = new System.Drawing.Size(700, 20);
            this.lblFooter.TabIndex = 8;
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Location = new System.Drawing.Point(13, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 30);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "انصراف";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.Indigo;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(88, 3);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 30);
            this.btnPrint.TabIndex = 6;
            this.btnPrint.Text = "چاپ";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // ReportActZirSarfasl
            // 
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("IRANSans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Name = "ReportActZirSarfasl";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(700, 400);
            this.Load += new System.EventHandler(this.ReportActZirSarfasl_Load);
            this.pnlHeader.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActZirSarfasl)).EndInit();
            this.pnlFooter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void ReportActZirSarfasl_Load(object sender, EventArgs e)
        {

            if (_isActForSarfasl)
            {
                dgvActZirSarfasl.DataSource = dt = conection.GetActZirSarfaslServices(sarfaslID: _sarfaslID, listZirsarfasl: _listZirSar);
            }
            else
            {
                dgvActZirSarfasl.DataSource = dt = conection.GetActZirSarfaslServices(zirSarfaslID: _zirSarfaslID);
            }

            SetTextLabelFooter(dt.Count, (int)dt.Sum(d => d.bed - d.bes), dt.Sum(d => d.bed), dt.Sum(d => d.bes));

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
            if (e.KeyData == Keys.Escape)
            {
                txtFilter.Text = "";
            }
            else if (dgvActZirSarfasl.Rows.Count > 0)
            {
                int countRowGrid = dgvActZirSarfasl.Rows.Count;
                int rowIndexSelected = dgvActZirSarfasl.SelectedRows[0].Index;
                if (e.KeyCode == Keys.Up)
                {
                    if (rowIndexSelected == 0)
                    {
                        dgvActZirSarfasl.Rows[countRowGrid - 1].Selected = true;
                    }
                    else
                    {
                        dgvActZirSarfasl.Rows[rowIndexSelected - 1].Selected = true;
                    }
                }
                else if (e.KeyCode == Keys.Down)
                {
                    dgvActZirSarfasl.Rows[(rowIndexSelected + 1) % countRowGrid].Selected = true;
                }
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            //چاپ
        }

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
            foreach (DataGridViewColumn col in dgvActZirSarfasl.Columns) col.Visible = false;
            //foreach (DataGridViewRow row in dgvSarfasl.Rows) row.Cells["row"].Value = row.Index + 1;

            dgvActZirSarfasl.Columns["row"].Visible = true;
            dgvActZirSarfasl.Columns["row"].HeaderText = "رديف";

            dgvActZirSarfasl.Columns["description"].Visible = true;
            dgvActZirSarfasl.Columns["description"].HeaderText = "توضيحات";
            dgvActZirSarfasl.Columns["description"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvActZirSarfasl.Columns["bed"].Visible = true;
            dgvActZirSarfasl.Columns["bed"].HeaderText = "بدهكاري";
            dgvActZirSarfasl.Columns["bed"].DefaultCellStyle.Format = "#,0";
            dgvActZirSarfasl.Columns["bed"].DefaultCellStyle.Font = new Font("IRANSans(FaNum)", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dgvActZirSarfasl.Columns["bed"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvActZirSarfasl.Columns["bes"].Visible = true;
            dgvActZirSarfasl.Columns["bes"].HeaderText = "بستانكاري";
            dgvActZirSarfasl.Columns["bes"].DefaultCellStyle.Format = "#,0";
            dgvActZirSarfasl.Columns["bes"].DefaultCellStyle.Font = new Font("IRANSans(FaNum)", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dgvActZirSarfasl.Columns["bes"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvActZirSarfasl.Columns["bed_bes"].Visible = true;
            dgvActZirSarfasl.Columns["bed_bes"].HeaderText = "وضعيت";
            dgvActZirSarfasl.Columns["bed_bes"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvActZirSarfasl.Columns["date"].Visible = true;
            dgvActZirSarfasl.Columns["date"].HeaderText = "تاريخ";
            dgvActZirSarfasl.Columns["date"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


        }

        private void search()
        {
            if (dt != null)
            {
                var filter = txtFilter.Text.Trim();

                var dt1 = dt.Where(c => c.description.Contains(filter)).ToList();
                dgvActZirSarfasl.DataSource = dt1;

                SetTextLabelFooter(dt1.Count, (int)dt1.Sum(d => d.bed - d.bes), dt1.Sum(d => d.bed), dt1.Sum(d => d.bes));
            }
        }

        private void SetTextLabelFooter(int number, int sum, decimal bed, decimal bes)
        {
            string status = (sum > 0) ? "بدهكار" : (sum == 0) ? "--": "بستانكار";
            lblFooter.Text =
                $"تعداد: {number}   بدهكاري: {bed.ToMan()}   بستانكاري: {bes.ToMan()}   اختلاف: {Math.Abs(sum)}  ({status})";
        }

        #endregion
    }
}
