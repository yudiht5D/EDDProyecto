﻿namespace EDDemo.Metodos_de_Ordenamientos
{
    partial class FormQuicksort
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtCantidad1 = new System.Windows.Forms.TextBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLista = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.txtOrdenado = new System.Windows.Forms.TextBox();
            this.txtTiempo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(87, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 24);
            this.label3.TabIndex = 28;
            this.label3.Text = "Cantidad a generar";
            // 
            // txtCantidad1
            // 
            this.txtCantidad1.Location = new System.Drawing.Point(71, 85);
            this.txtCantidad1.Name = "txtCantidad1";
            this.txtCantidad1.Size = new System.Drawing.Size(50, 20);
            this.txtCantidad1.TabIndex = 29;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(180, 85);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(101, 20);
            this.btnGenerar.TabIndex = 30;
            this.btnGenerar.Text = "Generar lista";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(121, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 24);
            this.label2.TabIndex = 31;
            this.label2.Text = "Lista para quicksort";
            // 
            // txtLista
            // 
            this.txtLista.Location = new System.Drawing.Point(24, 232);
            this.txtLista.Name = "txtLista";
            this.txtLista.Size = new System.Drawing.Size(360, 20);
            this.txtLista.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label6.Location = new System.Drawing.Point(464, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 24);
            this.label6.TabIndex = 35;
            this.label6.Text = "Lista ordenada";
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Location = new System.Drawing.Point(628, 85);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(101, 20);
            this.btnOrdenar.TabIndex = 36;
            this.btnOrdenar.Text = "Ordenar";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // txtOrdenado
            // 
            this.txtOrdenado.Location = new System.Drawing.Point(428, 142);
            this.txtOrdenado.Name = "txtOrdenado";
            this.txtOrdenado.Size = new System.Drawing.Size(360, 20);
            this.txtOrdenado.TabIndex = 37;
            // 
            // txtTiempo
            // 
            this.txtTiempo.Location = new System.Drawing.Point(581, 199);
            this.txtTiempo.Name = "txtTiempo";
            this.txtTiempo.ReadOnly = true;
            this.txtTiempo.Size = new System.Drawing.Size(78, 20);
            this.txtTiempo.TabIndex = 38;
            // 
            // FormQuicksort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTiempo);
            this.Controls.Add(this.txtOrdenado);
            this.Controls.Add(this.btnOrdenar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtLista);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.txtCantidad1);
            this.Controls.Add(this.label3);
            this.Name = "FormQuicksort";
            this.Text = "FormQuicksort";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCantidad1;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLista;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.TextBox txtOrdenado;
        private System.Windows.Forms.TextBox txtTiempo;
    }
}