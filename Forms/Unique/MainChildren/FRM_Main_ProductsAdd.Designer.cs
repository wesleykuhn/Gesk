namespace Gesk.Forms.Unique.MainChildren
{
    partial class FRM_Main_ProductsAdd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BTN_ManuallyAdd = new System.Windows.Forms.Button();
            this.NUD_Demand = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.NUD_Stock = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.CBX_Addresses = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TXT_CodeClient = new System.Windows.Forms.TextBox();
            this.TXT_Description = new System.Windows.Forms.TextBox();
            this.TXT_CodeBSC = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PNL_ImportFileBack = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.BTN_ImportExcel = new System.Windows.Forms.Button();
            this.OFD_FileSelector = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Demand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Stock)).BeginInit();
            this.PNL_ImportFileBack.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.PNL_ImportFileBack);
            this.panel1.Location = new System.Drawing.Point(2, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(546, 514);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.BTN_ManuallyAdd);
            this.panel2.Controls.Add(this.NUD_Demand);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.NUD_Stock);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.CBX_Addresses);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.TXT_CodeClient);
            this.panel2.Controls.Add(this.TXT_Description);
            this.panel2.Controls.Add(this.TXT_CodeBSC);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(10, 172);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(526, 321);
            this.panel2.TabIndex = 3;
            // 
            // BTN_ManuallyAdd
            // 
            this.BTN_ManuallyAdd.Location = new System.Drawing.Point(22, 255);
            this.BTN_ManuallyAdd.Name = "BTN_ManuallyAdd";
            this.BTN_ManuallyAdd.Size = new System.Drawing.Size(137, 46);
            this.BTN_ManuallyAdd.TabIndex = 15;
            this.BTN_ManuallyAdd.Text = "Adicionar";
            this.BTN_ManuallyAdd.UseVisualStyleBackColor = true;
            this.BTN_ManuallyAdd.Click += new System.EventHandler(this.BTN_ManuallyAdd_Click);
            // 
            // NUD_Demand
            // 
            this.NUD_Demand.Location = new System.Drawing.Point(96, 206);
            this.NUD_Demand.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.NUD_Demand.Name = "NUD_Demand";
            this.NUD_Demand.Size = new System.Drawing.Size(79, 26);
            this.NUD_Demand.TabIndex = 14;
            this.NUD_Demand.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 208);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 18);
            this.label8.TabIndex = 13;
            this.label8.Text = "Demanda:";
            // 
            // NUD_Stock
            // 
            this.NUD_Stock.Location = new System.Drawing.Point(87, 175);
            this.NUD_Stock.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.NUD_Stock.Name = "NUD_Stock";
            this.NUD_Stock.Size = new System.Drawing.Size(79, 26);
            this.NUD_Stock.TabIndex = 12;
            this.NUD_Stock.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 18);
            this.label7.TabIndex = 11;
            this.label7.Text = "Estoque:";
            // 
            // CBX_Addresses
            // 
            this.CBX_Addresses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBX_Addresses.FormattingEnabled = true;
            this.CBX_Addresses.Location = new System.Drawing.Point(95, 143);
            this.CBX_Addresses.Name = "CBX_Addresses";
            this.CBX_Addresses.Size = new System.Drawing.Size(222, 26);
            this.CBX_Addresses.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 18);
            this.label6.TabIndex = 9;
            this.label6.Text = "Endereço:";
            // 
            // TXT_CodeClient
            // 
            this.TXT_CodeClient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXT_CodeClient.Location = new System.Drawing.Point(126, 113);
            this.TXT_CodeClient.MaxLength = 50;
            this.TXT_CodeClient.Name = "TXT_CodeClient";
            this.TXT_CodeClient.Size = new System.Drawing.Size(256, 26);
            this.TXT_CodeClient.TabIndex = 8;
            // 
            // TXT_Description
            // 
            this.TXT_Description.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXT_Description.Location = new System.Drawing.Point(96, 82);
            this.TXT_Description.MaxLength = 50;
            this.TXT_Description.Name = "TXT_Description";
            this.TXT_Description.Size = new System.Drawing.Size(347, 26);
            this.TXT_Description.TabIndex = 7;
            // 
            // TXT_CodeBSC
            // 
            this.TXT_CodeBSC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXT_CodeBSC.Location = new System.Drawing.Point(80, 51);
            this.TXT_CodeBSC.MaxLength = 50;
            this.TXT_CodeBSC.Name = "TXT_CodeBSC";
            this.TXT_CodeBSC.Size = new System.Drawing.Size(256, 26);
            this.TXT_CodeBSC.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "Descrição:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Código cliente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Código:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.label2.Location = new System.Drawing.Point(18, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Adicionar manualmente:";
            // 
            // PNL_ImportFileBack
            // 
            this.PNL_ImportFileBack.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PNL_ImportFileBack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PNL_ImportFileBack.Controls.Add(this.label1);
            this.PNL_ImportFileBack.Controls.Add(this.BTN_ImportExcel);
            this.PNL_ImportFileBack.Location = new System.Drawing.Point(10, 13);
            this.PNL_ImportFileBack.Name = "PNL_ImportFileBack";
            this.PNL_ImportFileBack.Size = new System.Drawing.Size(526, 137);
            this.PNL_ImportFileBack.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.label1.Location = new System.Drawing.Point(31, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(462, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Importar produtos a partir de um arquivo XML criado pelo \r\nProtheus:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BTN_ImportExcel
            // 
            this.BTN_ImportExcel.Location = new System.Drawing.Point(179, 65);
            this.BTN_ImportExcel.Name = "BTN_ImportExcel";
            this.BTN_ImportExcel.Size = new System.Drawing.Size(166, 57);
            this.BTN_ImportExcel.TabIndex = 0;
            this.BTN_ImportExcel.Text = "Importar arquivo .xml";
            this.BTN_ImportExcel.UseVisualStyleBackColor = true;
            this.BTN_ImportExcel.Click += new System.EventHandler(this.BTN_ImportExcel_Click);
            // 
            // OFD_FileSelector
            // 
            this.OFD_FileSelector.Title = "Localizar Arquivo";
            // 
            // FRM_Main_ProductsAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 546);
            this.Controls.Add(this.panel1);
            this.Name = "FRM_Main_ProductsAdd";
            this.Text = "GESK - Adicionar Produtos";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Demand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Stock)).EndInit();
            this.PNL_ImportFileBack.ResumeLayout(false);
            this.PNL_ImportFileBack.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTN_ImportExcel;
        private System.Windows.Forms.OpenFileDialog OFD_FileSelector;
        private System.Windows.Forms.Panel PNL_ImportFileBack;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox TXT_CodeClient;
        private System.Windows.Forms.TextBox TXT_Description;
        private System.Windows.Forms.TextBox TXT_CodeBSC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CBX_Addresses;
        private System.Windows.Forms.NumericUpDown NUD_Demand;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown NUD_Stock;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BTN_ManuallyAdd;
    }
}