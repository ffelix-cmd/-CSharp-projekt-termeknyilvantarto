namespace Terméknyilvántartó
{
    partial class ModositoForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnMegse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rbUjElek
            // 
            this.rbUjElek.Visible = false;
            // 
            // rbUjTermek
            // 
            this.rbUjTermek.Visible = false;
            // 
            // btnRogzit
            // 
            this.btnRogzit.Text = "Mentés";
            this.btnRogzit.Click += new System.EventHandler(this.btnRogzit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(387, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "hó";
            this.label1.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(386, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Ft";
            // 
            // btnMegse
            // 
            this.btnMegse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnMegse.Location = new System.Drawing.Point(42, 396);
            this.btnMegse.Name = "btnMegse";
            this.btnMegse.Size = new System.Drawing.Size(338, 69);
            this.btnMegse.TabIndex = 15;
            this.btnMegse.Text = "Mégse";
            this.btnMegse.UseVisualStyleBackColor = true;
            this.btnMegse.Click += new System.EventHandler(this.btnMegse_Click);
            // 
            // ModositoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 536);
            this.Controls.Add(this.btnMegse);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Name = "ModositoForm";
            this.Text = "Termék módosítása";
            this.Controls.SetChildIndex(this.rbUjElek, 0);
            this.Controls.SetChildIndex(this.rbUjTermek, 0);
            this.Controls.SetChildIndex(this.tbUjKeszl, 0);
            this.Controls.SetChildIndex(this.tbUjGar, 0);
            this.Controls.SetChildIndex(this.tbUjNev, 0);
            this.Controls.SetChildIndex(this.tbUjAr, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.btnRogzit, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.btnMegse, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnMegse;
    }
}