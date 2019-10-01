namespace ReportSarfasl.Forms
{
    partial class frmListSarfaslOrZirSarfasl
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
            this.listSafaslaOrZirSarfasls1 = new ReportSarfasl.ListSafaslaOrZirSarfasls();
            this.SuspendLayout();
            // 
            // listSafaslaOrZirSarfasls1
            // 
            this.listSafaslaOrZirSarfasls1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listSafaslaOrZirSarfasls1.Font = new System.Drawing.Font("IRANSans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.listSafaslaOrZirSarfasls1.Location = new System.Drawing.Point(0, 0);
            this.listSafaslaOrZirSarfasls1.Name = "listSafaslaOrZirSarfasls1";
            this.listSafaslaOrZirSarfasls1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.listSafaslaOrZirSarfasls1.Size = new System.Drawing.Size(800, 527);
            this.listSafaslaOrZirSarfasls1.TabIndex = 0;
            this.listSafaslaOrZirSarfasls1.CloseUserControl += new System.EventHandler(this.listSafaslaOrZirSarfasls1_CloseUserControl);
            // 
            // frmListSarfaslOrZirSarfasl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 527);
            this.Controls.Add(this.listSafaslaOrZirSarfasls1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmListSarfaslOrZirSarfasl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.ResumeLayout(false);

        }

        #endregion

        private ListSafaslaOrZirSarfasls listSafaslaOrZirSarfasls1;
    }
}