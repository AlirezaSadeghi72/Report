using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReportSarfasl.Forms
{
    public class BaseForm:Form
    {
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuReport;
        private ToolStripMenuItem menuSarfasl;

        public BaseForm()
        {
            InitializeComponent();
        }
        
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuReport = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSarfasl = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuReport});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(436, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuReport
            // 
            this.menuReport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSarfasl});
            this.menuReport.Name = "menuReport";
            this.menuReport.Size = new System.Drawing.Size(50, 20);
            this.menuReport.Text = "گزارش";
            // 
            // menuSarfasl
            // 
            this.menuSarfasl.Name = "menuSarfasl";
            this.menuSarfasl.Size = new System.Drawing.Size(180, 22);
            this.menuSarfasl.Text = "سرفصل";
            this.menuSarfasl.Click += new System.EventHandler(this.menuSarfasl_Click);
            // 
            // BaseForm
            // 
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(436, 396);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("IRANSans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "BaseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        
        private void menuSarfasl_Click(object sender, EventArgs e)
        {
            DefultForm reportSarfaForm = new DefultForm();
            reportSarfaForm.ShowDialog(new reportSarfasl(), new Size(1360, 735));
        }
    }
}
