namespace Gesk.Forms.Unique.MainChildren
{
    partial class FRM_Main_KitAdd
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
            this.PNL_Background = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.LVL_Products = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.LBL_Origin = new System.Windows.Forms.Label();
            this.LBL_BollhoffCode = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.LBL_Desc = new System.Windows.Forms.Label();
            this.LBL_ClientCode = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.RBT_BollhoffCode = new System.Windows.Forms.RadioButton();
            this.RBT_ClientCode = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.BTN_Search = new System.Windows.Forms.Button();
            this.TXT_Code = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.NUD_Quantity = new System.Windows.Forms.NumericUpDown();
            this.BTN_AddProduct = new System.Windows.Forms.Button();
            this.BTN_AddKit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TXT_Name = new System.Windows.Forms.TextBox();
            this.PNL_Background.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Quantity)).BeginInit();
            this.SuspendLayout();
            // 
            // PNL_Background
            // 
            this.PNL_Background.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PNL_Background.BackColor = System.Drawing.SystemColors.Control;
            this.PNL_Background.Controls.Add(this.label5);
            this.PNL_Background.Controls.Add(this.TXT_Name);
            this.PNL_Background.Controls.Add(this.label3);
            this.PNL_Background.Controls.Add(this.BTN_AddKit);
            this.PNL_Background.Controls.Add(this.panel3);
            this.PNL_Background.Controls.Add(this.LVL_Products);
            this.PNL_Background.Location = new System.Drawing.Point(2, 30);
            this.PNL_Background.Name = "PNL_Background";
            this.PNL_Background.Size = new System.Drawing.Size(951, 464);
            this.PNL_Background.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Quantidade:";
            // 
            // LVL_Products
            // 
            this.LVL_Products.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader3,
            this.columnHeader2});
            this.LVL_Products.FullRowSelect = true;
            this.LVL_Products.GridLines = true;
            this.LVL_Products.HideSelection = false;
            this.LVL_Products.Location = new System.Drawing.Point(438, 8);
            this.LVL_Products.Name = "LVL_Products";
            this.LVL_Products.Size = new System.Drawing.Size(503, 380);
            this.LVL_Products.TabIndex = 1;
            this.LVL_Products.UseCompatibleStateImageBehavior = false;
            this.LVL_Products.View = System.Windows.Forms.View.Details;
            this.LVL_Products.DoubleClick += new System.EventHandler(this.LVL_Products_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Código Böllhoff";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Código Cliente";
            this.columnHeader3.Width = 160;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Quantidade";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader2.Width = 130;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.LBL_Origin);
            this.panel1.Controls.Add(this.LBL_BollhoffCode);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.LBL_ClientCode);
            this.panel1.Location = new System.Drawing.Point(19, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(370, 150);
            this.panel1.TabIndex = 11;
            // 
            // LBL_Origin
            // 
            this.LBL_Origin.AutoSize = true;
            this.LBL_Origin.Location = new System.Drawing.Point(5, 122);
            this.LBL_Origin.Name = "LBL_Origin";
            this.LBL_Origin.Size = new System.Drawing.Size(0, 18);
            this.LBL_Origin.TabIndex = 4;
            // 
            // LBL_BollhoffCode
            // 
            this.LBL_BollhoffCode.AutoSize = true;
            this.LBL_BollhoffCode.Location = new System.Drawing.Point(5, 4);
            this.LBL_BollhoffCode.Name = "LBL_BollhoffCode";
            this.LBL_BollhoffCode.Size = new System.Drawing.Size(244, 18);
            this.LBL_BollhoffCode.TabIndex = 0;
            this.LBL_BollhoffCode.Text = "Digite um código e clique em Procurar.";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.LBL_Desc);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(2, 65);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(352, 52);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // LBL_Desc
            // 
            this.LBL_Desc.AutoSize = true;
            this.LBL_Desc.Location = new System.Drawing.Point(3, 0);
            this.LBL_Desc.Name = "LBL_Desc";
            this.LBL_Desc.Size = new System.Drawing.Size(0, 18);
            this.LBL_Desc.TabIndex = 2;
            // 
            // LBL_ClientCode
            // 
            this.LBL_ClientCode.AutoSize = true;
            this.LBL_ClientCode.Location = new System.Drawing.Point(5, 33);
            this.LBL_ClientCode.Name = "LBL_ClientCode";
            this.LBL_ClientCode.Size = new System.Drawing.Size(0, 18);
            this.LBL_ClientCode.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 18);
            this.label4.TabIndex = 22;
            this.label4.Text = "Código:";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.panel2.Controls.Add(this.RBT_BollhoffCode);
            this.panel2.Controls.Add(this.RBT_ClientCode);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(70, 179);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(267, 30);
            this.panel2.TabIndex = 21;
            // 
            // RBT_BollhoffCode
            // 
            this.RBT_BollhoffCode.AutoSize = true;
            this.RBT_BollhoffCode.ForeColor = System.Drawing.Color.White;
            this.RBT_BollhoffCode.Location = new System.Drawing.Point(13, 5);
            this.RBT_BollhoffCode.Name = "RBT_BollhoffCode";
            this.RBT_BollhoffCode.Size = new System.Drawing.Size(106, 22);
            this.RBT_BollhoffCode.TabIndex = 0;
            this.RBT_BollhoffCode.Text = "Cód. Böllhoff";
            this.RBT_BollhoffCode.UseVisualStyleBackColor = true;
            // 
            // RBT_ClientCode
            // 
            this.RBT_ClientCode.AutoSize = true;
            this.RBT_ClientCode.Checked = true;
            this.RBT_ClientCode.ForeColor = System.Drawing.Color.White;
            this.RBT_ClientCode.Location = new System.Drawing.Point(154, 5);
            this.RBT_ClientCode.Name = "RBT_ClientCode";
            this.RBT_ClientCode.Size = new System.Drawing.Size(102, 22);
            this.RBT_ClientCode.TabIndex = 1;
            this.RBT_ClientCode.TabStop = true;
            this.RBT_ClientCode.Text = "Cód. Cliente";
            this.RBT_ClientCode.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(127, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "-";
            // 
            // BTN_Search
            // 
            this.BTN_Search.Location = new System.Drawing.Point(302, 218);
            this.BTN_Search.Name = "BTN_Search";
            this.BTN_Search.Size = new System.Drawing.Size(87, 26);
            this.BTN_Search.TabIndex = 18;
            this.BTN_Search.Text = "Procurar";
            this.BTN_Search.UseVisualStyleBackColor = true;
            this.BTN_Search.Click += new System.EventHandler(this.BTN_Search_Click);
            // 
            // TXT_Code
            // 
            this.TXT_Code.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TXT_Code.Location = new System.Drawing.Point(77, 218);
            this.TXT_Code.MaxLength = 16;
            this.TXT_Code.Name = "TXT_Code";
            this.TXT_Code.Size = new System.Drawing.Size(219, 26);
            this.TXT_Code.TabIndex = 17;
            this.TXT_Code.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TXT_Code_KeyUp);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.BTN_AddProduct);
            this.panel3.Controls.Add(this.NUD_Quantity);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.TXT_Code);
            this.panel3.Controls.Add(this.BTN_Search);
            this.panel3.Location = new System.Drawing.Point(14, 57);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(404, 397);
            this.panel3.TabIndex = 23;
            // 
            // NUD_Quantity
            // 
            this.NUD_Quantity.Location = new System.Drawing.Point(106, 258);
            this.NUD_Quantity.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.NUD_Quantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUD_Quantity.Name = "NUD_Quantity";
            this.NUD_Quantity.Size = new System.Drawing.Size(109, 26);
            this.NUD_Quantity.TabIndex = 23;
            this.NUD_Quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NUD_Quantity.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.NUD_Quantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUD_Quantity.KeyUp += new System.Windows.Forms.KeyEventHandler(this.NUD_Quantity_KeyUp);
            // 
            // BTN_AddProduct
            // 
            this.BTN_AddProduct.Location = new System.Drawing.Point(247, 337);
            this.BTN_AddProduct.Name = "BTN_AddProduct";
            this.BTN_AddProduct.Size = new System.Drawing.Size(142, 42);
            this.BTN_AddProduct.TabIndex = 24;
            this.BTN_AddProduct.Text = "Adicionar Produto";
            this.BTN_AddProduct.UseVisualStyleBackColor = true;
            this.BTN_AddProduct.Click += new System.EventHandler(this.BTN_AddProduct_Click);
            // 
            // BTN_AddKit
            // 
            this.BTN_AddKit.Location = new System.Drawing.Point(806, 412);
            this.BTN_AddKit.Name = "BTN_AddKit";
            this.BTN_AddKit.Size = new System.Drawing.Size(142, 42);
            this.BTN_AddKit.TabIndex = 25;
            this.BTN_AddKit.Text = "Cadastrar";
            this.BTN_AddKit.UseVisualStyleBackColor = true;
            this.BTN_AddKit.Click += new System.EventHandler(this.BTN_AddKit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(435, 391);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(264, 14);
            this.label3.TabIndex = 26;
            this.label3.Text = "Dois cliques num item da lista para removê-lo.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 18);
            this.label5.TabIndex = 28;
            this.label5.Text = "Nome:";
            // 
            // TXT_Name
            // 
            this.TXT_Name.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TXT_Name.Location = new System.Drawing.Point(67, 14);
            this.TXT_Name.MaxLength = 100;
            this.TXT_Name.Name = "TXT_Name";
            this.TXT_Name.Size = new System.Drawing.Size(351, 26);
            this.TXT_Name.TabIndex = 27;
            // 
            // FRM_Main_KitAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 496);
            this.Controls.Add(this.PNL_Background);
            this.Name = "FRM_Main_KitAdd";
            this.Text = "GESK - Kits > Adicionando Kit";
            this.Controls.SetChildIndex(this.PNL_Background, 0);
            this.PNL_Background.ResumeLayout(false);
            this.PNL_Background.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Quantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PNL_Background;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView LVL_Products;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LBL_Origin;
        private System.Windows.Forms.Label LBL_BollhoffCode;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label LBL_Desc;
        private System.Windows.Forms.Label LBL_ClientCode;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BTN_AddProduct;
        private System.Windows.Forms.NumericUpDown NUD_Quantity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton RBT_BollhoffCode;
        private System.Windows.Forms.RadioButton RBT_ClientCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXT_Code;
        private System.Windows.Forms.Button BTN_Search;
        private System.Windows.Forms.Button BTN_AddKit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TXT_Name;
    }
}