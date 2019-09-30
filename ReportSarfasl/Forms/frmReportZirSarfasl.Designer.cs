namespace ReportSarfasl.Forms
{
    partial class frmReportZirSarfasl
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
            this.reportZirSarfasl1 = new ReportSarfasl.ReportZirSarfasl();
            this.SuspendLayout();
            // 
            // reportZirSarfasl1
            // 
            this.reportZirSarfasl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportZirSarfasl1.Location = new System.Drawing.Point(0, 0);
            this.reportZirSarfasl1.Name = "reportZirSarfasl1";
            this.reportZirSarfasl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.reportZirSarfasl1.Size = new System.Drawing.Size(1000, 480);
            this.reportZirSarfasl1.TabIndex = 0;
            this.reportZirSarfasl1.OpenFormActZirSarfasl += new System.EventHandler(this.reportZirSarfasl1_OpenFormActZirSarfasl);
            this.reportZirSarfasl1.ButtenCancelClick += new System.EventHandler(this.reportZirSarfasl1_ButtenCancelClick);
            // 
            // frmReportZirSarfasl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 480);
            this.Controls.Add(this.reportZirSarfasl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReportZirSarfasl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmReportZirSarfasl";
            this.ResumeLayout(false);

        }

        #endregion

        private ReportZirSarfasl reportZirSarfasl1;
    }
}