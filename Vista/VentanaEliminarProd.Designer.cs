namespace AplicacionStock.Vista
{
    partial class _vntEliminarProd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_vntEliminarProd));
            this._btnConfElim = new System.Windows.Forms.Button();
            this._btnCancElim = new System.Windows.Forms.Button();
            this._txbIDElim = new System.Windows.Forms.TextBox();
            this._lblIDElim = new System.Windows.Forms.Label();
            this._lblModifProd = new System.Windows.Forms.Label();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // _btnConfElim
            // 
            this._btnConfElim.BackColor = System.Drawing.Color.White;
            this._btnConfElim.FlatAppearance.BorderSize = 0;
            this._btnConfElim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnConfElim.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnConfElim.Location = new System.Drawing.Point(310, 455);
            this._btnConfElim.Name = "_btnConfElim";
            this._btnConfElim.Size = new System.Drawing.Size(180, 50);
            this._btnConfElim.TabIndex = 32;
            this._btnConfElim.Text = "Eliminar Producto";
            this._btnConfElim.UseVisualStyleBackColor = false;
            this._btnConfElim.Click += new System.EventHandler(this._btnConfElim_Click);
            // 
            // _btnCancElim
            // 
            this._btnCancElim.BackColor = System.Drawing.Color.White;
            this._btnCancElim.FlatAppearance.BorderSize = 0;
            this._btnCancElim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnCancElim.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnCancElim.Location = new System.Drawing.Point(549, 455);
            this._btnCancElim.Name = "_btnCancElim";
            this._btnCancElim.Size = new System.Drawing.Size(180, 50);
            this._btnCancElim.TabIndex = 31;
            this._btnCancElim.Text = "Cancelar";
            this._btnCancElim.UseVisualStyleBackColor = false;
            this._btnCancElim.Click += new System.EventHandler(this._btnCancElim_Click);
            // 
            // _txbIDElim
            // 
            this._txbIDElim.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txbIDElim.Location = new System.Drawing.Point(310, 312);
            this._txbIDElim.Name = "_txbIDElim";
            this._txbIDElim.Size = new System.Drawing.Size(419, 23);
            this._txbIDElim.TabIndex = 27;
            // 
            // _lblIDElim
            // 
            this._lblIDElim.AutoSize = true;
            this._lblIDElim.Font = new System.Drawing.Font("Century Gothic", 10F);
            this._lblIDElim.Location = new System.Drawing.Point(423, 269);
            this._lblIDElim.Name = "_lblIDElim";
            this._lblIDElim.Size = new System.Drawing.Size(193, 19);
            this._lblIDElim.TabIndex = 23;
            this._lblIDElim.Text = "ID del producto a eliminar:";
            // 
            // _lblModifProd
            // 
            this._lblModifProd.AutoSize = true;
            this._lblModifProd.Font = new System.Drawing.Font("Century Gothic", 16F);
            this._lblModifProd.Location = new System.Drawing.Point(417, 98);
            this._lblModifProd.Name = "_lblModifProd";
            this._lblModifProd.Size = new System.Drawing.Size(199, 25);
            this._lblModifProd.TabIndex = 22;
            this._lblModifProd.Text = "Eliminar Producto";
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Image = global::AplicacionStock.Properties.Resources.Minimizar;
            this.btnMinimizar.Location = new System.Drawing.Point(966, 12);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(20, 20);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 33;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Image = global::AplicacionStock.Properties.Resources.Cerrar;
            this.btnCerrar.Location = new System.Drawing.Point(992, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(20, 20);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 34;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // _vntEliminarProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnMinimizar);
            this.Controls.Add(this._btnConfElim);
            this.Controls.Add(this._btnCancElim);
            this.Controls.Add(this._txbIDElim);
            this.Controls.Add(this._lblIDElim);
            this.Controls.Add(this._lblModifProd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "_vntEliminarProd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eliminar Producto";
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _btnConfElim;
        private System.Windows.Forms.Button _btnCancElim;
        private System.Windows.Forms.TextBox _txbIDElim;
        private System.Windows.Forms.Label _lblIDElim;
        private System.Windows.Forms.Label _lblModifProd;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnCerrar;
    }
}