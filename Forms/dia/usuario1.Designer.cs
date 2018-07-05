namespace Tienda
{
    partial class usuario1
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
            this.txtCorreo1 = new System.Windows.Forms.TextBox();
            this.txtContra1 = new System.Windows.Forms.TextBox();
            this.txtContraseña1 = new System.Windows.Forms.TextBox();
            this.txtUsuario1 = new System.Windows.Forms.TextBox();
            this.btnSalir1 = new System.Windows.Forms.Button();
            this.btnEntrar1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCorreo1
            // 
            this.txtCorreo1.Location = new System.Drawing.Point(350, 116);
            this.txtCorreo1.Name = "txtCorreo1";
            this.txtCorreo1.Size = new System.Drawing.Size(203, 20);
            this.txtCorreo1.TabIndex = 0;
            this.txtCorreo1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtContra1
            // 
            this.txtContra1.Location = new System.Drawing.Point(350, 254);
            this.txtContra1.Name = "txtContra1";
            this.txtContra1.Size = new System.Drawing.Size(203, 20);
            this.txtContra1.TabIndex = 1;
            // 
            // txtContraseña1
            // 
            this.txtContraseña1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtContraseña1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.txtContraseña1.Location = new System.Drawing.Point(152, 182);
            this.txtContraseña1.Name = "txtContraseña1";
            this.txtContraseña1.Size = new System.Drawing.Size(137, 31);
            this.txtContraseña1.TabIndex = 2;
            this.txtContraseña1.Text = "Contraseña";
            // 
            // txtUsuario1
            // 
            this.txtUsuario1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtUsuario1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.txtUsuario1.Location = new System.Drawing.Point(152, 53);
            this.txtUsuario1.Name = "txtUsuario1";
            this.txtUsuario1.Size = new System.Drawing.Size(137, 31);
            this.txtUsuario1.TabIndex = 3;
            this.txtUsuario1.Text = "Usuario";
            // 
            // btnSalir1
            // 
            this.btnSalir1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnSalir1.Font = new System.Drawing.Font("Modern No. 20", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.btnSalir1.Location = new System.Drawing.Point(152, 323);
            this.btnSalir1.Name = "btnSalir1";
            this.btnSalir1.Size = new System.Drawing.Size(127, 49);
            this.btnSalir1.TabIndex = 6;
            this.btnSalir1.Text = "SALIR";
            this.btnSalir1.UseVisualStyleBackColor = false;
            this.btnSalir1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEntrar1
            // 
            this.btnEntrar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnEntrar1.Font = new System.Drawing.Font("Modern No. 20", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.btnEntrar1.Location = new System.Drawing.Point(550, 323);
            this.btnEntrar1.Name = "btnEntrar1";
            this.btnEntrar1.Size = new System.Drawing.Size(127, 49);
            this.btnEntrar1.TabIndex = 7;
            this.btnEntrar1.Text = "ENTRAR";
            this.btnEntrar1.UseVisualStyleBackColor = false;
            this.btnEntrar1.Click += new System.EventHandler(this.button2_Click);
            // 
            // usuario1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEntrar1);
            this.Controls.Add(this.btnSalir1);
            this.Controls.Add(this.txtUsuario1);
            this.Controls.Add(this.txtContraseña1);
            this.Controls.Add(this.txtContra1);
            this.Controls.Add(this.txtCorreo1);
            this.Name = "usuario1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCorreo1;
        private System.Windows.Forms.TextBox txtContra1;
        private System.Windows.Forms.TextBox txtContraseña1;
        private System.Windows.Forms.TextBox txtUsuario1;
        private System.Windows.Forms.Button btnSalir1;
        private System.Windows.Forms.Button btnEntrar1;
    }
}