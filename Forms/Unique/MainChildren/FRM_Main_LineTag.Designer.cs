namespace Gesk.Forms.Unique.MainChildren
{
    partial class FRM_Main_LineTag
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
            this.BTN_Print = new System.Windows.Forms.Button();
            this.TXT_Destination = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TXT_Code = new System.Windows.Forms.TextBox();
            this.PNL_Background.SuspendLayout();
            this.SuspendLayout();
            // 
            // PNL_Background
            // 
            this.PNL_Background.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PNL_Background.BackColor = System.Drawing.SystemColors.Control;
            this.PNL_Background.Controls.Add(this.BTN_Print);
            this.PNL_Background.Controls.Add(this.TXT_Destination);
            this.PNL_Background.Controls.Add(this.label3);
            this.PNL_Background.Controls.Add(this.label4);
            this.PNL_Background.Controls.Add(this.TXT_Code);
            this.PNL_Background.Location = new System.Drawing.Point(2, 30);
            this.PNL_Background.Name = "PNL_Background";
            this.PNL_Background.Size = new System.Drawing.Size(396, 168);
            this.PNL_Background.TabIndex = 5;
            // 
            // BTN_Print
            // 
            this.BTN_Print.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_Print.Location = new System.Drawing.Point(275, 116);
            this.BTN_Print.Name = "BTN_Print";
            this.BTN_Print.Size = new System.Drawing.Size(111, 42);
            this.BTN_Print.TabIndex = 21;
            this.BTN_Print.Text = "Imprimir";
            this.BTN_Print.UseVisualStyleBackColor = true;
            this.BTN_Print.Click += new System.EventHandler(this.BTN_Print_Click);
            // 
            // TXT_Destination
            // 
            this.TXT_Destination.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TXT_Destination.Location = new System.Drawing.Point(124, 54);
            this.TXT_Destination.MaxLength = 16;
            this.TXT_Destination.Name = "TXT_Destination";
            this.TXT_Destination.Size = new System.Drawing.Size(262, 26);
            this.TXT_Destination.TabIndex = 19;
            this.TXT_Destination.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TXT_Destination_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 18);
            this.label3.TabIndex = 20;
            this.label3.Text = "Endereço linha: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 18);
            this.label4.TabIndex = 18;
            this.label4.Text = "Código:";
            // 
            // TXT_Code
            // 
            this.TXT_Code.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TXT_Code.Location = new System.Drawing.Point(71, 15);
            this.TXT_Code.MaxLength = 10;
            this.TXT_Code.Name = "TXT_Code";
            this.TXT_Code.Size = new System.Drawing.Size(315, 26);
            this.TXT_Code.TabIndex = 17;
            this.TXT_Code.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TXT_Code_KeyUp);
            // 
            // FRM_Main_LineTag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 200);
            this.Controls.Add(this.PNL_Background);
            this.Name = "FRM_Main_LineTag";
            this.Text = "GESK - Produtos > Etiqueta Linha";
            this.Controls.SetChildIndex(this.PNL_Background, 0);
            this.PNL_Background.ResumeLayout(false);
            this.PNL_Background.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PNL_Background;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TXT_Code;
        private System.Windows.Forms.TextBox TXT_Destination;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BTN_Print;
    }
}