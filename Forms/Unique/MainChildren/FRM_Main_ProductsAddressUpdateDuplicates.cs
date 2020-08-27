using Gesk.Library;
using Gesk.Library.Objects.SubObjects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Gesk.Forms.Unique.MainChildren
{
    public partial class FRM_Main_ProductsAddressUpdateDuplicates : Bases.Default
    {
        private int counter = 0;
        private List<Library.Protheus12Xml.SubObjects.Duplicate> duplicates = new List<Library.Protheus12Xml.SubObjects.Duplicate>();

        public FRM_Main_ProductsAddressUpdateDuplicates(List<Library.Protheus12Xml.SubObjects.Duplicate> duplicates)
        {
            InitializeComponent();            

            this.ReadyForm();

            this.UnableResize();

            this.duplicates = duplicates;

            this.UpdateUI();
        }

        private void UpdateUI()
        {
            LVL_Duplicates.Items.Clear();

            LBL_Completed.Text = this.counter.ToString() + "/" + this.duplicates.Count.ToString();

            int index = GlobalVariables.Products.FindIndex(x => x.CodeBSC == this.duplicates[this.counter].CodeBSC);

            LBL_CodeBSC.Text = "Código: " + this.duplicates[this.counter].CodeBSC;
            LBL_Desc.Text = "Descrição: " + GlobalVariables.Products[index].Description;

            foreach (int address_id in this.duplicates[this.counter].Addresses_Id)
            {
                ListViewItem lvi = LVL_Duplicates.Items.Add(Address.GetAddressString(address_id));

                if (lvi.Index % 2 == 1)
                {
                    lvi.BackColor = Color.FromArgb(190, 245, 205);
                }
            }
        }

        private void BTN_Next_Click(object sender, EventArgs e)
        {
            if(LVL_Duplicates.SelectedItems.Count < 1)
            {
                MessageBox.Show("Você precisa selecionar um endereço, que é o correto, antes de continuar!", "Erro!");

                return;
            }

            int addressId = Address.GetAddressId(LVL_Duplicates.Items[LVL_Duplicates.SelectedIndices[0]].Text);

            int[] productsIds = GlobalVariables.Products.Where(x => x.CodeBSC == this.duplicates[this.counter].CodeBSC).Select(x => x.Id).ToArray();
            foreach (int id in productsIds)
            {
                GlobalVariables.Products[id].Address_Id = addressId;
            }

            this.counter++;

            if(this.counter == this.duplicates.Count)
            {
                MessageBox.Show("Todos os conflitos foram resolvidos!", "Concluído!");

                this.Close();
            }
            else
            {
                this.UpdateUI();
            }
        }

        private void BTN_Stop_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja realmente parar de verificar as duplicatas? Isso é muito importante!", "Atenção!", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes) this.Close();
        }
    }
}
