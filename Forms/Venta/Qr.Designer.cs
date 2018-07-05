namespace Tienda.Forms.Venta
{
    partial class Qr
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
            this.lblTex = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGuar = new System.Windows.Forms.Button();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pbGenerar = new System.Windows.Forms.PictureBox();
            this.pbAbrir = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbGenerar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAbrir)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTex
            // 
            this.lblTex.AutoSize = true;
            this.lblTex.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTex.Location = new System.Drawing.Point(12, 19);
            this.lblTex.Name = "lblTex";
            this.lblTex.Size = new System.Drawing.Size(199, 31);
            this.lblTex.TabIndex = 15;
            this.lblTex.Text = "Texto para QR";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(18, 66);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(350, 20);
            this.textBox1.TabIndex = 16;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(424, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(28, 426);
            this.panel1.TabIndex = 17;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnGuar
            // 
            this.btnGuar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnGuar.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuar.Location = new System.Drawing.Point(87, 371);
            this.btnGuar.Name = "btnGuar";
            this.btnGuar.Size = new System.Drawing.Size(139, 36);
            this.btnGuar.TabIndex = 18;
            this.btnGuar.Text = "Guardar";
            this.btnGuar.UseVisualStyleBackColor = false;
            this.btnGuar.Click += new System.EventHandler(this.btnGuar_Click);
            // 
            // btnAbrir
            // 
            this.btnAbrir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAbrir.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrir.Location = new System.Drawing.Point(566, 33);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(139, 36);
            this.btnAbrir.TabIndex = 19;
            this.btnAbrir.Text = "Abrir QR";
            this.btnAbrir.UseVisualStyleBackColor = false;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(477, 341);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(297, 20);
            this.textBox2.TabIndex = 21;
            // 
            // pbGenerar
            // 
            this.pbGenerar.Location = new System.Drawing.Point(18, 124);
            this.pbGenerar.Name = "pbGenerar";
            this.pbGenerar.Size = new System.Drawing.Size(350, 222);
            this.pbGenerar.TabIndex = 22;
            this.pbGenerar.TabStop = false;
            // 
            // pbAbrir
            // 
            this.pbAbrir.Location = new System.Drawing.Point(477, 86);
            this.pbAbrir.Name = "pbAbrir";
            this.pbAbrir.Size = new System.Drawing.Size(297, 222);
            this.pbAbrir.TabIndex = 23;
            this.pbAbrir.TabStop = false;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSalir.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(566, 402);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(139, 36);
            this.btnSalir.TabIndex = 24;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Qr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.pbAbrir);
            this.Controls.Add(this.pbGenerar);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btnAbrir);
            this.Controls.Add(this.btnGuar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblTex);
            this.Name = "Qr";
            this.Text = "Qr";
            this.Load += new System.EventHandler(this.Qr_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbGenerar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAbrir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTex;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGuar;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.PictureBox pbGenerar;
        private System.Windows.Forms.PictureBox pbAbrir;
        private System.Windows.Forms.Button btnSalir;
    }
}