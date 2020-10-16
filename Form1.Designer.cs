namespace RegisztracioAlkalmazas
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxNev = new System.Windows.Forms.TextBox();
            this.szulDatumBeker = new System.Windows.Forms.DateTimePicker();
            this.radioButtonFerfi = new System.Windows.Forms.RadioButton();
            this.radioButtonNo = new System.Windows.Forms.RadioButton();
            this.listBoxHobbiLista = new System.Windows.Forms.ListBox();
            this.textBoxUjhobbi = new System.Windows.Forms.TextBox();
            this.buttonHozzaad = new System.Windows.Forms.Button();
            this.buttonMentes = new System.Windows.Forms.Button();
            this.buttonBetoltes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(35, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Név:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(35, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Szül. dátum:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(35, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nem:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(325, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kedvenc hobbi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(241, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Új hobbi:";
            // 
            // textBoxNev
            // 
            this.textBoxNev.Location = new System.Drawing.Point(192, 37);
            this.textBoxNev.Name = "textBoxNev";
            this.textBoxNev.Size = new System.Drawing.Size(127, 20);
            this.textBoxNev.TabIndex = 5;
            // 
            // szulDatumBeker
            // 
            this.szulDatumBeker.Location = new System.Drawing.Point(154, 80);
            this.szulDatumBeker.Name = "szulDatumBeker";
            this.szulDatumBeker.Size = new System.Drawing.Size(165, 20);
            this.szulDatumBeker.TabIndex = 6;
            // 
            // radioButtonFerfi
            // 
            this.radioButtonFerfi.AutoSize = true;
            this.radioButtonFerfi.Checked = true;
            this.radioButtonFerfi.Location = new System.Drawing.Point(154, 129);
            this.radioButtonFerfi.Name = "radioButtonFerfi";
            this.radioButtonFerfi.Size = new System.Drawing.Size(31, 17);
            this.radioButtonFerfi.TabIndex = 7;
            this.radioButtonFerfi.TabStop = true;
            this.radioButtonFerfi.Text = "F";
            this.radioButtonFerfi.UseVisualStyleBackColor = true;
            // 
            // radioButtonNo
            // 
            this.radioButtonNo.AutoSize = true;
            this.radioButtonNo.Location = new System.Drawing.Point(217, 129);
            this.radioButtonNo.Name = "radioButtonNo";
            this.radioButtonNo.Size = new System.Drawing.Size(33, 17);
            this.radioButtonNo.TabIndex = 8;
            this.radioButtonNo.Text = "N";
            this.radioButtonNo.UseVisualStyleBackColor = true;
            // 
            // listBoxHobbiLista
            // 
            this.listBoxHobbiLista.FormattingEnabled = true;
            this.listBoxHobbiLista.Location = new System.Drawing.Point(348, 69);
            this.listBoxHobbiLista.Name = "listBoxHobbiLista";
            this.listBoxHobbiLista.Size = new System.Drawing.Size(120, 95);
            this.listBoxHobbiLista.TabIndex = 9;
            // 
            // textBoxUjhobbi
            // 
            this.textBoxUjhobbi.Location = new System.Drawing.Point(341, 225);
            this.textBoxUjhobbi.Name = "textBoxUjhobbi";
            this.textBoxUjhobbi.Size = new System.Drawing.Size(127, 20);
            this.textBoxUjhobbi.TabIndex = 10;
            // 
            // buttonHozzaad
            // 
            this.buttonHozzaad.Location = new System.Drawing.Point(393, 261);
            this.buttonHozzaad.Name = "buttonHozzaad";
            this.buttonHozzaad.Size = new System.Drawing.Size(75, 23);
            this.buttonHozzaad.TabIndex = 11;
            this.buttonHozzaad.Text = "Hozzáad";
            this.buttonHozzaad.UseVisualStyleBackColor = true;
            this.buttonHozzaad.Click += new System.EventHandler(this.buttonHozzaad_Click);
            // 
            // buttonMentes
            // 
            this.buttonMentes.Location = new System.Drawing.Point(312, 355);
            this.buttonMentes.Name = "buttonMentes";
            this.buttonMentes.Size = new System.Drawing.Size(75, 23);
            this.buttonMentes.TabIndex = 12;
            this.buttonMentes.Text = "Mentés";
            this.buttonMentes.UseVisualStyleBackColor = true;
            // 
            // buttonBetoltes
            // 
            this.buttonBetoltes.Location = new System.Drawing.Point(393, 355);
            this.buttonBetoltes.Name = "buttonBetoltes";
            this.buttonBetoltes.Size = new System.Drawing.Size(75, 23);
            this.buttonBetoltes.TabIndex = 13;
            this.buttonBetoltes.Text = "Betöltés";
            this.buttonBetoltes.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 413);
            this.Controls.Add(this.buttonBetoltes);
            this.Controls.Add(this.buttonMentes);
            this.Controls.Add(this.buttonHozzaad);
            this.Controls.Add(this.textBoxUjhobbi);
            this.Controls.Add(this.listBoxHobbiLista);
            this.Controls.Add(this.radioButtonNo);
            this.Controls.Add(this.radioButtonFerfi);
            this.Controls.Add(this.szulDatumBeker);
            this.Controls.Add(this.textBoxNev);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxNev;
        private System.Windows.Forms.DateTimePicker szulDatumBeker;
        private System.Windows.Forms.RadioButton radioButtonFerfi;
        private System.Windows.Forms.RadioButton radioButtonNo;
        private System.Windows.Forms.ListBox listBoxHobbiLista;
        private System.Windows.Forms.TextBox textBoxUjhobbi;
        private System.Windows.Forms.Button buttonHozzaad;
        private System.Windows.Forms.Button buttonMentes;
        private System.Windows.Forms.Button buttonBetoltes;
    }
}

