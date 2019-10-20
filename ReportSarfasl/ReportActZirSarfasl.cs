using ReportSarfasl.dataLayer;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReportSarfasl.Forms;
using ReportSarfasl.Services;
using Stimulsoft.Report;
using Stimulsoft.Report.Dictionary;

namespace ReportSarfasl
{
    public class ReportActZirSarfasl : UserControl
    {
        private int _zirSarfaslID, _sarfaslID;
        private List<int> _listZirSar = new List<int>(), _choiseKind = new List<int>(), ListSelected = new List<int>();
        private bool _isSearch, _isKeySpase, _isActForSarfasl;
        private List<SZAservice> dt;
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
        private CheckBox chbAll;
        private DataGridViewCheckBoxColumn select;
        private Label label2;
        private Label lblLoding;
        private Panel pnlFooter;

        public ReportActZirSarfasl(string FromDate, string ToDate, string NameGrupBoxHeader, int sarfaslID , int zirSarfaslID = -1, List<int> listZirsarfasl = null)
        {
            InitializeComponent();
            textDate1.FromDate = FromDate;
            textDate1.ToDate = ToDate;
            _sarfaslID = sarfaslID;

            if (zirSarfaslID != -1)
            {
                _zirSarfaslID = zirSarfaslID;
                _isActForSarfasl = false;
            }
            else if (listZirsarfasl != null)
            {
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
            this.lblLoding = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chbActKind = new System.Windows.Forms.CheckBox();
            this.textDate1 = new ReportSarfasl.TextDate();
            this.chbAll = new System.Windows.Forms.CheckBox();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvActZirSarfasl = new System.Windows.Forms.DataGridView();
            this.select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
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
            this.pnlHeader.Size = new System.Drawing.Size(905, 80);
            this.pnlHeader.TabIndex = 2;
            // 
            // gbHeader
            // 
            this.gbHeader.Controls.Add(this.lblLoding);
            this.gbHeader.Controls.Add(this.label2);
            this.gbHeader.Controls.Add(this.chbActKind);
            this.gbHeader.Controls.Add(this.textDate1);
            this.gbHeader.Controls.Add(this.chbAll);
            this.gbHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbHeader.Location = new System.Drawing.Point(0, 0);
            this.gbHeader.Name = "gbHeader";
            this.gbHeader.Size = new System.Drawing.Size(905, 80);
            this.gbHeader.TabIndex = 0;
            this.gbHeader.TabStop = false;
            this.gbHeader.Text = "جزييات زيرسرفصل";
            // 
            // lblLoding
            // 
            this.lblLoding.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLoding.AutoSize = true;
            this.lblLoding.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblLoding.Location = new System.Drawing.Point(489, 24);
            this.lblLoding.Name = "lblLoding";
            this.lblLoding.Size = new System.Drawing.Size(89, 20);
            this.lblLoding.TabIndex = 18;
            this.lblLoding.Text = "درحال پردازش ...";
            this.lblLoding.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(23, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "چاپ قيض سند سرفصل براي عملكرد: Enter";
            // 
            // chbActKind
            // 
            this.chbActKind.AutoSize = true;
            this.chbActKind.Location = new System.Drawing.Point(249, 52);
            this.chbActKind.Name = "chbActKind";
            this.chbActKind.Size = new System.Drawing.Size(79, 24);
            this.chbActKind.TabIndex = 15;
            this.chbActKind.Text = "نوع عملكرد";
            this.chbActKind.UseVisualStyleBackColor = true;
            this.chbActKind.CheckedChanged += new System.EventHandler(this.chbActKind_CheckedChanged);
            this.chbActKind.KeyDown += new System.Windows.Forms.KeyEventHandler(this.chbActKind_KeyDown);
            // 
            // textDate1
            // 
            this.textDate1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textDate1.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textDate1.FromDate = "1398/07/22";
            this.textDate1.Location = new System.Drawing.Point(499, 23);
            this.textDate1.Name = "textDate1";
            this.textDate1.Size = new System.Drawing.Size(390, 24);
            this.textDate1.TabIndex = 0;
            this.textDate1.ToDate = "1398/07/22";
            this.textDate1.KeyEnterTextBoxToYear += new System.EventHandler(this.textDate1_KeyEnterTextBoxToYear);
            // 
            // chbAll
            // 
            this.chbAll.AutoSize = true;
            this.chbAll.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.chbAll.Location = new System.Drawing.Point(3, 53);
            this.chbAll.Name = "chbAll";
            this.chbAll.Size = new System.Drawing.Size(899, 24);
            this.chbAll.TabIndex = 10;
            this.chbAll.Text = "انتخاب همه";
            this.chbAll.UseVisualStyleBackColor = true;
            this.chbAll.CheckedChanged += new System.EventHandler(this.chbAll_CheckedChanged);
            this.chbAll.KeyDown += new System.Windows.Forms.KeyEventHandler(this.chbAll_KeyDown);
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.groupBox1);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 80);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(905, 380);
            this.pnlMain.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvActZirSarfasl);
            this.groupBox1.Controls.Add(this.txtFilter);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(905, 380);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "عملكرد هاي  زيرسرفصل";
            // 
            // dgvActZirSarfasl
            // 
            this.dgvActZirSarfasl.AllowUserToAddRows = false;
            this.dgvActZirSarfasl.AllowUserToDeleteRows = false;
            this.dgvActZirSarfasl.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvActZirSarfasl.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("IRANSans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvActZirSarfasl.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvActZirSarfasl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActZirSarfasl.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.select});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("IRANSans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DodgerBlue;
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.dgvActZirSarfasl.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvActZirSarfasl.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvActZirSarfasl.Size = new System.Drawing.Size(899, 325);
            this.dgvActZirSarfasl.TabIndex = 6;
            this.dgvActZirSarfasl.DataSourceChanged += new System.EventHandler(this.dgvActZirSarfasl_DataSourceChanged);
            this.dgvActZirSarfasl.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvActZirSarfasl_CellClick);
            this.dgvActZirSarfasl.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvActZirSarfasl_RowEnter);
            this.dgvActZirSarfasl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvActZirSarfasl_KeyDown);
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
            this.label1.Location = new System.Drawing.Point(677, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "كل:                بدهكاري:";
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
            GetData();
        }

        #region Event Controls
        private void textDate1_KeyEnterTextBoxToYear(object sender, EventArgs e)
        {
            GetData();
            chbActKind.Focus();
        }

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
            if (e.KeyCode == Keys.Enter)
            {
                txtFilter.Focus();
            }
        }

        private void chbAll_CheckedChanged(object sender, EventArgs e)
        {
            List<int> list1 = ((List<SZAservice>)dgvActZirSarfasl.DataSource).Select(a => a.AID).ToList();
            ListSelected.RemoveAll(x => list1.Contains(x));
            if (chbAll.Checked)
            {
                ListSelected.AddRange(list1);
                foreach (DataGridViewRow row in dgvActZirSarfasl.Rows)
                {
                    row.Cells["select"].Value = true;
                    row.DefaultCellStyle.BackColor = Color.PaleTurquoise;
                }
            }
            else
            {
                foreach (DataGridViewRow row in dgvActZirSarfasl.Rows)
                {
                    row.Cells["select"].Value = false;
                    row.DefaultCellStyle.BackColor = Color.White;
                }
            }

            lblFooterNumber.Text = $"تعداد: {dgvActZirSarfasl.RowCount}\nتعداد انتخابي: {ListSelected.Count}";

        }
        private void chbAll_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtFilter.Focus();
            }
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
                if ((txtFilter.Text.Trim() == "") || (dgvActZirSarfasl.Rows.Count == 1))
                {
                    _isKeySpase = true;
                    SetCheckBoxColumn();
                    txtFilter.Text = "";
                }
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
                if (e.KeyCode == Keys.Enter)
                {
                    ShowReportSanadAct();
                    //OpenActZirSarfasl(dgvActZirSarfasl.SelectedRows[0].Cells["ZName"].Value.ToString());
                }
                else if (e.KeyCode == Keys.Up)
                {
                    _isSearch = true;
                    txtFilter.Text = "";
                    if (rowIndexSelected == 0)
                    {
                        dgvActZirSarfasl.Rows[countRowGrid - 1].Cells["Arow"].Selected = true;
                    }
                    else
                    {
                        dgvActZirSarfasl.Rows[rowIndexSelected - 1].Cells["Arow"].Selected = true;
                    }
                }
                else if (e.KeyCode == Keys.Down)
                {
                    _isSearch = true;
                    txtFilter.Text = "";
                    if (rowIndexSelected + 1 == countRowGrid)
                    {
                        dgvActZirSarfasl.Rows[0].Cells["Arow"].Selected = true;
                    }
                    else
                    {
                        dgvActZirSarfasl.Rows[rowIndexSelected + 1].Cells["Arow"].Selected = true;
                    }
                    //dgvActZirSarfasl.Rows[(rowIndexSelected + 1) % countRowGrid].Cells[0].Selected = true;
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

        private void btnPrint_Click(object sender, EventArgs e)
        {
            #region Cod Me

            List<SZAservice> dt1 = dt;

            if (ListSelected.Count > 0)
            {
                dt1 = dt1.Where(d => ListSelected.Contains(d.AID)).ToList();
            }

            var DateNow = DateTime.Now;
            string today = pc.GetYear(DateNow).ToString("0000") + "/" + pc.GetMonth(DateNow).ToString("00") + "/" + pc.GetDayOfMonth(DateNow).ToString("00");
            StiReport report = new StiReport();
            report.Load(@"C:\Users\North-PC\Desktop\Report Sarfasl (Stimulsoft)\Atiran\ReportActZirSarfasl1_1.mrt");
            //report.Compile();
            //report.Dictionary.Databases.Add(new StiSqlDatabase("Connection", "Integrated Security=True;Data Source=.;Initial Catalog=ZAnsari;Password=;User ID="));//Connections.ConnectionInfo.BuildStimulConnectionString()));
            report.Dictionary.Variables["User"].Value = "alirezasadegghi";
            report.Dictionary.Variables["today"].Value = today;
            report.Dictionary.Variables["FromDate"].Value = textDate1.FromDate;
            report.Dictionary.Variables["ToDate"].Value = textDate1.ToDate;
            report.Dictionary.Variables["NameReport"].Value = ((_isActForSarfasl) ? "سرفصل : " : "زير سرفصل : ") + _nameSarfaslOrZirSarfasl;
            //var befor = dt1.FirstOrDefault(d => d.AID == 0) ?? new SZAservice();
            //report.Dictionary.Variables["SumBedDate"].Value = (dt1.Sum(d => d.Abed) - befor.Abed).ToString();
            //report.Dictionary.Variables["SumBesDate"].Value = (dt1.Sum(d => d.Abes) - befor.Abes).ToString();
            report.RegBusinessObject("SZA", dt1);
            report.Render();
            report.Show();

            #endregion

            //چاپ
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ((Form)this.TopLevelControl).Close();
            //بستن فرم
        }

        private void dgvActZirSarfasl_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvActZirSarfasl.SelectedRows.Count > 0)
            {
                lblDisAct.Text = dgvActZirSarfasl.SelectedRows[0].Cells["Adescription"].Value.ToString();
            }
            else
            {
                lblDisAct.Text = "";
            }
        }
        private void dgvActZirSarfasl_KeyDown(object sender, KeyEventArgs e)
        {
            if (dgvActZirSarfasl.SelectedRows.Count > 0)
            {
                if (e.KeyCode == Keys.Space)
                {
                    _isKeySpase = true;
                    SetCheckBoxColumn();
                }
                else if (e.KeyCode == Keys.Enter)
                {
                    ShowReportSanadAct();
                }
            }
        }
        private void dgvActZirSarfasl_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!_isKeySpase && e.RowIndex >= 0 && e.ColumnIndex == 0)
                SetCheckBoxColumn();

            _isKeySpase = false;
        }
        private void dgvActZirSarfasl_DataSourceChanged(object sender, EventArgs e)
        {
            if (dgvActZirSarfasl.SelectedRows.Count > 0)
            {
                lblDisAct.Text = dgvActZirSarfasl.SelectedRows[0].Cells["Adescription"].Value.ToString();
                decimal man1 = 0;
                foreach (DataGridViewRow row in dgvActZirSarfasl.Rows)
                {
                    var result = dt.First(d => d.AID == (int)row.Cells["AID"].Value);
                    result.AMan = man1 += (decimal)row.Cells["Abed"].Value - (decimal)row.Cells["Abes"].Value;

                    result.AManbed_bes = result.AMan > 0 ? "بد" :
                        result.AMan == 0 ? "--" : "بس";

                    row.Cells["AMan"].Value = Math.Abs(result.AMan);
                    row.Cells["AManbed_bes"].Value = result.AManbed_bes;

                    if (ListSelected.Any(i => i == (int)row.Cells["AID"].Value))
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
            else
            {
                lblDisAct.Text = "";
            }
        }


        #endregion
        #region Event override
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                ((Form)this.TopLevelControl).Close();
                return false;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }


        #endregion

        #region Method

        private void GetData()
        {
            lblLoding.Visible = true;

            ListSelected.Clear();

            Thread tGetdata = new Thread(() =>
            {
                if (_isActForSarfasl)
                {
                    dt = conection.GetActZirSarfaslServices(textDate1.FromDate, textDate1.ToDate, sarfaslID: _sarfaslID, listZirsarfasl: _listZirSar);
                }
                else
                {
                    dt = conection.GetActZirSarfaslServices(textDate1.FromDate, textDate1.ToDate, _sarfaslID,new List<int>(){ _zirSarfaslID });
                }
            });
            tGetdata.Start();
            tGetdata.Join();

            dgvActZirSarfasl.DataSource = dt;
            
            chbAll.Checked = false;
            SetTextLabelFooter(dt.Count, dt.Sum(d => d.Abed), dt.Sum(d => d.Abes), dt.Sum(d => d.Abed - d.Abes));
            SetGrid();
            txtFilter.Focus();
            lblLoding.Visible = false;

        }

        private void SetGrid()
        {
            foreach (DataGridViewColumn col in dgvActZirSarfasl.Columns) col.Visible = false;

            dgvActZirSarfasl.Columns["select"].Visible = true;
            dgvActZirSarfasl.Columns["select"].Width = 25;

            dgvActZirSarfasl.Columns["Arow"].Visible = true;
            dgvActZirSarfasl.Columns["Arow"].HeaderText = "رديف";
            dgvActZirSarfasl.Columns["Arow"].Width = 40;

            dgvActZirSarfasl.Columns["Adate"].Visible = true;
            dgvActZirSarfasl.Columns["Adate"].HeaderText = "تاريخ";
            dgvActZirSarfasl.Columns["Adate"].Width = 80;

            dgvActZirSarfasl.Columns["Auser"].Visible = true;
            dgvActZirSarfasl.Columns["Auser"].HeaderText = "كاربر";
            dgvActZirSarfasl.Columns["Auser"].Width = 90;

            dgvActZirSarfasl.Columns["Asanadno"].Visible = true;
            dgvActZirSarfasl.Columns["Asanadno"].HeaderText = "سند";
            dgvActZirSarfasl.Columns["Asanadno"].Width = 40;

            dgvActZirSarfasl.Columns["Adescription"].Visible = true;
            dgvActZirSarfasl.Columns["Adescription"].HeaderText = "شــــرح";
            dgvActZirSarfasl.Columns["Adescription"].Width = 493;


            dgvActZirSarfasl.Columns["Abed"].Visible = true;
            dgvActZirSarfasl.Columns["Abed"].HeaderText = "بدهكاري";
            dgvActZirSarfasl.Columns["Abed"].DefaultCellStyle.Format = "#,0";
            dgvActZirSarfasl.Columns["Abed"].DefaultCellStyle.Font = new Font("IRANSans(FaNum)", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dgvActZirSarfasl.Columns["Abed"].Width = 125;

            dgvActZirSarfasl.Columns["Abes"].Visible = true;
            dgvActZirSarfasl.Columns["Abes"].HeaderText = "بستانكاري";
            dgvActZirSarfasl.Columns["Abes"].DefaultCellStyle.Format = "#,0";
            dgvActZirSarfasl.Columns["Abes"].DefaultCellStyle.Font = new Font("IRANSans(FaNum)", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dgvActZirSarfasl.Columns["Abes"].Width = 125;

            dgvActZirSarfasl.Columns["AMan"].Visible = true;
            dgvActZirSarfasl.Columns["AMan"].HeaderText = "مانده";
            dgvActZirSarfasl.Columns["AMan"].DefaultCellStyle.Format = "#,0";
            dgvActZirSarfasl.Columns["AMan"].DefaultCellStyle.Font = new Font("IRANSans(FaNum)", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dgvActZirSarfasl.Columns["AMan"].Width = 125;

            dgvActZirSarfasl.Columns["AManbed_bes"].Visible = true;
            dgvActZirSarfasl.Columns["AManbed_bes"].HeaderText = "تش";
            dgvActZirSarfasl.Columns["AManbed_bes"].Width = 30;

            dgvActZirSarfasl.Columns["AkindName"].Visible = true;
            dgvActZirSarfasl.Columns["AkindName"].HeaderText = "نوع عملكرد";
            dgvActZirSarfasl.Columns["AkindName"].Width = 150;

        }

        private void search()
        {
            if (dt != null && !_isSearch)
            {
                var filter = txtFilter.Text.Trim();
                List<SZAservice> dt1 = new List<SZAservice>();
                if (_choiseKind.Any())
                {
                    dt1 = dt.Where(c => c.Adescription.Contains(filter) && _choiseKind.Contains(c.Akind ?? 0)).ToList();
                }
                else
                {
                    dt1 = dt.Where(c => c.Adescription.Contains(filter)).ToList();
                }

                dgvActZirSarfasl.DataSource = dt1;
                var befor = dt1.FirstOrDefault(d => d.AID == 0) ?? new SZAservice();
                SetTextLabelFooter(dt1.Count, dt1.Sum(d => d.Abed), dt1.Sum(d => d.Abes), dt1.Sum(d => d.Abed - d.Abes));
            }
        }

        private void SetCheckBoxColumn()
        {
            if (dgvActZirSarfasl.SelectedRows.Count > 0)
            {
                var rowIndex = dgvActZirSarfasl.SelectedRows[0].Index;
                if (Convert.ToBoolean(dgvActZirSarfasl.SelectedRows[0].Cells["select"].Value) == false)
                {
                    dgvActZirSarfasl.Rows[rowIndex].Cells["select"].Value = true;
                    dgvActZirSarfasl.Rows[rowIndex].DefaultCellStyle.BackColor = Color.PaleTurquoise;
                    AddOrRemoveInListAndTextSelected(rowIndex, true);
                }
                else
                {
                    dgvActZirSarfasl.Rows[rowIndex].Cells["select"].Value = false;
                    dgvActZirSarfasl.Rows[rowIndex].DefaultCellStyle.BackColor = Color.White;
                    AddOrRemoveInListAndTextSelected(rowIndex, false);
                }
            }
        }

        private void AddOrRemoveInListAndTextSelected(int rowData, bool isAdded)
        {
            ListSelected.RemoveAll(i => i == (int)dgvActZirSarfasl.Rows[rowData].Cells["AID"].Value);

            if (isAdded)
            {
                ListSelected.Add((int)dgvActZirSarfasl.Rows[rowData].Cells["AID"].Value);
            }

            lblFooterNumber.Text = $"تعداد: {dgvActZirSarfasl.RowCount}\nتعداد انتخابي: {ListSelected.Count}";

        }

        private void ShowReportSanadAct()
        {
            if (dgvActZirSarfasl.SelectedRows.Count > 0)
            {


                #region Cod Me

                //SZAservice result = ((List<SZAservice>)dgvActZirSarfasl.DataSource).First(x =>
                //   x.AID == (int)dgvActZirSarfasl.SelectedRows[0].Cells["AID"].Value);
                //string firstText = "";
                //string secenText = "";
                //string TreeText = "";
                //var str1 = result.Adescription.Replace(" به ", ";");
                //str1 = str1.Replace("از ", "");
                //var str = str1.Split(';');

                //try
                //{
                //    firstText = str[0];

                //    str[1] = str[1].Replace(" بابت ", ";");
                //    str = str[1].Split(';');

                //    secenText = str[0];
                //    TreeText = str[1];
                //}
                //catch (Exception)
                //{
                //}

                //decimal Man = result.Abed - result.Abes;

                //var DateNow = DateTime.Now;
                //string today = pc.GetYear(DateNow).ToString("0000") + "/" + pc.GetMonth(DateNow).ToString("00") + "/" + pc.GetDayOfMonth(DateNow).ToString("00");
                //StiReport report = new StiReport();
                //report.Load(@"C:\Users\North-PC\Desktop\Report Sarfasl (Stimulsoft)\ReportSanadActZirSarfasl1.mrt");
                //report.Compile();
                //report["User"] = "alirezasadegghi";
                //report["today"] = today;
                //report["DateAct"] = result.Adate;
                //report["ASanad"] = result.Asanadno.ToString().Trim();
                //report["AUser"] = result.Auser;
                //report["Abes"] = Man >= 0 ? firstText.Trim() : secenText.Trim();
                //report["Abed"] = Man < 0 ? firstText.Trim() : secenText.Trim();
                //report["AMan"] = Math.Abs(Man);
                //report["AManPersian"] = ((int)Math.Abs(Man)).num2str().Trim() + " ريال";
                //report["ADis"] = TreeText.Trim();

                //report.Show();


                #endregion
                SZAservice result = ((List<SZAservice>)dgvActZirSarfasl.DataSource).First(x =>
                    x.AID == (int)dgvActZirSarfasl.SelectedRows[0].Cells["AID"].Value);
                var DateNow = DateTime.Now;
                string today = pc.GetYear(DateNow).ToString("0000") + "/" + pc.GetMonth(DateNow).ToString("00") + "/" + pc.GetDayOfMonth(DateNow).ToString("00");

                #region Cod Ateran

                StiReport report = new StiReport();

                report.Load(@"C:\Users\North-PC\Desktop\Report Sarfasl (Stimulsoft)\Atiran\ReportSabtDarSarFasl.mrt");
                report.Dictionary.Databases.Add(new StiSqlDatabase("Connection", "Integrated Security=True;Data Source=.;Initial Catalog=ZAnsari;Password=;User ID="));//Connections.ConnectionInfo.BuildStimulConnectionString()));
                report.Dictionary.Variables["user"].Value = "Alireza Sadeghi";//Connections.GetCurrentSysUser.Instance.user_name.ToString();
                report.Dictionary.Variables["today"].Value = today;//Atiran.Connections.DataService.DateTodayFullChar();
                report.Dictionary.Variables["Date"].Value = result.Adate;//SanadDocument.date;
                report.Dictionary.Variables["Ghno"].Value = result.Asanadno.ToString(); //SanadDocument.SanadNumber.ToString("#,0");
                report.Dictionary.Variables["sysid"].Value = 1.ToString();//Atiran.Reporting.BLL.ReturnMasirForosh.ReturnMasirName(Connections.ConnectionInfo.SysID);
                report.Dictionary.Variables["Mablagh"].Value = result.AMan.ToString("#,0");//(ActZirSarFaslHere.bed + ActZirSarFaslHere.bes).ToString("#,0");
                report.Dictionary.Variables["Babat"].Value = result.Adescription;//ActZirSarFaslHere.dis;
                report.Render();
                report.Show();

                #endregion
            }
        }

        private void SetTextLabelFooter(int number, decimal bed, decimal bes, decimal sumAll)
        {
            var befor = new SZAservice()
            {
                Abed = dt.Where(d => d.AID < 0).Sum(b => b.Abed),
                Abes = dt.Where(d => d.AID < 0).Sum(b => b.Abes)
            };
            decimal sum = sumAll - (befor.Abed - befor.Abes);
            string status1 = sum > 0 ? "بد" : sum == 0 ? "--" : "بس";
            string status2 = sumAll > 0 ? "بد" : sumAll == 0 ? "--" : "بس";

            lblFooterNumber.Text = $"تعداد: {number}\nتعداد انتخابي: {ListSelected.Count}";
            lblBedDate.Text = (bed - befor.Abed).ToMan();
            lblBesDate.Text = (bes - befor.Abes).ToMan();
            lblManDate.Text = $"{Math.Abs(sum).ToMan()} ({status1})";
            lblBed.Text = bed.ToMan();
            lblBes.Text = bes.ToMan();
            lblMan.Text = $"{ Math.Abs(sumAll).ToMan()} ({status2})";
        }


        #endregion
    }
}
