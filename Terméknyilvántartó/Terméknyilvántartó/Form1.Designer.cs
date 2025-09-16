namespace Terméknyilvántartó
{
    partial class Terméknyilvántartó
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
            this.lbTermekek = new System.Windows.Forms.ListBox();
            this.rbTermekek = new System.Windows.Forms.RadioButton();
            this.rbElektr = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbElektr = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.termékHozzáadásaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbAr = new System.Windows.Forms.TextBox();
            this.tbKeszl = new System.Windows.Forms.TextBox();
            this.tbGar = new System.Windows.Forms.TextBox();
            this.tbAzon = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbNev = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnMod = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTermekek
            // 
            this.lbTermekek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbTermekek.FormattingEnabled = true;
            this.lbTermekek.ItemHeight = 25;
            this.lbTermekek.Location = new System.Drawing.Point(31, 74);
            this.lbTermekek.Name = "lbTermekek";
            this.lbTermekek.Size = new System.Drawing.Size(393, 304);
            this.lbTermekek.TabIndex = 0;
            this.lbTermekek.SelectedIndexChanged += new System.EventHandler(this.lbTermekek_SelectedIndexChanged);
            // 
            // rbTermekek
            // 
            this.rbTermekek.AutoSize = true;
            this.rbTermekek.Checked = true;
            this.rbTermekek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbTermekek.Location = new System.Drawing.Point(44, 427);
            this.rbTermekek.Name = "rbTermekek";
            this.rbTermekek.Size = new System.Drawing.Size(121, 29);
            this.rbTermekek.TabIndex = 3;
            this.rbTermekek.TabStop = true;
            this.rbTermekek.Text = "Termékek";
            this.rbTermekek.UseVisualStyleBackColor = true;
            this.rbTermekek.CheckedChanged += new System.EventHandler(this.rbTermekek_CheckedChanged);
            // 
            // rbElektr
            // 
            this.rbElektr.AutoSize = true;
            this.rbElektr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbElektr.Location = new System.Drawing.Point(44, 462);
            this.rbElektr.Name = "rbElektr";
            this.rbElektr.Size = new System.Drawing.Size(218, 29);
            this.rbElektr.TabIndex = 4;
            this.rbElektr.TabStop = true;
            this.rbElektr.Text = "Elektroniaki termékek";
            this.rbElektr.UseVisualStyleBackColor = true;
            this.rbElektr.CheckedChanged += new System.EventHandler(this.rbElektr_CheckedChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightGray;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(31, 511);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(303, 73);
            this.button2.TabIndex = 5;
            this.button2.Text = "Termék törlése";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(28, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Termékek";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(26, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Elektronikai terrmékek";
            this.label2.Visible = false;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbElektr
            // 
            this.lbElektr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbElektr.FormattingEnabled = true;
            this.lbElektr.ItemHeight = 25;
            this.lbElektr.Location = new System.Drawing.Point(31, 74);
            this.lbElektr.Name = "lbElektr";
            this.lbElektr.Size = new System.Drawing.Size(393, 304);
            this.lbElektr.TabIndex = 8;
            this.lbElektr.Visible = false;
            this.lbElektr.SelectedIndexChanged += new System.EventHandler(this.lbElektr_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.termékHozzáadásaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(722, 33);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // termékHozzáadásaToolStripMenuItem
            // 
            this.termékHozzáadásaToolStripMenuItem.BackColor = System.Drawing.Color.LightGray;
            this.termékHozzáadásaToolStripMenuItem.Name = "termékHozzáadásaToolStripMenuItem";
            this.termékHozzáadásaToolStripMenuItem.Size = new System.Drawing.Size(205, 29);
            this.termékHozzáadásaToolStripMenuItem.Text = "Termék hozzáadása";
            this.termékHozzáadásaToolStripMenuItem.Click += new System.EventHandler(this.termékHozzáadásaToolStripMenuItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(28, 399);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Termék típusok:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(473, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Ár";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(473, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Készleten";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(473, 320);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "Garancia";
            this.label6.Visible = false;
            // 
            // tbAr
            // 
            this.tbAr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbAr.Location = new System.Drawing.Point(478, 224);
            this.tbAr.Name = "tbAr";
            this.tbAr.ReadOnly = true;
            this.tbAr.Size = new System.Drawing.Size(165, 30);
            this.tbAr.TabIndex = 14;
            // 
            // tbKeszl
            // 
            this.tbKeszl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbKeszl.Location = new System.Drawing.Point(478, 287);
            this.tbKeszl.Name = "tbKeszl";
            this.tbKeszl.ReadOnly = true;
            this.tbKeszl.Size = new System.Drawing.Size(165, 30);
            this.tbKeszl.TabIndex = 15;
            // 
            // tbGar
            // 
            this.tbGar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbGar.Location = new System.Drawing.Point(478, 348);
            this.tbGar.Name = "tbGar";
            this.tbGar.ReadOnly = true;
            this.tbGar.Size = new System.Drawing.Size(165, 30);
            this.tbGar.TabIndex = 16;
            this.tbGar.Visible = false;
            // 
            // tbAzon
            // 
            this.tbAzon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbAzon.Location = new System.Drawing.Point(478, 163);
            this.tbAzon.Name = "tbAzon";
            this.tbAzon.ReadOnly = true;
            this.tbAzon.Size = new System.Drawing.Size(165, 30);
            this.tbAzon.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(473, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 25);
            this.label7.TabIndex = 18;
            this.label7.Text = "Azonosító";
            // 
            // tbNev
            // 
            this.tbNev.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tbNev.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbNev.Location = new System.Drawing.Point(478, 102);
            this.tbNev.Name = "tbNev";
            this.tbNev.ReadOnly = true;
            this.tbNev.Size = new System.Drawing.Size(165, 30);
            this.tbNev.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(473, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 25);
            this.label8.TabIndex = 20;
            this.label8.Text = "Megnevezése";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(649, 234);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 16);
            this.label9.TabIndex = 21;
            this.label9.Text = "Ft";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(649, 358);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(22, 16);
            this.label10.TabIndex = 22;
            this.label10.Text = "hó";
            this.label10.Visible = false;
            // 
            // btnMod
            // 
            this.btnMod.BackColor = System.Drawing.Color.LightGray;
            this.btnMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnMod.Location = new System.Drawing.Point(384, 511);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(303, 73);
            this.btnMod.TabIndex = 23;
            this.btnMod.Text = "Termék módosítása";
            this.btnMod.UseVisualStyleBackColor = false;
            this.btnMod.Click += new System.EventHandler(this.btnMod_Click);
            // 
            // Terméknyilvántartó
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 615);
            this.Controls.Add(this.btnMod);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbNev);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbAzon);
            this.Controls.Add(this.tbGar);
            this.Controls.Add(this.tbKeszl);
            this.Controls.Add(this.tbAr);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbElektr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.rbElektr);
            this.Controls.Add(this.rbTermekek);
            this.Controls.Add(this.lbTermekek);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Terméknyilvántartó";
            this.Text = "Terméknyilvántartó";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbTermekek;
        private System.Windows.Forms.RadioButton rbTermekek;
        private System.Windows.Forms.RadioButton rbElektr;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbElektr;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem termékHozzáadásaToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbAr;
        private System.Windows.Forms.TextBox tbKeszl;
        private System.Windows.Forms.TextBox tbGar;
        private System.Windows.Forms.TextBox tbAzon;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbNev;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnMod;
    }
}

