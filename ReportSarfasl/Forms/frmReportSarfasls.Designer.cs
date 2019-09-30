namespace ReportSarfasl.Forms
{
    partial class frmReportSarfasls
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.reportSarfasl1 = new ReportSarfasl.reportSarfasl();
            this.SuspendLayout();
            // 
            // reportSarfasl1
            // 
            this.reportSarfasl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportSarfasl1.Font = new System.Drawing.Font("IRANSans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.reportSarfasl1.Location = new System.Drawing.Point(0, 0);
            this.reportSarfasl1.Name = "reportSarfasl1";
            this.reportSarfasl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.reportSarfasl1.Size = new System.Drawing.Size(1200, 527);
            this.reportSarfasl1.TabIndex = 0;
            this.reportSarfasl1.txtSarfasl_KeyDownEnter += new System.EventHandler(this.reportSarfasl1_txtSarfasl_KeyDownEnter);
            this.reportSarfasl1.txtZirSarfasl_KeyDownEnter += new System.EventHandler(this.reportSarfasl1_txtZirSarfasl_KeyDownEnter);
            this.reportSarfasl1.OpenFormZirSarfasl += new System.EventHandler(this.reportSarfasl1_OpenFormZirSarfasl);
            this.reportSarfasl1.ButtenCancelClick += new System.EventHandler(this.reportSarfasl1_ButtenCancelClick);
            // 
            // frmReportSarfasls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 527);
            this.Controls.Add(this.reportSarfasl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReportSarfasls";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmReportSarfasls";
            this.ResumeLayout(false);

        }

        #endregion

        private reportSarfasl reportSarfasl1;
    }
}