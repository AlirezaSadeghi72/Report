﻿using System;
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
        private List<SZAservice> dt , dt0;
        private string _nameSarfasl;
        private Panel pnlMain;
        private Button btnCancel;
        private Button btnPrint;
        private GroupBox gbHeader;
        private TextBox txtFilter;
        private DataGridView dgvZirSarfal;
        private TextDate textDate1;
        private Label lblFooterNumber;
        private Label lblLoding;
        private CheckBox chbAll;
        private DataGridViewCheckBoxColumn select;
        private Panel panel1;
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
            this.lblFooterNumber = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlMain.SuspendLayout();
            this.gbHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZirSarfal)).BeginInit();
            this.pnlFooter.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.gbHeader);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1169, 440);
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
            this.gbHeader.Size = new System.Drawing.Size(1169, 440);
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
            this.dgvZirSarfal.Size = new System.Drawing.Size(1163, 337);
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
            this.txtFilter.Size = new System.Drawing.Size(1163, 28);
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
            this.chbAll.Size = new System.Drawing.Size(1163, 24);
            this.chbAll.TabIndex = 15;
            this.chbAll.Text = "انتخاب همه";
            this.chbAll.UseVisualStyleBackColor = true;
            this.chbAll.CheckedChanged += new System.EventHandler(this.chbAll_CheckedChanged);
            this.chbAll.KeyDown += new System.Windows.Forms.KeyEventHandler(this.chbAll_KeyDown);
            // 
            // lblLoding
            // 
            this.lblLoding.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLoding.AutoSize = true;
            this.lblLoding.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblLoding.Location = new System.Drawing.Point(759, 25);
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
            this.textDate1.FromDate = "1398/07/28";
            this.textDate1.Location = new System.Drawing.Point(3, 24);
            this.textDate1.Name = "textDate1";
            this.textDate1.Size = new System.Drawing.Size(1163, 24);
            this.textDate1.TabIndex = 2;
            this.textDate1.ToDate = "1398/07/28";
            this.textDate1.KeyEnterTextBoxToYear += new System.EventHandler(this.textDate1_KeyEnterTextBoxToYear);
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
            this.pnlFooter.Controls.Add(this.lblFooterNumber);
            this.pnlFooter.Controls.Add(this.panel1);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 440);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(1169, 60);
            this.pnlFooter.TabIndex = 2;
            // 
            // lblMan
            // 
            this.lblMan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMan.Location = new System.Drawing.Point(275, 29);
            this.lblMan.Name = "lblMan";
            this.lblMan.Size = new System.Drawing.Size(114, 20);
            this.lblMan.TabIndex = 32;
            this.lblMan.Text = "0";
            this.lblMan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblManSelect
            // 
            this.lblManSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblManSelect.Location = new System.Drawing.Point(475, 6);
            this.lblManSelect.Name = "lblManSelect";
            this.lblManSelect.Size = new System.Drawing.Size(114, 20);
            this.lblManSelect.TabIndex = 31;
            this.lblManSelect.Text = "0";
            this.lblManSelect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblManDate
            // 
            this.lblManDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblManDate.Location = new System.Drawing.Point(475, 29);
            this.lblManDate.Name = "lblManDate";
            this.lblManDate.Size = new System.Drawing.Size(114, 20);
            this.lblManDate.TabIndex = 30;
            this.lblManDate.Text = "0";
            this.lblManDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBesSelect
            // 
            this.lblBesSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBesSelect.Location = new System.Drawing.Point(638, 6);
            this.lblBesSelect.Name = "lblBesSelect";
            this.lblBesSelect.Size = new System.Drawing.Size(114, 20);
            this.lblBesSelect.TabIndex = 29;
            this.lblBesSelect.Text = "0";
            this.lblBesSelect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBesDate
            // 
            this.lblBesDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBesDate.Location = new System.Drawing.Point(638, 29);
            this.lblBesDate.Name = "lblBesDate";
            this.lblBesDate.Size = new System.Drawing.Size(114, 20);
            this.lblBesDate.TabIndex = 28;
            this.lblBesDate.Text = "0";
            this.lblBesDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBedSelect
            // 
            this.lblBedSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBedSelect.Location = new System.Drawing.Point(825, 6);
            this.lblBedSelect.Name = "lblBedSelect";
            this.lblBedSelect.Size = new System.Drawing.Size(114, 20);
            this.lblBedSelect.TabIndex = 26;
            this.lblBedSelect.Text = "0";
            this.lblBedSelect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBedDate
            // 
            this.lblBedDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBedDate.Location = new System.Drawing.Point(825, 29);
            this.lblBedDate.Name = "lblBedDate";
            this.lblBedDate.Size = new System.Drawing.Size(114, 20);
            this.lblBedDate.TabIndex = 25;
            this.lblBedDate.Text = "0";
            this.lblBedDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(395, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 20);
            this.label11.TabIndex = 22;
            this.label11.Text = "مانده كل:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(595, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 20);
            this.label8.TabIndex = 21;
            this.label8.Text = "مانده:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(595, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 20);
            this.label9.TabIndex = 20;
            this.label9.Text = "مانده:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(758, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "بستانكاري:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(758, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "بستانكاري:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(945, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 20);
            this.label4.TabIndex = 33;
            this.label4.Text = "انتخابي:        بدهكاري:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(945, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 20);
            this.label3.TabIndex = 34;
            this.label3.Text = "دربازه:            بدهكاري:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFooterNumber
            // 
            this.lblFooterNumber.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblFooterNumber.Location = new System.Drawing.Point(1064, 0);
            this.lblFooterNumber.Name = "lblFooterNumber";
            this.lblFooterNumber.Size = new System.Drawing.Size(105, 60);
            this.lblFooterNumber.TabIndex = 13;
            this.lblFooterNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnPrint);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 60);
            this.panel1.TabIndex = 16;
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.Indigo;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(95, 16);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 30);
            this.btnPrint.TabIndex = 10;
            this.btnPrint.Text = "چاپ";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Location = new System.Drawing.Point(20, 16);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 30);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "انصراف";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ReportZirSarfasl
            // 
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlFooter);
            this.Font = new System.Drawing.Font("IRANSans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Name = "ReportZirSarfasl";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(1169, 500);
            this.Load += new System.EventHandler(this.ReportZirSarfasl_Load);
            this.pnlMain.ResumeLayout(false);
            this.gbHeader.ResumeLayout(false);
            this.gbHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZirSarfal)).EndInit();
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            this.panel1.ResumeLayout(false);
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
            SetTextLabelFooter();
            //lblFooterNumber.Text = $"تعداد: {dgvZirSarfal.RowCount}\nتعداد انتخابي: {ListSelected.Count}";

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
            report.Load(@"C:\Users\North-PC\Desktop\Report Sarfasl (Stimulsoft)\Atiran\ReportZirSarfasl1.mrt");
            //report.Dictionary.Databases.Add(new StiSqlDatabase("Connection", "Integrated Security=True;Data Source=.;Initial Catalog=ZAnsari;Password=;User ID="));//Connections.ConnectionInfo.BuildStimulConnectionString()));
            //report.Compile();
            report.Dictionary.Variables["User"].Value = "alirezasadegghi";
            report.Dictionary.Variables["today"].Value = today;
            report.Dictionary.Variables["NameSarfasl"].Value = _nameSarfasl;
            report.Dictionary.Variables["FromDate"].Value = textDate1.FromDate;
            report.Dictionary.Variables["ToDate"].Value = textDate1.ToDate;
            report.RegBusinessObject("SZA", dt1);
            report.Render();
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

            return base.ProcessCmdKey(ref msg, keyData);
        }

        #endregion
        #region Method

        private void GetData()
        {
            lblLoding.Visible = true;

            ListSelected.Clear();

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
            dgvZirSarfal.DataSource =dt0 =  dt.GroupBy(g => new
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

            chbAll.Checked = false;
            SetTextLabelFooter(dt.Count, dt.Sum(d=>d.Zbed),dt.Sum(d=>d.Zbes),dt.Sum(d => d.ZMan), dt.Sum(d => d.ZMan_All));
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
            dgvZirSarfal.Columns["ZMan"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


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

                var dt1 = dt0.Where(c => c.ZName.Contains(filter)).ToList();
                dgvZirSarfal.DataSource = dt1.ToList();
                SetTextLabelFooter(dt1.Count, dt1.Sum(d => d.Zbed), dt1.Sum(d => d.Zbes), dt1.Sum(d => d.ZMan), dt1.Sum(d => d.ZMan_All));
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
            SetTextLabelFooter();
            //lblFooterNumber.Text = $"تعداد: {dgvZirSarfal.RowCount}\nتعداد انتخابي: {ListSelected.Count}";

        }

        private void OpenActZirSarfasl(string NameZirSarfasl)
        {
            if (dgvZirSarfal.SelectedRows.Count > 0)
            {
                _zirSarfaslIdSelected = (int)dgvZirSarfal.SelectedRows[0].Cells["ZID"].Value;
                DefultForm reportZirSarfasl = new DefultForm();
                reportZirSarfasl.ShowDialog(new ReportActZirSarfasl(textDate1.FromDate, textDate1.ToDate, NameZirSarfasl,_sarfaslID, zirSarfaslID: _zirSarfaslIdSelected), new Size(1360, 694));
                //باز کردن زیر سرفصل های سرفصل انتخابی داخل گرید
            }
        }

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
            lblBedDate.Text = (bed ).ToMan();
            lblBesDate.Text = (bes).ToMan();
            lblManDate.Text = $"{Math.Abs(sum).ToMan()} ({status1})";

            lblMan.Text = $"{ Math.Abs(sumAll).ToMan()} ({status2})";
        }
        private void SetTextLabelFooter()
        {
            decimal bedSelect = dt.Where(d => ListSelected.Contains(d.ZID)).Sum(d => d.Zbed);
            decimal besSelect = dt.Where(d => ListSelected.Contains(d.ZID)).Sum(d => d.Zbes);
            decimal sumSelect = bedSelect - besSelect;
            string status0 = sumSelect > 0 ? "بد" : sumSelect == 0 ? "--" : "بس";

            lblFooterNumber.Text = $"تعداد: {dgvZirSarfal.RowCount}\nتعداد انتخابي: {ListSelected.Count}";
            lblBedSelect.Text = (bedSelect).ToMan();
            lblBesSelect.Text = (besSelect).ToMan();
            lblManSelect.Text = $"{Math.Abs(sumSelect).ToMan()} ({status0})";
        }

        #endregion

    }
}
