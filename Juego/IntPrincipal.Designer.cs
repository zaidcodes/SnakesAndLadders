namespace Juego
{
    partial class IntPrincipal
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
            this.PanelInf = new System.Windows.Forms.Panel();
            this.LblPruebas = new System.Windows.Forms.Label();
            this.PanelTablero = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PanelInf.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelInf
            // 
            this.PanelInf.Controls.Add(this.LblPruebas);
            this.PanelInf.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelInf.Location = new System.Drawing.Point(0, 550);
            this.PanelInf.Name = "PanelInf";
            this.PanelInf.Size = new System.Drawing.Size(700, 100);
            this.PanelInf.TabIndex = 0;
            // 
            // LblPruebas
            // 
            this.LblPruebas.AutoSize = true;
            this.LblPruebas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPruebas.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.LblPruebas.Location = new System.Drawing.Point(36, 26);
            this.LblPruebas.Name = "LblPruebas";
            this.LblPruebas.Size = new System.Drawing.Size(80, 24);
            this.LblPruebas.TabIndex = 0;
            this.LblPruebas.Text = "Pruebas";
            // 
            // PanelTablero
            // 
            this.PanelTablero.BackColor = System.Drawing.Color.Transparent;
            this.PanelTablero.Location = new System.Drawing.Point(86, 0);
            this.PanelTablero.Name = "PanelTablero";
            this.PanelTablero.Size = new System.Drawing.Size(504, 551);
            this.PanelTablero.TabIndex = 1;
            this.PanelTablero.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelTablero_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(605, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 87);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // IntPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(700, 650);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PanelTablero);
            this.Controls.Add(this.PanelInf);
            this.Name = "IntPrincipal";
            this.Text = "Serpientes y Escaleras";
            this.Shown += new System.EventHandler(this.IntPrincipal_Shown);
            this.PanelInf.ResumeLayout(false);
            this.PanelInf.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelInf;
        private System.Windows.Forms.Panel PanelTablero;
        private System.Windows.Forms.Label LblPruebas;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

