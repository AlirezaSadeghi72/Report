using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReportSarfasl
{
    class ChoiceActKind:UserControl
    {
        public List<int> choice = new List<int>();
        private CheckBox chb51;
        private CheckBox chb52;
        private CheckBox chb53;
        private CheckBox chb54;
        private CheckBox chb55;
        private CheckBox chb56;
        private CheckBox chb57;
        private CheckBox chb58;
        private CheckBox chb59;
        private CheckBox chb60;
        private CheckBox chb61;
        private CheckBox chb62;
        private CheckBox chb63;
        private CheckBox chb64;
        private CheckBox chb65;
        private Button btnOk;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        public ChoiceActKind()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChoiceActKind));
            this.chb51 = new System.Windows.Forms.CheckBox();
            this.chb52 = new System.Windows.Forms.CheckBox();
            this.chb53 = new System.Windows.Forms.CheckBox();
            this.chb54 = new System.Windows.Forms.CheckBox();
            this.chb55 = new System.Windows.Forms.CheckBox();
            this.chb56 = new System.Windows.Forms.CheckBox();
            this.chb57 = new System.Windows.Forms.CheckBox();
            this.chb58 = new System.Windows.Forms.CheckBox();
            this.chb59 = new System.Windows.Forms.CheckBox();
            this.chb60 = new System.Windows.Forms.CheckBox();
            this.chb61 = new System.Windows.Forms.CheckBox();
            this.chb62 = new System.Windows.Forms.CheckBox();
            this.chb63 = new System.Windows.Forms.CheckBox();
            this.chb64 = new System.Windows.Forms.CheckBox();
            this.chb65 = new System.Windows.Forms.CheckBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // chb51
            // 
            this.chb51.AutoSize = true;
            this.chb51.Location = new System.Drawing.Point(430, 51);
            this.chb51.Name = "chb51";
            this.chb51.Size = new System.Drawing.Size(125, 24);
            this.chb51.TabIndex = 1;
            this.chb51.Text = "از صندوق به سرفصل";
            this.chb51.UseVisualStyleBackColor = true;
            this.chb51.CheckedChanged += new System.EventHandler(this.chb51_CheckedChanged);
            // 
            // chb52
            // 
            this.chb52.AutoSize = true;
            this.chb52.Location = new System.Drawing.Point(3, 21);
            this.chb52.Name = "chb52";
            this.chb52.Size = new System.Drawing.Size(263, 24);
            this.chb52.TabIndex = 10;
            this.chb52.Text = "از اسناد پرداختي و صندوق - نقد و چك به سرفصل";
            this.chb52.UseVisualStyleBackColor = true;
            this.chb52.CheckedChanged += new System.EventHandler(this.chb52_CheckedChanged);
            // 
            // chb53
            // 
            this.chb53.AutoSize = true;
            this.chb53.Location = new System.Drawing.Point(75, 111);
            this.chb53.Name = "chb53";
            this.chb53.Size = new System.Drawing.Size(191, 24);
            this.chb53.TabIndex = 13;
            this.chb53.Text = "از اسناد پرداختي - چكي به سرفصل";
            this.chb53.UseVisualStyleBackColor = true;
            this.chb53.CheckedChanged += new System.EventHandler(this.chb53_CheckedChanged);
            // 
            // chb54
            // 
            this.chb54.AutoSize = true;
            this.chb54.Location = new System.Drawing.Point(429, 21);
            this.chb54.Name = "chb54";
            this.chb54.Size = new System.Drawing.Size(126, 24);
            this.chb54.TabIndex = 0;
            this.chb54.Text = "از سرفصل به سرفصل";
            this.chb54.UseVisualStyleBackColor = true;
            this.chb54.CheckedChanged += new System.EventHandler(this.chb54_CheckedChanged);
            // 
            // chb55
            // 
            this.chb55.AutoSize = true;
            this.chb55.Location = new System.Drawing.Point(116, 141);
            this.chb55.Name = "chb55";
            this.chb55.Size = new System.Drawing.Size(150, 24);
            this.chb55.TabIndex = 14;
            this.chb55.Text = "از سرفصل به حساب جاري";
            this.chb55.UseVisualStyleBackColor = true;
            this.chb55.CheckedChanged += new System.EventHandler(this.chb55_CheckedChanged);
            // 
            // chb56
            // 
            this.chb56.AutoSize = true;
            this.chb56.Location = new System.Drawing.Point(285, 21);
            this.chb56.Name = "chb56";
            this.chb56.Size = new System.Drawing.Size(125, 24);
            this.chb56.TabIndex = 5;
            this.chb56.Text = "از سرفصل به مشتري";
            this.chb56.UseVisualStyleBackColor = true;
            this.chb56.CheckedChanged += new System.EventHandler(this.chb56_CheckedChanged);
            // 
            // chb57
            // 
            this.chb57.AutoSize = true;
            this.chb57.Location = new System.Drawing.Point(285, 51);
            this.chb57.Name = "chb57";
            this.chb57.Size = new System.Drawing.Size(125, 24);
            this.chb57.TabIndex = 6;
            this.chb57.Text = "از سرفصل به صندوق";
            this.chb57.UseVisualStyleBackColor = true;
            this.chb57.CheckedChanged += new System.EventHandler(this.chb57_CheckedChanged);
            // 
            // chb58
            // 
            this.chb58.AutoSize = true;
            this.chb58.Location = new System.Drawing.Point(440, 111);
            this.chb58.Name = "chb58";
            this.chb58.Size = new System.Drawing.Size(115, 24);
            this.chb58.TabIndex = 3;
            this.chb58.Text = "از جاري به سرفصل";
            this.chb58.UseVisualStyleBackColor = true;
            this.chb58.CheckedChanged += new System.EventHandler(this.chb58_CheckedChanged);
            // 
            // chb59
            // 
            this.chb59.AutoSize = true;
            this.chb59.Location = new System.Drawing.Point(306, 141);
            this.chb59.Name = "chb59";
            this.chb59.Size = new System.Drawing.Size(104, 24);
            this.chb59.TabIndex = 9;
            this.chb59.Text = "از جاري به جاري";
            this.chb59.UseVisualStyleBackColor = true;
            this.chb59.CheckedChanged += new System.EventHandler(this.chb59_CheckedChanged);
            // 
            // chb60
            // 
            this.chb60.AutoSize = true;
            this.chb60.Location = new System.Drawing.Point(296, 111);
            this.chb60.Name = "chb60";
            this.chb60.Size = new System.Drawing.Size(114, 24);
            this.chb60.TabIndex = 8;
            this.chb60.Text = "از جاري به مشتري";
            this.chb60.UseVisualStyleBackColor = true;
            this.chb60.CheckedChanged += new System.EventHandler(this.chb60_CheckedChanged);
            // 
            // chb61
            // 
            this.chb61.AutoSize = true;
            this.chb61.Location = new System.Drawing.Point(296, 81);
            this.chb61.Name = "chb61";
            this.chb61.Size = new System.Drawing.Size(114, 24);
            this.chb61.TabIndex = 7;
            this.chb61.Text = "از جاري به صندوق";
            this.chb61.UseVisualStyleBackColor = true;
            this.chb61.CheckedChanged += new System.EventHandler(this.chb61_CheckedChanged);
            // 
            // chb62
            // 
            this.chb62.AutoSize = true;
            this.chb62.Location = new System.Drawing.Point(56, 51);
            this.chb62.Name = "chb62";
            this.chb62.Size = new System.Drawing.Size(210, 24);
            this.chb62.TabIndex = 11;
            this.chb62.Text = "از اسناد دريافتي (خرج چك) به سرفصل";
            this.chb62.UseVisualStyleBackColor = true;
            this.chb62.CheckedChanged += new System.EventHandler(this.chb62_CheckedChanged);
            // 
            // chb63
            // 
            this.chb63.AutoSize = true;
            this.chb63.Location = new System.Drawing.Point(64, 81);
            this.chb63.Name = "chb63";
            this.chb63.Size = new System.Drawing.Size(202, 24);
            this.chb63.TabIndex = 12;
            this.chb63.Text = "از صندوق و اسناد دريافتي به سرفصل";
            this.chb63.UseVisualStyleBackColor = true;
            this.chb63.CheckedChanged += new System.EventHandler(this.chb63_CheckedChanged);
            // 
            // chb64
            // 
            this.chb64.AutoSize = true;
            this.chb64.Location = new System.Drawing.Point(430, 81);
            this.chb64.Name = "chb64";
            this.chb64.Size = new System.Drawing.Size(125, 24);
            this.chb64.TabIndex = 2;
            this.chb64.Text = "از مشتري به سرفصل";
            this.chb64.UseVisualStyleBackColor = true;
            this.chb64.CheckedChanged += new System.EventHandler(this.chb64_CheckedChanged);
            // 
            // chb65
            // 
            this.chb65.AutoSize = true;
            this.chb65.Location = new System.Drawing.Point(447, 141);
            this.chb65.Name = "chb65";
            this.chb65.Size = new System.Drawing.Size(108, 24);
            this.chb65.TabIndex = 4;
            this.chb65.Text = "از انبار به سرفصل";
            this.chb65.UseVisualStyleBackColor = true;
            this.chb65.CheckedChanged += new System.EventHandler(this.chb65_CheckedChanged);
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnOk.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnOk.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOk.Font = new System.Drawing.Font("IRANSans", 10F);
            this.btnOk.ForeColor = System.Drawing.Color.White;
            this.btnOk.Location = new System.Drawing.Point(0, 198);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(571, 36);
            this.btnOk.TabIndex = 30;
            this.btnOk.Text = "تاييد";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(272, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(7, 172);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Location = new System.Drawing.Point(416, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(7, 172);
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // ChoiceActKind
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.chb65);
            this.Controls.Add(this.chb64);
            this.Controls.Add(this.chb63);
            this.Controls.Add(this.chb62);
            this.Controls.Add(this.chb61);
            this.Controls.Add(this.chb60);
            this.Controls.Add(this.chb59);
            this.Controls.Add(this.chb58);
            this.Controls.Add(this.chb57);
            this.Controls.Add(this.chb56);
            this.Controls.Add(this.chb55);
            this.Controls.Add(this.chb54);
            this.Controls.Add(this.chb53);
            this.Controls.Add(this.chb52);
            this.Controls.Add(this.chb51);
            this.Font = new System.Drawing.Font("IRANSans", 9F);
            this.Name = "ChoiceActKind";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(571, 234);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #region Event Controls

        private void chb54_CheckedChanged(object sender, EventArgs e)
        {
            if (chb54.Checked)
            {
                choice.Add(54);
            }
            else
            {
                choice.RemoveAll(c=>c==54);
            }
        }

        private void chb51_CheckedChanged(object sender, EventArgs e)
        {
            if (chb51.Checked)
            {
                choice.Add(51);
            }
            else
            {
                choice.RemoveAll(c => c == 51);
            }
        }

        private void chb64_CheckedChanged(object sender, EventArgs e)
        {
            if (chb64.Checked)
            {
                choice.Add(64);
            }
            else
            {
                choice.RemoveAll(c => c == 64);
            }
        }

        private void chb58_CheckedChanged(object sender, EventArgs e)
        {
            if (chb58.Checked)
            {
                choice.Add(58);
            }
            else
            {
                choice.RemoveAll(c => c == 58);
            }
        }

        private void chb65_CheckedChanged(object sender, EventArgs e)
        {
            if (chb65.Checked)
            {
                choice.Add(65);
            }
            else
            {
                choice.RemoveAll(c => c == 65);
            }
        }

        private void chb56_CheckedChanged(object sender, EventArgs e)
        {
            if (chb56.Checked)
            {
                choice.Add(56);
            }
            else
            {
                choice.RemoveAll(c => c == 56);
            }
        }

        private void chb57_CheckedChanged(object sender, EventArgs e)
        {
            if (chb57.Checked)
            {
                choice.Add(57);
            }
            else
            {
                choice.RemoveAll(c => c == 57);
            }
        }

        private void chb61_CheckedChanged(object sender, EventArgs e)
        {
            if (chb61.Checked)
            {
                choice.Add(61);
            }
            else
            {
                choice.RemoveAll(c => c == 61);
            }
        }

        private void chb60_CheckedChanged(object sender, EventArgs e)
        {
            if (chb60.Checked)
            {
                choice.Add(60);
            }
            else
            {
                choice.RemoveAll(c => c == 60);
            }
        }

        private void chb59_CheckedChanged(object sender, EventArgs e)
        {
            if (chb59.Checked)
            {
                choice.Add(59);
            }
            else
            {
                choice.RemoveAll(c => c == 59);
            }
        }

        private void chb52_CheckedChanged(object sender, EventArgs e)
        {
            if (chb52.Checked)
            {
                choice.Add(52);
            }
            else
            {
                choice.RemoveAll(c => c == 52);
            }
        }

        private void chb62_CheckedChanged(object sender, EventArgs e)
        {
            if (chb62.Checked)
            {
                choice.Add(62);
            }
            else
            {
                choice.RemoveAll(c => c == 62);
            }
        }

        private void chb63_CheckedChanged(object sender, EventArgs e)
        {
            if (chb63.Checked)
            {
                choice.Add(63);
            }
            else
            {
                choice.RemoveAll(c => c == 63);
            }
        }

        private void chb53_CheckedChanged(object sender, EventArgs e)
        {
            if (chb53.Checked)
            {
                choice.Add(53);
            }
            else
            {
                choice.RemoveAll(c => c == 53);
            }
        }

        private void chb55_CheckedChanged(object sender, EventArgs e)
        {
            if (chb55.Checked)
            {
                choice.Add(55);
            }
            else
            {
                choice.RemoveAll(c => c == 55);
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            ((Form)this.TopLevelControl).Close();
            //بسن فرم
        }

        #endregion

        #region Event override

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                ((Form)this.TopLevelControl).Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        #endregion
    }
}
