using ReportSarfasl.dataLayer;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReportSarfasl.Forms;
using ReportSarfasl.Services;
using Stimulsoft.Report;

namespace ReportSarfasl
{
    public class ReportActZirSarfasl : UserControl
    {
        private int _zirSarfaslID, _sarfaslID;
        private List<int> _listZirSar = new List<int>(), _choiseKind = new List<int>();
        private bool _isActForSarfasl;
        private List<ActZirSarfaslService> dt;
        private string _nameSarfaslOrZirSarfasl;
        private PersianCalendar pc = new PersianCalendar();
        private Panel pnlHeader;
        private Panel pnlMain;
        private Button btnCancel;
        private Button btnPrint;
        private TextBox txtFilter;
        private GroupBox gbHeader;
        private GroupBox groupBox1;
        private DataGridView dgvActZirSarfasl;
        private TextDate textDate1;
        private Label lblFooterNumber;
        private CheckBox chbActKind;
        private Label lblDisAct;
        private Label label3;
        private Panel panel1;
        private Label label1;
        private Label lblBed;
        private Label lblBedDate;
        private Label lblBes;
        private Label lblBesDate;
        private Label label6;
        private Label label5;
        private Label lblManDate;
        private Label label9;
        private Label lblMan;
        private Label label11;
        private Panel pnlFooter;

        public ReportActZirSarfasl(string FromDate, string ToDate,string NameGrupBoxHeader, int zirSarfaslID = -1, int sarfaslID = -1, List<int> listZirsarfasl = null)
        {
            InitializeComponent();
            textDate1.FromDate = FromDate;
            textDate1.ToDate = ToDate;
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

            gbHeader.Text = "ريز عملكردهاي" + (_isActForSarfasl ? "سرفصل : " : "زيرسرفصل : ") + NameGrupBoxHeader;
            _nameSarfaslOrZirSarfasl = NameGrupBoxHeader;

        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.gbHeader = new System.Windows.Forms.GroupBox();
            this.chbActKind = new System.Windows.Forms.CheckBox();
            this.textDate1 = new ReportSarfasl.TextDate();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvActZirSarfasl = new System.Windows.Forms.DataGridView();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.lblBes = new System.Windows.Forms.Label();
            this.lblMan = new System.Windows.Forms.Label();
            this.lblManDate = new System.Windows.Forms.Label();
            this.lblBesDate = new System.Windows.Forms.Label();
            this.lblBed = new System.Windows.Forms.Label();
            this.lblBedDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblFooterNumber = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.lblDisAct = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.gbHeader.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActZirSarfasl)).BeginInit();
            this.pnlFooter.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.gbHeader);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(905, 54);
            this.pnlHeader.TabIndex = 1;
            // 
            // gbHeader
            // 
            this.gbHeader.Controls.Add(this.chbActKind);
            this.gbHeader.Controls.Add(this.textDate1);
            this.gbHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbHeader.Location = new System.Drawing.Point(0, 0);
            this.gbHeader.Name = "gbHeader";
            this.gbHeader.Size = new System.Drawing.Size(905, 54);
            this.gbHeader.TabIndex = 0;
            this.gbHeader.TabStop = false;
            this.gbHeader.Text = "جزييات زيرسرفصل";
            // 
            // chbActKind
            // 
            this.chbActKind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chbActKind.AutoSize = true;
            this.chbActKind.Location = new System.Drawing.Point(369, 23);
            this.chbActKind.Name = "chbActKind";
            this.chbActKind.Size = new System.Drawing.Size(79, 24);
            this.chbActKind.TabIndex = 0;
            this.chbActKind.Text = "نوع عملكرد";
            this.chbActKind.UseVisualStyleBackColor = true;
            this.chbActKind.CheckedChanged += new System.EventHandler(this.chbActKind_CheckedChanged);
            this.chbActKind.KeyDown += new System.Windows.Forms.KeyEventHandler(this.chbActKind_KeyDown);
            // 
            // textDate1
            // 
            this.textDate1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textDate1.Enabled = false;
            this.textDate1.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textDate1.FromDate = "1398/07/16";
            this.textDate1.Location = new System.Drawing.Point(499, 23);
            this.textDate1.Name = "textDate1";
            this.textDate1.Size = new System.Drawing.Size(390, 24);
            this.textDate1.TabIndex = 0;
            this.textDate1.ToDate = "1398/07/16";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.groupBox1);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 54);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(905, 406);
            this.pnlMain.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvActZirSarfasl);
            this.groupBox1.Controls.Add(this.txtFilter);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(905, 406);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "عملكرد هاي  زيرسرفصل";
            // 
            // dgvActZirSarfasl
            // 
            this.dgvActZirSarfasl.AllowUserToAddRows = false;
            this.dgvActZirSarfasl.AllowUserToDeleteRows = false;
            this.dgvActZirSarfasl.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
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
            this.dgvActZirSarfasl.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            this.dgvActZirSarfasl.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvActZirSarfasl.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvActZirSarfasl.Size = new System.Drawing.Size(899, 351);
            this.dgvActZirSarfasl.TabIndex = 6;
            this.dgvActZirSarfasl.DataSourceChanged += new System.EventHandler(this.dgvActZirSarfasl_DataSourceChanged);
            this.dgvActZirSarfasl.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvActZirSarfasl_RowEnter);
            // 
            // txtFilter
            // 
            this.txtFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtFilter.Location = new System.Drawing.Point(3, 24);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(899, 28);
            this.txtFilter.TabIndex = 5;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            this.txtFilter.Enter += new System.EventHandler(this.txtFilter_Enter);
            this.txtFilter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFilter_KeyDown);
            this.txtFilter.Leave += new System.EventHandler(this.txtFilter_Leave);
            // 
            // pnlFooter
            // 
            this.pnlFooter.Controls.Add(this.lblBes);
            this.pnlFooter.Controls.Add(this.lblMan);
            this.pnlFooter.Controls.Add(this.lblManDate);
            this.pnlFooter.Controls.Add(this.lblBesDate);
            this.pnlFooter.Controls.Add(this.lblBed);
            this.pnlFooter.Controls.Add(this.lblBedDate);
            this.pnlFooter.Controls.Add(this.label1);
            this.pnlFooter.Controls.Add(this.label6);
            this.pnlFooter.Controls.Add(this.label11);
            this.pnlFooter.Controls.Add(this.label9);
            this.pnlFooter.Controls.Add(this.label5);
            this.pnlFooter.Controls.Add(this.label3);
            this.pnlFooter.Controls.Add(this.lblFooterNumber);
            this.pnlFooter.Controls.Add(this.panel1);
            this.pnlFooter.Controls.Add(this.lblDisAct);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 460);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(905, 71);
            this.pnlFooter.TabIndex = 3;
            // 
            // lblBes
            // 
            this.lblBes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBes.Location = new System.Drawing.Point(369, 29);
            this.lblBes.Name = "lblBes";
            this.lblBes.Size = new System.Drawing.Size(114, 20);
            this.lblBes.TabIndex = 12;
            this.lblBes.Text = "0";
            this.lblBes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMan
            // 
            this.lblMan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMan.Location = new System.Drawing.Point(206, 29);
            this.lblMan.Name = "lblMan";
            this.lblMan.Size = new System.Drawing.Size(114, 20);
            this.lblMan.TabIndex = 12;
            this.lblMan.Text = "0";
            this.lblMan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblManDate
            // 
            this.lblManDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblManDate.Location = new System.Drawing.Point(206, 9);
            this.lblManDate.Name = "lblManDate";
            this.lblManDate.Size = new System.Drawing.Size(114, 20);
            this.lblManDate.TabIndex = 12;
            this.lblManDate.Text = "0";
            this.lblManDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBesDate
            // 
            this.lblBesDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBesDate.Location = new System.Drawing.Point(369, 9);
            this.lblBesDate.Name = "lblBesDate";
            this.lblBesDate.Size = new System.Drawing.Size(114, 20);
            this.lblBesDate.TabIndex = 12;
            this.lblBesDate.Text = "0";
            this.lblBesDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBed
            // 
            this.lblBed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBed.Location = new System.Drawing.Point(556, 31);
            this.lblBed.Name = "lblBed";
            this.lblBed.Size = new System.Drawing.Size(114, 20);
            this.lblBed.TabIndex = 12;
            this.lblBed.Text = "0";
            this.lblBed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBedDate
            // 
            this.lblBedDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBedDate.Location = new System.Drawing.Point(556, 9);
            this.lblBedDate.Name = "lblBedDate";
            this.lblBedDate.Size = new System.Drawing.Size(114, 20);
            this.lblBedDate.TabIndex = 12;
            this.lblBedDate.Text = "0";
            this.lblBedDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(672, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "باحساب قبلي: بدهكاري: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(489, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "بستانكاري:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(326, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 20);
            this.label11.TabIndex = 12;
            this.label11.Text = "مانده:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(326, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 20);
            this.label9.TabIndex = 12;
            this.label9.Text = "مانده:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(489, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "بستانكاري:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(676, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "دربازه:            بدهكاري:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFooterNumber
            // 
            this.lblFooterNumber.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblFooterNumber.Location = new System.Drawing.Point(800, 0);
            this.lblFooterNumber.Name = "lblFooterNumber";
            this.lblFooterNumber.Size = new System.Drawing.Size(105, 51);
            this.lblFooterNumber.TabIndex = 13;
            this.lblFooterNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnPrint);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 51);
            this.panel1.TabIndex = 15;
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Location = new System.Drawing.Point(23, 9);
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
            this.btnPrint.Location = new System.Drawing.Point(98, 9);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 30);
            this.btnPrint.TabIndex = 6;
            this.btnPrint.Text = "چاپ";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // lblDisAct
            // 
            this.lblDisAct.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblDisAct.Location = new System.Drawing.Point(0, 51);
            this.lblDisAct.Name = "lblDisAct";
            this.lblDisAct.Size = new System.Drawing.Size(905, 20);
            this.lblDisAct.TabIndex = 14;
            // 
            // ReportActZirSarfasl
            // 
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlFooter);
            this.Font = new System.Drawing.Font("IRANSans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Name = "ReportActZirSarfasl";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(905, 531);
            this.Load += new System.EventHandler(this.ReportActZirSarfasl_Load);
            this.pnlHeader.ResumeLayout(false);
            this.gbHeader.ResumeLayout(false);
            this.gbHeader.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActZirSarfasl)).EndInit();
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void ReportActZirSarfasl_Load(object sender, EventArgs e)
        {
            if (_isActForSarfasl)
            {
                dt = conection.GetActZirSarfaslServices(textDate1.FromDate, textDate1.ToDate, sarfaslID: _sarfaslID, listZirsarfasl: _listZirSar);
            }
            else
            {
                dt = conection.GetActZirSarfaslServices(textDate1.FromDate, textDate1.ToDate, zirSarfaslID: _zirSarfaslID);
            }

            dgvActZirSarfasl.DataSource = dt;
            var befor = dt.FirstOrDefault(d => d.ID == 0) ?? new ActZirSarfaslService();

            SetTextLabelFooter(dt.Count, dt.Sum(d => d.bed), dt.Sum(d => d.bes), dt.Sum(d => d.bed - d.bes), befor.bed, befor.bes);

            SetGrid();
            chbActKind.Focus();
        }

        #region Event Controls
        private void chbActKind_CheckedChanged(object sender, EventArgs e)
        {
            if (chbActKind.Checked)
            {
                DefultForm kindForm = new DefultForm();
                ChoiceActKind actKind = new ChoiceActKind();
                kindForm.ShowDialog(actKind, new Size(571, 234));
                _choiseKind = actKind.choice;
                txtFilter.Focus();
                //show user control
            }
            else
            {
                _choiseKind = new List<int>();
            }

            search();
        }
        private void chbActKind_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                chbActKind.Checked = !chbActKind.Checked;
        }

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
            //else if (e.KeyCode == Keys.Left && txtFilter.Text.Trim() == "")
            //{
            //    if (dgvActZirSarfasl.DataSource != null)
            //        dgvActZirSarfasl.Columns["description"].Width = dgvActZirSarfasl.Columns["description"].Width + 1;
            //}
            //else if (e.KeyCode == Keys.Right && txtFilter.Text.Trim() == "")
            //{
            //    if (dgvActZirSarfasl.DataSource != null)
            //        dgvActZirSarfasl.Columns["description"].Width = dgvActZirSarfasl.Columns["description"].Width - 1;
            //}
            else if (dgvActZirSarfasl.Rows.Count > 0)
            {
                int countRowGrid = dgvActZirSarfasl.Rows.Count;
                int rowIndexSelected = dgvActZirSarfasl.SelectedRows[0].Index;
                if (e.KeyCode == Keys.Up)
                {
                    if (rowIndexSelected == 0)
                    {
                        dgvActZirSarfasl.Rows[countRowGrid - 1].Cells[0].Selected = true;
                    }
                    else
                    {
                        dgvActZirSarfasl.Rows[rowIndexSelected - 1].Cells[0].Selected = true;
                    }
                }
                else if (e.KeyCode == Keys.Down)
                {
                    dgvActZirSarfasl.Rows[(rowIndexSelected + 1) % countRowGrid].Cells[0].Selected = true;
                }
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            var DateNow = DateTime.Now;
            string today = pc.GetYear(DateNow).ToString("0000") + "/" + pc.GetMonth(DateNow).ToString("00") + "/" + pc.GetDayOfMonth(DateNow).ToString("00");
            StiReport report = new StiReport();
            report.Load(@"C:\Users\North-PC\Desktop\Report Sarfasl (Stimulsoft)\ReportActZirSarfasl1.mrt");
            report.Compile();
            report["User"] = "alirezasadegghi";
            report["today"] = today;
            report["FromDate"] = textDate1.FromDate;
            report["ToDate"] = textDate1.ToDate;
            report["NameReport"] = ((_isActForSarfasl) ? "سرفصل : " : "زير سرفصل : ") + _nameSarfaslOrZirSarfasl;
            List<ActZirSarfaslService> dt1 = (List<ActZirSarfaslService>)dgvActZirSarfasl.DataSource;
            var befor = dt1.FirstOrDefault(d => d.ID == 0) ?? new ActZirSarfaslService();
            report["SumBedDate"] = dt1.Sum(d => d.bed) - befor.bed;
            report["SumBesDate"] = dt1.Sum(d => d.bes) - befor.bes;
            report.RegBusinessObject("ActZirSarfasls", dgvActZirSarfasl.DataSource);

            report.Show();
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

        private void dgvActZirSarfasl_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvActZirSarfasl.SelectedRows.Count > 0)
            {
                lblDisAct.Text = dgvActZirSarfasl.SelectedRows[0].Cells["description"].Value.ToString();
            }
            else
            {
                lblDisAct.Text = "";
            }
        }
        private void dgvActZirSarfasl_DataSourceChanged(object sender, EventArgs e)
        {
            if (dgvActZirSarfasl.SelectedRows.Count > 0)
            {
                lblDisAct.Text = dgvActZirSarfasl.SelectedRows[0].Cells["description"].Value.ToString();
                foreach (DataGridViewRow row in dgvActZirSarfasl.Rows)
                {
                    if (row.Index == 0)
                    {
                        row.Cells["Man"].Value = (decimal) row.Cells["bed"].Value - (decimal) row.Cells["bes"].Value;
                    }
                    else
                    {
                        row.Cells["Man"].Value = (decimal) row.Cells["bed"].Value - (decimal) row.Cells["bes"].Value +
                                                 (decimal) dgvActZirSarfasl.Rows[row.Index - 1].Cells["Man"].Value;
                    }
                }
            }
            else
            {
                lblDisAct.Text = "";
            }
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
            dgvActZirSarfasl.Columns["row"].Width = 40;

            dgvActZirSarfasl.Columns["date"].Visible = true;
            dgvActZirSarfasl.Columns["date"].HeaderText = "تاريخ";
            dgvActZirSarfasl.Columns["date"].Width = 70;
            // dgvActZirSarfasl.Columns["date"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvActZirSarfasl.Columns["user"].Visible = true;
            dgvActZirSarfasl.Columns["user"].HeaderText = "كاربر";
            dgvActZirSarfasl.Columns["user"].Width = 50;

            dgvActZirSarfasl.Columns["sanadno"].Visible = true;
            dgvActZirSarfasl.Columns["sanadno"].HeaderText = "سند";
            dgvActZirSarfasl.Columns["sanadno"].Width = 70;
            // dgvActZirSarfasl.Columns["date"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvActZirSarfasl.Columns["description"].Visible = true;
            dgvActZirSarfasl.Columns["description"].HeaderText = "شــــرح";
            dgvActZirSarfasl.Columns["description"].Width = 241;
            //dgvActZirSarfasl.Columns["description"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvActZirSarfasl.Columns["bed"].Visible = true;
            dgvActZirSarfasl.Columns["bed"].HeaderText = "بدهكاري";
            dgvActZirSarfasl.Columns["bed"].DefaultCellStyle.Format = "#,0";
            dgvActZirSarfasl.Columns["bed"].DefaultCellStyle.Font = new Font("IRANSans(FaNum)", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            // dgvActZirSarfasl.Columns["bed"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvActZirSarfasl.Columns["bes"].Visible = true;
            dgvActZirSarfasl.Columns["bes"].HeaderText = "بستانكاري";
            dgvActZirSarfasl.Columns["bes"].DefaultCellStyle.Format = "#,0";
            dgvActZirSarfasl.Columns["bes"].DefaultCellStyle.Font = new Font("IRANSans(FaNum)", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            // dgvActZirSarfasl.Columns["bes"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvActZirSarfasl.Columns["bed_bes"].Visible = true;
            dgvActZirSarfasl.Columns["bed_bes"].HeaderText = "تشخيص";
            // dgvActZirSarfasl.Columns["bed_bes"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvActZirSarfasl.Columns["Man"].Visible = true;
            dgvActZirSarfasl.Columns["Man"].HeaderText = "مانده";
            dgvActZirSarfasl.Columns["Man"].DefaultCellStyle.Format = "#,0";
            dgvActZirSarfasl.Columns["Man"].DefaultCellStyle.Font = new Font("IRANSans(FaNum)", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            // dgvActZirSarfasl.Columns["bes"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvActZirSarfasl.Columns["kindName"].Visible = true;
            dgvActZirSarfasl.Columns["kindName"].HeaderText = "نوع عملكرد";
        }

        private void search()
        {
            if (dt != null)
            {
                var filter = txtFilter.Text.Trim();
                List<ActZirSarfaslService> dt1 = new List<ActZirSarfaslService>();
                if (_choiseKind.Any())
                {
                    dt1 = dt.Where(c => c.description.Contains(filter) && _choiseKind.Contains(c.kind ?? 0)).ToList();
                }
                else
                {
                    dt1 = dt.Where(c => c.description.Contains(filter)).ToList();
                }

                dgvActZirSarfasl.DataSource = dt1;
                var befor = dt1.FirstOrDefault(d => d.ID == 0) ?? new ActZirSarfaslService();
                SetTextLabelFooter(dt1.Count, dt1.Sum(d => d.bed), dt1.Sum(d => d.bes), dt1.Sum(d => d.bed - d.bes), befor.bed, befor.bes);
            }
        }

        private void SetTextLabelFooter(int number, decimal bed, decimal bes, decimal sumAll, decimal bedBefor,
            decimal besBefor)
        {
            decimal sum = sumAll - (bedBefor - besBefor);
            string status1 = sum > 0 ? "بد" : sum == 0 ? "--" : "بس";
            string status2 = sumAll > 0 ? "بد" : sumAll == 0 ? "--" : "بس";

            lblFooterNumber.Text = $"تعداد: {number}";
            lblBedDate.Text = (bed - bedBefor).ToMan();
            lblBesDate.Text = (bes - besBefor).ToMan();
            lblManDate.Text = $"{Math.Abs(sum).ToMan()} ({status1})";
            lblBed.Text = bed.ToMan();
            lblBes.Text = bes.ToMan();
            lblMan.Text = $"{ Math.Abs(sumAll).ToMan()} ({status2})";
        }
        

        #endregion
    }
}
