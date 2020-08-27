using Gesk.Library;
using Gesk.Library.Checker;
using Gesk.Library.Objects.SubObjects;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Gesk.Forms.Unique.MainChildren
{
    public partial class FRM_Main_AddressesAdd : Bases.Default
    {
        public bool Added = false;

        public FRM_Main_AddressesAdd()
        {
            InitializeComponent();

            ReadyForm();

            UnableResize();
        }

        private bool AlreadyExists(Address a)
        {
            if (GlobalVariables.Addresses.Exists(x => x.Row == a.Row && x.Side == a.Side && x.Column == a.Column && x.Rack == a.Rack)) return true;
            else return false;
        }

        private void BTN_SingleAdd_Click(object sender, EventArgs e)
        {
            TXT_SingleColumn.Text = TXT_SingleColumn.Text.Trim();
            TXT_SingleRack.Text = TXT_SingleRack.Text.Trim();
            TXT_SingleRow.Text = TXT_SingleRow.Text.Trim();
            TXT_SingleSide.Text = TXT_SingleSide.Text.Trim();

            if (Validator.TextBoxesHasWord(new TextBox[] { TXT_SingleColumn, TXT_SingleRack, TXT_SingleSide }))
            {
                MessageBox.Show("Você só pode inserir números nos campos armazem, lado, coluna e prateleira.", "Erro!");
                
                return;
            }

            Address address = new Address(GlobalVariables.CurrentFreeAddressId, TXT_SingleRow.Text, TXT_SingleSide.Text, TXT_SingleColumn.Text, TXT_SingleRack.Text);

            if (AlreadyExists(address))
            {
                MessageBox.Show("Já existe um endereço cadastrado com esses dados!", "Erro");
            }

            if(!Library.Serialization.Serialize.Addresses(new Address[] { address }))
            {
                MessageBox.Show("Ocorreu um erro ao tentar salvar o endereço adicionado! Verifique o que houve no arquivos Logs.txt", "Erro!");

                return;
            }

            this.Added = true;

            GlobalVariables.CurrentFreeAddressId++;
            GlobalVariables.Addresses.Add(address);

            MessageBox.Show("Endereço adicionado com sucesso!", "Sucesso");

            TXT_SingleColumn.Text = String.Empty;
            TXT_SingleRack.Text = String.Empty;
            TXT_SingleRow.Text = String.Empty;
            TXT_SingleSide.Text = String.Empty;
        }

        private void BTN_SeqAdd_Click(object sender, EventArgs e)
        {
            DateTime start = DateTime.Now;

            int idBackup = GlobalVariables.CurrentFreeAddressId;

            TXT_SeqColumnEnd.Text = TXT_SeqColumnEnd.Text.Trim();
            TXT_SeqColumnStart.Text = TXT_SeqColumnStart.Text.Trim();
            TXT_SeqRackEnd.Text = TXT_SeqRackEnd.Text.Trim();
            TXT_SeqRackStart.Text = TXT_SeqRackStart.Text.Trim();
            TXT_SeqRow.Text = TXT_SeqRow.Text.Trim();
            TXT_SeqSideEnd.Text = TXT_SeqSideEnd.Text.Trim();
            TXT_SeqSideStart.Text = TXT_SeqSideStart.Text.Trim();

            if (Validator.TextBoxesHasWord(new TextBox[] { TXT_SeqColumnEnd, TXT_SeqColumnStart, TXT_SeqRackEnd, TXT_SeqRackStart, TXT_SeqSideEnd, TXT_SeqSideStart }))
            {
                MessageBox.Show("Você só pode inserir números nos campos armazem, lado, coluna e prateleira.", "Erro!");

                return;
            }

            int sideStart = int.Parse(TXT_SeqSideStart.Text), sideEnd = int.Parse(TXT_SeqSideEnd.Text);
            int columnStart = int.Parse(TXT_SeqColumnStart.Text), columnEnd = int.Parse(TXT_SeqColumnEnd.Text);
            int rackStart = int.Parse(TXT_SeqRackStart.Text), rackEnd = int.Parse(TXT_SeqRackEnd.Text);

            if(sideStart > sideEnd || columnStart > columnEnd || rackStart > rackEnd)
            {
                MessageBox.Show("Os campos lado, coluna e prateleira inicial não podem ser maiores que os campos finais dos mesmos.", "Erro!");

                return;
            }

            List<Address> addresses = new List<Address>();

            for (int s = sideStart; s <= sideEnd; s++)
            {
                for (int c = columnStart; c <= columnEnd; c++)
                {
                    for (int r = rackStart; r <= rackEnd; r++)
                    {
                        string side = "", column = "", rack = "";

                        if (s < 10) side = "0";
                        if (c < 10) column = "0";
                        if (r < 10) rack = "0";

                        side += s.ToString();
                        column += c.ToString();
                        rack += r.ToString();

                        addresses.Add(new Address(GlobalVariables.CurrentFreeAddressId, TXT_SeqRow.Text, side, column, rack));

                        GlobalVariables.CurrentFreeAddressId++;
                    }
                }
            }

            foreach (Address address in addresses)
            {
                if (AlreadyExists(address))
                {
                    MessageBox.Show("Já existe um endereço cadastrado com os dados de um dos endereços da sequência que você quer cadastrar!", "Erro");

                    GlobalVariables.CurrentFreeAddressId = idBackup;

                    return;
                }
            }

            if (!Library.Serialization.Serialize.Addresses(addresses))
            {
                MessageBox.Show("Ocorreu um erro ao tentar salvar o endereço adicionado! Verifique o que houve no arquivos Logs.txt", "Erro!");

                return;
            }

            this.Added = true;

            GlobalVariables.Addresses.AddRange(addresses);
            addresses.Clear();

            DateTime end = DateTime.Now;
            TimeSpan dif = end.Subtract(start);
            MessageBox.Show(dif.TotalMilliseconds.ToString());

            MessageBox.Show("Endereços adicionados com sucesso!", "Sucesso");

            TXT_SeqRow.Text = String.Empty;
            TXT_SeqColumnEnd.Text = String.Empty;
            TXT_SeqColumnStart.Text = String.Empty;
            TXT_SeqRackEnd.Text = String.Empty;
            TXT_SeqRackStart.Text = String.Empty;
            TXT_SeqSideEnd.Text = String.Empty;
            TXT_SeqSideStart.Text = String.Empty;           
        }
    }
}
