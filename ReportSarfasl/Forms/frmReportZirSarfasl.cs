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
    public partial class frmReportZirSarfasl : Form
    {
        public frmReportZirSarfasl(List<int> ListZirSar,int sarfaslID)
        {
            InitializeComponent();
            reportZirSarfasl1.ListZirSar = ListZirSar;
            reportZirSarfasl1.SarfaslID = sarfaslID;
        }

        private void reportZirSarfasl1_ButtenCancelClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void reportZirSarfasl1_OpenFormActZirSarfasl(object sender, EventArgs e)
        {
            Form reportActZirSarfasl= new frmReportActZirSarfasl(zirSarfaslID:reportZirSarfasl1.ZirSarfaslIdSelected);
            reportActZirSarfasl.ShowDialog();
        }
    }
}
