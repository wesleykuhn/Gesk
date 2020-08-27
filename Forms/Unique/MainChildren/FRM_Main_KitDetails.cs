using Gesk.Library;
using Gesk.Library.Objects;
using Gesk.Library.Objects.SubObjects;
using Gesk.Library.Outputs;
using System;
using System.Windows.Forms;

namespace Gesk.Forms.Unique.MainChildren
{
    public partial class FRM_Main_KitDetails : Bases.Default
    {
        private readonly Kit kit;

        public FRM_Main_KitDetails(Kit kit)
        {
            InitializeComponent();

            this.ReadyForm();
            this.UnableResize();

            LBL_Name.Text = kit.Name;

            foreach (KitProduct kp in kit.KitProducts)
            {
                Product product = Product.CloneProduct(kp.Id_Product);

                if (product == null) continue;

                ListViewItem lvi = LVL_Products.Items.Add(product.CodeBSC);
                lvi.SubItems.Add(product.CodeClient);
                lvi.SubItems.Add(kp.Quantity.ToString());
            }

            this.kit = kit;
        }

        private void BTN_KitPrint_Click(object sender, EventArgs e)
        {
            foreach (KitProduct kp in this.kit.KitProducts)
            {
                if (!GlobalVariables.Products.Exists(x => x.Id == kp.Id_Product)) continue;

                Library.Outputs.Pdf.CreateKitTag(Product.CloneProduct(kp.Id_Product), kp.Quantity, this.kit.Name);

                AdobePrint.Print(Convert.ToInt32(NUD_Copies.Value));
            }

            MessageBox.Show("Etiquetas impressas com sucesso!");
        }
    }
}
