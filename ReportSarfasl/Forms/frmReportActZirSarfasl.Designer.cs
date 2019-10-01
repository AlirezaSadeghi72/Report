namespace ReportSarfasl.Forms
{
    partial class frmReportActZirSarfasl
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
            this.reportActZirSarfasl1 = new ReportSarfasl.ReportActZirSarfasl();
            this.SuspendLayout();
            // 
            // reportActZirSarfasl1
            // 
            this.reportActZirSarfasl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportActZirSarfasl1.Font = new System.Drawing.Font("IRANSans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.reportActZirSarfasl1.Location = new System.Drawing.Point(0, 0);
            this.reportActZirSarfasl1.Name = "reportActZirSarfasl1";
            this.reportActZirSarfasl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.reportActZirSarfasl1.Size = new System.Drawing.Size(784, 421);
            this.reportActZirSarfasl1.TabIndex = 0;
            this.reportActZirSarfasl1.ButtenCancelClick += new System.EventHandler(this.reportActZirSarfasl1_ButtenCancelClick);
            // 
            // frmReportActZirSarfasl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 421);
            this.Controls.Add(this.reportActZirSarfasl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReportActZirSarfasl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmReportActZirSarfasl";
            this.ResumeLayout(false);

        }

        #endregion

        private ReportActZirSarfasl reportActZirSarfasl1;
    }
}