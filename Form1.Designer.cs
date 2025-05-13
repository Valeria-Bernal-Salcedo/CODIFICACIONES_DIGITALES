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
            this.pbPESUDO = new System.Windows.Forms.PictureBox();
            this.pbManchester = new System.Windows.Forms.PictureBox();
            this.pbCodigoDif = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbNRZL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNRZI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBipAMI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPESUDO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbManchester)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCodigoDif)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "SEÑAL A GRAFICAR:";
            // 
            // signal
            // 
            this.signal.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signal.Location = new System.Drawing.Point(438, 29);
            this.signal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.signal.Name = "signal";
            this.signal.Size = new System.Drawing.Size(326, 41);
            this.signal.TabIndex = 1;
            // 
            // GRAFICAR
            // 
            this.GRAFICAR.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GRAFICAR.Location = new System.Drawing.Point(1828, 38);
            this.GRAFICAR.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GRAFICAR.Name = "GRAFICAR";
            this.GRAFICAR.Size = new System.Drawing.Size(312, 72);
            this.GRAFICAR.TabIndex = 2;
            this.GRAFICAR.Text = "GRAFICAR";
            this.GRAFICAR.UseVisualStyleBackColor = true;
            this.GRAFICAR.Click += new System.EventHandler(this.GRAFICAR_Click);
            // 
            // pbNRZL
            // 
            this.pbNRZL.Location = new System.Drawing.Point(68, 124);
            this.pbNRZL.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbNRZL.Name = "pbNRZL";
            this.pbNRZL.Size = new System.Drawing.Size(753, 271);
            this.pbNRZL.TabIndex = 3;
            this.pbNRZL.TabStop = false;
            // 
            // pbNRZI
            // 
            this.pbNRZI.Location = new System.Drawing.Point(60, 444);
            this.pbNRZI.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbNRZI.Name = "pbNRZI";
            this.pbNRZI.Size = new System.Drawing.Size(770, 272);
            this.pbNRZI.TabIndex = 4;
            this.pbNRZI.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(63, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "SEÑAL NRZ-L";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 410);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "SEÑAL NRZ-I";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(62, 732);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(264, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "SEÑAL BIPOLAR AMI";
            // 
            // pbBipAMI
            // 
            this.pbBipAMI.Location = new System.Drawing.Point(60, 778);
            this.pbBipAMI.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbBipAMI.Name = "pbBipAMI";
            this.pbBipAMI.Size = new System.Drawing.Size(770, 259);
            this.pbBipAMI.TabIndex = 9;
            this.pbBipAMI.TabStop = false;
            // 
            // pbPESUDO
            // 
            this.pbPESUDO.Location = new System.Drawing.Point(934, 38);
            this.pbPESUDO.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbPESUDO.Name = "pbPESUDO";
            this.pbPESUDO.Size = new System.Drawing.Size(878, 515);
            this.pbPESUDO.TabIndex = 10;
            this.pbPESUDO.TabStop = false;
            // 
            // pbManchester
            // 
            this.pbManchester.Location = new System.Drawing.Point(934, 591);
            this.pbManchester.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbManchester.Name = "pbManchester";
            this.pbManchester.Size = new System.Drawing.Size(753, 259);
            this.pbManchester.TabIndex = 11;
            this.pbManchester.TabStop = false;
            // 
            // pbCodigoDif
            // 
            this.pbCodigoDif.Location = new System.Drawing.Point(934, 897);
            this.pbCodigoDif.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbCodigoDif.Name = "pbCodigoDif";
            this.pbCodigoDif.Size = new System.Drawing.Size(753, 259);
            this.pbCodigoDif.TabIndex = 12;
            this.pbCodigoDif.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(929, 557);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(266, 29);
            this.label5.TabIndex = 13;
            this.label5.Text = "SEÑAL MANCHESTER";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(929, 864);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(374, 29);
            this.label6.TabIndex = 14;
            this.label6.Text = "SEÑAL CÓDIGO DIFERENCIAL";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(929, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(328, 29);
            this.label7.TabIndex = 15;
            this.label7.Text = "SEÑAL PSEUDOTERNARIO";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1825, 1050);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pbCodigoDif);
            this.Controls.Add(this.pbManchester);
            this.Controls.Add(this.pbPESUDO);
            this.Controls.Add(this.pbBipAMI);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pbNRZI);
            this.Controls.Add(this.pbNRZL);
            this.Controls.Add(this.GRAFICAR);
            this.Controls.Add(this.signal);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbNRZL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNRZI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBipAMI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPESUDO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbManchester)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCodigoDif)).EndInit();
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
        private System.Windows.Forms.PictureBox pbPESUDO;
        private System.Windows.Forms.PictureBox pbManchester;
        private System.Windows.Forms.PictureBox pbCodigoDif;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

