using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
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

        private List<int> _listZirSar = new List<int>(), ListSelected = new List<int>();
        private bool _isSearch, _isKeySpase;
        private PersianCalendar pc = new PersianCalendar();
        private int _sarfaslID, _zirSarfaslIdSelected;
        private List<SZAservice> dt;
        private string _nameSarfasl;
        private Panel pnlMain;
        private Button btnCancel;
        private Button btnPrint;
        private GroupBox gbHeader;
        private TextBox txtFilter;
        private DataGridView dgvZirSarfal;
        private TextDate textDate1;
        private Label lblFooter;
        private Label lblFooterNumber;
        private Label lblLoding;
        private CheckBox chbAll;
        private DataGridViewCheckBoxColumn select;
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
            this.select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.chbAll = new System.Windows.Forms.CheckBox();
            this.lblLoding = new System.Windows.Forms.Label();
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
            this.gbHeader.Controls.Add(this.chbAll);
            this.gbHeader.Controls.Add(this.lblLoding);
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
            this.dgvZirSarfal.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvZirSarfal.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("IRANSans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvZirSarfal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvZirSarfal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZirSarfal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.select});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("IRANSans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvZirSarfal.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvZirSarfal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvZirSarfal.EnableHeadersVisualStyles = false;
            this.dgvZirSarfal.Location = new System.Drawing.Point(3, 100);
            this.dgvZirSarfal.MultiSelect = false;
            this.dgvZirSarfal.Name = "dgvZirSarfal";
            this.dgvZirSarfal.ReadOnly = true;
            this.dgvZirSarfal.RowHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.dgvZirSarfal.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvZirSarfal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvZirSarfal.Size = new System.Drawing.Size(794, 339);
            this.dgvZirSarfal.TabIndex = 2;
            this.dgvZirSarfal.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvZirSarfal_CellClick);
            this.dgvZirSarfal.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvZirSarfal_CellDoubleClick);
            this.dgvZirSarfal.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvZirSarfal_DataBindingComplete);
            this.dgvZirSarfal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvZirSarfal_KeyDown);
            // 
            // select
            // 
            this.select.FillWeight = 40F;
            this.select.HeaderText = "";
            this.select.Name = "select";
            this.select.ReadOnly = true;
            this.select.Visible = false;
            this.select.Width = 49;
            // 
            // txtFilter
            // 
            this.txtFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtFilter.Location = new System.Drawing.Point(3, 72);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(794, 28);
            this.txtFilter.TabIndex = 0;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            this.txtFilter.Enter += new System.EventHandler(this.txtFilter_Enter);
            this.txtFilter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFilter_KeyDown);
            this.txtFilter.Leave += new System.EventHandler(this.txtFilter_Leave);
            // 
            // chbAll
            // 
            this.chbAll.AutoSize = true;
            this.chbAll.Dock = System.Windows.Forms.DockStyle.Top;
            this.chbAll.Location = new System.Drawing.Point(3, 48);
            this.chbAll.Name = "chbAll";
            this.chbAll.Size = new System.Drawing.Size(794, 24);
            this.chbAll.TabIndex = 15;
            this.chbAll.Text = "انتخاب همه";
            this.chbAll.UseVisualStyleBackColor = true;
            this.chbAll.CheckedChanged += new System.EventHandler(this.chbAll_CheckedChanged);
            // 
            // lblLoding
            // 
            this.lblLoding.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLoding.AutoSize = true;
            this.lblLoding.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblLoding.Location = new System.Drawing.Point(297, 24);
            this.lblLoding.Name = "lblLoding";
            this.lblLoding.Size = new System.Drawing.Size(89, 20);
            this.lblLoding.TabIndex = 3;
            this.lblLoding.Text = "درحال پردازش ...";
            this.lblLoding.Visible = false;
            // 
            // textDate1
            // 
            this.textDate1.Dock = System.Windows.Forms.DockStyle.Top;
            this.textDate1.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textDate1.FromDate = "1398/07/21";
            this.textDate1.Location = new System.Drawing.Point(3, 24);
            this.textDate1.Name = "textDate1";
            this.textDate1.Size = new System.Drawing.Size(794, 24);
            this.textDate1.TabIndex = 2;
            this.textDate1.ToDate = "1398/07/21";
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
            GetData();
            //var listsarfasl = new List<int>();
            //listsarfasl.Add(_sarfaslID);
            //dt = conection.GetZirSarfaslServices1(listsarfasl, _listZirSar, textDate1.FromDate, textDate1.ToDate);
            //int row = 1;
            //dgvZirSarfal.DataSource = dt.GroupBy(g => new
            //{
            //    g.ZID,
            //    g.ZSarfaslID,
            //    g.ZName,
            //    g.Zbed,
            //    g.Zbes,
            //    g.ZMan,
            //    g.Zbed_bes,
            //    g.ZMan_Befor,
            //    g.Zbed_bes_Befor,
            //    g.ZMan_All,
            //    g.Zbed_bes_All,
            //    g.Zhas_dar,
            //    g.ZActive
            //}).Select(g => new SZAservice()
            //{
            //    Zrow = row++,
            //    ZID = g.Key.ZID,
            //    ZSarfaslID = g.Key.ZSarfaslID,
            //    ZName = g.Key.ZName,
            //    Zbed = g.Key.Zbed,
            //    Zbes = g.Key.Zbes,
            //    ZMan = g.Key.ZMan,
            //    Zbed_bes = g.Key.Zbed_bes,
            //    ZMan_Befor = g.Key.ZMan_Befor,
            //    Zbed_bes_Befor = g.Key.Zbed_bes_Befor,
            //    ZMan_All = g.Key.ZMan_All,
            //    Zbed_bes_All = g.Key.Zbed_bes_All,
            //    Zhas_dar = g.Key.Zhas_dar,
            //    ZActive = g.Key.ZActive
            //}).ToList();
            //SetTextLabelFooter(dt.Count, dt.Sum(d => d.ZMan), dt.Sum(d => d.ZMan_All));

            //SetGrid();
        }

        #region Event Controls

        private void textDate1_KeyEnterTextBoxToYear(object sender, EventArgs e)
        {
            GetData();
            //lblLoding.Visible = true;
            //var listsarfasl = new List<int>();
            //listsarfasl.Add(_sarfaslID);
            //Thread tGetdata = new Thread(() =>
            //{
            //    dt = conection.GetZirSarfaslServices1(listsarfasl, _listZirSar, textDate1.FromDate, textDate1.ToDate);
            //});
            //tGetdata.Start();
            //tGetdata.Join();
            ////dt = conection.GetZirSarfaslServices1(listsarfasl, _listZirSar, textDate1.FromDate, textDate1.ToDate);
            //int row = 1;
            //dgvZirSarfal.DataSource = dt.GroupBy(g => new
            //{
            //    g.ZID,
            //    g.ZSarfaslID,
            //    g.ZName,
            //    g.Zbed,
            //    g.Zbes,
            //    g.ZMan,
            //    g.Zbed_bes,
            //    g.ZMan_Befor,
            //    g.Zbed_bes_Befor,
            //    g.ZMan_All,
            //    g.Zbed_bes_All,
            //    g.Zhas_dar,
            //    g.ZActive
            //}).Select(g => new SZAservice()
            //{
            //    Zrow = row++,
            //    ZID = g.Key.ZID,
            //    ZSarfaslID = g.Key.ZSarfaslID,
            //    ZName = g.Key.ZName,
            //    Zbed = g.Key.Zbed,
            //    Zbes = g.Key.Zbes,
            //    ZMan = g.Key.ZMan,
            //    Zbed_bes = g.Key.Zbed_bes,
            //    ZMan_Befor = g.Key.ZMan_Befor,
            //    Zbed_bes_Befor = g.Key.Zbed_bes_Befor,
            //    ZMan_All = g.Key.ZMan_All,
            //    Zbed_bes_All = g.Key.Zbed_bes_All,
            //    Zhas_dar = g.Key.Zhas_dar,
            //    ZActive = g.Key.ZActive
            //}).ToList();

            //SetTextLabelFooter(dt.Count, dt.Sum(d => d.ZMan), dt.Sum(d => d.ZMan_All));

            //txtFilter.Focus();
            //lblLoding.Visible = false;
        }

        private void chbAll_CheckedChanged(object sender, EventArgs e)
        {
            List<int> list1 = ((List<SZAservice>)dgvZirSarfal.DataSource).Select(a => a.ZID).ToList();
            ListSelected.RemoveAll(x => list1.Contains(x));
            if (chbAll.Checked)
            {
                ListSelected.AddRange(list1);
                foreach (DataGridViewRow row in dgvZirSarfal.Rows)
                {
                    row.Cells["select"].Value = true;
                    row.DefaultCellStyle.BackColor = Color.PaleTurquoise;
                }
            }
            else
            {
                foreach (DataGridViewRow row in dgvZirSarfal.Rows)
                {
                    row.Cells["select"].Value = false;
                    row.DefaultCellStyle.BackColor = Color.White;
                }
            }

            lblFooterNumber.Text = $"تعداد: {dgvZirSarfal.RowCount}\nتعداد انتخابي: {ListSelected.Count}";

        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            search();
        }
        private void txtFilter_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Escape)
            //{
            //    _isSearch = false;
            //    txtFilter.Text = " ";
            //}
            //else
            if (e.KeyCode == Keys.Space)
            {
                if ((txtFilter.Text.Trim() == "") || (dgvZirSarfal.Rows.Count == 1))
                {
                    _isKeySpase = true;
                    SetCheckBoxColumn();
                    txtFilter.Text = "";
                }
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
                    _isSearch = true;
                    txtFilter.Text = "";
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
                    _isSearch = true;
                    txtFilter.Text = "";
                    if (rowIndexSelected + 1 == countRowGrid)
                    {
                        dgvZirSarfal.Rows[0].Cells["Zrow"].Selected = true;
                    }
                    else
                    {
                        dgvZirSarfal.Rows[rowIndexSelected + 1].Cells["Zrow"].Selected = true;
                    }
                }
                else
                {
                    _isSearch = false;
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
            if (e.KeyCode == Keys.Space)
            {
                _isKeySpase = true;
                SetCheckBoxColumn();
            }
            else if (dgvZirSarfal.SelectedRows.Count > 0)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    OpenActZirSarfasl(dgvZirSarfal.SelectedRows[0].Cells["ZName"].Value.ToString());
                }
            }
        }
        private void dgvZirSarfal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!_isKeySpase && e.RowIndex >= 0 && e.ColumnIndex == 0)
                SetCheckBoxColumn();

            _isKeySpase = false;
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
                row.Cells["ZMan_All"].Value = Math.Abs((decimal)row.Cells["ZMan_All"].Value).ToString();
                if (ListSelected.Any(i => i == (int)row.Cells["ZID"].Value))
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

        private void btnPrint_Click(object sender, EventArgs e)
        {
            List<SZAservice> dt1 = dt;

            if (ListSelected.Count > 0)
            {
                dt1 = dt1.Where(d => ListSelected.Contains(d.ZID)).ToList();
            }
            //else
            //{
            //    if (MessageBox.Show("در صورت انتخاب نكردن موردي همه موارد در گزارش ذكر ميشود.\nآيا مايل به ادامه هستيد؟",
            //            "سوال", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            //    {
            //        goto END1;
            //    }
            //}

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
            report.RegBusinessObject("SZA", dt1);

            report.Show();
            //END1:;
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
            if (keyData == Keys.Escape )
            {
                ((Form)this.TopLevelControl).Close();
                return true;
            }
            else if (keyData == Keys.Enter && dgvZirSarfal.SelectedRows.Count > 0 && !textDate1.focuseDate)
            {
                OpenActZirSarfasl(dgvZirSarfal.SelectedRows[0].Cells["ZName"].Value.ToString());
                return true;
            }


            return base.ProcessCmdKey(ref msg, keyData);
        }

        #endregion
        #region Method

        private void GetData()
        {
            lblLoding.Visible = true;

            var listsarfasl = new List<int>();
            listsarfasl.Add(_sarfaslID);
            Thread tGetdata = new Thread(() =>
            {
                dt = conection.GetSZAServices(textDate1.FromDate, textDate1.ToDate, _listZirSar,listsarfasl,new List<int>());
            });
            tGetdata.Start();
            tGetdata.Join();
            //dt = conection.GetZirSarfaslServices1(listsarfasl, _listZirSar, textDate1.FromDate, textDate1.ToDate);
            int row = 1;
            dgvZirSarfal.DataSource = dt.GroupBy(g => new
            {
                g.ZID,
                g.ZSarfaslID,
                g.ZName,
                g.Zbed,
                g.Zbes,
                g.ZMan,
                g.Zbed_bes,
                g.ZMan_Befor,
                g.Zbed_bes_Befor,
                g.ZMan_All,
                g.Zbed_bes_All,
                g.Zhas_dar,
                g.ZActive
            }).Select(g => new SZAservice()
            {
                Zrow = row++,
                ZID = g.Key.ZID,
                ZSarfaslID = g.Key.ZSarfaslID,
                ZName = g.Key.ZName,
                Zbed = g.Key.Zbed,
                Zbes = g.Key.Zbes,
                ZMan = g.Key.ZMan,
                Zbed_bes = g.Key.Zbed_bes,
                ZMan_Befor = g.Key.ZMan_Befor,
                Zbed_bes_Befor = g.Key.Zbed_bes_Befor,
                ZMan_All = g.Key.ZMan_All,
                Zbed_bes_All = g.Key.Zbed_bes_All,
                Zhas_dar = g.Key.Zhas_dar,
                ZActive = g.Key.ZActive
            }).ToList();

            SetTextLabelFooter(dt.Count, dt.Sum(d => d.ZMan), dt.Sum(d => d.ZMan_All));

            SetGrid();

            txtFilter.Focus();

            lblLoding.Visible = false;

        }
        private void SetGrid()
        {
            foreach (DataGridViewColumn col in dgvZirSarfal.Columns) col.Visible = false;
            //foreach (DataGridViewRow row in dgvSarfasl.Rows) row.Cells["row"].Value = row.Index + 1;

            dgvZirSarfal.Columns["select"].Visible = true;
            dgvZirSarfal.Columns["select"].Width = 25;

            dgvZirSarfal.Columns["Zrow"].Visible = true;
            dgvZirSarfal.Columns["Zrow"].HeaderText = "رديف";
            dgvZirSarfal.Columns["Zrow"].Width = 40;

            dgvZirSarfal.Columns["ZName"].Visible = true;
            dgvZirSarfal.Columns["ZName"].HeaderText = "نام";
            dgvZirSarfal.Columns["ZName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvZirSarfal.Columns["Zhas_dar"].Visible = true;
            dgvZirSarfal.Columns["Zhas_dar"].HeaderText = "ماهيت";
            dgvZirSarfal.Columns["Zhas_dar"].Width = 60;

            dgvZirSarfal.Columns["Zbed"].Visible = true;
            dgvZirSarfal.Columns["Zbed"].HeaderText = "بدهكار";
            dgvZirSarfal.Columns["Zbed"].DefaultCellStyle.Format = "#,0";
            dgvZirSarfal.Columns["Zbed"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvZirSarfal.Columns["Zbes"].Visible = true;
            dgvZirSarfal.Columns["Zbes"].HeaderText = "بستانكار";
            dgvZirSarfal.Columns["Zbes"].DefaultCellStyle.Format = "#,0";
            dgvZirSarfal.Columns["Zbes"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvZirSarfal.Columns["ZMan"].Visible = true;
            dgvZirSarfal.Columns["ZMan"].HeaderText = "مانده اين بازه";
            dgvZirSarfal.Columns["ZMan"].DefaultCellStyle.Format = "#,0";
            dgvZirSarfal.Columns["ZMan"].DefaultCellStyle.Font = new Font("IRANSans(FaNum)", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dgvZirSarfal.Columns["Zbes"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


            dgvZirSarfal.Columns["Zbed_bes"].Visible = true;
            dgvZirSarfal.Columns["Zbed_bes"].HeaderText = "تش";
            dgvZirSarfal.Columns["Zbed_bes"].Width = 30;

            dgvZirSarfal.Columns["ZMan_Befor"].Visible = true;
            dgvZirSarfal.Columns["ZMan_Befor"].HeaderText = "مانده قبلي";
            dgvZirSarfal.Columns["ZMan_Befor"].DefaultCellStyle.Format = "#,0";
            dgvZirSarfal.Columns["ZMan_Befor"].DefaultCellStyle.Font = new Font("IRANSans(FaNum)", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dgvZirSarfal.Columns["ZMan_Befor"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvZirSarfal.Columns["Zbed_bes_Befor"].Visible = true;
            dgvZirSarfal.Columns["Zbed_bes_Befor"].HeaderText = "تش";
            dgvZirSarfal.Columns["Zbed_bes_Befor"].Width = 30;

            dgvZirSarfal.Columns["ZMan_All"].Visible = true;
            dgvZirSarfal.Columns["ZMan_All"].HeaderText = "مانده كل";
            dgvZirSarfal.Columns["ZMan_All"].DefaultCellStyle.Format = "#,0";
            dgvZirSarfal.Columns["ZMan_All"].DefaultCellStyle.Font = new Font("IRANSans(FaNum)", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dgvZirSarfal.Columns["ZMan_All"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvZirSarfal.Columns["Zbed_bes_All"].Visible = true;
            dgvZirSarfal.Columns["Zbed_bes_All"].HeaderText = "تش";
            dgvZirSarfal.Columns["Zbed_bes_All"].Width = 30;

        }

        private void search()
        {
            if (dt != null && !_isSearch)
            {
                var filter = txtFilter.Text.Trim();
                int row = 1;

                var dt1 = dt.Where(c => c.ZName.Contains(filter)).ToList();
                dgvZirSarfal.DataSource = dt1.GroupBy(g => new
                {
                    g.ZID,
                    g.ZSarfaslID,
                    g.ZName,
                    g.Zbed,
                    g.Zbes,
                    g.ZMan,
                    g.Zbed_bes,
                    g.ZMan_Befor,
                    g.Zbed_bes_Befor,
                    g.ZMan_All,
                    g.Zbed_bes_All,
                    g.Zhas_dar,
                    g.ZActive
                }).Select(g => new SZAservice()
                {
                    Zrow = row++,
                    ZID = g.Key.ZID,
                    ZSarfaslID = g.Key.ZSarfaslID,
                    ZName = g.Key.ZName,
                    Zbed = g.Key.Zbed,
                    Zbes = g.Key.Zbes,
                    ZMan = g.Key.ZMan,
                    Zbed_bes = g.Key.Zbed_bes,
                    ZMan_Befor = g.Key.ZMan_Befor,
                    Zbed_bes_Befor = g.Key.Zbed_bes_Befor,
                    ZMan_All = g.Key.ZMan_All,
                    Zbed_bes_All = g.Key.Zbed_bes_All,
                    Zhas_dar = g.Key.Zhas_dar,
                    ZActive = g.Key.ZActive
                }).ToList();
                SetTextLabelFooter(dt1.Count, dt1.Sum(d => d.ZMan), dt1.Sum(d => d.ZMan_All));
            }
        }

        private void SetCheckBoxColumn()
        {
            if (dgvZirSarfal.SelectedRows.Count > 0)
            {
                var rowIndex = dgvZirSarfal.SelectedRows[0].Index;
                if (Convert.ToBoolean(dgvZirSarfal.SelectedRows[0].Cells["select"].Value) == false)
                {
                    dgvZirSarfal.Rows[rowIndex].Cells["select"].Value = true;
                    dgvZirSarfal.Rows[rowIndex].DefaultCellStyle.BackColor = Color.PaleTurquoise;
                    AddOrRemoveInListAndTextSelected(rowIndex, true);
                }
                else
                {
                    dgvZirSarfal.Rows[rowIndex].Cells["select"].Value = false;
                    dgvZirSarfal.Rows[rowIndex].DefaultCellStyle.BackColor = Color.White;
                    AddOrRemoveInListAndTextSelected(rowIndex, false);
                }
            }
        }

        private void AddOrRemoveInListAndTextSelected(int rowData, bool isAdded)
        {
            ListSelected.RemoveAll(i => i == (int)dgvZirSarfal.Rows[rowData].Cells["ZID"].Value);

            if (isAdded)
            {
                ListSelected.Add((int)dgvZirSarfal.Rows[rowData].Cells["ZID"].Value);
            }
            lblFooterNumber.Text = $"تعداد: {dgvZirSarfal.RowCount}\nتعداد انتخابي: {ListSelected.Count}";

        }

        private void OpenActZirSarfasl(string NameZirSarfasl)
        {
            if (dgvZirSarfal.SelectedRows.Count > 0)
            {
                _zirSarfaslIdSelected = (int)dgvZirSarfal.SelectedRows[0].Cells["ZID"].Value;
                DefultForm reportZirSarfasl = new DefultForm();
                reportZirSarfasl.ShowDialog(new ReportActZirSarfasl(textDate1.FromDate, textDate1.ToDate, NameZirSarfasl, zirSarfaslID: _zirSarfaslIdSelected), new Size(1360, 694));
                //باز کردن زیر سرفصل های سرفصل انتخابی داخل گرید
            }
        }

        private void SetTextLabelFooter(int number, decimal sum, decimal sumAll)
        {
            string status1 = sum > 0 ? "بد" : sum == 0 ? "--" : "بس";
            string status2 = sumAll > 0 ? "بد" : sumAll == 0 ? "--" : "بس";

            lblFooterNumber.Text = $"تعداد: {number}\nتعداد انتخابي: {ListSelected.Count}";
            lblFooter.Text = $"   مانده در بازه: {Math.Abs(sum).ToMan()} ({status1})\n   مانده كل : {Math.Abs(sumAll).ToMan()} ({status2})";
        }

        #endregion

    }
}
