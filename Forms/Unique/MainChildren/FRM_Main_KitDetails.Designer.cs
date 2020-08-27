namespace Gesk.Forms.Unique.MainChildren
{
    partial class FRM_Main_KitDetails
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
            this.LBL_Name = new System.Windows.Forms.Label();
            this.LVL_Products = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.BTN_KitPrint = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.NUD_Copies = new System.Windows.Forms.NumericUpDown();
            this.PNL_Background.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Copies)).BeginInit();
            this.SuspendLayout();
            // 
            // PNL_Background
            // 
            this.PNL_Background.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PNL_Background.BackColor = System.Drawing.SystemColors.Control;
            this.PNL_Background.Controls.Add(this.panel1);
            this.PNL_Background.Controls.Add(this.LVL_Products);
            this.PNL_Background.Controls.Add(this.LBL_Name);
            this.PNL_Background.Location = new System.Drawing.Point(2, 30);
            this.PNL_Background.Name = "PNL_Background";
            this.PNL_Background.Size = new System.Drawing.Size(796, 418);
            this.PNL_Background.TabIndex = 5;
            // 
            // LBL_Name
            // 
            this.LBL_Name.AutoSize = true;
            this.LBL_Name.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Name.Location = new System.Drawing.Point(13, 13);
            this.LBL_Name.Name = "LBL_Name";
            this.LBL_Name.Size = new System.Drawing.Size(56, 23);
            this.LBL_Name.TabIndex = 0;
            this.LBL_Name.Text = "label1";
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
            this.LVL_Products.Location = new System.Drawing.Point(17, 45);
            this.LVL_Products.Name = "LVL_Products";
            this.LVL_Products.Size = new System.Drawing.Size(769, 205);
            this.LVL_Products.TabIndex = 2;
            this.LVL_Products.UseCompatibleStateImageBehavior = false;
            this.LVL_Products.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Código Böllhoff";
            this.columnHeader1.Width = 300;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Código Cliente";
            this.columnHeader3.Width = 260;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Quantidade";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader2.Width = 200;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.NUD_Copies);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.BTN_KitPrint);
            this.panel1.Location = new System.Drawing.Point(17, 274);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(411, 120);
            this.panel1.TabIndex = 3;
            // 
            // BTN_KitPrint
            // 
            this.BTN_KitPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_KitPrint.Location = new System.Drawing.Point(253, 33);
            this.BTN_KitPrint.Name = "BTN_KitPrint";
            this.BTN_KitPrint.Size = new System.Drawing.Size(146, 51);
            this.BTN_KitPrint.TabIndex = 18;
            this.BTN_KitPrint.Text = "Imprimir Etiquetas";
            this.BTN_KitPrint.UseVisualStyleBackColor = true;
            this.BTN_KitPrint.Click += new System.EventHandler(this.BTN_KitPrint_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 18);
            this.label1.TabIndex = 19;
            this.label1.Text = "Quantidade de Kits:";
            // 
            // NUD_Copies
            // 
            this.NUD_Copies.Location = new System.Drawing.Point(141, 49);
            this.NUD_Copies.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.NUD_Copies.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUD_Copies.Name = "NUD_Copies";
            this.NUD_Copies.Size = new System.Drawing.Size(73, 26);
            this.NUD_Copies.TabIndex = 20;
            this.NUD_Copies.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // FRM_Main_KitDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PNL_Background);
            this.Name = "FRM_Main_KitDetails";
            this.Text = "FRM_Main_KitDetails";
            this.Controls.SetChildIndex(this.PNL_Background, 0);
            this.PNL_Background.ResumeLayout(false);
            this.PNL_Background.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Copies)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PNL_Background;
        private System.Windows.Forms.Label LBL_Name;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView LVL_Products;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.NumericUpDown NUD_Copies;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTN_KitPrint;
    }
}