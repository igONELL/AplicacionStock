using AplicacionStock.Controlador;
using AplicacionStock.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionStock.Vista
{
    public partial class _vntEliminarProd : Form
    {
        public _vntEliminarProd()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void _btnCancElim_Click(object sender, EventArgs e)
        {
            _vntProd vntProd = new _vntProd();
            vntProd.Show();
            this.Hide();
        }

        private void _btnConfElim_Click(object sender, EventArgs e)
        {
            try
            {
                //Validar que no esté vacío el campo
                if (_txbIDElim.Text == "")
                {
                    MessageBox.Show("El campo es obligatorio.", "Datos Inválidos");
                }
                else
                {
                    //Validar que no se exceda de largo
                    if (_txbIDElim.TextLength > 10)
                    {
                        MessageBox.Show("El campo excede el largo máximo.", "Datos Inválidos");
                    }
                    else
                    {
                        //Validar el tipo de dato
                        int idParse = 0;
                        bool idVal = Int32.TryParse(_txbIDElim.Text, out idParse);

                        if (!idVal)
                        {
                            MessageBox.Show("El ID está en un formato no válido.", "Datos Inválidos");
                        }
                        else
                        {
                            //Crear link a la DB
                            LINQProductosDataContext tblProd = new LINQProductosDataContext();

                            //Validar que el ID exista
                            var idIguales = from producto in tblProd.Producto where producto.id == idParse select producto.id;

                            if (idIguales.Count() != 1)
                            {
                                MessageBox.Show("El ID que ingresó no existe en la tabla, intente otro.", "Datos Inválidos");
                            }
                            else
                            {
                                if (MessageBox.Show("¿Está seguro que quiere eliminar el producto?", "Eliminar Producto", MessageBoxButtons.YesNo) == DialogResult.Yes)
                                {
                                    //Filtrar el ID
                                    var productoEliminar = from producto in tblProd.Producto where producto.id == Int32.Parse(_txbIDElim.Text) select producto;

                                    //Eliminar producto
                                    tblProd.Producto.DeleteOnSubmit(productoEliminar.First());
                                    tblProd.SubmitChanges();

                                    //Avisar por alerta la operación exitosa
                                    AlertaEliminar alertaEliminar = new AlertaEliminar();
                                    alertaEliminar.enviarAlerta(true);

                                    //Volver a la ventana de productos
                                    _vntProd vntProd = new _vntProd();
                                    vntProd.Show();
                                    this.Hide();
                                }
                            }
                        }
                    }
                }
            }catch(Exception ex)
            {
                //Avisar por alerta la operación no exitosa
                AlertaEliminar alertaEliminar = new AlertaEliminar();
                alertaEliminar.enviarAlerta(false);
                MessageBox.Show(ex.Message, "Error");
            }    
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
