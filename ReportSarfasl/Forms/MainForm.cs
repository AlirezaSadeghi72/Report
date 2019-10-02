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
        private border _bSarfasl, _bZirSarfasl, _bActZirSarfasl, _bListSafaslaOrZirSarfasl;

        private void MainForm_Load(object sender, EventArgs e)
        {
            AddReportSafasl();
        }

        #region Handler Reoprt Sarfasl

        private void AddReportSafasl()
        {
            _rSarfasl = new reportSarfasl();
            _rSarfasl.Dock = DockStyle.Fill;
            _rSarfasl.txtSarfasl_KeyDownEnter += _rSarfasl_txtSarfasl_KeyDownEnter;
            _rSarfasl.txtZirSarfasl_KeyDownEnter += _rSarfasl_txtZirSarfasl_KeyDownEnter;
            _rSarfasl.OpenFormZirSarfasl += _rSarfasl_OpenFormZirSarfasl;
            _rSarfasl.OpenFormActZirSarfasl += _rSarfasl_OpenFormActZirSarfasl;
            _rSarfasl.ButtenCancelClick += _rSarfasl_ButtenCancelClick;

            SetBorder(ref _bSarfasl, _rSarfasl,new Size(900,600));
            //_bSarfasl = new border();
            //_bSarfasl.panel1.Controls.Add(_rSarfasl);
            //_bSarfasl.Width = 900;
            //_bSarfasl.Height = 600;
            //_bSarfasl.Location = new Point((Width - _bSarfasl.Width) / 2, (Height - _bSarfasl.Height) / 2);
            ////_sarfasl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            //this.Controls.Add(_bSarfasl);
        }

        #region Handler Event Reoprt Sarfasl
        private void _rSarfasl_txtSarfasl_KeyDownEnter(object sender, EventArgs e)
        {
            _bSarfasl.Enabled = false;
            //var sarfasl = new frmListSarfaslOrZirSarfasl(true, RSarfasl.ListSar, RSarfasl.txtSarfasl.Text);
            //sarfasl.ShowDialog();
            AddListSarfasl();
        }

        private void _rSarfasl_txtZirSarfasl_KeyDownEnter(object sender, EventArgs e)
        {
            _bSarfasl.Enabled = false;
            //var zirSarfasl = new frmListSarfaslOrZirSarfasl(false, RSarfasl.ListZirSar, RSarfasl.txtZirSarfasl.Text, RSarfasl.ListSar);
            //zirSarfasl.ShowDialog();
            AddListZirSarfasl();
        }

        private void _rSarfasl_OpenFormZirSarfasl(object sender, EventArgs e)
        {
            _bSarfasl.Enabled = false;
            //Form reportZirsarfasl = new frmReportZirSarfasl(_rSarfasl.ListZirSar, _rSarfasl.SarfaslIdSelected);
            //reportZirsarfasl.ShowDialog();
            AddReportZirSafasl();
        }

        private void _rSarfasl_OpenFormActZirSarfasl(object sender, EventArgs e)
        {
            _rSarfasl.Enabled = false;
            //Form reportActZirsarfasl = new frmReportActZirSarfasl(sarfaslID: _rSarfasl.SarfaslIdSelected, listZirsarfasl: _rSarfasl.ListZirSar);
            //reportActZirsarfasl.ShowDialog();
            AddReportActZirSarfasl(true);
        }

        private void _rSarfasl_ButtenCancelClick(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion
        #endregion

        #region Handler list choice Sarfasl

        private void AddListSarfasl()
        {
            _listSafasla = new ListSafaslaOrZirSarfasls();
            _listSafasla.Dock = DockStyle.Fill;
            _listSafasla.CloseUserControl += _listSafasla_CloseUserControl;

            SetDataListSarfasl();

            SetBorder(ref _bListSafaslaOrZirSarfasl, _listSafasla, new Size(800, 500));

            //_bListSafaslaOrZirSarfasl = new border();
            //_bListSafaslaOrZirSarfasl.panel1.Controls.Add(_listSafasla);
            //_bListSafaslaOrZirSarfasl.Width = 800;
            //_bListSafaslaOrZirSarfasl.Height = 500;
            //_bListSafaslaOrZirSarfasl.Location = new Point((Width - _bListSafaslaOrZirSarfasl.Width) / 2, (Height - _bListSafaslaOrZirSarfasl.Height) / 2);
            ////_listSafaslaOrZirSarfasl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            //this.Controls.Add(_bListSafaslaOrZirSarfasl);
        }

        private void SetDataListSarfasl()
        {
            _listSafasla.Choise = 1;
            _listSafasla.listSelected = _rSarfasl.ListSar;
            _listSafasla.lblTextSelected.Text = _rSarfasl.txtSarfasl.Text;
        }

        #region Handler Event list choice Sarfasl

        private void _listSafasla_CloseUserControl(object sender, EventArgs e)
        {
            _rSarfasl.ListSar = _listSafasla.listSelected;
            _rSarfasl.txtSarfasl.Text = _listSafasla.lblTextSelected.Text;
            this.Controls.Remove(_bListSafaslaOrZirSarfasl);
            _bSarfasl.Enabled = true;
            _rSarfasl.txtSarfasl.Focus();
        }

        #endregion
        #endregion

        #region Handler list choice ZirSarfasl

        private void AddListZirSarfasl()
        {
            _listZirSarfasl = new ListSafaslaOrZirSarfasls();
            _listZirSarfasl.Dock = DockStyle.Fill;
            _listZirSarfasl.CloseUserControl += _listZirSarfasl_CloseUserControl;

            SetDataListZirSarfasl();

            SetBorder(ref _bListSafaslaOrZirSarfasl, _listZirSarfasl,new Size(800,500));

            //_bListSafaslaOrZirSarfasl = new border();
            //_bListSafaslaOrZirSarfasl.panel1.Controls.Add(_listZirSarfasl);
            //_bListSafaslaOrZirSarfasl.Width = 800;
            //_bListSafaslaOrZirSarfasl.Height = 500;
            //_bListSafaslaOrZirSarfasl.Location = new Point((Width - _bListSafaslaOrZirSarfasl.Width) / 2, (Height - _bListSafaslaOrZirSarfasl.Height) / 2);
            ////_listSafaslaOrZirSarfasl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            //this.Controls.Add(_bListSafaslaOrZirSarfasl);
        }

        private void SetDataListZirSarfasl()
        {
            _listZirSarfasl.Choise = 2;
            _listZirSarfasl.listSarfsl = _rSarfasl.ListSar;
            _listZirSarfasl.listSelected = _rSarfasl.ListZirSar;
            _listZirSarfasl.lblTextSelected.Text = _rSarfasl.txtZirSarfasl.Text;
        }

        #region Handler Event list choice ZirSarfasl

        private void _listZirSarfasl_CloseUserControl(object sender, EventArgs e)
        {

            _rSarfasl.ListZirSar = _listSafasla.listSelected;
            _rSarfasl.txtZirSarfasl.Text = _listSafasla.lblTextSelected.Text;
            this.Controls.Remove(_bListSafaslaOrZirSarfasl);
            _bSarfasl.Enabled = true;
            _rSarfasl.txtZirSarfasl.Focus();

        }

        #endregion
        #endregion


        #region Handler Reoprt ZirSarfasl

        private void AddReportZirSafasl()
        {
            _rZirSarfasl = new ReportZirSarfasl();
            _rZirSarfasl.Dock = DockStyle.Fill;
            _rZirSarfasl.ButtenCancelClick += _rZirSarfasl_ButtenCancelClick;
            _rZirSarfasl.OpenFormActZirSarfasl += _rZirSarfasl_OpenFormActZirSarfasl;

            SetDataReportZirSarfasl();

            SetBorder(ref _bZirSarfasl, _rZirSarfasl, new Size(800, 500));

            //_bZirSarfasl = new border();
            //_bZirSarfasl.panel1.Controls.Add(_rZirSarfasl);
            //_bZirSarfasl.Width = 800;
            //_bZirSarfasl.Height = 500;
            //_bZirSarfasl.Location = new Point((Width - _bZirSarfasl.Width) / 2, (Height - _bZirSarfasl.Height) / 2);
            ////_sarfasl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            //this.Controls.Add(_bZirSarfasl);
        }

        private void SetDataReportZirSarfasl()
        {
            _rZirSarfasl.ListZirSar = _rSarfasl.ListZirSar;
            _rZirSarfasl.SarfaslID = _rSarfasl.SarfaslIdSelected;
        }

        #region Handler Event Reoprt ZirSarfasl
        private void _rZirSarfasl_ButtenCancelClick(object sender, EventArgs e)
        {
            this.Controls.Remove(_bZirSarfasl);
            _bSarfasl.Enabled = true;
            _rSarfasl.txtFilter.Focus();
        }

        private void _rZirSarfasl_OpenFormActZirSarfasl(object sender, EventArgs e)
        {
            //Form reportActZirSarfasl = new frmReportActZirSarfasl(zirSarfaslID: reportZirSarfasl1.ZirSarfaslIdSelected);
            //reportActZirSarfasl.ShowDialog();
            _rZirSarfasl.Enabled = false;
            AddReportActZirSarfasl(false);
        }
        #endregion
        #endregion

        #region Handler Event Reoprt ActZirSarfasl

        private void AddReportActZirSarfasl(bool isSarfasl)
        {
            _rActZirSarfasl = new ReportActZirSarfasl();
            _rActZirSarfasl.Dock = DockStyle.Fill;
            _rActZirSarfasl.ButtenCancelClick += _rActZirSarfasl_ButtenCancelClick;

            SetDataReportActZirSarfasl(isSarfasl);

            SetBorder(ref _bZirSarfasl, _rActZirSarfasl, new Size(800, 500));

            //_bZirSarfasl = new border();
            //_bZirSarfasl.panel1.Controls.Add(_rActZirSarfasl);
            //_bZirSarfasl.Width = 800;
            //_bZirSarfasl.Height = 500;
            //_bZirSarfasl.Location = new Point((Width - _bZirSarfasl.Width) / 2, (Height - _bZirSarfasl.Height) / 2);
            ////_sarfasl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            //this.Controls.Add(_bZirSarfasl);


        }

        private void SetDataReportActZirSarfasl(bool isSarfasl)
        {
            if (!isSarfasl)
            {
                _rActZirSarfasl.ZirSarfaslID = _rZirSarfasl.ZirSarfaslIdSelected;
                _rActZirSarfasl.IsActForSarfasl = false;
            }
            else
            {
                _rActZirSarfasl.SarfaslID = _rSarfasl.SarfaslIdSelected;
                _rActZirSarfasl.ListZirSar = _rSarfasl.ListZirSar;
                _rActZirSarfasl.IsActForSarfasl = true;
            }
        }

        #region Handler Event Reoprt ActZirSarfasl
        private void _rActZirSarfasl_ButtenCancelClick(object sender, EventArgs e)
        {
            this.Controls.Remove(_bZirSarfasl);
            if (_rActZirSarfasl.IsActForSarfasl)
            {
                _rSarfasl.Enabled = true;
                _rSarfasl.txtFilter.Focus();

            }
            else
            {
                _rZirSarfasl.Enabled = true;
                _rZirSarfasl.txtFilter.Focus();
            }
        }

        #endregion
        #endregion


        #region Method

        private void SetBorder(ref border border, UserControl chide ,Size sizeBorder)
        {
            border = new border();
            border.panel1.Controls.Add(chide);
            //border.BringToFront();
            border.Width = sizeBorder.Width;
            border.Height = sizeBorder.Height;
            border.Location = new Point((Width - border.Width) / 2, (Height - border.Height) / 2);
            //border.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.Controls.Add(border);
            border.BringToFront();
            //foreach (Control control in Controls)
            //{
            //    control.SendToBack();
            //}
        }

        #endregion
    }
}
