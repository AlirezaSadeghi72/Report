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
    public partial class frmReportActZirSarfasl : Form
    {
        public frmReportActZirSarfasl(int zirSarfaslID = -1, int sarfaslID = -1, List<int> listZirsarfasl = null)
        {
            InitializeComponent();
            if (zirSarfaslID != -1)
            {
                reportActZirSarfasl1.ZirSarfaslID = zirSarfaslID;
                reportActZirSarfasl1.IsActForSarfasl = false;
            }
            else if (sarfaslID != -1)
            {
                reportActZirSarfasl1.SarfaslID = sarfaslID;
                reportActZirSarfasl1.ListZirSar = listZirsarfasl;
                reportActZirSarfasl1.IsActForSarfasl = true;
            }
            else
            {
                throw new NullReferenceException();
            }
        }

        private void reportActZirSarfasl1_ButtenCancelClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
