namespace AplicacionStock.Vista
{
    partial class _vntLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_vntLogin));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineUsuario = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.txtBoxUsuario = new System.Windows.Forms.TextBox();
            this.txtBoxContrasena = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.linkLblOlvido = new System.Windows.Forms.LinkLabel();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.lblTitulo.Location = new System.Drawing.Point(365, 219);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(68, 25);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Login";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1,
            this.lineUsuario});
            this.shapeContainer1.Size = new System.Drawing.Size(800, 600);
            this.shapeContainer1.TabIndex = 1;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Enabled = false;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 224;
            this.lineShape1.X2 = 568;
            this.lineShape1.Y1 = 427;
            this.lineShape1.Y2 = 427;
            // 
            // lineUsuario
            // 
            this.lineUsuario.Enabled = false;
            this.lineUsuario.Name = "lineUsuario";
            this.lineUsuario.X1 = 223;
            this.lineUsuario.X2 = 567;
            this.lineUsuario.Y1 = 351;
            this.lineUsuario.Y2 = 351;
            // 
            // txtBoxUsuario
            // 
            this.txtBoxUsuario.BackColor = System.Drawing.Color.White;
            this.txtBoxUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxUsuario.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxUsuario.ForeColor = System.Drawing.Color.LightGray;
            this.txtBoxUsuario.Location = new System.Drawing.Point(223, 328);
            this.txtBoxUsuario.Name = "txtBoxUsuario";
            this.txtBoxUsuario.Size = new System.Drawing.Size(345, 15);
            this.txtBoxUsuario.TabIndex = 1;
            this.txtBoxUsuario.Text = "USUARIO";
            this.txtBoxUsuario.Enter += new System.EventHandler(this.txtBoxUsuario_Enter);
            this.txtBoxUsuario.Leave += new System.EventHandler(this.txtBoxUsuario_Leave);
            // 
            // txtBoxContrasena
            // 
            this.txtBoxContrasena.BackColor = System.Drawing.Color.White;
            this.txtBoxContrasena.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxContrasena.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxContrasena.ForeColor = System.Drawing.Color.LightGray;
            this.txtBoxContrasena.Location = new System.Drawing.Point(224, 405);
            this.txtBoxContrasena.Name = "txtBoxContrasena";
            this.txtBoxContrasena.Size = new System.Drawing.Size(345, 15);
            this.txtBoxContrasena.TabIndex = 2;
            this.txtBoxContrasena.Text = "CONTRASEÑA";
            this.txtBoxContrasena.Enter += new System.EventHandler(this.txtBoxContrasena_Enter);
            this.txtBoxContrasena.Leave += new System.EventHandler(this.txtBoxContrasena_Leave);
            // 
            // btnLogin
            // 
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnLogin.ForeColor = System.Drawing.Color.Gray;
            this.btnLogin.Location = new System.Drawing.Point(312, 461);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(180, 50);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Ingresar";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // linkLblOlvido
            // 
            this.linkLblOlvido.ActiveLinkColor = System.Drawing.Color.Gainsboro;
            this.linkLblOlvido.AutoSize = true;
            this.linkLblOlvido.DisabledLinkColor = System.Drawing.Color.LightGray;
            this.linkLblOlvido.ForeColor = System.Drawing.SystemColors.ControlText;
            this.linkLblOlvido.LinkColor = System.Drawing.Color.DimGray;
            this.linkLblOlvido.Location = new System.Drawing.Point(328, 531);
            this.linkLblOlvido.Name = "linkLblOlvido";
            this.linkLblOlvido.Size = new System.Drawing.Size(146, 13);
            this.linkLblOlvido.TabIndex = 0;
            this.linkLblOlvido.TabStop = true;
            this.linkLblOlvido.Text = "¿Ha olvidado su contraseña?";
            this.linkLblOlvido.VisitedLinkColor = System.Drawing.Color.Black;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Image = global::AplicacionStock.Properties.Resources.Minimizar;
            this.btnMinimizar.Location = new System.Drawing.Point(742, 12);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(20, 20);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 8;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Image = global::AplicacionStock.Properties.Resources.Cerrar;
            this.btnCerrar.Location = new System.Drawing.Point(768, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(20, 20);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 7;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLogo.Image = global::AplicacionStock.Properties.Resources.logo;
            this.pictureBoxLogo.Location = new System.Drawing.Point(249, 91);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(300, 123);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 6;
            this.pictureBoxLogo.TabStop = false;
            // 
            // _vntLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.btnMinimizar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.linkLblOlvido);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtBoxContrasena);
            this.Controls.Add(this.txtBoxUsuario);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "_vntLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineUsuario;
        private System.Windows.Forms.TextBox txtBoxUsuario;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.TextBox txtBoxContrasena;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.LinkLabel linkLblOlvido;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.PictureBox btnMinimizar;
    }
}