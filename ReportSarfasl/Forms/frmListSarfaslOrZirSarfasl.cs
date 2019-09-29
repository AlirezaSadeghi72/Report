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
        public List<int> listSelected;
        public string Text;
        public frmListSarfaslOrZirSarfasl(bool isSarfasl , List<int> listSelected)
        {
            InitializeComponent();
            listSafaslaOrZirSarfasls1.Choise = isSarfasl ? 1 : 2;
            listSafaslaOrZirSarfasls1.listSelected = listSelected;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                listSelected = listSafaslaOrZirSarfasls1.listSelected;
                Text = listSafaslaOrZirSarfasls1.lblTextSelected.Text;
                this.Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
