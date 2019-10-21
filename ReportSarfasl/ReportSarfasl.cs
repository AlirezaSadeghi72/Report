using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReportSarfasl.dataLayer;
using ReportSarfasl.Forms;
using ReportSarfasl.Services;
using Stimulsoft.Report;
using Stimulsoft.Report.Dictionary;


namespace ReportSarfasl
{
    public class reportSarfasl : UserControl
    {
        private List<int> _listGroupSar = new List<int>(), _listSar = new List<int>(), _listZirSar = new List<int>(), ListSelected = new List<int>();
        private bool _isSearch, _isKeySpase;
        private PersianCalendar pc = new PersianCalendar();
        private int _sarfaslIdSelected;
        private List<SZAservice> dt , dt0;
        private Button btnPrint;
        private Panel pnlFooter;
        private Panel pnlHeader;
        private Panel pnlMain;
        private GroupBox groupBox1;
        private Button btnShow;
        private TextBox txtZirSarfasl;
        private TextBox txtSarfasl;
        private Label lblSarfasls;
        private Button btnCancel;
        private TextDate textDate1;
        private Label lblFooterNumber;
        private CheckBox chbZirSarfasls;
        private CheckBox chbSarfasls;
        private Label label1;
        private DataGridView dgvSarfasl;
        private CheckBox chbChoiceModPrint;
        private Label lblLoding;
        private CheckBox chbAll;
        private DataGridViewCheckBoxColumn select;
        private CheckBox chbGroupSarfasl;
        private TextBox txtGroupSarfasl;
        private Label lblMan;
        private Label lblManSelect;
        private Label lblManDate;
        private Label lblBesSelect;
        private Label lblBesDate;
        private Label lblBedSelect;
        private Label lblBedDate;
        private Label label11;
        private Label label8;
        private Label label9;
        private Label label7;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txtFilter;


        public reportSarfasl()
        {
            InitializeComponent();

            lblFooterNumber.Text = $"تعداد: 0\nتعداد انتخابي: {ListSelected.Count}";
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chbAll = new System.Windows.Forms.CheckBox();
            this.lblLoding = new System.Windows.Forms.Label();
            this.chbZirSarfasls = new System.Windows.Forms.CheckBox();
            this.chbGroupSarfasl = new System.Windows.Forms.CheckBox();
            this.chbSarfasls = new System.Windows.Forms.CheckBox();
            this.textDate1 = new ReportSarfasl.TextDate();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSarfasls = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.txtZirSarfasl = new System.Windows.Forms.TextBox();
            this.txtGroupSarfasl = new System.Windows.Forms.TextBox();
            this.txtSarfasl = new System.Windows.Forms.TextBox();
            this.chbChoiceModPrint = new System.Windows.Forms.CheckBox();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.dgvSarfasl = new System.Windows.Forms.DataGridView();
            this.select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.lblFooterNumber = new System.Windows.Forms.Label();
            this.lblMan = new System.Windows.Forms.Label();
            this.lblManSelect = new System.Windows.Forms.Label();
            this.lblManDate = new System.Windows.Forms.Label();
            this.lblBesSelect = new System.Windows.Forms.Label();
            this.lblBesDate = new System.Windows.Forms.Label();
            this.lblBedSelect = new System.Windows.Forms.Label();
            this.lblBedDate = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
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
            this.pnlHeader.Size = new System.Drawing.Size(1266, 116);
            this.pnlHeader.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chbAll);
            this.groupBox1.Controls.Add(this.lblLoding);
            this.groupBox1.Controls.Add(this.chbZirSarfasls);
            this.groupBox1.Controls.Add(this.chbGroupSarfasl);
            this.groupBox1.Controls.Add(this.chbSarfasls);
            this.groupBox1.Controls.Add(this.textDate1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblSarfasls);
            this.groupBox1.Controls.Add(this.btnShow);
            this.groupBox1.Controls.Add(this.txtZirSarfasl);
            this.groupBox1.Controls.Add(this.txtGroupSarfasl);
            this.groupBox1.Controls.Add(this.txtSarfasl);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1266, 116);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // chbAll
            // 
            this.chbAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chbAll.AutoSize = true;
            this.chbAll.Location = new System.Drawing.Point(1161, 92);
            this.chbAll.Name = "chbAll";
            this.chbAll.Size = new System.Drawing.Size(86, 24);
            this.chbAll.TabIndex = 14;
            this.chbAll.Text = "انتخاب همه";
            this.chbAll.UseVisualStyleBackColor = true;
            this.chbAll.CheckedChanged += new System.EventHandler(this.chbAll_CheckedChanged);
            this.chbAll.KeyDown += new System.Windows.Forms.KeyEventHandler(this.chbAll_KeyDown);
            // 
            // lblLoding
            // 
            this.lblLoding.AutoSize = true;
            this.lblLoding.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblLoding.Location = new System.Drawing.Point(98, 75);
            this.lblLoding.Name = "lblLoding";
            this.lblLoding.Size = new System.Drawing.Size(89, 20);
            this.lblLoding.TabIndex = 13;
            this.lblLoding.Text = "درحال پردازش ...";
            this.lblLoding.Visible = false;
            // 
            // chbZirSarfasls
            // 
            this.chbZirSarfasls.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chbZirSarfasls.AutoSize = true;
            this.chbZirSarfasls.Location = new System.Drawing.Point(482, 63);
            this.chbZirSarfasls.Name = "chbZirSarfasls";
            this.chbZirSarfasls.Size = new System.Drawing.Size(94, 24);
            this.chbZirSarfasls.TabIndex = 8;
            this.chbZirSarfasls.Text = "زير سرفصل ها";
            this.chbZirSarfasls.UseVisualStyleBackColor = true;
            this.chbZirSarfasls.CheckedChanged += new System.EventHandler(this.chbZirSarfasls_CheckedChanged);
            this.chbZirSarfasls.KeyDown += new System.Windows.Forms.KeyEventHandler(this.chbZirSarfasls_KeyDown);
            // 
            // chbGroupSarfasl
            // 
            this.chbGroupSarfasl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chbGroupSarfasl.AutoSize = true;
            this.chbGroupSarfasl.Location = new System.Drawing.Point(1157, 63);
            this.chbGroupSarfasl.Name = "chbGroupSarfasl";
            this.chbGroupSarfasl.Size = new System.Drawing.Size(101, 24);
            this.chbGroupSarfasl.TabIndex = 6;
            this.chbGroupSarfasl.Text = "گروه سرفصل ها";
            this.chbGroupSarfasl.UseVisualStyleBackColor = true;
            this.chbGroupSarfasl.CheckedChanged += new System.EventHandler(this.chbGroupSarfasl_CheckedChanged);
            this.chbGroupSarfasl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.chbGroupSarfasl_KeyDown);
            // 
            // chbSarfasls
            // 
            this.chbSarfasls.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chbSarfasls.AutoSize = true;
            this.chbSarfasls.Location = new System.Drawing.Point(827, 63);
            this.chbSarfasls.Name = "chbSarfasls";
            this.chbSarfasls.Size = new System.Drawing.Size(78, 24);
            this.chbSarfasls.TabIndex = 6;
            this.chbSarfasls.Text = "سرفصل ها";
            this.chbSarfasls.UseVisualStyleBackColor = true;
            this.chbSarfasls.CheckedChanged += new System.EventHandler(this.chbSarfasls_CheckedChanged);
            this.chbSarfasls.KeyDown += new System.Windows.Forms.KeyEventHandler(this.chbSarfasls_KeyDown);
            // 
            // textDate1
            // 
            this.textDate1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textDate1.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textDate1.FromDate = "1398/07/28";
            this.textDate1.Location = new System.Drawing.Point(861, 23);
            this.textDate1.Name = "textDate1";
            this.textDate1.Size = new System.Drawing.Size(394, 24);
            this.textDate1.TabIndex = 0;
            this.textDate1.ToDate = "1398/07/28";
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
            this.btnShow.BackColor = System.Drawing.Color.Indigo;
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnShow.ForeColor = System.Drawing.Color.White;
            this.btnShow.Location = new System.Drawing.Point(12, 68);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(80, 34);
            this.btnShow.TabIndex = 10;
            this.btnShow.Text = "نمایش";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            this.btnShow.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnShow_KeyDown);
            // 
            // txtZirSarfasl
            // 
            this.txtZirSarfasl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtZirSarfasl.Location = new System.Drawing.Point(209, 61);
            this.txtZirSarfasl.Name = "txtZirSarfasl";
            this.txtZirSarfasl.ReadOnly = true;
            this.txtZirSarfasl.Size = new System.Drawing.Size(267, 28);
            this.txtZirSarfasl.TabIndex = 9;
            this.txtZirSarfasl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtZirSarfasl.Enter += new System.EventHandler(this.textBox_Enter);
            this.txtZirSarfasl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtZirSarfasl_KeyDown);
            this.txtZirSarfasl.Leave += new System.EventHandler(this.textBox_Leave);
            // 
            // txtGroupSarfasl
            // 
            this.txtGroupSarfasl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGroupSarfasl.Location = new System.Drawing.Point(911, 61);
            this.txtGroupSarfasl.Name = "txtGroupSarfasl";
            this.txtGroupSarfasl.ReadOnly = true;
            this.txtGroupSarfasl.Size = new System.Drawing.Size(240, 28);
            this.txtGroupSarfasl.TabIndex = 7;
            this.txtGroupSarfasl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtGroupSarfasl.Enter += new System.EventHandler(this.textBox_Enter);
            this.txtGroupSarfasl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtGroupSarfasl_KeyDown);
            this.txtGroupSarfasl.Leave += new System.EventHandler(this.textBox_Leave);
            // 
            // txtSarfasl
            // 
            this.txtSarfasl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSarfasl.Location = new System.Drawing.Point(581, 61);
            this.txtSarfasl.Name = "txtSarfasl";
            this.txtSarfasl.ReadOnly = true;
            this.txtSarfasl.Size = new System.Drawing.Size(240, 28);
            this.txtSarfasl.TabIndex = 7;
            this.txtSarfasl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSarfasl.Enter += new System.EventHandler(this.textBox_Enter);
            this.txtSarfasl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSarfasl_KeyDown);
            this.txtSarfasl.Leave += new System.EventHandler(this.textBox_Leave);
            // 
            // chbChoiceModPrint
            // 
            this.chbChoiceModPrint.AutoSize = true;
            this.chbChoiceModPrint.Location = new System.Drawing.Point(188, 10);
            this.chbChoiceModPrint.Name = "chbChoiceModPrint";
            this.chbChoiceModPrint.Size = new System.Drawing.Size(145, 24);
            this.chbChoiceModPrint.TabIndex = 12;
            this.chbChoiceModPrint.Text = "چاپ گزارش با زيرسرفصل";
            this.chbChoiceModPrint.UseVisualStyleBackColor = true;
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.dgvSarfasl);
            this.pnlMain.Controls.Add(this.txtFilter);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 116);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1266, 425);
            this.pnlMain.TabIndex = 1;
            // 
            // dgvSarfasl
            // 
            this.dgvSarfasl.AllowUserToAddRows = false;
            this.dgvSarfasl.AllowUserToDeleteRows = false;
            this.dgvSarfasl.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvSarfasl.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSarfasl.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvSarfasl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSarfasl.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.select});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSarfasl.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgvSarfasl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSarfasl.EnableHeadersVisualStyles = false;
            this.dgvSarfasl.Location = new System.Drawing.Point(0, 28);
            this.dgvSarfasl.MultiSelect = false;
            this.dgvSarfasl.Name = "dgvSarfasl";
            this.dgvSarfasl.ReadOnly = true;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSarfasl.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvSarfasl.RowHeadersVisible = false;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            this.dgvSarfasl.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvSarfasl.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSarfasl.Size = new System.Drawing.Size(1266, 397);
            this.dgvSarfasl.TabIndex = 1;
            this.dgvSarfasl.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSarfasl_CellClick);
            this.dgvSarfasl.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSarfasl_CellDoubleClick);
            this.dgvSarfasl.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvSarfasl_DataBindingComplete);
            this.dgvSarfasl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvSarfasl_KeyDown);
            // 
            // select
            // 
            this.select.FillWeight = 10F;
            this.select.HeaderText = "";
            this.select.Name = "select";
            this.select.ReadOnly = true;
            this.select.Visible = false;
            this.select.Width = 49;
            // 
            // txtFilter
            // 
            this.txtFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtFilter.Location = new System.Drawing.Point(0, 0);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(1266, 28);
            this.txtFilter.TabIndex = 11;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            this.txtFilter.Enter += new System.EventHandler(this.textBox_Enter);
            this.txtFilter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFilter_KeyDown);
            this.txtFilter.Leave += new System.EventHandler(this.textBox_Leave);
            // 
            // pnlFooter
            // 
            this.pnlFooter.Controls.Add(this.lblMan);
            this.pnlFooter.Controls.Add(this.lblManSelect);
            this.pnlFooter.Controls.Add(this.lblManDate);
            this.pnlFooter.Controls.Add(this.lblBesSelect);
            this.pnlFooter.Controls.Add(this.lblBesDate);
            this.pnlFooter.Controls.Add(this.lblBedSelect);
            this.pnlFooter.Controls.Add(this.lblBedDate);
            this.pnlFooter.Controls.Add(this.label11);
            this.pnlFooter.Controls.Add(this.label8);
            this.pnlFooter.Controls.Add(this.label9);
            this.pnlFooter.Controls.Add(this.label7);
            this.pnlFooter.Controls.Add(this.label5);
            this.pnlFooter.Controls.Add(this.label4);
            this.pnlFooter.Controls.Add(this.label3);
            this.pnlFooter.Controls.Add(this.btnCancel);
            this.pnlFooter.Controls.Add(this.chbChoiceModPrint);
            this.pnlFooter.Controls.Add(this.btnPrint);
            this.pnlFooter.Controls.Add(this.lblFooterNumber);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 541);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(1266, 59);
            this.pnlFooter.TabIndex = 2;
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Location = new System.Drawing.Point(22, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 30);
            this.btnCancel.TabIndex = 14;
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
            this.btnPrint.TabIndex = 13;
            this.btnPrint.Text = "چاپ";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // lblFooterNumber
            // 
            this.lblFooterNumber.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblFooterNumber.Location = new System.Drawing.Point(1161, 0);
            this.lblFooterNumber.Name = "lblFooterNumber";
            this.lblFooterNumber.Size = new System.Drawing.Size(105, 59);
            this.lblFooterNumber.TabIndex = 11;
            this.lblFooterNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMan
            // 
            this.lblMan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMan.Location = new System.Drawing.Point(362, 29);
            this.lblMan.Name = "lblMan";
            this.lblMan.Size = new System.Drawing.Size(114, 20);
            this.lblMan.TabIndex = 46;
            this.lblMan.Text = "0";
            this.lblMan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblManSelect
            // 
            this.lblManSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblManSelect.Location = new System.Drawing.Point(567, 6);
            this.lblManSelect.Name = "lblManSelect";
            this.lblManSelect.Size = new System.Drawing.Size(114, 20);
            this.lblManSelect.TabIndex = 45;
            this.lblManSelect.Text = "0";
            this.lblManSelect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblManDate
            // 
            this.lblManDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblManDate.Location = new System.Drawing.Point(567, 29);
            this.lblManDate.Name = "lblManDate";
            this.lblManDate.Size = new System.Drawing.Size(114, 20);
            this.lblManDate.TabIndex = 44;
            this.lblManDate.Text = "0";
            this.lblManDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBesSelect
            // 
            this.lblBesSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBesSelect.Location = new System.Drawing.Point(730, 6);
            this.lblBesSelect.Name = "lblBesSelect";
            this.lblBesSelect.Size = new System.Drawing.Size(114, 20);
            this.lblBesSelect.TabIndex = 43;
            this.lblBesSelect.Text = "0";
            this.lblBesSelect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBesDate
            // 
            this.lblBesDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBesDate.Location = new System.Drawing.Point(730, 29);
            this.lblBesDate.Name = "lblBesDate";
            this.lblBesDate.Size = new System.Drawing.Size(114, 20);
            this.lblBesDate.TabIndex = 42;
            this.lblBesDate.Text = "0";
            this.lblBesDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBedSelect
            // 
            this.lblBedSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBedSelect.Location = new System.Drawing.Point(917, 6);
            this.lblBedSelect.Name = "lblBedSelect";
            this.lblBedSelect.Size = new System.Drawing.Size(114, 20);
            this.lblBedSelect.TabIndex = 41;
            this.lblBedSelect.Text = "0";
            this.lblBedSelect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBedDate
            // 
            this.lblBedDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBedDate.Location = new System.Drawing.Point(917, 29);
            this.lblBedDate.Name = "lblBedDate";
            this.lblBedDate.Size = new System.Drawing.Size(114, 20);
            this.lblBedDate.TabIndex = 40;
            this.lblBedDate.Text = "0";
            this.lblBedDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(482, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 20);
            this.label11.TabIndex = 39;
            this.label11.Text = "مانده كل:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(687, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 20);
            this.label8.TabIndex = 38;
            this.label8.Text = "مانده:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(687, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 20);
            this.label9.TabIndex = 37;
            this.label9.Text = "مانده:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(850, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 20);
            this.label7.TabIndex = 36;
            this.label7.Text = "بستانكاري:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(850, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 35;
            this.label5.Text = "بستانكاري:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1037, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 20);
            this.label4.TabIndex = 47;
            this.label4.Text = "انتخابي:        بدهكاري:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1037, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 20);
            this.label3.TabIndex = 48;
            this.label3.Text = "دربازه:            بدهكاري:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // reportSarfasl
            // 
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlFooter);
            this.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Name = "reportSarfasl";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(1266, 600);
            this.pnlHeader.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSarfasl)).EndInit();
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            this.ResumeLayout(false);

        }

        #region Event Controls

        private void textDate1_KeyEnterTextBoxToYear(object sender, EventArgs e)
        {
            chbGroupSarfasl.Focus();
        }

        private void chbGroupSarfasl_CheckedChanged(object sender, EventArgs e)
        {
            if (chbGroupSarfasl.Checked)
            {
                ShowList(1);
                txtGroupSarfasl.Focus();
                chbSarfasls.Checked = false;
                chbZirSarfasls.Checked = false;
            }
            else
            {
                txtGroupSarfasl.Text = "";
                _listGroupSar.Clear();
            }
        }
        private void chbGroupSarfasl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                txtGroupSarfasl.Focus();
        }
        private void txtGroupSarfasl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                chbSarfasls.Focus();
            }
        }

        private void chbSarfasls_CheckedChanged(object sender, EventArgs e)
        {
            if (chbSarfasls.Checked)
            {
                ShowList(2);
                txtSarfasl.Focus();
                chbZirSarfasls.Checked = false;
            }
            else
            {
                txtSarfasl.Text = "";
                _listSar.Clear();
            }

        }
        private void chbSarfasls_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                txtSarfasl.Focus();
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
                ShowList(3);
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
            if (e.KeyData == Keys.Enter)
                txtZirSarfasl.Focus();
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

            lblLoding.Visible = true;

            ListSelected.Clear();

            Thread tGetdata = new Thread(() =>
            {
                dt = conection.GetSZAServices(textDate1.FromDate,
                            textDate1.ToDate, _listZirSar, _listSar, _listGroupSar);
            });
            tGetdata.Start();
            tGetdata.Join();
            //dt = conection.GetZirSarfaslServices1(_listSar, _listZirSar, textDate1.FromDate, textDate1.ToDate);
            int row = 1;
            dgvSarfasl.DataSource = dt0  = dt.GroupBy(g => new
            {
                g.SID,
                g.SGroupSarfaslName,
                g.SGroupSarfaslID,
                g.SName,
                g.Sbed,
                g.Sbes,
                g.SMan,
                g.Sbed_bes,
                g.SMan_Befor,
                g.Sbed_bes_Befor,
                g.SMan_All,
                g.Sbed_bes_All,
                g.Shas_dar,
                g.Swho_def
            }).Select(g => new SZAservice()
            {
                Srow = row++,
                SID = g.Key.SID,
                SGroupSarfaslName = g.Key.SGroupSarfaslName,
                SGroupSarfaslID = g.Key.SGroupSarfaslID,
                SName = g.Key.SName,
                Sbed = g.Key.Sbed,
                Sbes = g.Key.Sbes,
                SMan = g.Key.SMan,
                Sbed_bes = g.Key.Sbed_bes,
                SMan_Befor = g.Key.SMan_Befor,
                Sbed_bes_Befor = g.Key.Sbed_bes_Befor,
                SMan_All = g.Key.SMan_All,
                Sbed_bes_All = g.Key.Sbed_bes_All,
                Shas_dar = g.Key.Shas_dar,
                Swho_def = g.Key.Swho_def
            }).ToList();
            chbAll.Checked = false;
            SetTextLabelFooter(dt0.Count, dt0.Sum(d => d.Sbed), dt0.Sum(d => d.Sbes), dt0.Sum(d => d.SMan), dt0.Sum(d => d.SMan_All));
            SetGrid();
            txtFilter.Focus();
            lblLoding.Visible = false;
        }
        private void btnShow_KeyDown(object sender, KeyEventArgs e)
        {
            btnShow_Click(sender, e);
        }

        private void chbAll_CheckedChanged(object sender, EventArgs e)
        {
            List<int> list1 = ((List<SZAservice>)dgvSarfasl.DataSource).Select(a => a.SID).ToList();
            ListSelected.RemoveAll(x => list1.Contains(x));
            if (chbAll.Checked)
            {
                ListSelected.AddRange(list1);

                foreach (DataGridViewRow row in dgvSarfasl.Rows)
                {
                    row.Cells["select"].Value = true;
                    row.DefaultCellStyle.BackColor = Color.PaleTurquoise;
                }
            }
            else
            {
                foreach (DataGridViewRow row in dgvSarfasl.Rows)
                {
                    row.Cells["select"].Value = false;
                    row.DefaultCellStyle.BackColor = Color.White;
                }
            }

            SetTextLabelFooter();
            //lblFooterNumber.Text = $"تعداد: {dgvSarfasl.RowCount}\nتعداد انتخابي: {ListSelected.Count}";

        }
        private void chbAll_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtFilter.Focus();
            }
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
                if ((txtFilter.Text.Trim() == "") || (dgvSarfasl.Rows.Count == 1))
                {
                    _isKeySpase = true;
                    SetCheckBoxColumn();
                    txtFilter.Text = "";
                }
            }
            //else if (e.KeyCode == Keys.Left && txtFilter.Text.Trim() == "")
            //{
            //    if(dgvSarfasl.DataSource != null)
            //    dgvSarfasl.Columns["Name"].Width = dgvSarfasl.Columns["Name"].Width + 1;
            //}
            //else if (e.KeyCode == Keys.Right && txtFilter.Text.Trim() == "")
            //{
            //    if (dgvSarfasl.DataSource != null)
            //        dgvSarfasl.Columns["Name"].Width = dgvSarfasl.Columns["Name"].Width - 1;
            //}
            else if (dgvSarfasl.Rows.Count > 0)
            {
                if (e.KeyData == Keys.Enter)
                {
                    ShowReportZirSarfasl(dgvSarfasl.SelectedRows[0].Cells["SName"].Value.ToString());
                }
                else if (e.Alt && e.KeyCode == Keys.F3)
                {
                    ShowReportActZirSarfasl(dgvSarfasl.SelectedRows[0].Cells["SName"].Value.ToString());
                }
                else
                {
                    int countRowGrid = dgvSarfasl.Rows.Count;
                    int rowIndexSelected = dgvSarfasl.SelectedRows[0].Index;
                    if (e.KeyCode == Keys.Up)
                    {
                        _isSearch = true;
                        txtFilter.Text = "";
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
                        _isSearch = true;
                        txtFilter.Text = "";
                        dgvSarfasl.Rows[(rowIndexSelected + 1) % countRowGrid].Cells[0].Selected = true;
                    }
                    else
                    {
                        _isSearch = false;
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
            (sender as TextBox).BackColor = ((sender as TextBox).Name == "txtFilter") ? Color.White : SystemColors.Control;
        }

        #region Event Control Data Grid View

        private void dgvSarfasl_KeyDown(object sender, KeyEventArgs e)
        {
            if (dgvSarfasl.SelectedRows.Count > 0)
            {
                if (e.KeyCode == Keys.Space)
                {
                    _isKeySpase = true;
                    SetCheckBoxColumn();
                }
                else if (e.Alt && e.KeyCode == Keys.F3)
                {
                    ShowReportActZirSarfasl(dgvSarfasl.SelectedRows[0].Cells["SName"].Value.ToString());
                }
                else if (e.KeyCode == Keys.Enter)
                {
                    ShowReportZirSarfasl(dgvSarfasl.SelectedRows[0].Cells["SName"].Value.ToString());
                }
            }
        }
        private void dgvSarfasl_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!_isKeySpase && e.RowIndex >= 0 && e.ColumnIndex == 0)
                SetCheckBoxColumn();

            _isKeySpase = false;
        }
        private void dgvSarfasl_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSarfasl.SelectedRows.Count > 0)
            {
                ShowReportZirSarfasl(dgvSarfasl.SelectedRows[0].Cells["SName"].Value.ToString());
            }
        }
        private void dgvSarfasl_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in dgvSarfasl.Rows)
            {
                row.Cells["SMan"].Value = Math.Abs((decimal)row.Cells["SMan"].Value).ToString();
                row.Cells["SMan_Befor"].Value = Math.Abs((decimal)row.Cells["SMan_Befor"].Value).ToString();
                row.Cells["SMan_All"].Value = Math.Abs((decimal)row.Cells["SMan_All"].Value).ToString();

                if (ListSelected.Any(i => i == (int)row.Cells["SID"].Value))
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
            List<SZAservice> dt1 = dt0;

            if (ListSelected.Count > 0)
            {
                dt1 = dt0.Where(d => ListSelected.Contains(d.SID)).ToList();
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
            if (chbChoiceModPrint.Checked)
            {
                report.Load(@"C:\Users\North-PC\Desktop\Report Sarfasl (Stimulsoft)\Atiran\ReportSarfasl1.mrt");
            }
            else
            {
                report.Load(@"C:\Users\North-PC\Desktop\Report Sarfasl (Stimulsoft)\Atiran\ReportSarfasl1_1.mrt");

                if (dt1 != null)
                {
                    var filter = txtFilter.Text.Trim();
                    int row = 1;
                    dt1 = dt1.Where(c => c.SName.Contains(filter)).ToList();
                }
            }
            //report.Dictionary.Databases.Add(new StiSqlDatabase("Connection", "Integrated Security=True;Data Source=.;Initial Catalog=ZAnsari;Password=;User ID="));//Connections.ConnectionInfo.BuildStimulConnectionString()));
            //report.Compile();
            report.Dictionary.Variables["User"].Value = "alirezasadegghi";
            report.Dictionary.Variables["today"].Value = today;
            report.Dictionary.Variables["FromDate"].Value = textDate1.FromDate;
            report.Dictionary.Variables["ToDate"].Value = textDate1.ToDate;
            report.RegBusinessObject("SZA", dt1);
            report["IsZirSarfasl"] = false;
            report.Render();
            report.Show();

            //END1:;
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
            if (keyData == Keys.Escape)
            {
                ((Form)this.TopLevelControl).Close();
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        #endregion

        #region Method

        public void SetGrid()
        {
            foreach (DataGridViewColumn col in dgvSarfasl.Columns)
            {
                col.Visible = false;
                //col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            }
            //foreach (DataGridViewRow row in dgvSarfasl.Rows) row.Cells["row"].Value = row.Index + 1;

            dgvSarfasl.Columns["select"].Visible = true;
            dgvSarfasl.Columns["select"].Width = 25;

            dgvSarfasl.Columns["Srow"].Visible = true;
            dgvSarfasl.Columns["Srow"].HeaderText = "رديف";
            dgvSarfasl.Columns["Srow"].Width = 40;

            dgvSarfasl.Columns["SGroupSarfaslName"].Visible = true;
            dgvSarfasl.Columns["SGroupSarfaslName"].HeaderText = "نام گروه";
            dgvSarfasl.Columns["SGroupSarfaslName"].Width = 80;


            dgvSarfasl.Columns["SName"].Visible = true;
            dgvSarfasl.Columns["SName"].HeaderText = "نام";
            dgvSarfasl.Columns["SName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvSarfasl.Columns["Shas_dar"].Visible = true;
            dgvSarfasl.Columns["Shas_dar"].HeaderText = "ماهيت";
            dgvSarfasl.Columns["Shas_dar"].Width = 60;

            dgvSarfasl.Columns["Swho_def"].Visible = true;
            dgvSarfasl.Columns["Swho_def"].HeaderText = "كاربر";
            dgvSarfasl.Columns["Swho_def"].Width = 60;

            dgvSarfasl.Columns["Sbed"].Visible = true;
            dgvSarfasl.Columns["Sbed"].HeaderText = "بدهكار";
            dgvSarfasl.Columns["Sbed"].DefaultCellStyle.Format = "#,0";
            dgvSarfasl.Columns["Sbed"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvSarfasl.Columns["Sbes"].Visible = true;
            dgvSarfasl.Columns["Sbes"].HeaderText = "بستانكار";
            dgvSarfasl.Columns["Sbes"].DefaultCellStyle.Format = "#,0";
            dgvSarfasl.Columns["Sbes"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvSarfasl.Columns["SMan"].Visible = true;
            dgvSarfasl.Columns["SMan"].HeaderText = "مانده اين بازه";
            dgvSarfasl.Columns["SMan"].DefaultCellStyle.Format = "#,0";
            dgvSarfasl.Columns["SMan"].DefaultCellStyle.Font = new Font("IRANSans(FaNum)", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dgvSarfasl.Columns["SMan"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvSarfasl.Columns["Sbed_bes"].Visible = true;
            dgvSarfasl.Columns["Sbed_bes"].HeaderText = "تش";
            dgvSarfasl.Columns["Sbed_bes"].Width = 30;

            dgvSarfasl.Columns["SMan_Befor"].Visible = true;
            dgvSarfasl.Columns["SMan_Befor"].HeaderText = "مانده قبلي";
            dgvSarfasl.Columns["SMan_Befor"].DefaultCellStyle.Format = "#,0";
            dgvSarfasl.Columns["SMan_Befor"].DefaultCellStyle.Font = new Font("IRANSans(FaNum)", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dgvSarfasl.Columns["SMan_Befor"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvSarfasl.Columns["Sbed_bes_Befor"].Visible = true;
            dgvSarfasl.Columns["Sbed_bes_Befor"].HeaderText = "تش";
            dgvSarfasl.Columns["Sbed_bes_Befor"].Width = 30;

            dgvSarfasl.Columns["SMan_All"].Visible = true;
            dgvSarfasl.Columns["SMan_All"].HeaderText = "مانده كل";
            dgvSarfasl.Columns["SMan_All"].DefaultCellStyle.Format = "#,0";
            dgvSarfasl.Columns["SMan_All"].DefaultCellStyle.Font = new Font("IRANSans(FaNum)", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dgvSarfasl.Columns["SMan_All"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvSarfasl.Columns["Sbed_bes_All"].Visible = true;
            dgvSarfasl.Columns["Sbed_bes_All"].HeaderText = "تش";
            dgvSarfasl.Columns["Sbed_bes_All"].Width = 30;
        }

        private void search()
        {
            if (dt != null && !_isSearch)
            {
                var filter = txtFilter.Text.Trim();
                int row = 1;
                var dt1 = dt0.Where(c => c.SName.Contains(filter)).ToList();
                dgvSarfasl.DataSource = dt1.ToList();

                SetTextLabelFooter(dt1.Count, dt1.Sum(d=>d.Sbed),dt1.Sum(d=>d.Sbes),dt1.Sum(d => d.SMan), dt1.Sum(d => d.SMan_All));
            }
        }

        private void ShowList(int choice)
        {
            DefultForm listForm = new DefultForm();
            ListSafaslaOrZirSarfasls _list = choice == 1
                ?
                new ListSafaslaOrZirSarfasls(1, _listGroupSar, txtGroupSarfasl.Text)
                : choice == 2
                    ? new ListSafaslaOrZirSarfasls(2, _listSar, txtSarfasl.Text, listGroupSarfasl: _listGroupSar)
                    :
                    new ListSafaslaOrZirSarfasls(3, _listZirSar, txtZirSarfasl.Text, _listGroupSar, _listSar);
            listForm.ShowDialog(_list, new Size(800, 500));

            switch (choice)
            {
                case 1:
                    {
                        txtGroupSarfasl.Text = _list.lblTextSelected.Text;
                        _listGroupSar = _list.ListSelected;
                        break;
                    }
                case 2:
                    {
                        txtSarfasl.Text = _list.lblTextSelected.Text;
                        _listSar = _list.ListSelected;
                        break;
                    }
                case 3:
                    {
                        txtZirSarfasl.Text = _list.lblTextSelected.Text;
                        _listZirSar = _list.ListSelected;
                        break;
                    }
            }
        }

        private void SetCheckBoxColumn()
        {
            if (dgvSarfasl.SelectedRows.Count > 0)
            {
                var rowIndex = dgvSarfasl.SelectedRows[0].Index;
                if (Convert.ToBoolean(dgvSarfasl.SelectedRows[0].Cells["select"].Value) == false)
                {
                    dgvSarfasl.Rows[rowIndex].Cells["select"].Value = true;
                    dgvSarfasl.Rows[rowIndex].DefaultCellStyle.BackColor = Color.PaleTurquoise;
                    AddOrRemoveInListAndTextSelected(rowIndex, true);
                }
                else
                {
                    dgvSarfasl.Rows[rowIndex].Cells["select"].Value = false;
                    dgvSarfasl.Rows[rowIndex].DefaultCellStyle.BackColor = Color.White;
                    AddOrRemoveInListAndTextSelected(rowIndex, false);
                }
            }
        }

        private void AddOrRemoveInListAndTextSelected(int rowData, bool isAdded)
        {
            ListSelected.RemoveAll(i => i == (int)dgvSarfasl.Rows[rowData].Cells["SID"].Value);

            if (isAdded)
            {
                ListSelected.Add((int)dgvSarfasl.Rows[rowData].Cells["SID"].Value);
            }
            SetTextLabelFooter();
            //lblFooterNumber.Text = $"تعداد: {dgvSarfasl.RowCount}\nتعداد انتخابي: {ListSelected.Count}";
        }

        private void ShowReportZirSarfasl(string NameSarfasl)
        {
            _sarfaslIdSelected = (int)dgvSarfasl.SelectedRows[0].Cells["SID"].Value;
            DefultForm reportZirSarfasl = new DefultForm();
            reportZirSarfasl.ShowDialog(new ReportZirSarfasl(_listZirSar, _sarfaslIdSelected, NameSarfasl, textDate1.FromDate, textDate1.ToDate), new Size(1360, 714));
        }

        private void ShowReportActZirSarfasl(string NameSarfasl)
        {
            _sarfaslIdSelected = (int)dgvSarfasl.SelectedRows[0].Cells["SID"].Value;
            DefultForm reportActZirSarfasl = new DefultForm();
            reportActZirSarfasl.ShowDialog(new ReportActZirSarfasl(textDate1.FromDate, textDate1.ToDate, NameSarfasl, _sarfaslIdSelected, listZirsarfasl: _listZirSar), new Size(1360, 714));
        }

        //private void SetTextLabelFooter(int number, decimal sum, decimal sumAll)
        //{
        //    string status1 = sum > 0 ? "بد" : sum == 0 ? "--" : "بس";
        //    string status2 = sumAll > 0 ? "بد" : sumAll == 0 ? "--" : "بس";

        //    lblFooterNumber.Text = $"تعداد: {number}\nتعداد انتخابي: {ListSelected.Count}";
        //    lblFooter.Text = $"   مانده در بازه: {Math.Abs(sum).ToMan()} ({status1})\n   مانده كل : {Math.Abs(sumAll).ToMan()} ({status2})";
        //}

        private void SetTextLabelFooter(int number, decimal bed, decimal bes, decimal sum, decimal sumAll)
        {

            decimal bedSelect = dt.Where(d => ListSelected.Contains(d.ZID)).Sum(d => d.Zbed);
            decimal besSelect = dt.Where(d => ListSelected.Contains(d.ZID)).Sum(d => d.Zbes);
            decimal sumSelect = bedSelect - besSelect;
            string status0 = sumSelect > 0 ? "بد" : sumSelect == 0 ? "--" : "بس";
            string status1 = sum > 0 ? "بد" : sum == 0 ? "--" : "بس";
            string status2 = sumAll > 0 ? "بد" : sumAll == 0 ? "--" : "بس";


            lblFooterNumber.Text = $"تعداد: {number}\nتعداد انتخابي: {ListSelected.Count}";
            lblBedSelect.Text = (bedSelect).ToMan();
            lblBesSelect.Text = (besSelect).ToMan();
            lblManSelect.Text = $"{Math.Abs(sumSelect).ToMan()} ({status0})";
            lblBedDate.Text = (bed).ToMan();
            lblBesDate.Text = (bes).ToMan();
            lblManDate.Text = $"{Math.Abs(sum).ToMan()} ({status1})";

            lblMan.Text = $"{ Math.Abs(sumAll).ToMan()} ({status2})";
        }
        private void SetTextLabelFooter()
        {
            decimal bedSelect = dt0.Where(d => ListSelected.Contains(d.SID)).Sum(d => d.Sbed);
            decimal besSelect = dt0.Where(d => ListSelected.Contains(d.SID)).Sum(d => d.Sbes);
            decimal sumSelect = bedSelect - besSelect;
            string status0 = sumSelect > 0 ? "بد" : sumSelect == 0 ? "--" : "بس";

            lblFooterNumber.Text = $"تعداد: {dgvSarfasl.RowCount}\nتعداد انتخابي: {ListSelected.Count}";
            lblBedSelect.Text = (bedSelect).ToMan();
            lblBesSelect.Text = (besSelect).ToMan();
            lblManSelect.Text = $"{Math.Abs(sumSelect).ToMan()} ({status0})";
        }


        #endregion
    }
}