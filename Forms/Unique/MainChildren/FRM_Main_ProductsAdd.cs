using Gesk.Library;
using Gesk.Library.Objects;
using Gesk.Library.Objects.SubObjects;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;

namespace Gesk.Forms.Unique.MainChildren
{
    public partial class FRM_Main_ProductsAdd : Bases.Default
    {
        internal bool Added = false;

        private Product product = null;

        public FRM_Main_ProductsAdd()
        {
            InitializeComponent();

            this.ReadyForm();

            UnableResize();

            CBX_Addresses.Items.Add("Nenhum");
            CBX_Addresses.SelectedIndex = 0;

            foreach (Address address in GlobalVariables.Addresses)
            {
                CBX_Addresses.Items.Add(address.ToString());
            }
        }

        public FRM_Main_ProductsAdd(Product product)
        {
            InitializeComponent();

            this.ReadyForm();

            this.product = product;

            BTN_ImportExcel.Enabled = false;
            BTN_ManuallyAdd.Text = "Alterar";

            UnableResize();

            TXT_CodeBSC.Text = product.CodeBSC;
            TXT_Description.Text = product.Description;
            TXT_CodeClient.Text = product.CodeClient;

            CBX_Addresses.Items.Add("Nenhum");
            foreach (Address address in GlobalVariables.Addresses)
            {
                CBX_Addresses.Items.Add(address.ToString());
            }
            if (!GlobalVariables.Addresses.Exists(x => x.Id == product.Address_Id)) CBX_Addresses.SelectedIndex = 0;
            else CBX_Addresses.SelectedIndex = CBX_Addresses.Items.IndexOf(Address.GetAddressString(product.Address_Id));

            if (product.Stock <= 0) NUD_Stock.Value = Convert.ToDecimal(0);
            else NUD_Stock.Value = Convert.ToDecimal(product.Stock);

            if (product.Demand <= 0) NUD_Demand.Value = Convert.ToDecimal(0);
            else NUD_Demand.Value = Convert.ToDecimal(product.Demand);
        }

        private void BTN_ImportExcel_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult warningResult = MessageBox.Show("O arquivo deverá ser do tipo XML, ter sido gerado pelo Protheus 12 (SA7) e ter apenas 3 colunas, na seguinte sequência: 'Produto', 'Código do cliente' e 'Descrição do Produto'. Caso essa sequência não seja respeitada então os dados dos produtos ficarão invertidos." +
                "\n\nDeseja continuar?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (warningResult == DialogResult.No) return;
                
                OFD_FileSelector.Filter = "Arquivos Extensible Markup Language|*.xml";                

                DialogResult fsResult = OFD_FileSelector.ShowDialog();
                if (fsResult != DialogResult.OK) return;

                DialogResult resultConf = MessageBox.Show("O arquivo " + OFD_FileSelector.FileName + " foi selecionado, deseja continuar?", "Confirmar Arquivo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult == DialogResult.No) return;

                string fileName = OFD_FileSelector.FileName;
                int alreadyExist = 0, created = 0;

                OFD_FileSelector.Dispose();

                Library.Protheus12Xml.Reader xmlReader = new Library.Protheus12Xml.Reader(fileName);
                List<Product> products = xmlReader.XmlToProducts();
                if (products.Count < 1) return;

                foreach (Product product in products)
                {
                    if (GlobalVariables.Products.Exists(x => x.CodeBSC == product.CodeBSC && x.CodeClient == product.CodeClient))
                    {
                        alreadyExist++;

                        continue;
                    }
                    else
                    {
                        product.Id = GlobalVariables.CurrentFreeProductsId;
                        GlobalVariables.CurrentFreeProductsId++;

                        // RAM
                        GlobalVariables.Products.Add(product);

                        // LOCAL
                        Library.Serialization.Serialize.Product(product);

                        created++;
                    }
                }

                MessageBox.Show(("Produtos lidos: " + xmlReader.TotalRows.ToString() +
                    "\nProdutos que já existiam: " + alreadyExist.ToString() +
                    "\nProdutos cadastrados: " + created.ToString()), "Resultado da importação");

                if (created > 0) this.Added = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível prosseguir com a importação devido um erro. Para mais detalhes veja o arquivo log.txt", "Erro!");

                ErrorsCare.AppendErrorOnErrorsFile(ex.Message);
            }
        }

        private void BTN_ManuallyAdd_Click(object sender, EventArgs e)
        {
            TXT_CodeBSC.Text = TXT_CodeBSC.Text.TrimStart().TrimEnd();
            TXT_CodeClient.Text = TXT_CodeClient.Text.TrimStart().TrimEnd();
            TXT_Description.Text = TXT_Description.Text.TrimStart().TrimEnd();

            if(TXT_CodeBSC.Text == "" || TXT_CodeBSC.Text == null || TXT_CodeClient.Text == "" || TXT_CodeClient.Text == null)
            {
                MessageBox.Show("Os campos código e código cliente são obrigatórios!", "Erro");

                return;
            }

            if (this.product == null && GlobalVariables.Products.Exists(x => x.CodeBSC == TXT_CodeBSC.Text && x.CodeClient == TXT_CodeClient.Text))
            {
                MessageBox.Show("Já existe um produto cadastrado com esse código BSC e código cliente!", "Erro");

                return;
            }
            else if(this.product != null && GlobalVariables.Products.Exists(x => x.Id != this.product.Id && x.CodeBSC == TXT_CodeBSC.Text && x.CodeClient == TXT_CodeClient.Text))
            {
                MessageBox.Show("Já existe um produto cadastrado com esse código BSC e código cliente que você quer colocar como novo!", "Erro");

                return;
            }
            else
            {
                if(this.product == null)
                {
                    int addressId;

                    if (CBX_Addresses.Text == "Nenhum")
                    {
                        addressId = -1;
                    }
                    else
                    {
                        addressId = Address.GetAddressId(CBX_Addresses.Text);
                    }

                    if (!Library.Serialization.Serialize.Product(new Product(GlobalVariables.CurrentFreeProductsId, TXT_CodeBSC.Text, TXT_Description.Text, TXT_CodeClient.Text, Convert.ToInt32(NUD_Stock.Value), addressId, Convert.ToInt32(NUD_Demand.Value), 0, 0, false))) return;

                    GlobalVariables.Products.Add(new Product(GlobalVariables.CurrentFreeProductsId, TXT_CodeBSC.Text, TXT_Description.Text, TXT_CodeClient.Text, Convert.ToInt32(NUD_Stock.Value), addressId, Convert.ToInt32(NUD_Demand.Value), 0, 0, false));

                    GlobalVariables.CurrentFreeProductsId++;

                    MessageBox.Show("Produto adicionado com sucesso!", "Sucesso!");

                    this.Added = true;

                    TXT_CodeBSC.Text = String.Empty;
                    TXT_CodeClient.Text = String.Empty;
                    TXT_Description.Text = String.Empty;
                    NUD_Demand.Value = 0;
                    NUD_Stock.Value = 0;
                    CBX_Addresses.SelectedIndex = 0;
                }
                else
                {
                    this.product.CodeBSC = TXT_CodeBSC.Text;
                    this.product.Description = TXT_Description.Text;
                    this.product.CodeClient = TXT_CodeClient.Text;

                    if (CBX_Addresses.Text == "Nenhum")
                    {
                        this.product.Address_Id = -1;
                    }
                    else
                    {
                        this.product.Address_Id = Address.GetAddressId(CBX_Addresses.Text);
                    }

                    this.product.Stock = Convert.ToInt32(NUD_Stock.Value);
                    this.product.Demand = Convert.ToInt32(NUD_Demand.Value);

                    if (!Library.Serialization.Serialize.Product(this.product)) return;

                    int index = GlobalVariables.Products.FindIndex(x => x.Id == this.product.Id);
                    GlobalVariables.Products[index] = this.product;                    

                    MessageBox.Show("Produto alterado com sucesso!", "Sucesso!");

                    this.Added = true;

                    this.Close();
                }                
            }
        }
    }
}
