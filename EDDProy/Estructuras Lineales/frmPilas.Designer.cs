
namespace EDDemo
{
    partial class frmPilas
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
            this.txtPila = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCounter = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPop = new System.Windows.Forms.Button();
            this.btnVaciar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPila
            // 
            this.txtPila.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtPila.Location = new System.Drawing.Point(70, 89);
            this.txtPila.Multiline = true;
            this.txtPila.Name = "txtPila";
            this.txtPila.ReadOnly = true;
            this.txtPila.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPila.Size = new System.Drawing.Size(240, 40);
            this.txtPila.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(33, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 24);
            this.label3.TabIndex = 15;
            this.label3.Text = "Pila de elementos";
            // 
            // txtCounter
            // 
            this.txtCounter.Location = new System.Drawing.Point(245, 57);
            this.txtCounter.Name = "txtCounter";
            this.txtCounter.ReadOnly = true;
            this.txtCounter.Size = new System.Drawing.Size(50, 20);
            this.txtCounter.TabIndex = 20;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(417, 109);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label4.Location = new System.Drawing.Point(439, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 24);
            this.label4.TabIndex = 22;
            this.label4.Text = "Valor";
            // 
            // btnPop
            // 
            this.btnPop.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnPop.Location = new System.Drawing.Point(616, 101);
            this.btnPop.Name = "btnPop";
            this.btnPop.Size = new System.Drawing.Size(105, 30);
            this.btnPop.TabIndex = 23;
            this.btnPop.Text = "Pop";
            this.btnPop.UseVisualStyleBackColor = true;
            this.btnPop.Click += new System.EventHandler(this.btnPop_Click);
            // 
            // btnVaciar
            // 
            this.btnVaciar.BackColor = System.Drawing.SystemColors.Info;
            this.btnVaciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnVaciar.Location = new System.Drawing.Point(600, 171);
            this.btnVaciar.Name = "btnVaciar";
            this.btnVaciar.Size = new System.Drawing.Size(130, 30);
            this.btnVaciar.TabIndex = 24;
            this.btnVaciar.Text = "Vaciar pila";
            this.btnVaciar.UseVisualStyleBackColor = false;
            this.btnVaciar.Click += new System.EventHandler(this.btnVaciar_Click);
            // 
            // frmPilas
            // 
            this.ClientSize = new System.Drawing.Size(798, 410);
            this.Controls.Add(this.btnVaciar);
            this.Controls.Add(this.btnPop);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtCounter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPila);
            this.Name = "frmPilas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnPush;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtPila;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCounter;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPop;
        private System.Windows.Forms.Button btnVaciar;
    }
}