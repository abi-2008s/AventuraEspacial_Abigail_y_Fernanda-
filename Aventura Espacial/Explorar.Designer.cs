namespace Aventura_Espacial
{
    partial class Explorar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Explorar));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblNombrePlaneta = new System.Windows.Forms.Label();
            this.lblOxigeno = new System.Windows.Forms.Label();
            this.lblTemperatura = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblDano = new System.Windows.Forms.Label();
            this.regresar = new System.Windows.Forms.Button();
            this.Planeta = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Planeta)).BeginInit();
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
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1036, 100);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Courier New", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(-91, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1229, 70);
            this.label1.TabIndex = 1;
            this.label1.Text = "*:･ﾟ✧EXPLORACIÓN DE PLANETAS✧･ﾟ:*\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Courier New", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(23, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(537, 37);
            this.label3.TabIndex = 5;
            this.label3.Text = "Datos de planeta detectado";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Courier New", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(23, 389);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(343, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "Prescencia de oxígeno:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Courier New", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(23, 286);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(193, 29);
            this.label5.TabIndex = 7;
            this.label5.Text = "Temperatura:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Courier New", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(23, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 29);
            this.label6.TabIndex = 8;
            this.label6.Text = "Nombre:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // lblNombrePlaneta
            // 
            this.lblNombrePlaneta.AutoSize = true;
            this.lblNombrePlaneta.BackColor = System.Drawing.Color.Transparent;
            this.lblNombrePlaneta.Font = new System.Drawing.Font("Courier New", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombrePlaneta.ForeColor = System.Drawing.Color.IndianRed;
            this.lblNombrePlaneta.Location = new System.Drawing.Point(25, 234);
            this.lblNombrePlaneta.Name = "lblNombrePlaneta";
            this.lblNombrePlaneta.Size = new System.Drawing.Size(43, 29);
            this.lblNombrePlaneta.TabIndex = 11;
            this.lblNombrePlaneta.Text = "- ";
            this.lblNombrePlaneta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNombrePlaneta.Click += new System.EventHandler(this.lblNombrePlaneta_Click);
            // 
            // lblOxigeno
            // 
            this.lblOxigeno.AutoSize = true;
            this.lblOxigeno.BackColor = System.Drawing.Color.Transparent;
            this.lblOxigeno.Font = new System.Drawing.Font("Courier New", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOxigeno.ForeColor = System.Drawing.Color.IndianRed;
            this.lblOxigeno.Location = new System.Drawing.Point(23, 444);
            this.lblOxigeno.Name = "lblOxigeno";
            this.lblOxigeno.Size = new System.Drawing.Size(43, 29);
            this.lblOxigeno.TabIndex = 12;
            this.lblOxigeno.Text = "- ";
            this.lblOxigeno.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblOxigeno.Click += new System.EventHandler(this.lblOxigeno_Click);
            // 
            // lblTemperatura
            // 
            this.lblTemperatura.AutoSize = true;
            this.lblTemperatura.BackColor = System.Drawing.Color.Transparent;
            this.lblTemperatura.Font = new System.Drawing.Font("Courier New", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemperatura.ForeColor = System.Drawing.Color.IndianRed;
            this.lblTemperatura.Location = new System.Drawing.Point(23, 339);
            this.lblTemperatura.Name = "lblTemperatura";
            this.lblTemperatura.Size = new System.Drawing.Size(43, 29);
            this.lblTemperatura.TabIndex = 13;
            this.lblTemperatura.Text = "- ";
            this.lblTemperatura.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTemperatura.Click += new System.EventHandler(this.lblTemperatura_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(567, 408);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(321, 34);
            this.label7.TabIndex = 16;
            this.label7.Text = "Estado de la nave";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Courier New", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(567, 450);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(253, 29);
            this.label8.TabIndex = 17;
            this.label8.Text = "Daño acumulado: ";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDano
            // 
            this.lblDano.AutoSize = true;
            this.lblDano.BackColor = System.Drawing.Color.Transparent;
            this.lblDano.Font = new System.Drawing.Font("Courier New", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDano.ForeColor = System.Drawing.Color.IndianRed;
            this.lblDano.Location = new System.Drawing.Point(567, 492);
            this.lblDano.Name = "lblDano";
            this.lblDano.Size = new System.Drawing.Size(43, 29);
            this.lblDano.TabIndex = 18;
            this.lblDano.Text = "- ";
            this.lblDano.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDano.Click += new System.EventHandler(this.lblDano_Click);
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
            this.regresar.TabIndex = 19;
            this.regresar.Text = "INICIO";
            this.regresar.UseVisualStyleBackColor = false;
            this.regresar.Click += new System.EventHandler(this.regresar_Click);
            // 
            // Planeta
            // 
            this.Planeta.Location = new System.Drawing.Point(616, 120);
            this.Planeta.Name = "Planeta";
            this.Planeta.Size = new System.Drawing.Size(378, 267);
            this.Planeta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Planeta.TabIndex = 20;
            this.Planeta.TabStop = false;
            // 
            // Explorar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1036, 561);
            this.Controls.Add(this.Planeta);
            this.Controls.Add(this.regresar);
            this.Controls.Add(this.lblDano);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblTemperatura);
            this.Controls.Add(this.lblOxigeno);
            this.Controls.Add(this.lblNombrePlaneta);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Explorar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EXPLORAR PLANETAS";
            this.Load += new System.EventHandler(this.Explorar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Planeta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblNombrePlaneta;
        private System.Windows.Forms.Label lblOxigeno;
        private System.Windows.Forms.Label lblTemperatura;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblDano;
        private System.Windows.Forms.Button regresar;
        private System.Windows.Forms.PictureBox Planeta;
    }
}