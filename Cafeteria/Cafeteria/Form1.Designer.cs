namespace Cafeteria
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_idCli = new System.Windows.Forms.TextBox();
            this.txt_nomCli = new System.Windows.Forms.TextBox();
            this.txt_apeCli = new System.Windows.Forms.TextBox();
            this.txt_dirCli = new System.Windows.Forms.TextBox();
            this.txt_telCli = new System.Windows.Forms.TextBox();
            this.txt_dniCli = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.date_fechaNac = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(102, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "FORMULARIO DEL CLIENTE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "NOMBRE:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "APELLIDOS:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(118, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "DNI:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "DIRECCION:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "TELEFONO:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 172);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "FECHA DE NACIMIENTO";
            // 
            // txt_idCli
            // 
            this.txt_idCli.Location = new System.Drawing.Point(41, 24);
            this.txt_idCli.Name = "txt_idCli";
            this.txt_idCli.Size = new System.Drawing.Size(59, 20);
            this.txt_idCli.TabIndex = 8;
            this.txt_idCli.TextChanged += new System.EventHandler(this.txt_idCli_TextChanged);
            // 
            // txt_nomCli
            // 
            this.txt_nomCli.Location = new System.Drawing.Point(89, 55);
            this.txt_nomCli.Name = "txt_nomCli";
            this.txt_nomCli.Size = new System.Drawing.Size(164, 20);
            this.txt_nomCli.TabIndex = 9;
            // 
            // txt_apeCli
            // 
            this.txt_apeCli.Location = new System.Drawing.Point(90, 81);
            this.txt_apeCli.Name = "txt_apeCli";
            this.txt_apeCli.Size = new System.Drawing.Size(164, 20);
            this.txt_apeCli.TabIndex = 10;
            // 
            // txt_dirCli
            // 
            this.txt_dirCli.Location = new System.Drawing.Point(90, 107);
            this.txt_dirCli.Name = "txt_dirCli";
            this.txt_dirCli.Size = new System.Drawing.Size(163, 20);
            this.txt_dirCli.TabIndex = 11;
            // 
            // txt_telCli
            // 
            this.txt_telCli.Location = new System.Drawing.Point(90, 139);
            this.txt_telCli.Name = "txt_telCli";
            this.txt_telCli.Size = new System.Drawing.Size(164, 20);
            this.txt_telCli.TabIndex = 12;
            // 
            // txt_dniCli
            // 
            this.txt_dniCli.Location = new System.Drawing.Point(153, 24);
            this.txt_dniCli.Name = "txt_dniCli";
            this.txt_dniCli.Size = new System.Drawing.Size(100, 20);
            this.txt_dniCli.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Controls.Add(this.date_fechaNac);
            this.groupBox1.Controls.Add(this.txt_dniCli);
            this.groupBox1.Controls.Add(this.txt_telCli);
            this.groupBox1.Controls.Add(this.txt_dirCli);
            this.groupBox1.Controls.Add(this.txt_apeCli);
            this.groupBox1.Controls.Add(this.txt_nomCli);
            this.groupBox1.Controls.Add(this.txt_idCli);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(29, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 212);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CLIENTE";
            // 
            // date_fechaNac
            // 
            this.date_fechaNac.Location = new System.Drawing.Point(142, 166);
            this.date_fechaNac.Name = "date_fechaNac";
            this.date_fechaNac.Size = new System.Drawing.Size(18, 20);
            this.date_fechaNac.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(130, 269);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "GUARDAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(345, 319);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_idCli;
        private System.Windows.Forms.TextBox txt_nomCli;
        private System.Windows.Forms.TextBox txt_apeCli;
        private System.Windows.Forms.TextBox txt_dirCli;
        private System.Windows.Forms.TextBox txt_telCli;
        private System.Windows.Forms.TextBox txt_dniCli;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker date_fechaNac;
        private System.Windows.Forms.Button button1;
    }
}

