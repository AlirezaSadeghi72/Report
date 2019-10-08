using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReportSarfasl.dataLayer;
using ReportSarfasl.Forms;
using ReportSarfasl.Services;
using Stimulsoft.Report;

namespace ReportSarfasl
{
    public class ReportZirSarfasl : UserControl
    {

        private List<int> _listZirSar = new List<int>();
        private PersianCalendar pc = new PersianCalendar();
        private int _sarfaslID, _zirSarfaslIdSelected;
        private List<SZAservice> dt;

        private string _nameSarfasl;
        //private bool _isSearch = false;//, _isKeySpase = false;
        private Panel pnlMain;
        private Button btnCancel;
        private Button btnPrint;
        private GroupBox gbHeader;
        private TextBox txtFilter;
        private DataGridView dgvZirSarfal;
        private TextDate textDate1;
        private Label lblFooter;
        private Label lblFooterNumber;
        private Panel pnlFooter;

        public ReportZirSarfasl(List<int> ListZirSar, int sarfaslID, string NameSarfasl, string FromDate, string ToDate)
        {
            InitializeComponent();
            _listZirSar = ListZirSar;
            _sarfaslID = sarfaslID;
            gbHeader.Text += _nameSarfasl = NameSarfasl;
            textDate1.FromDate = FromDate;
            textDate1.ToDate = ToDate;
        }
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.gbHeader = new System.Windows.Forms.GroupBox();
            this.dgvZirSarfal = new System.Windows.Forms.DataGridView();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.textDate1 = new ReportSarfasl.TextDate();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.lblFooter = new System.Windows.Forms.Label();
            this.lblFooterNumber = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.pnlMain.SuspendLayout();
            this.gbHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZirSarfal)).BeginInit();
            this.pnlFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.gbHeader);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(800, 442);
            this.pnlMain.TabIndex = 1;
            // 
            // gbHeader
            // 
            this.gbHeader.Controls.Add(this.dgvZirSarfal);
            this.gbHeader.Controls.Add(this.txtFilter);
            this.gbHeader.Controls.Add(this.textDate1);
            this.gbHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbHeader.Location = new System.Drawing.Point(0, 0);
            this.gbHeader.Name = "gbHeader";
            this.gbHeader.Size = new System.Drawing.Size(800, 442);
            this.gbHeader.TabIndex = 0;
            this.gbHeader.TabStop = false;
            this.gbHeader.Text = "ليست زيرسرفصل هاي      سرفصل :   ";
            // 
            // dgvZirSarfal
            // 
            this.dgvZirSarfal.AllowUserToAddRows = false;
            this.dgvZirSarfal.AllowUserToDeleteRows = false;
            this.dgvZirSarfal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
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
            this.dgvZirSarfal.Location = new System.Drawing.Point(3, 76);
            this.dgvZirSarfal.MultiSelect = false;
            this.dgvZirSarfal.Name = "dgvZirSarfal";
            this.dgvZirSarfal.ReadOnly = true;
            this.dgvZirSarfal.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            this.dgvZirSarfal.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvZirSarfal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvZirSarfal.Size = new System.Drawing.Size(794, 363);
            this.dgvZirSarfal.TabIndex = 2;
            this.dgvZirSarfal.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvZirSarfal_CellDoubleClick);
            this.dgvZirSarfal.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvZirSarfal_DataBindingComplete);
            this.dgvZirSarfal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvZirSarfal_KeyDown);
            // 
            // txtFilter
            // 
            this.txtFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtFilter.Location = new System.Drawing.Point(3, 48);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(794, 28);
            this.txtFilter.TabIndex = 2;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            this.txtFilter.Enter += new System.EventHandler(this.txtFilter_Enter);
            this.txtFilter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFilter_KeyDown);
            this.txtFilter.Leave += new System.EventHandler(this.txtFilter_Leave);
            // 
            // textDate1
            // 
            this.textDate1.Dock = System.Windows.Forms.DockStyle.Top;
            this.textDate1.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textDate1.FromDate = "1398/07/16";
            this.textDate1.Location = new System.Drawing.Point(3, 24);
            this.textDate1.Name = "textDate1";
            this.textDate1.Size = new System.Drawing.Size(794, 24);
            this.textDate1.TabIndex = 0;
            this.textDate1.ToDate = "1398/07/16";
            this.textDate1.KeyEnterTextBoxToYear += new System.EventHandler(this.textDate1_KeyEnterTextBoxToYear);
            // 
            // pnlFooter
            // 
            this.pnlFooter.Controls.Add(this.lblFooter);
            this.pnlFooter.Controls.Add(this.lblFooterNumber);
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
            this.lblFooter.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblFooter.Location = new System.Drawing.Point(180, 0);
            this.lblFooter.Name = "lblFooter";
            this.lblFooter.Size = new System.Drawing.Size(515, 58);
            this.lblFooter.TabIndex = 12;
            this.lblFooter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFooterNumber
            // 
            this.lblFooterNumber.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblFooterNumber.Location = new System.Drawing.Point(695, 0);
            this.lblFooterNumber.Name = "lblFooterNumber";
            this.lblFooterNumber.Size = new System.Drawing.Size(105, 58);
            this.lblFooterNumber.TabIndex = 13;
            this.lblFooterNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Location = new System.Drawing.Point(24, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 30);
            this.btnCancel.TabIndex = 11;
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
            this.btnPrint.TabIndex = 10;
            this.btnPrint.Text = "چاپ";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // ReportZirSarfasl
            // 
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlFooter);
            this.Font = new System.Drawing.Font("IRANSans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Name = "ReportZirSarfasl";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(800, 500);
            this.Load += new System.EventHandler(this.ReportZirSarfasl_Load);
            this.pnlMain.ResumeLayout(false);
            this.gbHeader.ResumeLayout(false);
            this.gbHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZirSarfal)).EndInit();
            this.pnlFooter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void ReportZirSarfasl_Load(object sender, EventArgs e)
        {
            dgvZirSarfal.DataSource = dt = conection.GetZirSarfaslServices(textDate1.FromDate, textDate1.ToDate, _listZirSar, _sarfaslID);

            SetTextLabelFooter(dt.Count, dt.Sum(d => d.ZMan), dt.Sum(d => d.ZMan + d.ZMan_Befor));

            SetGrid();
        }

        #region Event Controls

        private void textDate1_KeyEnterTextBoxToYear(object sender, EventArgs e)
        {
            dgvZirSarfal.DataSource = dt = conection.GetZirSarfaslServices( textDate1.FromDate, textDate1.ToDate, _listZirSar, _sarfaslID);

            SetTextLabelFooter(dt.Count, dt.Sum(d => d.ZMan), dt.Sum(d => d.ZMan + d.ZMan_Befor));

            txtFilter.Focus();
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            search();
        }
        private void txtFilter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                //_isSearch = false;
                txtFilter.Text = "";
            }
            //else if (e.KeyCode == Keys.Left && txtFilter.Text.Trim() == "")
            //{
            //    if (dgvZirSarfal.DataSource != null)
            //    dgvZirSarfal.Columns["Name"].Width = dgvZirSarfal.Columns["Name"].Width + 1;
            //}
            //else if (e.KeyCode == Keys.Right && txtFilter.Text.Trim() == "")
            //{
            //    if (dgvZirSarfal.DataSource != null)
            //    dgvZirSarfal.Columns["Name"].Width = dgvZirSarfal.Columns["Name"].Width - 1;
            //}
            else if (dgvZirSarfal.Rows.Count > 0)
            {

                int countRowGrid = dgvZirSarfal.Rows.Count;
                int rowIndexSelected = dgvZirSarfal.SelectedRows[0].Index;
                if (e.KeyCode == Keys.Enter)
                {
                    OpenActZirSarfasl(dgvZirSarfal.SelectedRows[0].Cells["ZName"].Value.ToString());
                }
                else if (e.KeyCode == Keys.Up)
                {
                    if (rowIndexSelected == 0)
                    {
                        dgvZirSarfal.Rows[countRowGrid - 1].Cells["Zrow"].Selected = true;
                    }
                    else
                    {
                        dgvZirSarfal.Rows[rowIndexSelected - 1].Cells["Zrow"].Selected = true;
                    }
                }
                else if (e.KeyCode == Keys.Down)
                {
                    //var ali = (rowIndexSelected + 1) % countRowGrid;
                    // dgvZirSarfal.Rows[(rowIndexSelected + 1) % countRowGrid].Cells["Zrow"].Selected = true;
                    if (rowIndexSelected+1 == countRowGrid)
                    {
                        dgvZirSarfal.Rows[0].Cells["Zrow"].Selected = true;
                    }
                    else
                    {
                        dgvZirSarfal.Rows[rowIndexSelected + 1].Cells["Zrow"].Selected = true;
                    }
                }
            }
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

        private void dgvZirSarfal_KeyDown(object sender, KeyEventArgs e)
        {
            if (dgvZirSarfal.SelectedRows.Count > 0)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    OpenActZirSarfasl(dgvZirSarfal.SelectedRows[0].Cells["ZName"].Value.ToString());
                }
            }
        }
        private void dgvZirSarfal_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvZirSarfal.SelectedRows.Count > 0)
            {
                OpenActZirSarfasl(dgvZirSarfal.SelectedRows[0].Cells["ZName"].Value.ToString());
            }
        }
        private void dgvZirSarfal_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in dgvZirSarfal.Rows)
            {
                row.Cells["ZMan"].Value = Math.Abs((decimal)row.Cells["ZMan"].Value).ToString();
                row.Cells["ZMan_Befor"].Value = Math.Abs((decimal)row.Cells["ZMan_Befor"].Value).ToString();
            }
        }

        #endregion

        private void btnPrint_Click(object sender, EventArgs e)
        {
            var DateNow = DateTime.Now;
            string today = pc.GetYear(DateNow).ToString("0000") + "/" + pc.GetMonth(DateNow).ToString("00") + "/" + pc.GetDayOfMonth(DateNow).ToString("00");
            StiReport report = new StiReport();
            report.Load(@"C:\Users\North-PC\Desktop\Report Sarfasl (Stimulsoft)\ReportZirSarfasl1.mrt");
            report.Compile();
            report["User"] = "alirezasadegghi";
            report["today"] = today;
            report["NameSarfasl"] = _nameSarfasl;
            report["FromDate"] = textDate1.FromDate;
            report["ToDate"] = textDate1.ToDate;
            report.RegBusinessObject("SZA", dgvZirSarfal.DataSource);

            report.Show();
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

        private void SetGrid()
        {
            foreach (DataGridViewColumn col in dgvZirSarfal.Columns) col.Visible = false;
            //foreach (DataGridViewRow row in dgvSarfasl.Rows) row.Cells["row"].Value = row.Index + 1;

            dgvZirSarfal.Columns["Zrow"].Visible = true;
            dgvZirSarfal.Columns["Zrow"].HeaderText = "رديف";
            dgvZirSarfal.Columns["Zrow"].Width = 40;

            dgvZirSarfal.Columns["ZName"].Visible = true;
            dgvZirSarfal.Columns["ZName"].HeaderText = "نام";
            dgvZirSarfal.Columns["ZName"].Width = 180;
            // dgvZirSarfal.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvZirSarfal.Columns["Zhas_dar"].Visible = true;
            dgvZirSarfal.Columns["Zhas_dar"].HeaderText = "ماهيت";
            dgvZirSarfal.Columns["Zhas_dar"].Width = 70;

            dgvZirSarfal.Columns["Zbed"].Visible = true;
            dgvZirSarfal.Columns["Zbed"].HeaderText = "بدهكار";
            dgvZirSarfal.Columns["Zbed"].DefaultCellStyle.Format = "#,0";

            dgvZirSarfal.Columns["Zbes"].Visible = true;
            dgvZirSarfal.Columns["Zbes"].HeaderText = "بستانكار";
            dgvZirSarfal.Columns["Zbes"].DefaultCellStyle.Format = "#,0";

            dgvZirSarfal.Columns["ZMan"].Visible = true;
            dgvZirSarfal.Columns["ZMan"].HeaderText = "مانده اين بازه";
            dgvZirSarfal.Columns["ZMan"].DefaultCellStyle.Format = "#,0";
            dgvZirSarfal.Columns["ZMan"].DefaultCellStyle.Font = new Font("IRANSans(FaNum)", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            //dgvZirSarfal.Columns["Man"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvZirSarfal.Columns["Zbed_bes"].Visible = true;
            dgvZirSarfal.Columns["Zbed_bes"].HeaderText = "تشخيص";
            dgvZirSarfal.Columns["Zbed_bes"].Width = 53;

            dgvZirSarfal.Columns["ZMan_Befor"].Visible = true;
            dgvZirSarfal.Columns["ZMan_Befor"].HeaderText = "مانده قبلي";
            dgvZirSarfal.Columns["ZMan_Befor"].DefaultCellStyle.Format = "#,0";
            dgvZirSarfal.Columns["ZMan_Befor"].DefaultCellStyle.Font = new Font("IRANSans(FaNum)", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));

            dgvZirSarfal.Columns["Zbed_bes_Befor"].Visible = true;
            dgvZirSarfal.Columns["Zbed_bes_Befor"].HeaderText = "تشخيص";
            dgvZirSarfal.Columns["Zbed_bes_Befor"].Width = 53;

        }

        private void search()
        {
            if (dt != null)
            {
                var filter = txtFilter.Text.Trim();

                var dt1 = dt.Where(c => c.ZName.Contains(filter)).ToList();
                dgvZirSarfal.DataSource = dt1;

                SetTextLabelFooter(dt1.Count, dt1.Sum(d => d.ZMan), dt1.Sum(d => d.ZMan + d.ZMan_Befor));
            }
        }

        private void OpenActZirSarfasl(string NameZirSarfasl)
        {
            if (dgvZirSarfal.SelectedRows.Count > 0)
            {
                _zirSarfaslIdSelected = (int)dgvZirSarfal.SelectedRows[0].Cells["ZID"].Value;
                DefultForm reportZirSarfasl = new DefultForm();
                reportZirSarfasl.ShowDialog(new ReportActZirSarfasl(textDate1.FromDate, textDate1.ToDate, NameZirSarfasl, zirSarfaslID: _zirSarfaslIdSelected), new Size(1332, 694));
                //باز کردن زیر سرفصل های سرفصل انتخابی داخل گرید
            }
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
