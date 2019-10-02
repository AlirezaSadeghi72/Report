using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReportSarfasl.Forms
{
    public class BaseForm:Form
    {
        private Button Exit;
        private Button minimize;

        public BaseForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseForm));
            this.Exit = new System.Windows.Forms.Button();
            this.minimize = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Exit
            // 
            this.Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Exit.BackColor = System.Drawing.Color.Red;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Exit.Location = new System.Drawing.Point(396, 5);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(32, 27);
            this.Exit.TabIndex = 0;
            this.Exit.Text = "X";
            this.Exit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // minimize
            // 
            this.minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimize.BackColor = System.Drawing.Color.White;
            this.minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.minimize.Location = new System.Drawing.Point(365, 5);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(32, 27);
            this.minimize.TabIndex = 1;
            this.minimize.Text = "-";
            this.minimize.UseVisualStyleBackColor = false;
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // BaseForm
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(436, 396);
            this.Controls.Add(this.minimize);
            this.Controls.Add(this.Exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "BaseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
