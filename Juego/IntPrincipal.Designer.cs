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
            this.PanelTablero = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // PanelInf
            // 
            this.PanelInf.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelInf.Location = new System.Drawing.Point(0, 550);
            this.PanelInf.Name = "PanelInf";
            this.PanelInf.Size = new System.Drawing.Size(700, 100);
            this.PanelInf.TabIndex = 0;
            // 
            // PanelTablero
            // 
            this.PanelTablero.Location = new System.Drawing.Point(86, 0);
            this.PanelTablero.Name = "PanelTablero";
            this.PanelTablero.Size = new System.Drawing.Size(504, 551);
            this.PanelTablero.TabIndex = 1;
            // 
            // IntPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(700, 650);
            this.Controls.Add(this.PanelTablero);
            this.Controls.Add(this.PanelInf);
            this.Name = "IntPrincipal";
            this.Text = "Serpientes y Escaleras";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelInf;
        private System.Windows.Forms.Panel PanelTablero;
    }
}

