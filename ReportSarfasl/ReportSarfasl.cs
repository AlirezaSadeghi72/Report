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
        //DateTime ali = DateTime.ParseExact("2011/11/12","yyyy/mm/dd",null);
        private Label lblZirSarfasl;
        private TextBox txtSarfasl;
        private Label lblSarfasls;
        private Button btnCancel;
        private Label lblFooter;
        private TextDate textDate1;
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
            this.lblZirSarfasl = new System.Windows.Forms.Label();
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
            this.textDate1 = new ReportSarfasl.TextDate();
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
            this.pnlHeader.Size = new System.Drawing.Size(900, 109);
            this.pnlHeader.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textDate1);
            this.groupBox1.Controls.Add(this.lblZirSarfasl);
            this.groupBox1.Controls.Add(this.lblSarfasls);
            this.groupBox1.Controls.Add(this.btnShow);
            this.groupBox1.Controls.Add(this.txtZirSarfasl);
            this.groupBox1.Controls.Add(this.txtSarfasl);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(900, 109);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // lblZirSarfasl
            // 
            this.lblZirSarfasl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblZirSarfasl.AutoSize = true;
            this.lblZirSarfasl.Location = new System.Drawing.Point(474, 57);
            this.lblZirSarfasl.Name = "lblZirSarfasl";
            this.lblZirSarfasl.Size = new System.Drawing.Size(81, 20);
            this.lblZirSarfasl.TabIndex = 7;
            this.lblZirSarfasl.Text = "زیر سرفصل ها :";
            // 
            // lblSarfasls
            // 
            this.lblSarfasls.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSarfasls.AutoSize = true;
            this.lblSarfasls.Location = new System.Drawing.Point(822, 57);
            this.lblSarfasls.Name = "lblSarfasls";
            this.lblSarfasls.Size = new System.Drawing.Size(65, 20);
            this.lblSarfasls.TabIndex = 5;
            this.lblSarfasls.Text = "سرفصل ها :";
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.SlateGray;
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnShow.Location = new System.Drawing.Point(6, 54);
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
            this.txtZirSarfasl.Location = new System.Drawing.Point(228, 54);
            this.txtZirSarfasl.Name = "txtZirSarfasl";
            this.txtZirSarfasl.ReadOnly = true;
            this.txtZirSarfasl.Size = new System.Drawing.Size(240, 28);
            this.txtZirSarfasl.TabIndex = 8;
            this.txtZirSarfasl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtZirSarfasl.Click += new System.EventHandler(this.txtZirSarfasl_Click);
            this.txtZirSarfasl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtZirSarfasl_KeyDown);
            // 
            // txtSarfasl
            // 
            this.txtSarfasl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSarfasl.Location = new System.Drawing.Point(576, 54);
            this.txtSarfasl.Name = "txtSarfasl";
            this.txtSarfasl.ReadOnly = true;
            this.txtSarfasl.Size = new System.Drawing.Size(240, 28);
            this.txtSarfasl.TabIndex = 6;
            this.txtSarfasl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSarfasl.Click += new System.EventHandler(this.txtSarfasl_Click);
            this.txtSarfasl.TextChanged += new System.EventHandler(this.txtSarfasl_TextChanged);
            this.txtSarfasl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSarfasl_KeyDown);
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.dgvSarfasl);
            this.pnlMain.Controls.Add(this.txtFilter);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 109);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(900, 432);
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
            this.dgvSarfasl.Size = new System.Drawing.Size(900, 404);
            this.dgvSarfasl.TabIndex = 1;
            this.dgvSarfasl.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSarfasl_CellDoubleClick);
            this.dgvSarfasl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvSarfasl_KeyDown);
            // 
            // txtFilter
            // 
            this.txtFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtFilter.Location = new System.Drawing.Point(0, 0);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(900, 28);
            this.txtFilter.TabIndex = 0;
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
            this.pnlFooter.Location = new System.Drawing.Point(0, 541);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(900, 59);
            this.pnlFooter.TabIndex = 2;
            // 
            // lblFooter
            // 
            this.lblFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblFooter.Location = new System.Drawing.Point(0, 39);
            this.lblFooter.Name = "lblFooter";
            this.lblFooter.Size = new System.Drawing.Size(900, 20);
            this.lblFooter.TabIndex = 10;
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Location = new System.Drawing.Point(22, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 30);
            this.btnCancel.TabIndex = 1;
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
            this.btnPrint.TabIndex = 0;
            this.btnPrint.Text = "چاپ";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // textDate1
            // 
            this.textDate1.Dock = System.Windows.Forms.DockStyle.Top;
            this.textDate1.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textDate1.Location = new System.Drawing.Point(3, 24);
            this.textDate1.Name = "textDate1";
            this.textDate1.Size = new System.Drawing.Size(894, 24);
            this.textDate1.TabIndex = 10;
            this.textDate1.KeyEnterTextBoxToYear += new System.EventHandler(this.textDate1_KeyEnterTextBoxToYear_1);
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

        private void txtSarfasl_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                txtZirSarfasl.Focus();
            }
            if (e.KeyCode == Keys.Enter)
            {
                //txtSarfasl_KeyDownEnter(this, e);
                ShowList(true);

                //var sarfasl = new ListSafaslaOrZirSarfasls(1, _listSar);
                //sarfasl.Show();
                //_listSar = sarfasl.listSelectes;

            }
        }
        private void txtSarfasl_Click(object sender, EventArgs e)
        {
            ShowList(true);
        }
        private void txtSarfasl_TextChanged(object sender, EventArgs e)
        {
            txtZirSarfasl.Text = "";
            _listZirSar.Clear();
        }

        private void txtZirSarfasl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                btnShow.Focus();
            }
            else if (e.KeyCode == Keys.Right)
            {
                txtSarfasl.Focus();
            }

            if (e.KeyCode == Keys.Enter)
            {
                //this.txtZirSarfasl_KeyDownEnter(this, e);
                ShowList(false);
                //var zirsarfasl = new ListSafaslaOrZirSarfasls(2, _listZirSar);
                //zirsarfasl.Show();
                //_listZirSar = zirsarfasl.listSelectes;
            }
        }
        private void txtZirSarfasl_Click(object sender, EventArgs e)
        {
            ShowList(false);
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            //اتصال و اوردن اطلاعات
            dgvSarfasl.DataSource = dt = conection.GetSarfaslseServis(_listSar, _listZirSar,textDate1.FromDate,textDate1.ToDate);

            SetGrid();

            SetTextLabelFooter(dt.Count, dt.Sum(d => d.Man));

            txtFilter.Focus();
        }

        private void txtFilter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                txtFilter.Text = "";
            }
            else if (dgvSarfasl.Rows.Count > 0)
            {
                if (e.KeyData == Keys.Enter)
                {
                    ShowReportZirSarfasl();
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
        private void txtFilter_Enter(object sender, EventArgs e)
        {
            txtFilter.BackColor = Color.Bisque;
        }
        private void txtFilter_Leave(object sender, EventArgs e)
        {
            txtFilter.BackColor = Color.White;
        }
        #region Event Control Data Grid View

        private void dgvSarfasl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                ShowReportZirSarfasl();
            }
        }
        private void dgvSarfasl_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowReportActZirSarfasl();

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

            dgvSarfasl.Columns["Name"].Visible = true;
            dgvSarfasl.Columns["Name"].HeaderText = "نام";
            dgvSarfasl.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvSarfasl.Columns["Man"].Visible = true;
            dgvSarfasl.Columns["Man"].HeaderText = "مانده";
            dgvSarfasl.Columns["Man"].DefaultCellStyle.Format = "#,0";
            dgvSarfasl.Columns["Man"].DefaultCellStyle.Font = new Font("IRANSans(FaNum)", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dgvSarfasl.Columns["Man"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


        }

        private void search()
        {
            if (dt != null)
            {
                var filter = txtFilter.Text.Trim();

                var dt1 = dt.Where(c => c.Name.Contains(filter)).ToList();
                dgvSarfasl.DataSource = dt1;

                SetTextLabelFooter(dt1.Count, dt1.Sum(d => d.Man));
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
            reportActZirSarfasl.ShowDialog(new ReportActZirSarfasl(textDate1.FromDate,textDate1.ToDate,sarfaslID: _sarfaslIdSelected, listZirsarfasl: _listZirSar), new Size(800, 500));
        }

        private void textDate1_KeyEnterTextBoxToYear_1(object sender, EventArgs e)
        {
            txtSarfasl.Focus();
        }

        private void SetTextLabelFooter(int number, decimal sum)
        {
            string status = (sum > 0) ? "بدهكار" : (sum == 0) ? "--" : "بستانكار";
            lblFooter.Text =
                $"تعداد: {number}     اختلاف: {Math.Abs(sum).ToMan()} ({status})";
        }

        #endregion
    }
}