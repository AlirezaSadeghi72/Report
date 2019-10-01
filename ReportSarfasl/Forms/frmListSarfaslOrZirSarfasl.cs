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
    public partial class frmListSarfaslOrZirSarfasl : Form
    {
        public List<int> listSelected = new List<int>();
        public string Text;
        public frmListSarfaslOrZirSarfasl(bool isSarfasl, List<int> listSelected, string text,
            List<int> listSarfasl = null)
        {
            InitializeComponent();
            listSafaslaOrZirSarfasls1.Choise = isSarfasl ? 1 : 2;
            listSafaslaOrZirSarfasls1.listSelected = listSelected;
            listSafaslaOrZirSarfasls1.listSarfsl = listSarfasl;
            listSafaslaOrZirSarfasls1.lblTextSelected.Text = text;
        }
        

        private void listSafaslaOrZirSarfasls1_CloseUserControl(object sender, EventArgs e)
        {
            listSelected = listSafaslaOrZirSarfasls1.listSelected;
            Text = listSafaslaOrZirSarfasls1.lblTextSelected.Text;
            this.Close();
        }
    }
}
