namespace Aventura_Espacial
{
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.repararboton = new System.Windows.Forms.Button();
            this.historialboton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.explorarboton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1036, 566);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Courier New", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(989, 70);
            this.label1.TabIndex = 1;
            this.label1.Text = "✮⋆˙AVENTURA ESPACIAL˙⋆✮";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(25, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(995, 100);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-8, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(413, 357);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Location = new System.Drawing.Point(12, 129);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(412, 356);
            this.panel2.TabIndex = 4;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // repararboton
            // 
            this.repararboton.BackColor = System.Drawing.Color.Navy;
            this.repararboton.FlatAppearance.BorderSize = 0;
            this.repararboton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.repararboton.Font = new System.Drawing.Font("Courier New", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repararboton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.repararboton.Image = ((System.Drawing.Image)(resources.GetObject("repararboton.Image")));
            this.repararboton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.repararboton.Location = new System.Drawing.Point(561, 253);
            this.repararboton.Name = "repararboton";
            this.repararboton.Size = new System.Drawing.Size(334, 69);
            this.repararboton.TabIndex = 6;
            this.repararboton.Text = "   REPARAR NAVE";
            this.repararboton.UseVisualStyleBackColor = false;
            this.repararboton.Click += new System.EventHandler(this.repararboton_Click);
            // 
            // historialboton
            // 
            this.historialboton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.historialboton.FlatAppearance.BorderSize = 0;
            this.historialboton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.historialboton.Font = new System.Drawing.Font("Courier New", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.historialboton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.historialboton.Image = ((System.Drawing.Image)(resources.GetObject("historialboton.Image")));
            this.historialboton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.historialboton.Location = new System.Drawing.Point(561, 376);
            this.historialboton.Name = "historialboton";
            this.historialboton.Size = new System.Drawing.Size(334, 78);
            this.historialboton.TabIndex = 7;
            this.historialboton.Text = "   VER HISTORIAL";
            this.historialboton.UseVisualStyleBackColor = false;
            this.historialboton.Click += new System.EventHandler(this.historialboton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(685, 509);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(329, 40);
            this.label2.TabIndex = 8;
            this.label2.Text = "Programa creado por: \r\nAbigail Romero y Fernanda Campos";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // explorarboton
            // 
            this.explorarboton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.explorarboton.BackColor = System.Drawing.Color.IndianRed;
            this.explorarboton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.explorarboton.FlatAppearance.BorderSize = 0;
            this.explorarboton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.explorarboton.Font = new System.Drawing.Font("Courier New", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.explorarboton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.explorarboton.Image = ((System.Drawing.Image)(resources.GetObject("explorarboton.Image")));
            this.explorarboton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.explorarboton.Location = new System.Drawing.Point(561, 138);
            this.explorarboton.Name = "explorarboton";
            this.explorarboton.Size = new System.Drawing.Size(334, 75);
            this.explorarboton.TabIndex = 9;
            this.explorarboton.Text = "   EXPLORAR\r\n   PLANETAS";
            this.explorarboton.UseVisualStyleBackColor = false;
            this.explorarboton.Click += new System.EventHandler(this.explorarboton_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1036, 561);
            this.Controls.Add(this.explorarboton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.historialboton);
            this.Controls.Add(this.repararboton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "INICIO";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Inicio_FormClosing);
            this.Load += new System.EventHandler(this.Inicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button repararboton;
        private System.Windows.Forms.Button historialboton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button explorarboton;
    }
}

