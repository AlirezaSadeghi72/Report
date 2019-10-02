using ReportSarfasl.dataLayer;
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
        private Label label3;
        private Label lblSumMan;
        private Label lblNumber;
        private Label label1;
        private DataGridView dgvActZirSarfasl;
        private GroupBox groupBox2;
        private Label label2;
        private GroupBox groupBox1;
        private Label label5;
        private Label label4;
        private Label lblBes;
        private Label lblBed;
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvActZirSarfasl = new System.Windows.Forms.DataGridView();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblBes = new System.Windows.Forms.Label();
            this.lblBed = new System.Windows.Forms.Label();
            this.lblSumMan = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            this.pnlHeader.TabIndex = 0;
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
            this.pnlMain.TabIndex = 0;
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
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Beige;
            this.dgvActZirSarfasl.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvActZirSarfasl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("IRANSans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvActZirSarfasl.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvActZirSarfasl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvActZirSarfasl.Location = new System.Drawing.Point(3, 52);
            this.dgvActZirSarfasl.MultiSelect = false;
            this.dgvActZirSarfasl.Name = "dgvActZirSarfasl";
            this.dgvActZirSarfasl.ReadOnly = true;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Bisque;
            this.dgvActZirSarfasl.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvActZirSarfasl.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvActZirSarfasl.Size = new System.Drawing.Size(694, 291);
            this.dgvActZirSarfasl.TabIndex = 1;
            // 
            // txtFilter
            // 
            this.txtFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtFilter.Location = new System.Drawing.Point(3, 24);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(694, 28);
            this.txtFilter.TabIndex = 0;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            this.txtFilter.Enter += new System.EventHandler(this.txtFilter_Enter);
            this.txtFilter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFilter_KeyDown);
            this.txtFilter.Leave += new System.EventHandler(this.txtFilter_Leave);
            // 
            // pnlFooter
            // 
            this.pnlFooter.Controls.Add(this.label5);
            this.pnlFooter.Controls.Add(this.label4);
            this.pnlFooter.Controls.Add(this.label3);
            this.pnlFooter.Controls.Add(this.lblBes);
            this.pnlFooter.Controls.Add(this.lblBed);
            this.pnlFooter.Controls.Add(this.lblSumMan);
            this.pnlFooter.Controls.Add(this.lblNumber);
            this.pnlFooter.Controls.Add(this.label1);
            this.pnlFooter.Controls.Add(this.btnCancel);
            this.pnlFooter.Controls.Add(this.btnPrint);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 336);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(700, 64);
            this.pnlFooter.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(477, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "جمع كل بستانكاري :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(694, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "جمع كل بدهكاري :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(492, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "جمع كل بدهكاري و بستانكاري:";
            // 
            // lblBes
            // 
            this.lblBes.Location = new System.Drawing.Point(362, 34);
            this.lblBes.Name = "lblBes";
            this.lblBes.Size = new System.Drawing.Size(111, 19);
            this.lblBes.TabIndex = 5;
            this.lblBes.Text = "1,234,567,899,879.000";
            this.lblBes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblBed
            // 
            this.lblBed.Location = new System.Drawing.Point(580, 34);
            this.lblBed.Name = "lblBed";
            this.lblBed.Size = new System.Drawing.Size(111, 19);
            this.lblBed.TabIndex = 5;
            this.lblBed.Text = "1,234,567,899,879.000";
            this.lblBed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSumMan
            // 
            this.lblSumMan.Font = new System.Drawing.Font("IRANSans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblSumMan.Location = new System.Drawing.Point(362, 9);
            this.lblSumMan.Name = "lblSumMan";
            this.lblSumMan.Size = new System.Drawing.Size(124, 19);
            this.lblSumMan.TabIndex = 5;
            this.lblSumMan.Text = "1,234,567,899,879.000";
            this.lblSumMan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNumber
            // 
            this.lblNumber.Location = new System.Drawing.Point(640, 9);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(60, 19);
            this.lblNumber.TabIndex = 6;
            this.lblNumber.Text = "123456789";
            this.lblNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(701, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "تعداد عملكرد ها: ";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(29, 9);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 35);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "انصراف";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(110, 9);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 35);
            this.btnPrint.TabIndex = 2;
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
            this.pnlFooter.PerformLayout();
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

            lblNumber.Text = dt.Count.ToString();
            lblSumMan.Text = dt.Sum(d => d.bed - d.bes).ToMan();
            lblBed.Text = dt.Sum(d => d.bed).ToMan();
            lblBes.Text = dt.Sum(d => d.bes).ToMan();

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
            dgvActZirSarfasl.Columns["bed"].DefaultCellStyle.Format = "#,0.0000";
            dgvActZirSarfasl.Columns["bed"].DefaultCellStyle.Font = new Font("IRANSans(FaNum)", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dgvActZirSarfasl.Columns["bed"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvActZirSarfasl.Columns["bes"].Visible = true;
            dgvActZirSarfasl.Columns["bes"].HeaderText = "بستانكاري";
            dgvActZirSarfasl.Columns["bes"].DefaultCellStyle.Format = "#,0.0000";
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
                lblNumber.Text = dt1.Count.ToString();
                lblSumMan.Text = dt1.Sum(d => d.bed - d.bes).ToMan();
                lblBed.Text = dt1.Sum(d => d.bed).ToMan();
                lblBes.Text = dt1.Sum(d => d.bes).ToMan();
            }
        }
        #endregion
    }
}
