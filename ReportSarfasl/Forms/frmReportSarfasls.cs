using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReportSarfasl.Forms
{
    public partial class frmReportSarfasls : Form
    {
        public frmReportSarfasls()
        {
            InitializeComponent();
        }

        private void reportSarfasl1_txtSarfasl_KeyDownEnter(object sender, EventArgs e)
        {
            var sarfasl = new frmListSarfaslOrZirSarfasl(true, reportSarfasl1.ListSar , reportSarfasl1.txtSarfasl.Text);
            sarfasl.ShowDialog();
            reportSarfasl1.ListSar = sarfasl.listSelected;
            reportSarfasl1.txtSarfasl.Text = sarfasl.Text;
        }

        private void reportSarfasl1_txtZirSarfasl_KeyDownEnter(object sender, EventArgs e)
        {
            var zirSarfasl = new frmListSarfaslOrZirSarfasl(false, reportSarfasl1.ListZirSar, reportSarfasl1.txtZirSarfasl.Text, reportSarfasl1.ListSar);
            zirSarfasl.ShowDialog();
            reportSarfasl1.ListZirSar = zirSarfasl.listSelected;
            reportSarfasl1.txtZirSarfasl.Text = zirSarfasl.Text;
        }

        private void reportSarfasl1_OpenFormZirSarfasl(object sender, EventArgs e)
        {
            Form reportZirsarfasl = new frmReportZirSarfasl(reportSarfasl1.ListSar ,reportSarfasl1.SarfaslIdSelected);
            reportZirsarfasl.ShowDialog();
        }

        private void reportSarfasl1_ButtenCancelClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
