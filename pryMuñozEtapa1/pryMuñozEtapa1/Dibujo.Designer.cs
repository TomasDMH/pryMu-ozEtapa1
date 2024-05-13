namespace pryMuñozEtapa1
{
    partial class Dibujo
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
            this.pctFirma = new System.Windows.Forms.PictureBox();
            this.cmdGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctFirma)).BeginInit();
            this.SuspendLayout();
            // 
            // pctFirma
            // 
            this.pctFirma.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pctFirma.Location = new System.Drawing.Point(23, 12);
            this.pctFirma.Name = "pctFirma";
            this.pctFirma.Size = new System.Drawing.Size(395, 414);
            this.pctFirma.TabIndex = 0;
            this.pctFirma.TabStop = false;
            this.pctFirma.Click += new System.EventHandler(this.pctFirma_Click);
            this.pctFirma.Paint += new System.Windows.Forms.PaintEventHandler(this.pctFirma_Paint);
            this.pctFirma.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pctFirma_MouseClick);
            this.pctFirma.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pctFirma_MouseDown);
            this.pctFirma.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pctFirma_MouseMove);
            this.pctFirma.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pctFirma_MouseUp);
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.Location = new System.Drawing.Point(450, 173);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(236, 98);
            this.cmdGuardar.TabIndex = 1;
            this.cmdGuardar.Text = "Guardar firma";
            this.cmdGuardar.UseVisualStyleBackColor = true;
            this.cmdGuardar.Click += new System.EventHandler(this.cmdGuardar_Click);
            // 
            // Dibujo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 450);
            this.Controls.Add(this.cmdGuardar);
            this.Controls.Add(this.pctFirma);
            this.Name = "Dibujo";
            this.Text = "Etapa 1 - Dibujo";
            this.Load += new System.EventHandler(this.Dibujo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctFirma)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pctFirma;
        private System.Windows.Forms.Button cmdGuardar;
    }
}

