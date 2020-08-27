using Gesk.Library;
using Gesk.Library.Objects;
using Gesk.Library.Objects.SubObjects;
using Gesk.Library.Serialization;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Gesk.Forms.Unique.MainChildren
{
    public partial class FRM_Main_KitAdd : Bases.Default
    {
        private Product product = null;
        private List<KitProduct> kitProducts = new List<KitProduct>();

        internal bool Changes = false;

        public FRM_Main_KitAdd()
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

                    this.NUD_Quantity.Focus();
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

                    this.NUD_Quantity.Focus();
                }
            }
        }

        private void TXT_Code_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) this.BTN_Search_Click(this, new EventArgs());
        }

        private void NUD_Quantity_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) BTN_AddProduct.Focus();
        }

        private void BTN_AddProduct_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in LVL_Products.Items)
            {
                if (item.Text == this.product.CodeBSC && item.SubItems[1].Text == this.product.CodeClient)
                {
                    MessageBox.Show("Esse produto já está adicionado na lista! Tente outro por favor.");

                    return;
                }
            }

            this.kitProducts.Add(new KitProduct(Convert.ToInt32(NUD_Quantity.Value), this.product.Id));            

            ListViewItem lvi = LVL_Products.Items.Add(this.product.CodeBSC);
            lvi.SubItems.Add(this.product.CodeClient);
            lvi.SubItems.Add(Convert.ToInt32(NUD_Quantity.Value).ToString());

            LBL_BollhoffCode.Text = "Digite um código e clique em Procurar.";
            LBL_ClientCode.Text = "";
            LBL_Desc.Text = "";
            LBL_Origin.Text = "";

            this.product = null;

            if (TXT_Code.Text.Length > 1) TXT_Code.Select(0, TXT_Code.Text.Length);
            TXT_Code.Focus();

            NUD_Quantity.Value = 1;
        }

        private void BTN_AddKit_Click(object sender, EventArgs e)
        {
            if(TXT_Name.Text.Length < 1)
            {
                MessageBox.Show("O campo Nome não pode ficar em branco! Dê um nome para o kit.");

                return;
            }

            if (GlobalVariables.Kits.Exists(x => x.Name == TXT_Name.Text))
            {
                MessageBox.Show("Já existe um kit com esse nome!");

                return;
            }

            Kit kit = new Kit(GlobalVariables.CurrentFreeKitsId, TXT_Name.Text);
            kit.KitProducts.AddRange(this.kitProducts);

            GlobalVariables.CurrentFreeKitsId++;

            Serialize.Kit(kit);

            GlobalVariables.Kits.Add(kit);

            this.Changes = true;

            MessageBox.Show("Kit adicionado com sucesso!");

            this.Close();
        }

        private void LVL_Products_DoubleClick(object sender, EventArgs e)
        {
            if(LVL_Products.SelectedItems.Count > 0)
            {
                Product product = Product.CloneProduct(LVL_Products.Items[LVL_Products.SelectedIndices[0]].SubItems[1].Text);

                this.kitProducts.RemoveAll(x => x.Id_Product == product.Id);

                LVL_Products.Items.Clear();

                foreach (KitProduct kitProd in this.kitProducts)
                {
                    product = Product.CloneProduct(kitProd.Id_Product);

                    ListViewItem lvi = LVL_Products.Items.Add(product.CodeBSC);
                    lvi.SubItems.Add(product.CodeClient);
                    lvi.SubItems.Add(kitProd.Quantity.ToString());
                } 
            }
        }
    }
}
