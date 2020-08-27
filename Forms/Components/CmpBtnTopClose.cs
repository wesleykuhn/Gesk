using System;
using System.Windows.Forms;

namespace Gesk.Forms.Components
{
    public partial class CmpBtnTopClose : Panel
    {
        public CmpBtnTopClose()
        {
            InitializeComponent();
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            this.BackColor = Library.Style.Colors.DarkBlue;
        }

        protected override void OnMouseLeave(EventArgs e)
        {

            this.BackColor = Library.Style.Colors.HeavyDarkBlue;
        }
    }
}
