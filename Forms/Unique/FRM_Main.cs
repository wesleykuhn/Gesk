using Gesk.Forms.Unique.MainChildren;
using Gesk.Library;
using Gesk.Library.Checker;
using Gesk.Library.Objects;
using Gesk.Library.Objects.SubObjects;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Gesk.Forms.Unique
{
    public partial class FRM_Main : Bases.Default
    {
        public FRM_Main()
        {
            InitializeComponent();

            //Remover caso o programa se torne pago
            ErrorsCare.AntiInvalidInstance = false;

            StartUp.MakeCheckUps();

            this.ReadyForm();
            
            if (!ErrorsCare.AntiInvalidInstance)
            {
                this.UpdateAddresses();
                this.UpdateProducts();
                this.UpdateKits();
            }
        }

        private void UpdateProducts()
        {
            this.LBL_ProductsCount.Text = "Produtos cadastrados: " + GlobalVariables.Products.Count;

            LVL_Products.Items.Clear();
            foreach (Product product in GlobalVariables.Products)
            {
                ListViewItem lvi = LVL_Products.Items.Add(product.CodeBSC);
                lvi.SubItems.Add(product.Description);
                lvi.SubItems.Add(product.CodeClient);
                lvi.SubItems.Add(Address.GetAddressStringNonStorage(product.Address_Id));
                lvi.SubItems.Add(product.Stock.ToString());                
                lvi.SubItems.Add(product.Demand.ToString());
                lvi.SubItems.Add(product.DailyConsuption.ToString());
                lvi.SubItems.Add(product.Billed.ToString());
                lvi.SubItems.Add(product.Status.ToString());
                lvi.SubItems.Add(product.DailyConsuption.ToString());

                if (lvi.Index % 2 == 1)
                {
                    lvi.BackColor = Color.FromArgb(190, 245, 205);
                }
            }
        }

        private void ProductToList(Product product)
        {
            ListViewItem lvi = LVL_Products.Items.Add(product.CodeBSC);
            lvi.SubItems.Add(product.Description);
            lvi.SubItems.Add(product.CodeClient);
            lvi.SubItems.Add(Address.GetAddressStringNonStorage(product.Address_Id));
            lvi.SubItems.Add(product.Stock.ToString());            
            lvi.SubItems.Add(product.Demand.ToString());
            lvi.SubItems.Add(product.DailyConsuption.ToString());
            lvi.SubItems.Add(product.Billed.ToString());
            lvi.SubItems.Add(product.Status.ToString());
            lvi.SubItems.Add(product.DailyConsuption.ToString());

            if (lvi.Index % 2 == 1)
            {
                lvi.BackColor = Color.FromArgb(190, 245, 205);
            }
        }

        private void UpdateAddresses()
        {
            this.LBL_AddressesCount.Text = "Endereços cadastrados: " + GlobalVariables.Addresses.Count;

            LVL_Addresses.Items.Clear();
            foreach (Address address in GlobalVariables.Addresses)
            {
                ListViewItem lvi = LVL_Addresses.Items.Add(address.Row);
                lvi.SubItems.Add(address.Side);
                lvi.SubItems.Add(address.Column);
                lvi.SubItems.Add(address.Rack);
                lvi.SubItems.Add(address.ToString());

                if (lvi.Index % 2 == 1)
                {
                    lvi.BackColor = Color.FromArgb(190, 245, 205);
                }
            }
        }

        private void UpdateKits()
        {
            this.LBL_KitsCount.Text = "Kits cadastrados: " + GlobalVariables.Kits.Count;

            LVL_Kits.Items.Clear();
            foreach (Kit kit in GlobalVariables.Kits)
            {
                ListViewItem lvi = LVL_Kits.Items.Add(kit.Name);
                lvi.SubItems.Add(kit.KitProducts.Count.ToString());

                if (lvi.Index % 2 == 1)
                {
                    lvi.BackColor = Color.FromArgb(190, 245, 205);
                }
            }
        }

        private void FRM_Main_KeyDown(object sender, KeyEventArgs e)
        {
            if (TXT_ProductsSearch.Focused || TXT_AddressesSearch.Focused) return;

            if (TBC_Tabs.SelectedTab == TAB_Products)
            {
                if (e.KeyCode == Keys.K) this.BTN_PrintProductTag_Click(this, new EventArgs());
                else if (e.KeyCode == Keys.L) BTN_LineTag_Click(this, new EventArgs());
                else if (e.KeyCode == Keys.C) this.BTN_ProductsAdd_Click(this, new EventArgs());
                else if (e.KeyCode == Keys.A) this.BTN_UpdateAddresses_Click(this, new EventArgs());
            }
            else if (TBC_Tabs.SelectedTab == TAB_Addresses)
            {
                if (e.KeyCode == Keys.C) this.BTN_AddressesAdd_Click(this, new EventArgs());
            }
            else if(TBC_Tabs.SelectedTab == TAB_Kits)
            {
                if (e.KeyCode == Keys.C) this.BTN_KitAdd_Click(this, new EventArgs());
            }
        }

        private void BTN_AddressesAdd_Click(object sender, EventArgs e)
        {
            MainChildren.FRM_Main_AddressesAdd addressesAdd = new MainChildren.FRM_Main_AddressesAdd();
            addressesAdd.ShowDialog();

            if (addressesAdd.Added) this.UpdateAddresses();
        }

        private void BTN_ProductsAdd_Click(object sender, EventArgs e)
        {
            MainChildren.FRM_Main_ProductsAdd addProduct = new MainChildren.FRM_Main_ProductsAdd();
            addProduct.ShowDialog();

            if (addProduct.Added) this.UpdateProducts();
        }

        private void LVL_Products_DoubleClick(object sender, EventArgs e)
        {
            if (LVL_Products.SelectedItems.Count > 0)
            {
                string codeBsc = LVL_Products.Items[LVL_Products.SelectedIndices[0]].Text;
                string desc = LVL_Products.Items[LVL_Products.SelectedIndices[0]].SubItems[1].Text;
                string codeClient = LVL_Products.Items[LVL_Products.SelectedIndices[0]].SubItems[2].Text;

                int index = GlobalVariables.Products.FindIndex(x => x.CodeBSC == codeBsc && x.Description == desc && x.CodeClient == codeClient);

                FRM_Main_ProductsAdd alterProduct = new FRM_Main_ProductsAdd(GlobalVariables.Products[index]);
                alterProduct.ShowDialog();
                if (alterProduct.Added) this.UpdateProducts();
            }
        }

        private void BTN_PrintProductTag_Click(object sender, EventArgs e)
        {
            Forms.Unique.MainChildren.FRM_Main_KltTag print = new MainChildren.FRM_Main_KltTag();
            print.ShowDialog();
        }        

        private void BTN_UpdateAddresses_Click(object sender, EventArgs e)
        {
            DialogResult warningResult = MessageBox.Show("O arquivo deverá ser do tipo XML, ter sido gerado pelo Protheus 12 (SBF) e ter apenas 2 colunas, na seguinte sequência: 'Produto' e 'Endereço'. Caso essa sequência não seja respeitada então os dados dos produtos ficarão invertidos." +
               "\n\nDeseja continuar?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (warningResult == DialogResult.No) return;

            OFD_FileSelector.Filter = "Arquivos Extensible Markup Language|*.xml";

            DialogResult fsResult = OFD_FileSelector.ShowDialog();
            if (fsResult != DialogResult.OK) return;

            DialogResult resultConf = MessageBox.Show("O arquivo " + OFD_FileSelector.FileName + " foi selecionado, deseja continuar?", "Confirmar Arquivo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult == DialogResult.No) return;

            string fileName = OFD_FileSelector.FileName;

            OFD_FileSelector.Dispose();

            Library.Protheus12Xml.Reader xmlReader = new Library.Protheus12Xml.Reader(fileName);
            List<Library.Protheus12Xml.SubObjects.Duplicate> duplicates = xmlReader.UpdateProductsAddresses();

            if(duplicates.Count > 0)
            {
                MessageBox.Show("Existem conflitos nos endereços lidos, por favor, verifique e corriga.", "Atenção!");
                
                FRM_Main_ProductsAddressUpdateDuplicates frmDuplicates = new FRM_Main_ProductsAddressUpdateDuplicates(duplicates);
                frmDuplicates.ShowDialog();
            }

            Library.Serialization.Serialize.Products(GlobalVariables.Products);

            this.UpdateProducts();
        }

        private void BTN_LineTag_Click(object sender, EventArgs e)
        {
            FRM_Main_LineTag lineTag = new FRM_Main_LineTag();
            lineTag.ShowDialog();
        }

        private void TXT_ProductsSearch_TextChanged(object sender, EventArgs e)
        {
            if (LVL_Products.Items.Count == GlobalVariables.Products.Count) return;

            if(TXT_ProductsSearch.Text == null || TXT_ProductsSearch.Text.Length < 1 || TXT_ProductsSearch.Text == String.Empty) this.UpdateProducts();            
        }

        private void BTN_Search_Click(object sender, EventArgs e)
        {
            var filtered = GlobalVariables.Products.Where(x => x.CodeBSC.Contains(TXT_ProductsSearch.Text) || x.CodeClient.Contains(TXT_ProductsSearch.Text) || x.Description.Contains(TXT_ProductsSearch.Text)).Select(x => x.Id);

            this.LBL_ProductsCount.Text = "Produtos Encontrados: " + filtered.Count();
            LVL_Products.Items.Clear();

            if (filtered.Count() > 0)
            {
                foreach (int id in filtered)
                {
                    this.ProductToList(Product.CloneProduct(id));
                }
            }
            else
            {
                ListViewItem lvi = LVL_Products.Items.Add("Nenhum produto encontrado...");
            }
        }

        private void TXT_ProductsSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) this.BTN_Search_Click(this, new EventArgs());  
        }

        private void BTN_KitAdd_Click(object sender, EventArgs e)
        {
            FRM_Main_KitAdd kitAdd = new FRM_Main_KitAdd();
            kitAdd.ShowDialog();

            if (kitAdd.Changes)
            {
                this.UpdateKits();
            }
        }

        private void LVL_Kits_DoubleClick(object sender, EventArgs e)
        {
            if(LVL_Kits.SelectedItems.Count > 0)
            {
                int index = GlobalVariables.Kits.FindIndex(x => x.Name == LVL_Kits.Items[LVL_Kits.SelectedIndices[0]].Text);

                FRM_Main_KitDetails kitDetails = new FRM_Main_KitDetails(GlobalVariables.Kits[index]);
                kitDetails.ShowDialog();
            }
        }
    }
}
