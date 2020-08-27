using Gesk.Library.Objects;
using System;
using System.Windows.Forms;

namespace Gesk.Forms.Unique.MainChildren
{
    public partial class FRM_Main_LineTag : Bases.Default
    {
        public FRM_Main_LineTag()
        {
            InitializeComponent();

            this.ReadyForm();
            this.UnableResize();

            TXT_Code.Focus();
        }

        private void BTN_Print_Click(object sender, EventArgs e)
        {
            string desc = " ";
            string codeClient = TXT_Code.Text;

            Product product = Product.CloneProduct(TXT_Code.Text);
            if (product != null)
            {
                codeClient = product.CodeClient;
                desc = product.Description;
            }

            Library.Outputs.Pdf.CreateProductionLineTag(codeClient, desc, TXT_Destination.Text);

            // Print Document settings - new code
            Library.Outputs.AdobePrint.Print();

            if (TXT_Code.Text.Length > 1) TXT_Code.Select(0, TXT_Code.Text.Length);
            TXT_Code.Focus();
        }

        private void TXT_Code_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) TXT_Destination.Focus();
        }

        private void TXT_Destination_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) BTN_Print.Focus();
        }
    }
}
