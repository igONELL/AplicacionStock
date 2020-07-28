namespace AplicacionStock
{
    partial class _vntProd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_vntProd));
            this._lblListProd = new System.Windows.Forms.Label();
            this._gvProd = new System.Windows.Forms.DataGridView();
            this._btnAgregarProd = new System.Windows.Forms.Button();
            this._btnModProd = new System.Windows.Forms.Button();
            this._btnEliminProd = new System.Windows.Forms.Button();
            this._btnSalirSesion = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this._gvProd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            this.SuspendLayout();
            // 
            // _lblListProd
            // 
            this._lblListProd.AutoSize = true;
            this._lblListProd.Font = new System.Drawing.Font("Century Gothic", 16F);
            this._lblListProd.Location = new System.Drawing.Point(369, 82);
            this._lblListProd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._lblListProd.Name = "_lblListProd";
            this._lblListProd.Size = new System.Drawing.Size(235, 25);
            this._lblListProd.TabIndex = 0;
            this._lblListProd.Text = "Listado de Productos";
            // 
            // _gvProd
            // 
            this._gvProd.BackgroundColor = System.Drawing.Color.LightGray;
            this._gvProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._gvProd.Location = new System.Drawing.Point(126, 178);
            this._gvProd.Margin = new System.Windows.Forms.Padding(4);
            this._gvProd.Name = "_gvProd";
            this._gvProd.Size = new System.Drawing.Size(736, 367);
            this._gvProd.TabIndex = 1;
            // 
            // _btnAgregarProd
            // 
            this._btnAgregarProd.FlatAppearance.BorderSize = 0;
            this._btnAgregarProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnAgregarProd.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnAgregarProd.Location = new System.Drawing.Point(126, 570);
            this._btnAgregarProd.Margin = new System.Windows.Forms.Padding(4);
            this._btnAgregarProd.Name = "_btnAgregarProd";
            this._btnAgregarProd.Size = new System.Drawing.Size(240, 65);
            this._btnAgregarProd.TabIndex = 2;
            this._btnAgregarProd.Text = "Agregar Producto Nuevo";
            this._btnAgregarProd.UseVisualStyleBackColor = true;
            this._btnAgregarProd.Click += new System.EventHandler(this._btnAgregarProd_Click);
            // 
            // _btnModProd
            // 
            this._btnModProd.FlatAppearance.BorderSize = 0;
            this._btnModProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnModProd.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnModProd.Location = new System.Drawing.Point(374, 570);
            this._btnModProd.Margin = new System.Windows.Forms.Padding(4);
            this._btnModProd.Name = "_btnModProd";
            this._btnModProd.Size = new System.Drawing.Size(240, 65);
            this._btnModProd.TabIndex = 3;
            this._btnModProd.Text = "Modificar Producto";
            this._btnModProd.UseVisualStyleBackColor = true;
            this._btnModProd.Click += new System.EventHandler(this._btnModProd_Click);
            // 
            // _btnEliminProd
            // 
            this._btnEliminProd.FlatAppearance.BorderSize = 0;
            this._btnEliminProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnEliminProd.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnEliminProd.Location = new System.Drawing.Point(622, 570);
            this._btnEliminProd.Margin = new System.Windows.Forms.Padding(4);
            this._btnEliminProd.Name = "_btnEliminProd";
            this._btnEliminProd.Size = new System.Drawing.Size(240, 65);
            this._btnEliminProd.TabIndex = 4;
            this._btnEliminProd.Text = "Eliminar Producto";
            this._btnEliminProd.UseVisualStyleBackColor = true;
            this._btnEliminProd.Click += new System.EventHandler(this._btnEliminProd_Click);
            // 
            // _btnSalirSesion
            // 
            this._btnSalirSesion.FlatAppearance.BorderSize = 0;
            this._btnSalirSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnSalirSesion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnSalirSesion.Location = new System.Drawing.Point(374, 657);
            this._btnSalirSesion.Margin = new System.Windows.Forms.Padding(4);
            this._btnSalirSesion.Name = "_btnSalirSesion";
            this._btnSalirSesion.Size = new System.Drawing.Size(240, 65);
            this._btnSalirSesion.TabIndex = 5;
            this._btnSalirSesion.Text = "Salir de la Sesión";
            this._btnSalirSesion.UseVisualStyleBackColor = true;
            this._btnSalirSesion.Click += new System.EventHandler(this._btnSalirSesion_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Image = global::AplicacionStock.Properties.Resources.Cerrar;
            this.btnCerrar.Location = new System.Drawing.Point(992, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(20, 20);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 6;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Image = global::AplicacionStock.Properties.Resources.Minimizar;
            this.btnMinimizar.Location = new System.Drawing.Point(966, 12);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(20, 20);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 7;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // _vntProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1024, 749);
            this.Controls.Add(this.btnMinimizar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this._btnSalirSesion);
            this.Controls.Add(this._btnEliminProd);
            this.Controls.Add(this._btnModProd);
            this.Controls.Add(this._btnAgregarProd);
            this.Controls.Add(this._gvProd);
            this.Controls.Add(this._lblListProd);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "_vntProd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Productos";
            this.Load += new System.EventHandler(this._vntProd_Load);
            ((System.ComponentModel.ISupportInitialize)(this._gvProd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _lblListProd;
        private System.Windows.Forms.DataGridView _gvProd;
        private System.Windows.Forms.Button _btnAgregarProd;
        private System.Windows.Forms.Button _btnModProd;
        private System.Windows.Forms.Button _btnEliminProd;
        private System.Windows.Forms.Button _btnSalirSesion;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.PictureBox btnMinimizar;
    }
}

