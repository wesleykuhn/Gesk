using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing;

namespace Gesk.Forms.Bases
{
    public partial class Default : Form
    {
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;
        private const int cGrip = 16;
        private const int cCaption = 32;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        //Resize var
        private bool Maximized = false;

        public Default()
        {
            InitializeComponent();

            //Form resize
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);
        }

        //Resize
        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush brush = new SolidBrush(Color.FromArgb(0, 22, 22, 22));

            Rectangle rc = new Rectangle(this.ClientSize.Width - cGrip, this.ClientSize.Height - cGrip, cGrip, cGrip);
            ControlPaint.DrawSizeGrip(e.Graphics, this.BackColor, rc);
            rc = new Rectangle(0, 0, this.ClientSize.Width, cCaption);
            e.Graphics.FillRectangle(brush, rc);
        }

        //Move
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {  // Trap WM_NCHITTEST
                Point pos = new Point(m.LParam.ToInt32());
                pos = this.PointToClient(pos);
                if (pos.Y < cCaption)
                {
                    m.Result = (IntPtr)2;
                    return;
                }
                if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip)
                {
                    m.Result = (IntPtr)17;
                    return;
                }
            }
            base.WndProc(ref m);
        }

        private void CMPBtnTopClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LBL_Title_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void Default_Load(object sender, EventArgs e)
        {
            //Don't maximize and get the taskbar also!
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void CMP_BtnTopResize_Click(object sender, EventArgs e)
        {
            this.Maximized = !this.Maximized;

            if (!this.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void Default_Resize(object sender, EventArgs e)
        {
            if (this.Bounds.Width < Screen.FromHandle(this.Handle).WorkingArea.Width || this.Bounds.Height < Screen.FromHandle(this.Handle).WorkingArea.Height)
            {
                this.CMP_BtnTopResize.BackgroundImage = Properties.Resources.icon_maximizar_28x28;
                this.Maximized = false;
            }
            else
            {
                this.CMP_BtnTopResize.BackgroundImage = Properties.Resources.icon_redimensionar_28x28;
                this.Maximized = true;
            }
        }

        private void CMP_BtnTopMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        public void ReadyForm()
        {
            this.LBL_Title.Text = this.Text;

            this.CMP_BtnTopClose.Left = this.Width - 50;
            this.CMP_BtnTopResize.Left = this.Width - 100;
            this.CMP_BtnTopMinimize.Left = this.Width - 150;
        }

        /// <summary>
        /// Desabilita o botão de fechar do formulário.
        /// </summary>
        public void UnableClose()
        {
            this.CMP_BtnTopClose.Enabled = false;
            this.CMP_BtnTopClose.Hide();

            if (this.CMP_BtnTopResize.Enabled)
            {
                this.CMP_BtnTopResize.Left += 50;
            }

            if (this.CMP_BtnTopMinimize.Enabled)
            {
                this.CMP_BtnTopMinimize.Left += 50;
            }
        }

        /// <summary>
        /// Desabilita o botão de Redimencionamento do formulário.
        /// </summary>
        public void UnableResize()
        {
            this.CMP_BtnTopResize.Enabled = false;
            this.CMP_BtnTopResize.Hide();

            if (this.CMP_BtnTopMinimize.Enabled)
            {
                this.CMP_BtnTopMinimize.Left += 50;
            }
        }

        /// <summary>
        /// Desabilita o botão de minimizar do formulário.
        /// </summary>
        public void UnableMinimize()
        {
            this.CMP_BtnTopMinimize.Enabled = false;
            this.CMP_BtnTopMinimize.Hide();
        }
    }
}
