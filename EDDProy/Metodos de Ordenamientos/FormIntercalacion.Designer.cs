namespace EDDemo.Metodos_de_Ordenamientos
{
    partial class FormIntercalacion
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
            this.txtCantidad1 = new System.Windows.Forms.TextBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtArchivo1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCantidad2 = new System.Windows.Forms.TextBox();
            this.btnGenerar2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtArchivo2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnIntercalar = new System.Windows.Forms.Button();
            this.txtIntercalado = new System.Windows.Forms.TextBox();
            this.txtTiempo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtCantidad1
            // 
            this.txtCantidad1.Location = new System.Drawing.Point(62, 69);
            this.txtCantidad1.Name = "txtCantidad1";
            this.txtCantidad1.Size = new System.Drawing.Size(50, 20);
            this.txtCantidad1.TabIndex = 20;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(134, 69);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(101, 20);
            this.btnGenerar.TabIndex = 24;
            this.btnGenerar.Text = "Generar archivo";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(65, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 24);
            this.label3.TabIndex = 25;
            this.label3.Text = "Cantidad a generar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(108, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 24);
            this.label2.TabIndex = 26;
            this.label2.Text = "Archivo 1";
            // 
            // txtArchivo1
            // 
            this.txtArchivo1.Location = new System.Drawing.Point(23, 186);
            this.txtArchivo1.Name = "txtArchivo1";
            this.txtArchivo1.Size = new System.Drawing.Size(360, 20);
            this.txtArchivo1.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label4.Location = new System.Drawing.Point(65, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 24);
            this.label4.TabIndex = 28;
            this.label4.Text = "Cantidad a generar";
            // 
            // txtCantidad2
            // 
            this.txtCantidad2.Location = new System.Drawing.Point(38, 298);
            this.txtCantidad2.Name = "txtCantidad2";
            this.txtCantidad2.Size = new System.Drawing.Size(50, 20);
            this.txtCantidad2.TabIndex = 29;
            // 
            // btnGenerar2
            // 
            this.btnGenerar2.Location = new System.Drawing.Point(150, 298);
            this.btnGenerar2.Name = "btnGenerar2";
            this.btnGenerar2.Size = new System.Drawing.Size(101, 20);
            this.btnGenerar2.TabIndex = 30;
            this.btnGenerar2.Text = "Generar archivo";
            this.btnGenerar2.UseVisualStyleBackColor = true;
            this.btnGenerar2.Click += new System.EventHandler(this.btnGenerar2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label5.Location = new System.Drawing.Point(556, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 24);
            this.label5.TabIndex = 31;
            this.label5.Text = "Archivo 2";
            // 
            // txtArchivo2
            // 
            this.txtArchivo2.Location = new System.Drawing.Point(428, 70);
            this.txtArchivo2.Name = "txtArchivo2";
            this.txtArchivo2.Size = new System.Drawing.Size(360, 20);
            this.txtArchivo2.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label6.Location = new System.Drawing.Point(526, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 24);
            this.label6.TabIndex = 33;
            this.label6.Text = "Archivo intercalado";
            // 
            // btnIntercalar
            // 
            this.btnIntercalar.Location = new System.Drawing.Point(639, 204);
            this.btnIntercalar.Name = "btnIntercalar";
            this.btnIntercalar.Size = new System.Drawing.Size(101, 20);
            this.btnIntercalar.TabIndex = 34;
            this.btnIntercalar.Text = "Intercalar";
            this.btnIntercalar.UseVisualStyleBackColor = true;
            this.btnIntercalar.Click += new System.EventHandler(this.btnIntercalar_Click_1);
            // 
            // txtIntercalado
            // 
            this.txtIntercalado.Location = new System.Drawing.Point(428, 260);
            this.txtIntercalado.Name = "txtIntercalado";
            this.txtIntercalado.Size = new System.Drawing.Size(360, 20);
            this.txtIntercalado.TabIndex = 35;
            // 
            // txtTiempo
            // 
            this.txtTiempo.Location = new System.Drawing.Point(530, 204);
            this.txtTiempo.Name = "txtTiempo";
            this.txtTiempo.ReadOnly = true;
            this.txtTiempo.Size = new System.Drawing.Size(78, 20);
            this.txtTiempo.TabIndex = 36;
            // 
            // FormIntercalacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTiempo);
            this.Controls.Add(this.txtIntercalado);
            this.Controls.Add(this.btnIntercalar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtArchivo2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnGenerar2);
            this.Controls.Add(this.txtCantidad2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtArchivo1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.txtCantidad1);
            this.Name = "FormIntercalacion";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCantidad1;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtArchivo1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCantidad2;
        private System.Windows.Forms.Button btnGenerar2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtArchivo2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnIntercalar;
        private System.Windows.Forms.TextBox txtIntercalado;
        private System.Windows.Forms.TextBox txtTiempo;
    }
}