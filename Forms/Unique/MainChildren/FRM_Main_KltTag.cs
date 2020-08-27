using Gesk.Library;
using Gesk.Library.Objects;
using Gesk.Library.Objects.SubObjects;
using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace Gesk.Forms.Unique.MainChildren
{
    public partial class FRM_Main_KltTag : Bases.Default
    {
        private Product product = null;

        private System.Drawing.Printing.PrintDocument printDocument = new System.Drawing.Printing.PrintDocument();

        public FRM_Main_KltTag()
        {
            InitializeComponent();

            this.ReadyForm();
            this.UnableResize();

            TXT_Code.Focus();
        }

        private void BTN_Search_Click(object sender, EventArgs e)
        {
            int index;

            if (RBT_BollhoffCode.Checked)
            {
                index = GlobalVariables.Products.FindIndex(x => x.CodeBSC == TXT_Code.Text);
                if (index < 0)
                {
                    LBL_BollhoffCode.Text = "Produto não encontrado!";
                    LBL_ClientCode.Text = "";
                    LBL_Desc.Text = "";
                    LBL_Origin.Text = "";

                    this.product = null;
                }
                else
                {                  
                    LBL_BollhoffCode.Text = "Código Böllhoff: " + GlobalVariables.Products[index].CodeBSC;
                    LBL_ClientCode.Text = "Código cliente: " + GlobalVariables.Products[index].CodeClient;
                    LBL_Desc.Text = "Descrição: " + GlobalVariables.Products[index].Description;
                    LBL_Origin.Text = "Origem: " + Address.GetAddressString(GlobalVariables.Products[index].Address_Id);

                    this.product = GlobalVariables.Products[index];

                    this.TXT_Destination_GiveFocus();
                }
            }
            else
            {
                Product product = Product.CloneProduct(TXT_Code.Text);
                if (product == null)
                {
                    LBL_BollhoffCode.Text = "Produto não encontrado!";
                    LBL_ClientCode.Text = "";
                    LBL_Desc.Text = "";
                    LBL_Origin.Text = "";

                    this.product = null;
                }
                else
                {
                    LBL_BollhoffCode.Text = "Código Böllhoff: " + product.CodeBSC;
                    LBL_ClientCode.Text = "Código cliente: " + product.CodeClient;
                    LBL_Desc.Text = "Descrição: " + product.Description;
                    LBL_Origin.Text = "Origem: " + Address.GetAddressString(product.Address_Id);

                    this.product = product;

                    this.TXT_Destination_GiveFocus();
                }
            }
        }

        private void BTN_Print_Click(object sender, EventArgs e)
        {
            if (this.product == null) return;

            // PDF Generator
            Library.Outputs.Pdf.CreateProductTag(this.product, TXT_Destination.Text);

            // Print Document settings - new code
            Library.Outputs.AdobePrint.Print(Convert.ToInt32(NUD_Copies.Value));                 
            
            if (TXT_Code.Text.Length > 1) TXT_Code.Select(0, TXT_Code.Text.Length);
            TXT_Code.Focus();
        }   

        private void TXT_Destination_GiveFocus()
        {
            TXT_Destination.Focus();

            if(TXT_Destination.Text.Length > 1)
            {
                TXT_Destination.SelectionStart = 0;
                TXT_Destination.SelectionLength = TXT_Destination.Text.Length;
            }            
        }

        private void TXT_Code_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) this.BTN_Search_Click(this, new EventArgs());
            else if (e.KeyCode == Keys.Left) this.RBT_BollhoffCode.Checked = true;
            else if (e.KeyCode == Keys.Right) this.RBT_ClientCode.Checked = true;
            else if (e.KeyCode == Keys.Escape) this.Close();
            else if (e.KeyCode == Keys.Up)
            {
                if (NUD_Copies.Value < 100) NUD_Copies.Value++;
            }
            else if (e.KeyCode == Keys.Down)
            {
                if (NUD_Copies.Value > 1) NUD_Copies.Value--;
            }
        }

        private void TXT_Destination_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) BTN_Print.Focus();
            else if (e.KeyCode == Keys.Escape) this.Close();
            else if (e.KeyCode == Keys.Up)
            {
                if(NUD_Copies.Value < 100) NUD_Copies.Value++;                
            }
            else if (e.KeyCode == Keys.Down)
            {
                if (NUD_Copies.Value > 1) NUD_Copies.Value--;
            }
        }

        private void BTN_Print_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                if (NUD_Copies.Value < 100) NUD_Copies.Value++;
            }
            else if (e.KeyCode == Keys.Down)
            {
                if (NUD_Copies.Value > 1) NUD_Copies.Value--;
            }
        }

        private void FRM_Main_KltTag_FormClosing(object sender, FormClosingEventArgs e)
        {
            Library.Outputs.AdobePrint.KillAdobe();
        }
    }
}
