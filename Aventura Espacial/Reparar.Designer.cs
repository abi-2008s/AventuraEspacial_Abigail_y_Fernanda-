namespace Aventura_Espacial
{
    partial class Reparar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reparar));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDanoActual = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.reparacion = new System.Windows.Forms.Button();
            this.regresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1036, 561);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1036, 162);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Courier New", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(0, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1036, 72);
            this.label1.TabIndex = 1;
            this.label1.Text = "✮⋆˚｡REPARACIÓN DE LA NAVE⋆｡°✩";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDanoActual
            // 
            this.lblDanoActual.BackColor = System.Drawing.Color.Transparent;
            this.lblDanoActual.Font = new System.Drawing.Font("Courier New", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDanoActual.ForeColor = System.Drawing.Color.Crimson;
            this.lblDanoActual.Location = new System.Drawing.Point(267, 255);
            this.lblDanoActual.Name = "lblDanoActual";
            this.lblDanoActual.Size = new System.Drawing.Size(538, 84);
            this.lblDanoActual.TabIndex = 6;
            this.lblDanoActual.Text = "-";
            this.lblDanoActual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Courier New", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(241, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(577, 37);
            this.label2.TabIndex = 7;
            this.label2.Text = "Daño actual de los sistemas:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // reparacion
            // 
            this.reparacion.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.reparacion.FlatAppearance.BorderSize = 0;
            this.reparacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reparacion.Font = new System.Drawing.Font("Courier New", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reparacion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.reparacion.Image = ((System.Drawing.Image)(resources.GetObject("reparacion.Image")));
            this.reparacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reparacion.Location = new System.Drawing.Point(269, 378);
            this.reparacion.Name = "reparacion";
            this.reparacion.Size = new System.Drawing.Size(524, 83);
            this.reparacion.TabIndex = 8;
            this.reparacion.Text = "  Inciar protocolo de reparación";
            this.reparacion.UseVisualStyleBackColor = false;
            this.reparacion.Click += new System.EventHandler(this.reparacion_Click);
            // 
            // regresar
            // 
            this.regresar.BackColor = System.Drawing.Color.Crimson;
            this.regresar.FlatAppearance.BorderSize = 0;
            this.regresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.regresar.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regresar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.regresar.Location = new System.Drawing.Point(12, 505);
            this.regresar.Name = "regresar";
            this.regresar.Size = new System.Drawing.Size(123, 44);
            this.regresar.TabIndex = 20;
            this.regresar.Text = "INICIO";
            this.regresar.UseVisualStyleBackColor = false;
            this.regresar.Click += new System.EventHandler(this.regresar_Click);
            // 
            // Reparar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1036, 561);
            this.Controls.Add(this.regresar);
            this.Controls.Add(this.reparacion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblDanoActual);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Reparar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REPARAR NAVE";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDanoActual;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button reparacion;
        private System.Windows.Forms.Button regresar;
    }
}