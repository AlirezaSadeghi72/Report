using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReportSarfasl.Forms
{
    public class MainForm : System.Windows.Forms.Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // MainForm
            // 
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }
        private reportSarfasl _rSarfasl;
        private ListSafaslaOrZirSarfasls _listSafasla;
        private ListSafaslaOrZirSarfasls _listZirSarfasl;
        private ReportZirSarfasl _rZirSarfasl;
        private ReportActZirSarfasl _rActZirSarfasl;
        private border _sarfasl, _zirSarfasl, _actZirSarfasl;

        private void MainForm_Load(object sender, EventArgs e)
        {
            AddReportSafasl();
        }

        #region Handler Event Reoprt Sarfasl

        private void AddReportSafasl()
        {
            _rSarfasl = new reportSarfasl();
            _rSarfasl.Dock = DockStyle.Fill;
            _rSarfasl.txtSarfasl_KeyDownEnter += reportSarfasl1_txtSarfasl_KeyDownEnter;
            _rSarfasl.txtZirSarfasl_KeyDownEnter += reportSarfasl1_txtZirSarfasl_KeyDownEnter;
            _rSarfasl.OpenFormZirSarfasl += reportSarfasl1_OpenFormZirSarfasl;
            _rSarfasl.OpenFormActZirSarfasl += reportSarfasl1_OpenFormActZirSarfasl;
            _rSarfasl.ButtenCancelClick += reportSarfasl1_ButtenCancelClick;

            _sarfasl.panel1.Controls.Add(_rSarfasl);
            _sarfasl.Width = 900;
            _sarfasl.Height = 600;
            _sarfasl.Location = new Point((Width - _sarfasl.Width) / 2, (Height - _sarfasl.Height) / 2);
            //_sarfasl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.Controls.Add(_sarfasl);
        }

        private void reportSarfasl1_txtSarfasl_KeyDownEnter(object sender, EventArgs e)
        {
            _sarfasl.Visible = false;
            //var sarfasl = new frmListSarfaslOrZirSarfasl(true, RSarfasl.ListSar, RSarfasl.txtSarfasl.Text);
            //sarfasl.ShowDialog();
            addListSarfasl();

            _sarfasl.Visible = true;

            _rSarfasl.ListSar = _listSafasla.listSelected;
            _rSarfasl.txtSarfasl.Text = _listSafasla.Text;
        }

        private void reportSarfasl1_txtZirSarfasl_KeyDownEnter(object sender, EventArgs e)
        {
            //var zirSarfasl = new frmListSarfaslOrZirSarfasl(false, RSarfasl.ListZirSar, RSarfasl.txtZirSarfasl.Text, RSarfasl.ListSar);
            //zirSarfasl.ShowDialog();
            _rSarfasl.ListZirSar = _listZirSarfasl.listSelected;
            _rSarfasl.txtZirSarfasl.Text = _listZirSarfasl.Text;
        }

        private void reportSarfasl1_OpenFormZirSarfasl(object sender, EventArgs e)
        {
            Form reportZirsarfasl = new frmReportZirSarfasl(_rSarfasl.ListZirSar, _rSarfasl.SarfaslIdSelected);
            reportZirsarfasl.ShowDialog();
        }

        private void reportSarfasl1_OpenFormActZirSarfasl(object sender, EventArgs e)
        {
            Form reportActZirsarfasl = new frmReportActZirSarfasl(sarfaslID: _rSarfasl.SarfaslIdSelected, listZirsarfasl: _rSarfasl.ListZirSar);
            reportActZirsarfasl.ShowDialog();
        }

        private void reportSarfasl1_ButtenCancelClick(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region Handler Event list choice Sarfasl Or ZirSarfasl

        private void addListSarfasl()
        {
            _rZirSarfasl = new ReportZirSarfasl();
            _rZirSarfasl.Dock = DockStyle.Fill;

            _zirSarfasl.panel1.Controls.Add(_rSarfasl);
            _zirSarfasl.Width = 800;
            _zirSarfasl.Height = 700;
            _zirSarfasl.Location = new Point((Width - _sarfasl.Width) / 2, (Height - _sarfasl.Height) / 2);
            //_zirSarfasl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.Controls.Add(_zirSarfasl);
        }

        #endregion

        #region Handler Event Reoprt ZirSarfasl

        #endregion

        #region Handler Event Reoprt ActZirSarfasl

        #endregion

    }
}
