using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReportSarfasl
{
    class TextDate : UserControl
    {
        private TextBox txtToYear;
        private TextBox txtToMonth;
        private TextBox txtToDay;
        private TextBox txtFromYear;
        private TextBox txtFromMonth;
        private TextBox txtFromDay;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        public bool focuseDate = false;
        private PersianCalendar pc = new PersianCalendar();


        public TextDate()
        {
            InitializeComponent();

            var date = DateTime.Now;
            txtFromDay.Text = txtToDay.Text = pc.GetDayOfMonth(date).ToString("00");
            txtFromMonth.Text = txtToMonth.Text = pc.GetMonth(date).ToString("00");
            txtFromYear.Text = txtToYear.Text = pc.GetYear(date).ToString("0000");
        }

        private void InitializeComponent()
        {
            this.txtToYear = new System.Windows.Forms.TextBox();
            this.txtToMonth = new System.Windows.Forms.TextBox();
            this.txtFromYear = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFromMonth = new System.Windows.Forms.TextBox();
            this.txtToDay = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFromDay = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtToYear
            // 
            this.txtToYear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtToYear.BackColor = System.Drawing.SystemColors.Control;
            this.txtToYear.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtToYear.Location = new System.Drawing.Point(1, 2);
            this.txtToYear.MaxLength = 4;
            this.txtToYear.Name = "txtToYear";
            this.txtToYear.Size = new System.Drawing.Size(33, 21);
            this.txtToYear.TabIndex = 5;
            this.txtToYear.Text = "1372";
            this.txtToYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtToYear.Enter += new System.EventHandler(this.textBox_Enter);
            this.txtToYear.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_Keys);
            this.txtToYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            this.txtToYear.Leave += new System.EventHandler(this.textBox_Leave);
            // 
            // txtToMonth
            // 
            this.txtToMonth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtToMonth.BackColor = System.Drawing.SystemColors.Control;
            this.txtToMonth.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtToMonth.Location = new System.Drawing.Point(48, 2);
            this.txtToMonth.MaxLength = 2;
            this.txtToMonth.Name = "txtToMonth";
            this.txtToMonth.Size = new System.Drawing.Size(17, 21);
            this.txtToMonth.TabIndex = 4;
            this.txtToMonth.Text = "06";
            this.txtToMonth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtToMonth.Enter += new System.EventHandler(this.textBox_Enter);
            this.txtToMonth.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_Keys);
            this.txtToMonth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            this.txtToMonth.Leave += new System.EventHandler(this.textBox_Leave);
            // 
            // txtFromYear
            // 
            this.txtFromYear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFromYear.BackColor = System.Drawing.SystemColors.Control;
            this.txtFromYear.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFromYear.Location = new System.Drawing.Point(155, 2);
            this.txtFromYear.MaxLength = 4;
            this.txtFromYear.Name = "txtFromYear";
            this.txtFromYear.Size = new System.Drawing.Size(33, 21);
            this.txtFromYear.TabIndex = 2;
            this.txtFromYear.Text = "1372";
            this.txtFromYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFromYear.Enter += new System.EventHandler(this.textBox_Enter);
            this.txtFromYear.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_Keys);
            this.txtFromYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            this.txtFromYear.Leave += new System.EventHandler(this.textBox_Leave);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "/";
            // 
            // txtFromMonth
            // 
            this.txtFromMonth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFromMonth.BackColor = System.Drawing.SystemColors.Control;
            this.txtFromMonth.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFromMonth.Location = new System.Drawing.Point(201, 2);
            this.txtFromMonth.MaxLength = 2;
            this.txtFromMonth.Name = "txtFromMonth";
            this.txtFromMonth.Size = new System.Drawing.Size(17, 21);
            this.txtFromMonth.TabIndex = 1;
            this.txtFromMonth.Text = "06";
            this.txtFromMonth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFromMonth.Enter += new System.EventHandler(this.textBox_Enter);
            this.txtFromMonth.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_Keys);
            this.txtFromMonth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            this.txtFromMonth.Leave += new System.EventHandler(this.textBox_Leave);
            // 
            // txtToDay
            // 
            this.txtToDay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtToDay.BackColor = System.Drawing.SystemColors.Control;
            this.txtToDay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtToDay.Location = new System.Drawing.Point(77, 2);
            this.txtToDay.MaxLength = 2;
            this.txtToDay.Name = "txtToDay";
            this.txtToDay.Size = new System.Drawing.Size(17, 21);
            this.txtToDay.TabIndex = 3;
            this.txtToDay.Text = "20";
            this.txtToDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtToDay.Enter += new System.EventHandler(this.textBox_Enter);
            this.txtToDay.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_Keys);
            this.txtToDay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            this.txtToDay.Leave += new System.EventHandler(this.textBox_Leave);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(188, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "/";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "/";
            // 
            // txtFromDay
            // 
            this.txtFromDay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFromDay.BackColor = System.Drawing.SystemColors.Control;
            this.txtFromDay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFromDay.Location = new System.Drawing.Point(227, 2);
            this.txtFromDay.MaxLength = 2;
            this.txtFromDay.Name = "txtFromDay";
            this.txtFromDay.Size = new System.Drawing.Size(17, 21);
            this.txtFromDay.TabIndex = 0;
            this.txtFromDay.Text = "20";
            this.txtFromDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFromDay.Enter += new System.EventHandler(this.textBox_Enter);
            this.txtFromDay.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_Keys);
            this.txtFromDay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            this.txtFromDay.Leave += new System.EventHandler(this.textBox_Leave);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(96, 2);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "تا تاريخ : ";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "/";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(240, 2);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "از تاريخ : ";
            // 
            // TextDate
            // 
            this.Controls.Add(this.txtToYear);
            this.Controls.Add(this.txtToMonth);
            this.Controls.Add(this.txtFromYear);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtFromMonth);
            this.Controls.Add(this.txtToDay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtFromDay);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("IRANSans(FaNum)", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Name = "TextDate";
            this.Size = new System.Drawing.Size(296, 24);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #region Event Controls

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void textBox_Keys(object sender, KeyEventArgs e)
        {
            TextBox txt = (sender as TextBox);

            switch (e.KeyData)
            {
                case Keys.Up:
                    {
                        switch (txt.Name)
                        {
                            case "txtFromDay":
                                {
                                    int day;
                                    if (Convert.ToInt32(txtFromMonth.Text) > 6)
                                    {
                                        day = (Convert.ToInt32(txt.Text) + 1) % 31;
                                    }
                                    else
                                    {
                                        day = (Convert.ToInt32(txt.Text) + 1) % 32;
                                    }
                                    day = day == 0 ? 1 : day;
                                    txt.Text = day.ToString("00");
                                    break;
                                }
                            case "txtToDay":
                                {
                                    int day;
                                    if (Convert.ToInt32(txtFromMonth.Text) > 6)
                                    {
                                        day = (Convert.ToInt32(txt.Text) + 1) % 31;
                                    }
                                    else
                                    {
                                        day = (Convert.ToInt32(txt.Text) + 1) % 32;
                                    }
                                    day = day == 0 ? 1 : day;
                                    txt.Text = day.ToString("00");
                                    break;
                                }
                            case "txtFromMonth":
                            case "txtToMonth":
                                {
                                    int month = (Convert.ToInt32(txt.Text) + 1) % 13;
                                    month = month == 0 ? 1 : month;
                                    txt.Text = month.ToString("00");
                                    if (Convert.ToInt32(txtFromMonth.Text) > 6 && txtFromDay.Text == "31")
                                    {
                                        txtFromDay.Text = "01";
                                    }
                                    else if (Convert.ToInt32(txtToMonth.Text) > 6 && txtToDay.Text == "31")
                                    {
                                        txtToDay.Text = "01";
                                    }
                                    break;
                                }
                            case "txtFromYear":
                            case "txtToYear":
                                {
                                    int year = (Convert.ToInt32(txt.Text) + 1) % 2201;
                                    year = year == 0 ? 1 : year;
                                    txt.Text = year.ToString("0000");
                                    break;
                                }
                        }
                        txt.SelectAll();
                        break;
                    }
                case Keys.Down:
                    {
                        switch (txt.Name)
                        {
                            case "txtFromDay":
                                {
                                    int day;
                                    if (Convert.ToInt32(txtFromMonth.Text) > 6)
                                    {
                                        day = (Convert.ToInt32(txt.Text) - 1) % 31;
                                        day = day == 0 ? 30 : day;
                                    }
                                    else
                                    {
                                        day = (Convert.ToInt32(txt.Text) - 1) % 32;
                                        day = day == 0 ? 31 : day;
                                    }
                                    txt.Text = day.ToString("00");
                                    break;
                                }
                            case "txtToDay":
                                {
                                    int day;
                                    if (Convert.ToInt32(txtFromMonth.Text) > 6)
                                    {
                                        day = (Convert.ToInt32(txt.Text) - 1) % 31;
                                        day = day == 0 ? 30 : day;
                                    }
                                    else
                                    {
                                        day = (Convert.ToInt32(txt.Text) - 1) % 32;
                                        day = day == 0 ? 31 : day;
                                    }
                                    txt.Text = day.ToString("00");
                                    break;
                                }
                            case "txtFromMonth":
                            case "txtToMonth":
                                {
                                    int month = (Convert.ToInt32(txt.Text) - 1) % 13;
                                    month = month == 0 ? 12 : month;
                                    txt.Text = month.ToString("00");
                                    if (Convert.ToInt32(txtFromMonth.Text) > 6 && txtFromDay.Text == "31")
                                    {
                                        txtFromDay.Text = "01";
                                    }
                                    else if (Convert.ToInt32(txtToMonth.Text) > 6 && txtToDay.Text == "31")
                                    {
                                        txtToDay.Text = "01";
                                    }
                                    break;
                                }
                            case "txtFromYear":
                            case "txtToYear":
                                {
                                    int year = (Convert.ToInt32(txt.Text) - 1) % 2201;
                                    year = year == 0 ? 2200 : year;
                                    txt.Text = year.ToString("0000");
                                    break;
                                }
                        }
                        txt.SelectAll();
                        break;
                    }
                case Keys.Enter:
                    {
                        switch (txt.Name)
                        {
                            case "txtFromDay":
                                {
                                    txtFromMonth.Focus();
                                    if (int.Parse(txtFromMonth.Text) > 6 && int.Parse(txtFromDay.Text) > 30)
                                    {
                                        txtFromDay.Text = "30";
                                    }
                                    else if (int.Parse(txtFromMonth.Text) <= 6 && int.Parse(txtFromDay.Text) > 31)
                                    {
                                        txtFromDay.Text = "31";
                                    }
                                    break;
                                }
                            case "txtToDay":
                                {
                                    txtToMonth.Focus();
                                    if (int.Parse(txtToMonth.Text) > 6 && int.Parse(txtToDay.Text) > 30)
                                    {
                                        txtToDay.Text = "30";
                                    }
                                    else if (int.Parse(txtToMonth.Text) <= 6 && int.Parse(txtToDay.Text) > 31)
                                    {
                                        txtToDay.Text = "31";
                                    }
                                    break;
                                }
                            case "txtFromMonth":
                                {
                                    txtFromYear.Focus();
                                    if (int.Parse(txtFromMonth.Text) > 12)
                                    {
                                        txtFromMonth.Text = "12";
                                    }

                                    if (int.Parse(txtFromMonth.Text) > 6 && int.Parse(txtFromDay.Text) > 30)
                                    {
                                        txtFromDay.Text = "30";
                                    }
                                    else if (int.Parse(txtFromMonth.Text) <= 6 && int.Parse(txtFromDay.Text) > 31)
                                    {
                                        txtFromDay.Text = "31";
                                    }

                                    break;
                                }
                            case "txtToMonth":
                                {
                                    txtToYear.Focus();
                                    if (int.Parse(txtToMonth.Text) > 12)
                                    {
                                        txtToMonth.Text = "12";
                                    }

                                    if (int.Parse(txtToMonth.Text) > 6 && int.Parse(txtToDay.Text) > 30)
                                    {
                                        txtFromDay.Text = "30";
                                    }
                                    else if (int.Parse(txtToMonth.Text) <= 6 && int.Parse(txtToDay.Text) > 31)
                                    {
                                        txtFromDay.Text = "31";
                                    }
                                    break;
                                }
                            case "txtFromYear":
                                {
                                    txtToDay.Focus();
                                    if (int.Parse(txtFromYear.Text) > 2201)
                                    {
                                        txtFromYear.Text = "2200";
                                    }
                                    break;
                                }
                            case "txtToYear" when KeyEnterTextBoxToYear != null:
                                {
                                    KeyEnterTextBoxToYear(sender, e);
                                    if (int.Parse(txtToYear.Text) > 2201)
                                    {
                                        txtToYear.Text = "2200";
                                    }
                                    break;
                                }
                        }
                    }
                    break;
            }
        }

        private void textBox_Enter(object sender, EventArgs e)
        {
            (sender as TextBox).BackColor = Color.Bisque;
            (sender as TextBox).SelectAll();
            focuseDate = true;
        }

        private void textBox_Leave(object sender, EventArgs e)
        {
            focuseDate = false;
            (sender as TextBox).BackColor = SystemColors.Control;
            if ((sender as TextBox).Name != "txtToYear" || (sender as TextBox).Name != "txtFromYear")
            {
                (sender as TextBox).Text = int.Parse((sender as TextBox).Text).ToString("00");
            }
            else
            {
                (sender as TextBox).Text = int.Parse((sender as TextBox).Text).ToString("0000");
            }

        }

        //private void txtFromDay_TextChanged(object sender, EventArgs e)
        //{
        //    if (Convert.ToInt32(txtFromMonth.Text) > 6 && Convert.ToInt32(txtFromDay.Text) > 30)
        //    {
        //        txtFromDay.Text = "30";
        //    }
        //    else if (Convert.ToInt32(txtFromMonth.Text) < 6 && Convert.ToInt32(txtFromDay.Text) > 31)
        //    {
        //        txtFromDay.Text = "31";

        //    }

        //    if (Convert.ToInt32(txtFromDay.Text) < 1 || txtFromDay.Text.Trim() == "")
        //    {
        //        txtFromDay.Text = "1";
        //    }
        //}
        //private void txtToDay_TextChanged(object sender, EventArgs e)
        //{
        //    if (Convert.ToInt32(txtToMonth.Text) > 6 && Convert.ToInt32(txtToDay.Text) > 30)
        //    {
        //        txtToDay.Text = "30";
        //    }
        //    else if (Convert.ToInt32(txtToMonth.Text) < 6 && Convert.ToInt32(txtToDay.Text) > 31)
        //    {
        //        txtToDay.Text = "31";

        //    }

        //    if (Convert.ToInt32(txtToDay.Text) < 1 || txtToDay.Text.Trim() == "")
        //    {
        //        txtToDay.Text = "1";
        //    }
        //}
        //private void textBoxMonth_TextChanged(object sender, EventArgs e)
        //{
        //    if (Convert.ToInt32((sender as TextBox).Text) > 12)
        //    {
        //        (sender as TextBox).Text = "12";
        //    }
        //    if (Convert.ToInt32((sender as TextBox).Text) < 1 || (sender as TextBox).Text.Trim() == "")
        //    {
        //        (sender as TextBox).Text = "1";
        //    }
        //}
        //private void textBoxYear_TextChanged(object sender, EventArgs e)
        //{
        //    if (Convert.ToInt32((sender as TextBox).Text) > 2200)
        //    {
        //        (sender as TextBox).Text = "2200";
        //    }
        //    if (Convert.ToInt32((sender as TextBox).Text) < 1 || (sender as TextBox).Text.Trim() == "")
        //    {
        //        (sender as TextBox).Text = "1";
        //    }
        //}


        #endregion

        #region Event Handler

        public event EventHandler KeyEnterTextBoxToYear;

        #endregion

        #region property

        public string FromDate
        {
            get { return txtFromYear.Text + "/" + txtFromMonth.Text + "/" + txtFromDay.Text; }
            set
            {
                if (!DesignMode)
                {
                    var ali = value.Split('/');
                    txtFromYear.Text = ali[0];
                    txtFromMonth.Text = ali[1];
                    txtFromDay.Text = ali[2];
                }
            }
        }

        public string ToDate
        {
            get { return txtToYear.Text + "/" + txtToMonth.Text + "/" + txtToDay.Text; }
            set
            {
                if (!DesignMode)
                {
                    var ali = value.Split('/');
                    txtToYear.Text = ali[0];
                    txtToMonth.Text = ali[1];
                    txtToDay.Text = ali[2];
                }
            }
        }

        #endregion


    }
}
