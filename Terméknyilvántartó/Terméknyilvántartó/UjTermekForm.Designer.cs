namespace Terméknyilvántartó
{
    partial class UjTermekForm
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
            this.rbUjElek = new System.Windows.Forms.RadioButton();
            this.rbUjTermek = new System.Windows.Forms.RadioButton();
            this.tbUjKeszl = new System.Windows.Forms.TextBox();
            this.tbUjGar = new System.Windows.Forms.TextBox();
            this.tbUjNev = new System.Windows.Forms.TextBox();
            this.tbUjAr = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRogzit = new System.Windows.Forms.Button();
            this.label_honap = new System.Windows.Forms.Label();
            this.label_forint = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rbUjElek
            // 
            this.rbUjElek.AutoSize = true;
            this.rbUjElek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbUjElek.Location = new System.Drawing.Point(42, 253);
            this.rbUjElek.Name = "rbUjElek";
            this.rbUjElek.Size = new System.Drawing.Size(218, 29);
            this.rbUjElek.TabIndex = 0;
            this.rbUjElek.Text = "Új elektronikai termék";
            this.rbUjElek.UseVisualStyleBackColor = true;
            this.rbUjElek.CheckedChanged += new System.EventHandler(this.rbUjElek_CheckedChanged);
            // 
            // rbUjTermek
            // 
            this.rbUjTermek.AutoSize = true;
            this.rbUjTermek.Checked = true;
            this.rbUjTermek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbUjTermek.Location = new System.Drawing.Point(42, 218);
            this.rbUjTermek.Name = "rbUjTermek";
            this.rbUjTermek.Size = new System.Drawing.Size(115, 29);
            this.rbUjTermek.TabIndex = 1;
            this.rbUjTermek.TabStop = true;
            this.rbUjTermek.Text = "Új termék";
            this.rbUjTermek.UseVisualStyleBackColor = true;
            this.rbUjTermek.CheckedChanged += new System.EventHandler(this.rbUjTermek_CheckedChanged);
            // 
            // tbUjKeszl
            // 
            this.tbUjKeszl.Location = new System.Drawing.Point(174, 121);
            this.tbUjKeszl.Name = "tbUjKeszl";
            this.tbUjKeszl.Size = new System.Drawing.Size(206, 22);
            this.tbUjKeszl.TabIndex = 2;
            // 
            // tbUjGar
            // 
            this.tbUjGar.Location = new System.Drawing.Point(174, 163);
            this.tbUjGar.Name = "tbUjGar";
            this.tbUjGar.Size = new System.Drawing.Size(206, 22);
            this.tbUjGar.TabIndex = 3;
            this.tbUjGar.Visible = false;
            // 
            // tbUjNev
            // 
            this.tbUjNev.Location = new System.Drawing.Point(174, 40);
            this.tbUjNev.Name = "tbUjNev";
            this.tbUjNev.Size = new System.Drawing.Size(206, 22);
            this.tbUjNev.TabIndex = 4;
            // 
            // tbUjAr
            // 
            this.tbUjAr.Location = new System.Drawing.Point(174, 77);
            this.tbUjAr.Name = "tbUjAr";
            this.tbUjAr.Size = new System.Drawing.Size(206, 22);
            this.tbUjAr.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(37, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Megnevezés";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(37, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Egységár";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(37, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Készleten";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(37, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Garancia";
            this.label5.Visible = false;
            // 
            // btnRogzit
            // 
            this.btnRogzit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRogzit.Location = new System.Drawing.Point(42, 304);
            this.btnRogzit.Name = "btnRogzit";
            this.btnRogzit.Size = new System.Drawing.Size(338, 71);
            this.btnRogzit.TabIndex = 12;
            this.btnRogzit.Text = "Rögzítés";
            this.btnRogzit.UseVisualStyleBackColor = true;
            this.btnRogzit.Click += new System.EventHandler(this.btnRogzit_Click);
            // 
            // label_honap
            // 
            this.label_honap.AutoSize = true;
            this.label_honap.Location = new System.Drawing.Point(386, 169);
            this.label_honap.Name = "label_honap";
            this.label_honap.Size = new System.Drawing.Size(22, 16);
            this.label_honap.TabIndex = 13;
            this.label_honap.Text = "hó";
            this.label_honap.Visible = false;
            this.label_honap.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label_forint
            // 
            this.label_forint.AutoSize = true;
            this.label_forint.Location = new System.Drawing.Point(387, 82);
            this.label_forint.Name = "label_forint";
            this.label_forint.Size = new System.Drawing.Size(18, 16);
            this.label_forint.TabIndex = 14;
            this.label_forint.Text = "Ft";
            // 
            // UjTermekForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 406);
            this.Controls.Add(this.label_forint);
            this.Controls.Add(this.label_honap);
            this.Controls.Add(this.btnRogzit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbUjAr);
            this.Controls.Add(this.tbUjNev);
            this.Controls.Add(this.tbUjGar);
            this.Controls.Add(this.tbUjKeszl);
            this.Controls.Add(this.rbUjTermek);
            this.Controls.Add(this.rbUjElek);
            this.Name = "UjTermekForm";
            this.Text = "Termék hozzáadása";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.RadioButton rbUjElek;
        protected System.Windows.Forms.RadioButton rbUjTermek;
        protected System.Windows.Forms.TextBox tbUjKeszl;
        protected System.Windows.Forms.TextBox tbUjGar;
        protected System.Windows.Forms.TextBox tbUjNev;
        protected System.Windows.Forms.TextBox tbUjAr;
        protected System.Windows.Forms.Label label2;
        protected System.Windows.Forms.Label label3;
        protected System.Windows.Forms.Label label4;
        protected System.Windows.Forms.Label label5;
        protected System.Windows.Forms.Button btnRogzit;
        private System.Windows.Forms.Label label_honap;
        private System.Windows.Forms.Label label_forint;
    }
}