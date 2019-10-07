using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using ReportSarfasl.dataLayer;
using ReportSarfasl.Forms;
using ReportSarfasl.Services;

namespace ReportSarfasl
{
    public class reportSarfasl : UserControl
    {
        private List<int> _listSar = new List<int>(), _listZirSar = new List<int>();
        private int _sarfaslIdSelected;
        private List<SarfaslService> dt;
        private Button btnPrint;
        private DataGridView dgvSarfasl;
        private Panel pnlFooter;
        private Panel pnlHeader;
        private Panel pnlMain;
        private GroupBox groupBox1;
        private Button btnShow;
        private TextBox txtZirSarfasl;
        private TextBox txtSarfasl;
        private Label lblSarfasls;
        private Button btnCancel;
        private Label lblFooter;
        private TextDate textDate1;
        private Label lblFooterNumber;
        private CheckBox chbZirSarfasls;
        private CheckBox chbSarfasls;
        private Label label1;
        private TextBox txtFilter;


        public reportSarfasl()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chbZirSarfasls = new System.Windows.Forms.CheckBox();
            this.chbSarfasls = new System.Windows.Forms.CheckBox();
            this.textDate1 = new ReportSarfasl.TextDate();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSarfasls = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.txtZirSarfasl = new System.Windows.Forms.TextBox();
            this.txtSarfasl = new System.Windows.Forms.TextBox();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.dgvSarfasl = new System.Windows.Forms.DataGridView();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.lblFooter = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.lblFooterNumber = new System.Windows.Forms.Label();
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
            this.pnlHeader.Size = new System.Drawing.Size(900, 94);
            this.pnlHeader.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chbZirSarfasls);
            this.groupBox1.Controls.Add(this.chbSarfasls);
            this.groupBox1.Controls.Add(this.textDate1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblSarfasls);
            this.groupBox1.Controls.Add(this.btnShow);
            this.groupBox1.Controls.Add(this.txtZirSarfasl);
            this.groupBox1.Controls.Add(this.txtSarfasl);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(900, 94);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // chbZirSarfasls
            // 
            this.chbZirSarfasls.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chbZirSarfasls.AutoSize = true;
            this.chbZirSarfasls.Location = new System.Drawing.Point(471, 60);
            this.chbZirSarfasls.Name = "chbZirSarfasls";
            this.chbZirSarfasls.Size = new System.Drawing.Size(94, 24);
            this.chbZirSarfasls.TabIndex = 11;
            this.chbZirSarfasls.Text = "زير سرفصل ها";
            this.chbZirSarfasls.UseVisualStyleBackColor = true;
            this.chbZirSarfasls.CheckedChanged += new System.EventHandler(this.chbZirSarfasls_CheckedChanged);
            this.chbZirSarfasls.KeyDown += new System.Windows.Forms.KeyEventHandler(this.chbZirSarfasls_KeyDown);
            // 
            // chbSarfasls
            // 
            this.chbSarfasls.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chbSarfasls.AutoSize = true;
            this.chbSarfasls.Location = new System.Drawing.Point(816, 60);
            this.chbSarfasls.Name = "chbSarfasls";
            this.chbSarfasls.Size = new System.Drawing.Size(78, 24);
            this.chbSarfasls.TabIndex = 10;
            this.chbSarfasls.Text = "سرفصل ها";
            this.chbSarfasls.UseVisualStyleBackColor = true;
            this.chbSarfasls.CheckedChanged += new System.EventHandler(this.chbSarfasls_CheckedChanged);
            this.chbSarfasls.KeyDown += new System.Windows.Forms.KeyEventHandler(this.chbSarfasls_KeyDown);
            // 
            // textDate1
            // 
            this.textDate1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textDate1.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textDate1.FromDate = "1398/07/15";
            this.textDate1.Location = new System.Drawing.Point(503, 24);
            this.textDate1.Name = "textDate1";
            this.textDate1.Size = new System.Drawing.Size(394, 24);
            this.textDate1.TabIndex = 0;
            this.textDate1.ToDate = "1398/07/15";
            this.textDate1.KeyEnterTextBoxToYear += new System.EventHandler(this.textDate1_KeyEnterTextBoxToYear);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(52, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "نمايش زير سرفصل ها:  Enter";
            // 
            // lblSarfasls
            // 
            this.lblSarfasls.AutoSize = true;
            this.lblSarfasls.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblSarfasls.Location = new System.Drawing.Point(36, 14);
            this.lblSarfasls.Name = "lblSarfasls";
            this.lblSarfasls.Size = new System.Drawing.Size(178, 20);
            this.lblSarfasls.TabIndex = 5;
            this.lblSarfasls.Text = "نمايش عملكردهاي سرفصل: Alt+F3";
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.SlateGray;
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnShow.Location = new System.Drawing.Point(6, 57);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(80, 34);
            this.btnShow.TabIndex = 9;
            this.btnShow.Text = "نمایش";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // txtZirSarfasl
            // 
            this.txtZirSarfasl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtZirSarfasl.Location = new System.Drawing.Point(198, 58);
            this.txtZirSarfasl.Name = "txtZirSarfasl";
            this.txtZirSarfasl.ReadOnly = true;
            this.txtZirSarfasl.Size = new System.Drawing.Size(267, 28);
            this.txtZirSarfasl.TabIndex = 8;
            this.txtZirSarfasl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtZirSarfasl.Enter += new System.EventHandler(this.textBox_Enter);
            this.txtZirSarfasl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtZirSarfasl_KeyDown);
            this.txtZirSarfasl.Leave += new System.EventHandler(this.textBox_Leave);
            // 
            // txtSarfasl
            // 
            this.txtSarfasl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSarfasl.Location = new System.Drawing.Point(570, 58);
            this.txtSarfasl.Name = "txtSarfasl";
            this.txtSarfasl.ReadOnly = true;
            this.txtSarfasl.Size = new System.Drawing.Size(240, 28);
            this.txtSarfasl.TabIndex = 6;
            this.txtSarfasl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSarfasl.Enter += new System.EventHandler(this.textBox_Enter);
            this.txtSarfasl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSarfasl_KeyDown);
            this.txtSarfasl.Leave += new System.EventHandler(this.textBox_Leave);
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.dgvSarfasl);
            this.pnlMain.Controls.Add(this.txtFilter);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 94);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(900, 447);
            this.pnlMain.TabIndex = 1;
            // 
            // dgvSarfasl
            // 
            this.dgvSarfasl.AllowUserToAddRows = false;
            this.dgvSarfasl.AllowUserToDeleteRows = false;
            this.dgvSarfasl.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(160)))), ((int)(((byte)(200)))));
            this.dgvSarfasl.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(26)))), ((int)(((byte)(71)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSarfasl.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSarfasl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSarfasl.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSarfasl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSarfasl.EnableHeadersVisualStyles = false;
            this.dgvSarfasl.Location = new System.Drawing.Point(0, 28);
            this.dgvSarfasl.MultiSelect = false;
            this.dgvSarfasl.Name = "dgvSarfasl";
            this.dgvSarfasl.ReadOnly = true;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            this.dgvSarfasl.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSarfasl.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSarfasl.Size = new System.Drawing.Size(900, 419);
            this.dgvSarfasl.TabIndex = 1;
            this.dgvSarfasl.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSarfasl_CellDoubleClick);
            this.dgvSarfasl.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvSarfasl_DataBindingComplete);
            this.dgvSarfasl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvSarfasl_KeyDown);
            // 
            // txtFilter
            // 
            this.txtFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtFilter.Location = new System.Drawing.Point(0, 0);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(900, 28);
            this.txtFilter.TabIndex = 10;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            this.txtFilter.Enter += new System.EventHandler(this.textBox_Enter);
            this.txtFilter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFilter_KeyDown);
            this.txtFilter.Leave += new System.EventHandler(this.textBox_Leave);
            // 
            // pnlFooter
            // 
            this.pnlFooter.Controls.Add(this.lblFooter);
            this.pnlFooter.Controls.Add(this.btnCancel);
            this.pnlFooter.Controls.Add(this.btnPrint);
            this.pnlFooter.Controls.Add(this.lblFooterNumber);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 541);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(900, 59);
            this.pnlFooter.TabIndex = 2;
            // 
            // lblFooter
            // 
            this.lblFooter.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblFooter.Location = new System.Drawing.Point(270, 0);
            this.lblFooter.Name = "lblFooter";
            this.lblFooter.Size = new System.Drawing.Size(525, 59);
            this.lblFooter.TabIndex = 10;
            this.lblFooter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Location = new System.Drawing.Point(22, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 30);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "انصراف";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.Indigo;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(97, 6);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 30);
            this.btnPrint.TabIndex = 12;
            this.btnPrint.Text = "چاپ";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // lblFooterNumber
            // 
            this.lblFooterNumber.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblFooterNumber.Location = new System.Drawing.Point(795, 0);
            this.lblFooterNumber.Name = "lblFooterNumber";
            this.lblFooterNumber.Size = new System.Drawing.Size(105, 59);
            this.lblFooterNumber.TabIndex = 11;
            this.lblFooterNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // reportSarfasl
            // 
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlFooter);
            this.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Name = "reportSarfasl";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(900, 600);
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

        private void textDate1_KeyEnterTextBoxToYear(object sender, EventArgs e)
        {
            chbSarfasls.Focus();
        }

        private void chbSarfasls_CheckedChanged(object sender, EventArgs e)
        {
            if (chbSarfasls.Checked)
            {
                ShowList(true);
                txtSarfasl.Focus();
            }
            else
            {
                txtSarfasl.Text = "";
                _listSar.Clear();
                chbZirSarfasls.Checked = false;
            }

        }
        private void chbSarfasls_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Enter)
            chbSarfasls.Checked = (!chbSarfasls.Checked);
        }
        private void txtSarfasl_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                chbZirSarfasls.Focus();
            }
        }

        private void chbZirSarfasls_CheckedChanged(object sender, EventArgs e)
        {
            if (chbZirSarfasls.Checked)
            {
                ShowList(false);
                txtZirSarfasl.Focus();
            }
            else
            {
                txtZirSarfasl.Text = "";
                _listZirSar.Clear();
            }
        }
        private void chbZirSarfasls_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Enter)
                chbZirSarfasls.Checked = (!chbZirSarfasls.Checked);
        }
        private void txtZirSarfasl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnShow.Focus();
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            //اتصال و اوردن اطلاعات
            dgvSarfasl.DataSource = dt = conection.GetSarfaslseServis(_listSar, _listZirSar, textDate1.FromDate, textDate1.ToDate);

            SetGrid();

            SetTextLabelFooter(dt.Count, dt.Sum(d => d.Man), dt.Sum(d => d.Man + d.Man_Befor));

            txtFilter.Focus();
        }

        private void txtFilter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                txtFilter.Text = "";
            }
            else if (e.KeyCode == Keys.Left && txtFilter.Text.Trim() == "")
            {
                dgvSarfasl.Columns["Name"].Width = dgvSarfasl.Columns["Name"].Width + 1;
            }
            else if (e.KeyCode == Keys.Right && txtFilter.Text.Trim() == "")
            {
                dgvSarfasl.Columns["Name"].Width = dgvSarfasl.Columns["Name"].Width - 1;
            }
            else if (dgvSarfasl.Rows.Count > 0)
            {
                if (e.KeyData == Keys.Enter)
                {
                    ShowReportZirSarfasl();
                }
                else if (e.Alt && e.KeyCode == Keys.F3)
                {
                    ShowReportActZirSarfasl();
                }
                else
                {
                    int countRowGrid = dgvSarfasl.Rows.Count;
                    int rowIndexSelected = dgvSarfasl.SelectedRows[0].Index;
                    if (e.KeyCode == Keys.Up)
                    {
                        if (rowIndexSelected == 0)
                        {
                            //dgvSarfasl.Rows[countRowGrid - 1].Selected = true;
                            dgvSarfasl.Rows[countRowGrid - 1].Cells[0].Selected = true;
                        }
                        else
                        {
                            dgvSarfasl.Rows[rowIndexSelected - 1].Cells[0].Selected = true;
                        }
                    }
                    else if (e.KeyCode == Keys.Down)
                    {
                        dgvSarfasl.Rows[(rowIndexSelected + 1) % countRowGrid].Cells[0].Selected = true;
                    }
                }

            }
        }
        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            search();
        }

        private void textBox_Enter(object sender, EventArgs e)
        {
            (sender as TextBox).BackColor = Color.Bisque;
        }
        private void textBox_Leave(object sender, EventArgs e)
        {
            (sender as TextBox).BackColor = Color.White;
        }

        #region Event Control Data Grid View

        private void dgvSarfasl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                ShowReportZirSarfasl();
            }
            else if (e.Alt && e.KeyCode == Keys.F3)
            {
                ShowReportActZirSarfasl();
            }
        }
        private void dgvSarfasl_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowReportZirSarfasl();
        }
        private void dgvSarfasl_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in dgvSarfasl.Rows)
            {
                row.Cells["Man"].Value = Math.Abs((decimal)row.Cells["Man"].Value).ToString();
                row.Cells["Man_Befor"].Value = Math.Abs((decimal)row.Cells["Man_Befor"].Value).ToString();
            }
        }

        #endregion

        private void btnPrint_Click(object sender, EventArgs e)
        {
            //چاپ
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ((Form)this.TopLevelControl).Close();
            //بستن فرم
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

        public void SetGrid()
        {
            foreach (DataGridViewColumn col in dgvSarfasl.Columns) col.Visible = false;
            //foreach (DataGridViewRow row in dgvSarfasl.Rows) row.Cells["row"].Value = row.Index + 1;

            dgvSarfasl.Columns["row"].Visible = true;
            dgvSarfasl.Columns["row"].HeaderText = "رديف";
            dgvSarfasl.Columns["row"].Width = 40;

            dgvSarfasl.Columns["Name"].Visible = true;
            dgvSarfasl.Columns["Name"].HeaderText = "نام";
            dgvSarfasl.Columns["Name"].Width = 180;
            //dgvSarfasl.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvSarfasl.Columns["bed"].Visible = true;
            dgvSarfasl.Columns["bed"].HeaderText = "بدهكار";
            dgvSarfasl.Columns["bed"].DefaultCellStyle.Format = "#,0";

            dgvSarfasl.Columns["bes"].Visible = true;
            dgvSarfasl.Columns["bes"].HeaderText = "بستانكار";
            dgvSarfasl.Columns["bes"].DefaultCellStyle.Format = "#,0";

            dgvSarfasl.Columns["Man"].Visible = true;
            dgvSarfasl.Columns["Man"].HeaderText = "مانده اين بازه";
            dgvSarfasl.Columns["Man"].DefaultCellStyle.Format = "#,0";
            dgvSarfasl.Columns["Man"].DefaultCellStyle.Font = new Font("IRANSans(FaNum)", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            //dgvSarfasl.Columns["Man"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvSarfasl.Columns["bed_bes"].Visible = true;
            dgvSarfasl.Columns["bed_bes"].HeaderText = "تشخيص";
            dgvSarfasl.Columns["bed_bes"].Width = 53;

            dgvSarfasl.Columns["Man_Befor"].Visible = true;
            dgvSarfasl.Columns["Man_Befor"].HeaderText = "مانده قبلي";
            dgvSarfasl.Columns["Man_Befor"].DefaultCellStyle.Format = "#,0";
            dgvSarfasl.Columns["Man_Befor"].DefaultCellStyle.Font = new Font("IRANSans(FaNum)", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));

            dgvSarfasl.Columns["bed_bes_Befor"].Visible = true;
            dgvSarfasl.Columns["bed_bes_Befor"].HeaderText = "تشخيص";
            dgvSarfasl.Columns["bed_bes_Befor"].Width = 53;

            dgvSarfasl.Columns["who_def"].Visible = true;
            dgvSarfasl.Columns["who_def"].HeaderText = "كاربر";
            dgvSarfasl.Columns["who_def"].Width = 70;

        }

        private void search()
        {
            if (dt != null)
            {
                var filter = txtFilter.Text.Trim();

                var dt1 = dt.Where(c => c.Name.Contains(filter)).ToList();
                dgvSarfasl.DataSource = dt1;

                SetTextLabelFooter(dt1.Count, dt1.Sum(d => d.Man), dt1.Sum(d => d.Man + d.Man_Befor));
            }
        }

        private void ShowList(bool isSarfasl)
        {
            DefultForm listForm = new DefultForm();
            ListSafaslaOrZirSarfasls _list = isSarfasl ?
                new ListSafaslaOrZirSarfasls(true, _listSar, txtSarfasl.Text) :
                new ListSafaslaOrZirSarfasls(false, _listZirSar, txtZirSarfasl.Text, _listSar);
            listForm.ShowDialog(_list, new Size(800, 500));

            if (isSarfasl)
            {
                txtSarfasl.Text = _list.lblTextSelected.Text;
                _listSar = _list.ListSelected;
            }
            else
            {
                txtZirSarfasl.Text = _list.lblTextSelected.Text;
                _listZirSar = _list.ListSelected;
            }
        }

        private void ShowReportZirSarfasl()
        {
            _sarfaslIdSelected = (int)dgvSarfasl.SelectedRows[0].Cells["ID"].Value;
            DefultForm reportZirSarfasl = new DefultForm();
            reportZirSarfasl.ShowDialog(new ReportZirSarfasl(_listZirSar, _sarfaslIdSelected, textDate1.FromDate, textDate1.ToDate), new Size(800, 500));
        }

        private void ShowReportActZirSarfasl()
        {
            _sarfaslIdSelected = (int)dgvSarfasl.SelectedRows[0].Cells["ID"].Value;
            DefultForm reportActZirSarfasl = new DefultForm();
            reportActZirSarfasl.ShowDialog(new ReportActZirSarfasl(textDate1.FromDate, textDate1.ToDate, sarfaslID: _sarfaslIdSelected, listZirsarfasl: _listZirSar), new Size(800, 540));
        }

        private void SetTextLabelFooter(int number, decimal sum, decimal sumAll)
        {
            string status1 = sum > 0 ? "بد" : sum == 0 ? "--" : "بس";
            string status2 = sumAll > 0 ? "بد" : sumAll == 0 ? "--" : "بس";

            lblFooterNumber.Text = $"تعداد: {number}";
            lblFooter.Text = $"   مانده در بازه: {Math.Abs(sum).ToMan()} ({status1})\n   مانده كل : {Math.Abs(sumAll).ToMan()} ({status2})";
        }

        #endregion
    }
}