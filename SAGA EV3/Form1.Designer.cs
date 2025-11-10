namespace SAGA_EV3
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Txb_user = new System.Windows.Forms.TextBox();
            this.Txb_password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Btn_Login = new System.Windows.Forms.Button();
            this.lbl_hash = new System.Windows.Forms.Label();
            this.Txb_hash = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Txb_user
            // 
            this.Txb_user.Location = new System.Drawing.Point(249, 323);
            this.Txb_user.Name = "Txb_user";
            this.Txb_user.Size = new System.Drawing.Size(123, 20);
            this.Txb_user.TabIndex = 2;
            // 
            // Txb_password
            // 
            this.Txb_password.Location = new System.Drawing.Point(249, 387);
            this.Txb_password.Name = "Txb_password";
            this.Txb_password.PasswordChar = '*';
            this.Txb_password.Size = new System.Drawing.Size(123, 20);
            this.Txb_password.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(189, 326);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(171, 390);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Contraseña";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(236, 113);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 137);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Btn_Login
            // 
            this.Btn_Login.Location = new System.Drawing.Point(262, 431);
            this.Btn_Login.Name = "Btn_Login";
            this.Btn_Login.Size = new System.Drawing.Size(96, 37);
            this.Btn_Login.TabIndex = 7;
            this.Btn_Login.Text = "Iniciar Sesion";
            this.Btn_Login.UseVisualStyleBackColor = true;
            this.Btn_Login.Click += new System.EventHandler(this.Btn_Login_Click);
            // 
            // lbl_hash
            // 
            this.lbl_hash.AutoSize = true;
            this.lbl_hash.Location = new System.Drawing.Point(31, 266);
            this.lbl_hash.Name = "lbl_hash";
            this.lbl_hash.Size = new System.Drawing.Size(35, 13);
            this.lbl_hash.TabIndex = 8;
            this.lbl_hash.Text = "label1";
            // 
            // Txb_hash
            // 
            this.Txb_hash.Location = new System.Drawing.Point(12, 282);
            this.Txb_hash.Name = "Txb_hash";
            this.Txb_hash.Size = new System.Drawing.Size(568, 20);
            this.Txb_hash.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.Txb_hash);
            this.Controls.Add(this.lbl_hash);
            this.Controls.Add(this.Btn_Login);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txb_password);
            this.Controls.Add(this.Txb_user);
            this.Name = "Form1";
            this.Text = "Inicio";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Txb_user;
        private System.Windows.Forms.TextBox Txb_password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Btn_Login;
        private System.Windows.Forms.Label lbl_hash;
        private System.Windows.Forms.TextBox Txb_hash;
    }
}

