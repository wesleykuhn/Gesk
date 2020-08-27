namespace Gesk.Forms.Unique.MainChildren
{
    partial class FRM_Main_ProductsAddressUpdateDuplicates
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
            this.LBL_Completed = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.LBL_Desc = new System.Windows.Forms.Label();
            this.BTN_Stop = new System.Windows.Forms.Button();
            this.BTN_Next = new System.Windows.Forms.Button();
            this.LBL_CodeBSC = new System.Windows.Forms.Label();
            this.LVL_Duplicates = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.LBL_Completed);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.BTN_Stop);
            this.panel1.Controls.Add(this.BTN_Next);
            this.panel1.Controls.Add(this.LBL_CodeBSC);
            this.panel1.Controls.Add(this.LVL_Duplicates);
            this.panel1.Location = new System.Drawing.Point(2, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 368);
            this.panel1.TabIndex = 5;
            // 
            // LBL_Completed
            // 
            this.LBL_Completed.AutoSize = true;
            this.LBL_Completed.Location = new System.Drawing.Point(510, 323);
            this.LBL_Completed.Name = "LBL_Completed";
            this.LBL_Completed.Size = new System.Drawing.Size(28, 18);
            this.LBL_Completed.TabIndex = 9;
            this.LBL_Completed.Text = "1/1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(394, 274);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Selecione o endereço correto e clique em Próximo.";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.LBL_Desc);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(11, 42);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(355, 77);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // LBL_Desc
            // 
            this.LBL_Desc.AutoSize = true;
            this.LBL_Desc.Location = new System.Drawing.Point(3, 0);
            this.LBL_Desc.Name = "LBL_Desc";
            this.LBL_Desc.Size = new System.Drawing.Size(74, 18);
            this.LBL_Desc.TabIndex = 3;
            this.LBL_Desc.Text = "Descrição: ";
            // 
            // BTN_Stop
            // 
            this.BTN_Stop.Location = new System.Drawing.Point(17, 309);
            this.BTN_Stop.Name = "BTN_Stop";
            this.BTN_Stop.Size = new System.Drawing.Size(115, 46);
            this.BTN_Stop.TabIndex = 6;
            this.BTN_Stop.Text = "Parar";
            this.BTN_Stop.UseVisualStyleBackColor = true;
            this.BTN_Stop.Click += new System.EventHandler(this.BTN_Stop_Click);
            // 
            // BTN_Next
            // 
            this.BTN_Next.Location = new System.Drawing.Point(575, 309);
            this.BTN_Next.Name = "BTN_Next";
            this.BTN_Next.Size = new System.Drawing.Size(115, 46);
            this.BTN_Next.TabIndex = 5;
            this.BTN_Next.Text = "Próximo";
            this.BTN_Next.UseVisualStyleBackColor = true;
            this.BTN_Next.Click += new System.EventHandler(this.BTN_Next_Click);
            // 
            // LBL_CodeBSC
            // 
            this.LBL_CodeBSC.AutoSize = true;
            this.LBL_CodeBSC.Location = new System.Drawing.Point(14, 21);
            this.LBL_CodeBSC.Name = "LBL_CodeBSC";
            this.LBL_CodeBSC.Size = new System.Drawing.Size(58, 18);
            this.LBL_CodeBSC.TabIndex = 2;
            this.LBL_CodeBSC.Text = "Código: ";
            // 
            // LVL_Duplicates
            // 
            this.LVL_Duplicates.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LVL_Duplicates.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.LVL_Duplicates.FullRowSelect = true;
            this.LVL_Duplicates.GridLines = true;
            this.LVL_Duplicates.HideSelection = false;
            this.LVL_Duplicates.Location = new System.Drawing.Point(382, 21);
            this.LVL_Duplicates.MultiSelect = false;
            this.LVL_Duplicates.Name = "LVL_Duplicates";
            this.LVL_Duplicates.Size = new System.Drawing.Size(308, 250);
            this.LVL_Duplicates.TabIndex = 1;
            this.LVL_Duplicates.UseCompatibleStateImageBehavior = false;
            this.LVL_Duplicates.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Endereços em conflito";
            this.columnHeader1.Width = 300;
            // 
            // FRM_Main_ProductsAddressUpdateDuplicates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 400);
            this.Controls.Add(this.panel1);
            this.Name = "FRM_Main_ProductsAddressUpdateDuplicates";
            this.Text = "GESK - Produtos > Conflito na Atualização de Endereço";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label LBL_Desc;
        private System.Windows.Forms.Button BTN_Stop;
        private System.Windows.Forms.Button BTN_Next;
        private System.Windows.Forms.Label LBL_CodeBSC;
        private System.Windows.Forms.ListView LVL_Duplicates;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LBL_Completed;
    }
}