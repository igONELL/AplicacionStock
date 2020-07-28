using AplicacionStock.Controlador;
using AplicacionStock.Vista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionStock
{
    public partial class _vntProd : Form
    {
        public _vntProd()
        {
            InitializeComponent();
        }

        private void _vntProd_Load(object sender, EventArgs e)
        {
            LINQVistaProductosDataContext tblVistaProd = new LINQVistaProductosDataContext();
            var productosVisibles = from producto in tblVistaProd.ProductosVisibles select producto;
            _gvProd.DataSource = productosVisibles;
        }

        private void _btnSalirSesion_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Está seguro que quiere salir de la sesión?","Salir de la Sesión", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _vntLogin vntLogin = new _vntLogin();
                vntLogin.Show();
                this.Hide();
            }
            
        }

        private void _btnAgregarProd_Click(object sender, EventArgs e)
        {
            _vntAgregarProd vntAgregarProd = new _vntAgregarProd();
            vntAgregarProd.Show();
            this.Hide();
        }

        private void _btnModProd_Click(object sender, EventArgs e)
        {
            _vntModificarProd vntModificarProd = new _vntModificarProd();
            vntModificarProd.Show();
            this.Hide();
        }

        private void _btnEliminProd_Click(object sender, EventArgs e)
        {
            _vntEliminarProd vntEliminarProd = new _vntEliminarProd();
            vntEliminarProd.Show();
            this.Hide();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
