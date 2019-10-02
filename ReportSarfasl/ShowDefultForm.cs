using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReportSarfasl.Forms;

namespace ReportSarfasl
{
    public static class ShowDefultForm
    {
        public static void ShowDialog(this DefultForm form, UserControl Childe, Size sizeForm)
        {
            using (var Temp = new System.Windows.Forms.Form())
            {
                //Temp.Dock = System.Windows.Forms.DockStyle.Fill;
                Temp.WindowState = System.Windows.Forms.FormWindowState.Maximized;
                Temp.BackColor = System.Drawing.Color.SlateGray;
                Temp.Opacity = 0.7D;
                Temp.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                Temp.ShowInTaskbar = false;
                Temp.Load += (sender, e) =>
                {
                    Childe.Dock = DockStyle.Fill;
                    form.panel1.Controls.Add(Childe);
                    form.Size = sizeForm;
                    form.StartPosition = FormStartPosition.CenterParent;
                    form.ShowDialog();
                    Temp.Close();
                };
                Temp.ShowDialog();
            }
            
        }
    }
}
