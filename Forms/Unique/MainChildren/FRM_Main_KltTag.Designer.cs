namespace Gesk.Forms.Unique.MainChildren
{
    partial class FRM_Main_KltTag
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
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.RBT_BollhoffCode = new System.Windows.Forms.RadioButton();
            this.RBT_ClientCode = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.NUD_Copies = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.BTN_Print = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LBL_BollhoffCode = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.LBL_Desc = new System.Windows.Forms.Label();
            this.LBL_ClientCode = new System.Windows.Forms.Label();
            this.TXT_Destination = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BTN_Search = new System.Windows.Forms.Button();
            this.TXT_Code = new System.Windows.Forms.TextBox();
            this.PDL_PrintDialog = new System.Windows.Forms.PrintDialog();
            this.LBL_Origin = new System.Windows.Forms.Label();
            this.PNL_Background.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Copies)).BeginInit();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PNL_Background
            // 
            this.PNL_Background.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PNL_Background.BackColor = System.Drawing.SystemColors.Control;
            this.PNL_Background.Controls.Add(this.label4);
            this.PNL_Background.Controls.Add(this.panel2);
            this.PNL_Background.Controls.Add(this.NUD_Copies);
            this.PNL_Background.Controls.Add(this.label2);
            this.PNL_Background.Controls.Add(this.BTN_Print);
            this.PNL_Background.Controls.Add(this.panel1);
            this.PNL_Background.Controls.Add(this.TXT_Destination);
            this.PNL_Background.Controls.Add(this.label3);
            this.PNL_Background.Controls.Add(this.BTN_Search);
            this.PNL_Background.Controls.Add(this.TXT_Code);
            this.PNL_Background.Location = new System.Drawing.Point(2, 30);
            this.PNL_Background.Name = "PNL_Background";
            this.PNL_Background.Size = new System.Drawing.Size(390, 402);
            this.PNL_Background.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 18);
            this.label4.TabIndex = 16;
            this.label4.Text = "Código:";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.panel2.Controls.Add(this.RBT_BollhoffCode);
            this.panel2.Controls.Add(this.RBT_ClientCode);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(61, 186);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(269, 30);
            this.panel2.TabIndex = 15;
            // 
            // RBT_BollhoffCode
            // 
            this.RBT_BollhoffCode.AutoSize = true;
            this.RBT_BollhoffCode.Checked = true;
            this.RBT_BollhoffCode.ForeColor = System.Drawing.Color.White;
            this.RBT_BollhoffCode.Location = new System.Drawing.Point(13, 5);
            this.RBT_BollhoffCode.Name = "RBT_BollhoffCode";
            this.RBT_BollhoffCode.Size = new System.Drawing.Size(106, 22);
            this.RBT_BollhoffCode.TabIndex = 0;
            this.RBT_BollhoffCode.TabStop = true;
            this.RBT_BollhoffCode.Text = "Cód. Böllhoff";
            this.RBT_BollhoffCode.UseVisualStyleBackColor = true;
            // 
            // RBT_ClientCode
            // 
            this.RBT_ClientCode.AutoSize = true;
            this.RBT_ClientCode.ForeColor = System.Drawing.Color.White;
            this.RBT_ClientCode.Location = new System.Drawing.Point(154, 5);
            this.RBT_ClientCode.Name = "RBT_ClientCode";
            this.RBT_ClientCode.Size = new System.Drawing.Size(102, 22);
            this.RBT_ClientCode.TabIndex = 1;
            this.RBT_ClientCode.Text = "Cód. Cliente";
            this.RBT_ClientCode.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(127, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "-";
            // 
            // NUD_Copies
            // 
            this.NUD_Copies.Location = new System.Drawing.Point(66, 303);
            this.NUD_Copies.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUD_Copies.Name = "NUD_Copies";
            this.NUD_Copies.Size = new System.Drawing.Size(45, 26);
            this.NUD_Copies.TabIndex = 14;
            this.NUD_Copies.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 18);
            this.label2.TabIndex = 13;
            this.label2.Text = "Cópias:";
            // 
            // BTN_Print
            // 
            this.BTN_Print.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_Print.Location = new System.Drawing.Point(269, 350);
            this.BTN_Print.Name = "BTN_Print";
            this.BTN_Print.Size = new System.Drawing.Size(111, 42);
            this.BTN_Print.TabIndex = 11;
            this.BTN_Print.Text = "Imprimir";
            this.BTN_Print.UseVisualStyleBackColor = true;
            this.BTN_Print.Click += new System.EventHandler(this.BTN_Print_Click);
            this.BTN_Print.KeyUp += new System.Windows.Forms.KeyEventHandler(this.BTN_Print_KeyUp);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.LBL_Origin);
            this.panel1.Controls.Add(this.LBL_BollhoffCode);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.LBL_ClientCode);
            this.panel1.Location = new System.Drawing.Point(10, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(370, 150);
            this.panel1.TabIndex = 10;
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
            // TXT_Destination
            // 
            this.TXT_Destination.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TXT_Destination.Location = new System.Drawing.Point(120, 263);
            this.TXT_Destination.MaxLength = 16;
            this.TXT_Destination.Name = "TXT_Destination";
            this.TXT_Destination.Size = new System.Drawing.Size(260, 26);
            this.TXT_Destination.TabIndex = 2;
            this.TXT_Destination.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TXT_Destination_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Endereço linha: ";
            // 
            // BTN_Search
            // 
            this.BTN_Search.Location = new System.Drawing.Point(293, 225);
            this.BTN_Search.Name = "BTN_Search";
            this.BTN_Search.Size = new System.Drawing.Size(87, 26);
            this.BTN_Search.TabIndex = 1;
            this.BTN_Search.Text = "Procurar";
            this.BTN_Search.UseVisualStyleBackColor = true;
            this.BTN_Search.Click += new System.EventHandler(this.BTN_Search_Click);
            // 
            // TXT_Code
            // 
            this.TXT_Code.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TXT_Code.Location = new System.Drawing.Point(68, 225);
            this.TXT_Code.MaxLength = 16;
            this.TXT_Code.Name = "TXT_Code";
            this.TXT_Code.Size = new System.Drawing.Size(219, 26);
            this.TXT_Code.TabIndex = 0;
            this.TXT_Code.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TXT_Code_KeyUp);
            // 
            // PDL_PrintDialog
            // 
            this.PDL_PrintDialog.UseEXDialog = true;
            // 
            // LBL_Origin
            // 
            this.LBL_Origin.AutoSize = true;
            this.LBL_Origin.Location = new System.Drawing.Point(5, 122);
            this.LBL_Origin.Name = "LBL_Origin";
            this.LBL_Origin.Size = new System.Drawing.Size(0, 18);
            this.LBL_Origin.TabIndex = 4;
            // 
            // FRM_Main_KltTag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 434);
            this.Controls.Add(this.PNL_Background);
            this.Name = "FRM_Main_KltTag";
            this.Text = "GESK - Produtos > Impressão de Etiqueta";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FRM_Main_KltTag_FormClosing);
            this.Controls.SetChildIndex(this.PNL_Background, 0);
            this.PNL_Background.ResumeLayout(false);
            this.PNL_Background.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Copies)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PNL_Background;
        private System.Windows.Forms.Button BTN_Print;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LBL_BollhoffCode;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label LBL_Desc;
        private System.Windows.Forms.Label LBL_ClientCode;
        private System.Windows.Forms.TextBox TXT_Destination;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BTN_Search;
        private System.Windows.Forms.TextBox TXT_Code;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton RBT_ClientCode;
        private System.Windows.Forms.RadioButton RBT_BollhoffCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PrintDialog PDL_PrintDialog;
        private System.Windows.Forms.NumericUpDown NUD_Copies;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LBL_Origin;
    }
}