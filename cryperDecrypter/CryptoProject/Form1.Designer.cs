
namespace EncripterDecripter
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
            this.components = new System.ComponentModel.Container();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.txtClave = new System.Windows.Forms.RichTextBox();
            this.lblClave1 = new System.Windows.Forms.Label();
            this.txtClavePublica = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnImportKeys = new System.Windows.Forms.Button();
            this.btnExportKeys = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtText = new System.Windows.Forms.TextBox();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnImportText = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDesencriptado = new System.Windows.Forms.TextBox();
            this.txtTextoEncriptado = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDesecnriptar = new System.Windows.Forms.Button();
            this.btnEncriptar = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbAlgoritmos = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(9, 15);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(133, 23);
            this.btnGenerar.TabIndex = 0;
            this.btnGenerar.Text = "Generar Llaves";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // txtClave
            // 
            this.txtClave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtClave.Location = new System.Drawing.Point(89, 46);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(323, 53);
            this.txtClave.TabIndex = 1;
            this.txtClave.Text = "";
            // 
            // lblClave1
            // 
            this.lblClave1.AutoSize = true;
            this.lblClave1.Location = new System.Drawing.Point(6, 48);
            this.lblClave1.Name = "lblClave1";
            this.lblClave1.Size = new System.Drawing.Size(73, 13);
            this.lblClave1.TabIndex = 2;
            this.lblClave1.Text = "Clave Privada";
            // 
            // txtClavePublica
            // 
            this.txtClavePublica.Location = new System.Drawing.Point(89, 105);
            this.txtClavePublica.Name = "txtClavePublica";
            this.txtClavePublica.Size = new System.Drawing.Size(323, 53);
            this.txtClavePublica.TabIndex = 3;
            this.txtClavePublica.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Clave Publica";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Texto";
            // 
            // btnImportKeys
            // 
            this.btnImportKeys.Location = new System.Drawing.Point(283, 15);
            this.btnImportKeys.Name = "btnImportKeys";
            this.btnImportKeys.Size = new System.Drawing.Size(129, 23);
            this.btnImportKeys.TabIndex = 6;
            this.btnImportKeys.Text = "Importar Llaves";
            this.btnImportKeys.UseVisualStyleBackColor = true;
            this.btnImportKeys.Click += new System.EventHandler(this.btnImportKeys_Click);
            // 
            // btnExportKeys
            // 
            this.btnExportKeys.Location = new System.Drawing.Point(148, 15);
            this.btnExportKeys.Name = "btnExportKeys";
            this.btnExportKeys.Size = new System.Drawing.Size(129, 23);
            this.btnExportKeys.TabIndex = 7;
            this.btnExportKeys.Text = "Exportar Llaves";
            this.btnExportKeys.UseVisualStyleBackColor = true;
            this.btnExportKeys.Click += new System.EventHandler(this.btnExportKeys_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtClave);
            this.panel1.Controls.Add(this.btnExportKeys);
            this.panel1.Controls.Add(this.btnGenerar);
            this.panel1.Controls.Add(this.btnImportKeys);
            this.panel1.Controls.Add(this.lblClave1);
            this.panel1.Controls.Add(this.txtClavePublica);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(430, 179);
            this.panel1.TabIndex = 8;
            // 
            // txtText
            // 
            this.txtText.Location = new System.Drawing.Point(89, 13);
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(323, 20);
            this.txtText.TabIndex = 9;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(89, 72);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(323, 14);
            this.progressBar2.TabIndex = 21;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(89, 69);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(323, 14);
            this.progressBar1.TabIndex = 20;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // btnImportText
            // 
            this.btnImportText.Location = new System.Drawing.Point(12, 231);
            this.btnImportText.Name = "btnImportText";
            this.btnImportText.Size = new System.Drawing.Size(208, 23);
            this.btnImportText.TabIndex = 19;
            this.btnImportText.Text = "Importar Texto";
            this.btnImportText.UseVisualStyleBackColor = true;
            this.btnImportText.Click += new System.EventHandler(this.btnImportText_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(234, 231);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(208, 23);
            this.btnExport.TabIndex = 18;
            this.btnExport.Text = "Exportar Texto";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Resultado";
            // 
            // txtDesencriptado
            // 
            this.txtDesencriptado.Location = new System.Drawing.Point(89, 92);
            this.txtDesencriptado.Name = "txtDesencriptado";
            this.txtDesencriptado.Size = new System.Drawing.Size(323, 20);
            this.txtDesencriptado.TabIndex = 16;
            // 
            // txtTextoEncriptado
            // 
            this.txtTextoEncriptado.Location = new System.Drawing.Point(89, 17);
            this.txtTextoEncriptado.Name = "txtTextoEncriptado";
            this.txtTextoEncriptado.Size = new System.Drawing.Size(323, 20);
            this.txtTextoEncriptado.TabIndex = 15;
            this.txtTextoEncriptado.TextChanged += new System.EventHandler(this.txtTextoEncriptado_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Texto";
            // 
            // btnDesecnriptar
            // 
            this.btnDesecnriptar.Location = new System.Drawing.Point(89, 43);
            this.btnDesecnriptar.Name = "btnDesecnriptar";
            this.btnDesecnriptar.Size = new System.Drawing.Size(323, 23);
            this.btnDesecnriptar.TabIndex = 13;
            this.btnDesecnriptar.Text = "Desencriptar";
            this.btnDesecnriptar.UseVisualStyleBackColor = true;
            this.btnDesecnriptar.Click += new System.EventHandler(this.btnDesecnriptar_Click);
            // 
            // btnEncriptar
            // 
            this.btnEncriptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnEncriptar.Location = new System.Drawing.Point(89, 39);
            this.btnEncriptar.Name = "btnEncriptar";
            this.btnEncriptar.Size = new System.Drawing.Size(323, 23);
            this.btnEncriptar.TabIndex = 12;
            this.btnEncriptar.Text = "Encriptar";
            this.btnEncriptar.UseVisualStyleBackColor = false;
            this.btnEncriptar.Click += new System.EventHandler(this.btnEncriptar_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(89, 89);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(323, 20);
            this.txtResultado.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Resultado";
            // 
            // cmbAlgoritmos
            // 
            this.cmbAlgoritmos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAlgoritmos.FormattingEnabled = true;
            this.cmbAlgoritmos.Items.AddRange(new object[] {
            "Algoritmo Triple DES",
            "Algoritmo RSA"});
            this.cmbAlgoritmos.Location = new System.Drawing.Point(102, 10);
            this.cmbAlgoritmos.Name = "cmbAlgoritmos";
            this.cmbAlgoritmos.Size = new System.Drawing.Size(340, 21);
            this.cmbAlgoritmos.TabIndex = 11;
            this.cmbAlgoritmos.SelectedIndexChanged += new System.EventHandler(this.cmbAlgoritmos_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Selecciona:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtText);
            this.panel2.Controls.Add(this.txtResultado);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.progressBar1);
            this.panel2.Controls.Add(this.btnEncriptar);
            this.panel2.Location = new System.Drawing.Point(12, 260);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(430, 143);
            this.panel2.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.btnDesecnriptar);
            this.panel3.Controls.Add(this.progressBar2);
            this.panel3.Controls.Add(this.txtTextoEncriptado);
            this.panel3.Controls.Add(this.txtDesencriptado);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(12, 418);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(430, 143);
            this.panel3.TabIndex = 21;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(236)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(457, 573);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbAlgoritmos);
            this.Controls.Add(this.btnImportText);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "CrypterDecrypter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.RichTextBox txtClave;
        private System.Windows.Forms.Label lblClave1;
        private System.Windows.Forms.RichTextBox txtClavePublica;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnImportKeys;
        private System.Windows.Forms.Button btnExportKeys;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.Button btnDesecnriptar;
        private System.Windows.Forms.Button btnEncriptar;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDesencriptado;
        private System.Windows.Forms.TextBox txtTextoEncriptado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbAlgoritmos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnImportText;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}

