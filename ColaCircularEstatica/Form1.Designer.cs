namespace ColaCircularEstatica
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
            this.lblCola = new System.Windows.Forms.Label();
            this.txtDato = new System.Windows.Forms.TextBox();
            this.btnEncolar = new System.Windows.Forms.Button();
            this.btnDesencolar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtTamaño = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCargar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnFrente = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtNombreArchivo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dato";
            // 
            // lblCola
            // 
            this.lblCola.AutoSize = true;
            this.lblCola.Location = new System.Drawing.Point(230, 24);
            this.lblCola.Name = "lblCola";
            this.lblCola.Size = new System.Drawing.Size(63, 13);
            this.lblCola.TabIndex = 1;
            this.lblCola.Text = "ColaCircular";
            // 
            // txtDato
            // 
            this.txtDato.Location = new System.Drawing.Point(45, 19);
            this.txtDato.Name = "txtDato";
            this.txtDato.Size = new System.Drawing.Size(68, 20);
            this.txtDato.TabIndex = 2;
            // 
            // btnEncolar
            // 
            this.btnEncolar.Location = new System.Drawing.Point(119, 19);
            this.btnEncolar.Name = "btnEncolar";
            this.btnEncolar.Size = new System.Drawing.Size(75, 23);
            this.btnEncolar.TabIndex = 3;
            this.btnEncolar.Text = "Encolar";
            this.btnEncolar.UseVisualStyleBackColor = true;
            this.btnEncolar.Click += new System.EventHandler(this.btnEncolar_Click);
            // 
            // btnDesencolar
            // 
            this.btnDesencolar.Location = new System.Drawing.Point(119, 48);
            this.btnDesencolar.Name = "btnDesencolar";
            this.btnDesencolar.Size = new System.Drawing.Size(75, 23);
            this.btnDesencolar.TabIndex = 4;
            this.btnDesencolar.Text = "Desencolar";
            this.btnDesencolar.UseVisualStyleBackColor = true;
            this.btnDesencolar.Click += new System.EventHandler(this.btnDesencolar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(137, 20);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 5;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtTamaño
            // 
            this.txtTamaño.Location = new System.Drawing.Point(107, 22);
            this.txtTamaño.Name = "txtTamaño";
            this.txtTamaño.Size = new System.Drawing.Size(24, 20);
            this.txtTamaño.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tamaño de la cola";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAceptar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnCargar);
            this.groupBox1.Controls.Add(this.txtTamaño);
            this.groupBox1.Location = new System.Drawing.Point(13, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(357, 49);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(218, 20);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(75, 23);
            this.btnCargar.TabIndex = 5;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtNombreArchivo);
            this.groupBox2.Controls.Add(this.btnFrente);
            this.groupBox2.Controls.Add(this.btnGuardar);
            this.groupBox2.Controls.Add(this.txtDato);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnDesencolar);
            this.groupBox2.Controls.Add(this.lblCola);
            this.groupBox2.Controls.Add(this.btnEncolar);
            this.groupBox2.Location = new System.Drawing.Point(13, 58);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(465, 135);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // btnFrente
            // 
            this.btnFrente.Location = new System.Drawing.Point(233, 48);
            this.btnFrente.Name = "btnFrente";
            this.btnFrente.Size = new System.Drawing.Size(75, 23);
            this.btnFrente.TabIndex = 7;
            this.btnFrente.Text = "Frente";
            this.btnFrente.UseVisualStyleBackColor = true;
            this.btnFrente.Click += new System.EventHandler(this.btnFrente_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(6, 86);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtNombreArchivo
            // 
            this.txtNombreArchivo.Location = new System.Drawing.Point(87, 89);
            this.txtNombreArchivo.Name = "txtNombreArchivo";
            this.txtNombreArchivo.Size = new System.Drawing.Size(100, 20);
            this.txtNombreArchivo.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nombre del archivo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 193);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCola;
        private System.Windows.Forms.TextBox txtDato;
        private System.Windows.Forms.Button btnEncolar;
        private System.Windows.Forms.Button btnDesencolar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txtTamaño;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnFrente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombreArchivo;
    }
}

