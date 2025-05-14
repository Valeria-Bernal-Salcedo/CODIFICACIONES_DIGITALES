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
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pbBipAMI = new System.Windows.Forms.PictureBox();
            this.pbPESUDO = new System.Windows.Forms.PictureBox();
            this.pbCodigoDif = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pbManchester = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbNRZL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNRZI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBipAMI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPESUDO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCodigoDif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbManchester)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(1702, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "SEÑAL A GRAFICAR:";
            // 
            // signal
            // 
            this.signal.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signal.Location = new System.Drawing.Point(1690, 249);
            this.signal.Name = "signal";
            this.signal.Size = new System.Drawing.Size(299, 35);
            this.signal.TabIndex = 1;
            this.signal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // GRAFICAR
            // 
            this.GRAFICAR.BackColor = System.Drawing.Color.LightSteelBlue;
            this.GRAFICAR.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GRAFICAR.ForeColor = System.Drawing.Color.White;
            this.GRAFICAR.Location = new System.Drawing.Point(1690, 305);
            this.GRAFICAR.Name = "GRAFICAR";
            this.GRAFICAR.Size = new System.Drawing.Size(277, 58);
            this.GRAFICAR.TabIndex = 2;
            this.GRAFICAR.Text = "GRAFICAR";
            this.GRAFICAR.UseVisualStyleBackColor = false;
            this.GRAFICAR.Click += new System.EventHandler(this.GRAFICAR_Click);
            // 
            // pbNRZL
            // 
            this.pbNRZL.BackColor = System.Drawing.Color.White;
            this.pbNRZL.Location = new System.Drawing.Point(26, 66);
            this.pbNRZL.Name = "pbNRZL";
            this.pbNRZL.Size = new System.Drawing.Size(805, 241);
            this.pbNRZL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNRZL.TabIndex = 3;
            this.pbNRZL.TabStop = false;
            // 
            // pbNRZI
            // 
            this.pbNRZI.BackColor = System.Drawing.Color.White;
            this.pbNRZI.Location = new System.Drawing.Point(26, 354);
            this.pbNRZI.Name = "pbNRZI";
            this.pbNRZI.Size = new System.Drawing.Size(805, 241);
            this.pbNRZI.TabIndex = 4;
            this.pbNRZI.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SandyBrown;
            this.label2.Location = new System.Drawing.Point(342, 326);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "SEÑAL NRZ-I";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Goldenrod;
            this.label4.Location = new System.Drawing.Point(316, 620);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(221, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "SEÑAL BIPOLAR AMI";
            // 
            // pbBipAMI
            // 
            this.pbBipAMI.BackColor = System.Drawing.Color.White;
            this.pbBipAMI.Location = new System.Drawing.Point(26, 647);
            this.pbBipAMI.Name = "pbBipAMI";
            this.pbBipAMI.Size = new System.Drawing.Size(805, 241);
            this.pbBipAMI.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBipAMI.TabIndex = 9;
            this.pbBipAMI.TabStop = false;
            // 
            // pbPESUDO
            // 
            this.pbPESUDO.BackColor = System.Drawing.Color.White;
            this.pbPESUDO.Location = new System.Drawing.Point(846, 66);
            this.pbPESUDO.Name = "pbPESUDO";
            this.pbPESUDO.Size = new System.Drawing.Size(805, 241);
            this.pbPESUDO.TabIndex = 10;
            this.pbPESUDO.TabStop = false;
            // 
            // pbCodigoDif
            // 
            this.pbCodigoDif.BackColor = System.Drawing.Color.White;
            this.pbCodigoDif.Location = new System.Drawing.Point(846, 647);
            this.pbCodigoDif.Name = "pbCodigoDif";
            this.pbCodigoDif.Size = new System.Drawing.Size(805, 241);
            this.pbCodigoDif.TabIndex = 12;
            this.pbCodigoDif.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.SlateBlue;
            this.label6.Location = new System.Drawing.Point(1088, 620);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(309, 24);
            this.label6.TabIndex = 14;
            this.label6.Text = "SEÑAL CÓDIGO DIFERENCIAL";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.OliveDrab;
            this.label7.Location = new System.Drawing.Point(1125, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(272, 24);
            this.label7.TabIndex = 15;
            this.label7.Text = "SEÑAL PSEUDOTERNARIO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Tomato;
            this.label3.Location = new System.Drawing.Point(341, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "SEÑAL NRZ-L";
            // 
            // pbManchester
            // 
            this.pbManchester.BackColor = System.Drawing.Color.White;
            this.pbManchester.Location = new System.Drawing.Point(846, 354);
            this.pbManchester.Name = "pbManchester";
            this.pbManchester.Size = new System.Drawing.Size(805, 241);
            this.pbManchester.TabIndex = 11;
            this.pbManchester.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label5.Location = new System.Drawing.Point(1125, 326);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(220, 24);
            this.label5.TabIndex = 13;
            this.label5.Text = "SEÑAL MANCHESTER";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(1746, 454);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(180, 28);
            this.label8.TabIndex = 16;
            this.label8.Text = "INTEGRANTES";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(1731, 502);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(236, 28);
            this.label9.TabIndex = 17;
            this.label9.Text = "Valeria Bernal Salcedo";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(1676, 545);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(308, 28);
            this.label10.TabIndex = 18;
            this.label10.Text = "Fernando Grabriel Hernández";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(1702, 588);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(281, 28);
            this.label11.TabIndex = 19;
            this.label11.Text = "Rosa Lizeth Suárez Medina";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1924, 943);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pbCodigoDif);
            this.Controls.Add(this.pbManchester);
            this.Controls.Add(this.pbPESUDO);
            this.Controls.Add(this.pbBipAMI);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
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
            ((System.ComponentModel.ISupportInitialize)(this.pbPESUDO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCodigoDif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbManchester)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox signal;
        private System.Windows.Forms.Button GRAFICAR;
        private System.Windows.Forms.PictureBox pbNRZL;
        private System.Windows.Forms.PictureBox pbNRZI;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pbBipAMI;
        private System.Windows.Forms.PictureBox pbPESUDO;
        private System.Windows.Forms.PictureBox pbCodigoDif;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pbManchester;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}

