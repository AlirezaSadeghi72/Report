using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReportSarfasl
{
    class ChoiceModPrint:UserControl
    {
        private RadioButton rbtnYesZirSarfasl;
        private RadioButton rbtnNoZirSarfasl;

        public ChoiceModPrint()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.rbtnYesZirSarfasl = new System.Windows.Forms.RadioButton();
            this.rbtnNoZirSarfasl = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // rbtnYesZirSarfasl
            // 
            this.rbtnYesZirSarfasl.AutoSize = true;
            this.rbtnYesZirSarfasl.Location = new System.Drawing.Point(18, 14);
            this.rbtnYesZirSarfasl.Name = "rbtnYesZirSarfasl";
            this.rbtnYesZirSarfasl.Size = new System.Drawing.Size(86, 17);
            this.rbtnYesZirSarfasl.TabIndex = 0;
            this.rbtnYesZirSarfasl.Text = "با زيرسرفصل";
            this.rbtnYesZirSarfasl.UseVisualStyleBackColor = true;
            // 
            // rbtnNoZirSarfasl
            // 
            this.rbtnNoZirSarfasl.AutoSize = true;
            this.rbtnNoZirSarfasl.Checked = true;
            this.rbtnNoZirSarfasl.Location = new System.Drawing.Point(119, 14);
            this.rbtnNoZirSarfasl.Name = "rbtnNoZirSarfasl";
            this.rbtnNoZirSarfasl.Size = new System.Drawing.Size(100, 17);
            this.rbtnNoZirSarfasl.TabIndex = 0;
            this.rbtnNoZirSarfasl.TabStop = true;
            this.rbtnNoZirSarfasl.Text = "بدون زيرسرفصل";
            this.rbtnNoZirSarfasl.UseVisualStyleBackColor = true;
            // 
            // ChoiceModPrint
            // 
            this.Controls.Add(this.rbtnNoZirSarfasl);
            this.Controls.Add(this.rbtnYesZirSarfasl);
            this.Name = "ChoiceModPrint";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(235, 44);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        
        #region Event override

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                ((Form) this.TopLevelControl).Close();
                if (rbtnNoZirSarfasl.Checked)
                {
                    ((Form) this.TopLevelControl).DialogResult = DialogResult.No;
                }
                else
                {
                    ((Form)this.TopLevelControl).DialogResult = DialogResult.Yes;
                }
                return true;

            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        #endregion
    }
}
