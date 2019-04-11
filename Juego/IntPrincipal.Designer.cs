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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLanzar = new System.Windows.Forms.Button();
            this.LblPruebas = new System.Windows.Forms.Label();
            this.PanelTablero = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPuntJug4 = new System.Windows.Forms.Label();
            this.lblPuntJug3 = new System.Windows.Forms.Label();
            this.lblPuntJug2 = new System.Windows.Forms.Label();
            this.lblPuntJug1 = new System.Windows.Forms.Label();
            this.lblNomJug4 = new System.Windows.Forms.Label();
            this.lblNomJug3 = new System.Windows.Forms.Label();
            this.lblNomJug2 = new System.Windows.Forms.Label();
            this.lblNomJug1 = new System.Windows.Forms.Label();
            this.PanelInf.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelInf
            // 
            this.PanelInf.Controls.Add(this.pictureBox2);
            this.PanelInf.Controls.Add(this.pictureBox1);
            this.PanelInf.Controls.Add(this.btnLanzar);
            this.PanelInf.Controls.Add(this.LblPruebas);
            this.PanelInf.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelInf.Location = new System.Drawing.Point(0, 445);
            this.PanelInf.Name = "PanelInf";
            this.PanelInf.Size = new System.Drawing.Size(744, 155);
            this.PanelInf.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(652, 81);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(57, 54);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(543, 81);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 54);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnLanzar
            // 
            this.btnLanzar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLanzar.ForeColor = System.Drawing.Color.Chartreuse;
            this.btnLanzar.Location = new System.Drawing.Point(304, 85);
            this.btnLanzar.Name = "btnLanzar";
            this.btnLanzar.Size = new System.Drawing.Size(136, 50);
            this.btnLanzar.TabIndex = 1;
            this.btnLanzar.Text = "Lanzar";
            this.btnLanzar.UseVisualStyleBackColor = true;
            this.btnLanzar.Click += new System.EventHandler(this.btnLanzar_Click);
            // 
            // LblPruebas
            // 
            this.LblPruebas.AutoSize = true;
            this.LblPruebas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPruebas.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.LblPruebas.Location = new System.Drawing.Point(20, 96);
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
            this.PanelTablero.Size = new System.Drawing.Size(504, 501);
            this.PanelTablero.Paint += new System.Windows.Forms.PaintEventHandler(PanelTablero_Paint);
            this.PanelTablero.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblPuntJug4);
            this.panel1.Controls.Add(this.lblPuntJug3);
            this.panel1.Controls.Add(this.lblPuntJug2);
            this.panel1.Controls.Add(this.lblPuntJug1);
            this.panel1.Controls.Add(this.lblNomJug4);
            this.panel1.Controls.Add(this.lblNomJug3);
            this.panel1.Controls.Add(this.lblNomJug2);
            this.panel1.Controls.Add(this.lblNomJug1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 502);
            this.panel1.TabIndex = 2;
            // 
            // lblPuntJug4
            // 
            this.lblPuntJug4.AutoSize = true;
            this.lblPuntJug4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntJug4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblPuntJug4.Location = new System.Drawing.Point(130, 186);
            this.lblPuntJug4.Name = "lblPuntJug4";
            this.lblPuntJug4.Size = new System.Drawing.Size(46, 18);
            this.lblPuntJug4.TabIndex = 7;
            this.lblPuntJug4.Text = "label4";
            this.lblPuntJug4.Visible = false;
            // 
            // lblPuntJug3
            // 
            this.lblPuntJug3.AutoSize = true;
            this.lblPuntJug3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntJug3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblPuntJug3.Location = new System.Drawing.Point(130, 132);
            this.lblPuntJug3.Name = "lblPuntJug3";
            this.lblPuntJug3.Size = new System.Drawing.Size(46, 18);
            this.lblPuntJug3.TabIndex = 6;
            this.lblPuntJug3.Text = "label3";
            this.lblPuntJug3.Visible = false;
            // 
            // lblPuntJug2
            // 
            this.lblPuntJug2.AutoSize = true;
            this.lblPuntJug2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntJug2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblPuntJug2.Location = new System.Drawing.Point(130, 81);
            this.lblPuntJug2.Name = "lblPuntJug2";
            this.lblPuntJug2.Size = new System.Drawing.Size(46, 18);
            this.lblPuntJug2.TabIndex = 5;
            this.lblPuntJug2.Text = "label2";
            this.lblPuntJug2.Visible = false;
            // 
            // lblPuntJug1
            // 
            this.lblPuntJug1.AutoSize = true;
            this.lblPuntJug1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntJug1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblPuntJug1.Location = new System.Drawing.Point(130, 30);
            this.lblPuntJug1.Name = "lblPuntJug1";
            this.lblPuntJug1.Size = new System.Drawing.Size(46, 18);
            this.lblPuntJug1.TabIndex = 4;
            this.lblPuntJug1.Text = "label1";
            this.lblPuntJug1.Visible = false;
            // 
            // lblNomJug4
            // 
            this.lblNomJug4.AutoSize = true;
            this.lblNomJug4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomJug4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblNomJug4.Location = new System.Drawing.Point(13, 186);
            this.lblNomJug4.Name = "lblNomJug4";
            this.lblNomJug4.Size = new System.Drawing.Size(87, 18);
            this.lblNomJug4.TabIndex = 3;
            this.lblNomJug4.Text = "lblNomJug4";
            this.lblNomJug4.Visible = false;
            // 
            // lblNomJug3
            // 
            this.lblNomJug3.AutoSize = true;
            this.lblNomJug3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomJug3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblNomJug3.Location = new System.Drawing.Point(13, 132);
            this.lblNomJug3.Name = "lblNomJug3";
            this.lblNomJug3.Size = new System.Drawing.Size(87, 18);
            this.lblNomJug3.TabIndex = 2;
            this.lblNomJug3.Text = "lblNomJug3";
            this.lblNomJug3.Visible = false;
            // 
            // lblNomJug2
            // 
            this.lblNomJug2.AutoSize = true;
            this.lblNomJug2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomJug2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblNomJug2.Location = new System.Drawing.Point(13, 81);
            this.lblNomJug2.Name = "lblNomJug2";
            this.lblNomJug2.Size = new System.Drawing.Size(87, 18);
            this.lblNomJug2.TabIndex = 1;
            this.lblNomJug2.Text = "lblNomJug2";
            this.lblNomJug2.Visible = false;
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
            this.lblNomJug1.Visible = false;
            // 
            // IntPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(744, 600);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PanelTablero);
            this.Controls.Add(this.PanelInf);
            this.Name = "IntPrincipal";
            this.Text = "Serpientes y Escaleras";
            this.Shown += new System.EventHandler(this.IntPrincipal_Shown);
            this.PanelInf.ResumeLayout(false);
            this.PanelInf.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Button btnLanzar;
        private System.Windows.Forms.Label lblPuntJug4;
        private System.Windows.Forms.Label lblPuntJug3;
        private System.Windows.Forms.Label lblPuntJug2;
        private System.Windows.Forms.Label lblPuntJug1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

