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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNomJug1 = new System.Windows.Forms.Label();
            this.lblNomJug2 = new System.Windows.Forms.Label();
            this.lblNomJug3 = new System.Windows.Forms.Label();
            this.lblNomJug4 = new System.Windows.Forms.Label();
            this.PanelInf.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelInf
            // 
            this.PanelInf.Controls.Add(this.LblPruebas);
            this.PanelInf.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelInf.Location = new System.Drawing.Point(0, 550);
            this.PanelInf.Name = "PanelInf";
            this.PanelInf.Size = new System.Drawing.Size(744, 100);
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
            this.PanelTablero.Location = new System.Drawing.Point(244, 0);
            this.PanelTablero.Name = "PanelTablero";
            this.PanelTablero.Size = new System.Drawing.Size(504, 551);
            this.PanelTablero.TabIndex = 1;
            this.PanelTablero.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelTablero_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblNomJug4);
            this.panel1.Controls.Add(this.lblNomJug3);
            this.panel1.Controls.Add(this.lblNomJug2);
            this.panel1.Controls.Add(this.lblNomJug1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 551);
            this.panel1.TabIndex = 2;
            // 
            // lblNomJug1
            // 
            this.lblNomJug1.AutoSize = true;
            this.lblNomJug1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomJug1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblNomJug1.Location = new System.Drawing.Point(13, 30);
            this.lblNomJug1.Name = "lblNomJug1";
            this.lblNomJug1.Size = new System.Drawing.Size(87, 18);
            this.lblNomJug1.TabIndex = 0;
            this.lblNomJug1.Text = "lblNomJug1";
            // 
            // lblNomJug2
            // 
            this.lblNomJug2.AutoSize = true;
            this.lblNomJug2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomJug2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblNomJug2.Location = new System.Drawing.Point(13, 81);
            this.lblNomJug2.Name = "lblNomJug2";
            this.lblNomJug2.Size = new System.Drawing.Size(62, 13);
            this.lblNomJug2.TabIndex = 1;
            this.lblNomJug2.Text = "lblNomJug2";
            // 
            // lblNomJug3
            // 
            this.lblNomJug3.AutoSize = true;
            this.lblNomJug3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomJug3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblNomJug3.Location = new System.Drawing.Point(13, 132);
            this.lblNomJug3.Name = "lblNomJug3";
            this.lblNomJug3.Size = new System.Drawing.Size(62, 13);
            this.lblNomJug3.TabIndex = 2;
            this.lblNomJug3.Text = "lblNomJug3";
            // 
            // lblNomJug4
            // 
            this.lblNomJug4.AutoSize = true;
            this.lblNomJug4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomJug4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblNomJug4.Location = new System.Drawing.Point(13, 186);
            this.lblNomJug4.Name = "lblNomJug4";
            this.lblNomJug4.Size = new System.Drawing.Size(62, 13);
            this.lblNomJug4.TabIndex = 3;
            this.lblNomJug4.Text = "lblNomJug4";
            // 
            // IntPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(744, 650);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PanelTablero);
            this.Controls.Add(this.PanelInf);
            this.Name = "IntPrincipal";
            this.Text = "Serpientes y Escaleras";
            this.Shown += new System.EventHandler(this.IntPrincipal_Shown);
            this.PanelInf.ResumeLayout(false);
            this.PanelInf.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelInf;
        private System.Windows.Forms.Panel PanelTablero;
        private System.Windows.Forms.Label LblPruebas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNomJug4;
        private System.Windows.Forms.Label lblNomJug3;
        private System.Windows.Forms.Label lblNomJug2;
        private System.Windows.Forms.Label lblNomJug1;
    }
}

