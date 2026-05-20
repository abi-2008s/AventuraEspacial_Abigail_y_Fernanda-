namespace Aventura_Espacial
{
    partial class Historial 
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Historial));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.regresar = new System.Windows.Forms.Button();
            this.btnVerHistorialInterno = new System.Windows.Forms.Button();
            this.listBoxHistorial = new System.Windows.Forms.ListBox();
            this.btnBorrar = new System.Windows.Forms.Button();
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
            this.panel1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(24, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(995, 100);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Courier New", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(989, 70);
            this.label1.TabIndex = 1;
            this.label1.Text = "✪ HISTORIAL DE MISIONES ✪\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.regresar.TabIndex = 21;
            this.regresar.Text = "INICIO";
            this.regresar.UseVisualStyleBackColor = false;
            this.regresar.Click += new System.EventHandler(this.regresar_Click);
            // 
            // btnVerHistorialInterno
            // 
            this.btnVerHistorialInterno.BackColor = System.Drawing.Color.Turquoise;
            this.btnVerHistorialInterno.FlatAppearance.BorderSize = 0;
            this.btnVerHistorialInterno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerHistorialInterno.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerHistorialInterno.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVerHistorialInterno.Image = ((System.Drawing.Image)(resources.GetObject("btnVerHistorialInterno.Image")));
            this.btnVerHistorialInterno.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerHistorialInterno.Location = new System.Drawing.Point(37, 121);
            this.btnVerHistorialInterno.Name = "btnVerHistorialInterno";
            this.btnVerHistorialInterno.Size = new System.Drawing.Size(549, 58);
            this.btnVerHistorialInterno.TabIndex = 22;
            this.btnVerHistorialInterno.Text = "   Actualizar / Leer registro";
            this.btnVerHistorialInterno.UseVisualStyleBackColor = false;
            this.btnVerHistorialInterno.Click += new System.EventHandler(this.btnVerHistorialInterno_Click);
            // 
            // listBoxHistorial
            // 
            this.listBoxHistorial.BackColor = System.Drawing.Color.DarkOrchid;
            this.listBoxHistorial.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxHistorial.ForeColor = System.Drawing.Color.White;
            this.listBoxHistorial.FormattingEnabled = true;
            this.listBoxHistorial.HorizontalScrollbar = true;
            this.listBoxHistorial.ItemHeight = 27;
            this.listBoxHistorial.Location = new System.Drawing.Point(37, 207);
            this.listBoxHistorial.Name = "listBoxHistorial";
            this.listBoxHistorial.Size = new System.Drawing.Size(964, 274);
            this.listBoxHistorial.TabIndex = 23;
            this.listBoxHistorial.SelectedIndexChanged += new System.EventHandler(this.listBoxHistorial_SelectedIndexChanged);
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.LightGreen;
            this.btnBorrar.FlatAppearance.BorderSize = 0;
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBorrar.Image = ((System.Drawing.Image)(resources.GetObject("btnBorrar.Image")));
            this.btnBorrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBorrar.Location = new System.Drawing.Point(742, 121);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(259, 58);
            this.btnBorrar.TabIndex = 24;
            this.btnBorrar.Text = "   Borrar";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // Historial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1036, 561);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.listBoxHistorial);
            this.Controls.Add(this.btnVerHistorialInterno);
            this.Controls.Add(this.regresar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Historial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HISTORIAL";
            this.Load += new System.EventHandler(this.Historial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button regresar;
        private System.Windows.Forms.Button btnVerHistorialInterno;
        private System.Windows.Forms.ListBox listBoxHistorial;
        private System.Windows.Forms.Button btnBorrar;
    }
}