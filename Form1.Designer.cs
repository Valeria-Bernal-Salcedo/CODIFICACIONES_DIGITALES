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
            this.pbNRZI = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pbBipAMI = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbNRZL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNRZI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBipAMI)).BeginInit();
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
            this.pbNRZL.Location = new System.Drawing.Point(53, 159);
            this.pbNRZL.Name = "pbNRZL";
            this.pbNRZL.Size = new System.Drawing.Size(1137, 196);
            this.pbNRZL.TabIndex = 3;
            this.pbNRZL.TabStop = false;
            // 
            // pbNRZI
            // 
            this.pbNRZI.Location = new System.Drawing.Point(53, 429);
            this.pbNRZI.Name = "pbNRZI";
            this.pbNRZI.Size = new System.Drawing.Size(1137, 208);
            this.pbNRZI.TabIndex = 4;
            this.pbNRZI.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(55, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "SEÑAL NRZ-L";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 387);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "SEÑAL NRZ-I";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(55, 689);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(221, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "SEÑAL BIPOLAR AMI";
            // 
            // pbBipAMI
            // 
            this.pbBipAMI.Location = new System.Drawing.Point(53, 731);
            this.pbBipAMI.Name = "pbBipAMI";
            this.pbBipAMI.Size = new System.Drawing.Size(1137, 208);
            this.pbBipAMI.TabIndex = 9;
            this.pbBipAMI.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1229, 951);
            this.Controls.Add(this.pbBipAMI);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pbNRZI);
            this.Controls.Add(this.pbNRZL);
            this.Controls.Add(this.GRAFICAR);
            this.Controls.Add(this.signal);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbNRZL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNRZI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBipAMI)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox signal;
        private System.Windows.Forms.Button GRAFICAR;
        private System.Windows.Forms.PictureBox pbNRZL;
        private System.Windows.Forms.PictureBox pbNRZI;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pbBipAMI;
    }
}

