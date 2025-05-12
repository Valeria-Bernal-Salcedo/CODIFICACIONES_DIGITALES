namespace PRACTICA_CODIFICACIONES_DIGITALES
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
            this.signal = new System.Windows.Forms.TextBox();
            this.GRAFICAR = new System.Windows.Forms.Button();
            this.pbNRZL = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbNRZL)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(128, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "SEÑAL A GRAFICAR:";
            // 
            // signal
            // 
            this.signal.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signal.Location = new System.Drawing.Point(458, 50);
            this.signal.Name = "signal";
            this.signal.Size = new System.Drawing.Size(290, 35);
            this.signal.TabIndex = 1;
            // 
            // GRAFICAR
            // 
            this.GRAFICAR.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GRAFICAR.Location = new System.Drawing.Point(855, 53);
            this.GRAFICAR.Name = "GRAFICAR";
            this.GRAFICAR.Size = new System.Drawing.Size(277, 58);
            this.GRAFICAR.TabIndex = 2;
            this.GRAFICAR.Text = "GRAFICAR";
            this.GRAFICAR.UseVisualStyleBackColor = true;
            this.GRAFICAR.Click += new System.EventHandler(this.GRAFICAR_Click);
            // 
            // pbNRZL
            // 
            this.pbNRZL.Location = new System.Drawing.Point(59, 123);
            this.pbNRZL.Name = "pbNRZL";
            this.pbNRZL.Size = new System.Drawing.Size(1137, 196);
            this.pbNRZL.TabIndex = 3;
            this.pbNRZL.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1229, 717);
            this.Controls.Add(this.pbNRZL);
            this.Controls.Add(this.GRAFICAR);
            this.Controls.Add(this.signal);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbNRZL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox signal;
        private System.Windows.Forms.Button GRAFICAR;
        private System.Windows.Forms.PictureBox pbNRZL;
    }
}

