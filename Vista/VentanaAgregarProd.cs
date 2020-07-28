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
    public partial class _vntAgregarProd : Form
    {
        public _vntAgregarProd()
        {
            InitializeComponent();
        }

        private void _vntAgregarProd_Load(object sender, EventArgs e)
        {

        }

        private void _btnCancAgregar_Click(object sender, EventArgs e)
        {
            //Volver a la ventana de productos
            _vntProd vntProd = new _vntProd();
            vntProd.Show();
            this.Hide();
        }

        private void _btnConfAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                //Validar que no estén vacíos los campos
                if (_txbIDNuevo.Text == "" || _txbNombreNuevo.Text == "" || _txbCantNueva.Text == "" || _txbTallaNueva.Text == "")
                {
                    MessageBox.Show("Todos los campos son obligatorios.", "Datos Inválidos");
                }
                else
                {
                    //Validar que no se excedan de largo
                    if (_txbIDNuevo.TextLength > 10 || _txbNombreNuevo.TextLength > 45 || _txbCantNueva.TextLength > 7 || _txbTallaNueva.TextLength > 6)
                    {
                        MessageBox.Show("Uno de los campos excede el largo máximo.", "Datos Inválidos");
                    }
                    else
                    {
                        //Validar el tipo de dato
                        int idParse = 0;
                        int cantParse = 0;
                        bool idVal = Int32.TryParse(_txbIDNuevo.Text, out idParse);
                        bool cantVal = Int32.TryParse(_txbCantNueva.Text, out cantParse);

                        if (!idVal || !cantVal)
                        {
                            MessageBox.Show("El ID o la cantidad están en un formato no válido.", "Datos Inválidos");
                        }
                        else
                        {
                            //Crear link a la DB
                            LINQProductosDataContext tblProd = new LINQProductosDataContext();

                            //Validar que el ID no exista
                            var idIguales = from producto in tblProd.Producto where producto.id == idParse select producto.id;

                            if (idIguales.Count() != 0)
                            {
                                MessageBox.Show("El ID que ingresó ya existe en la tabla, intente otro.", "Datos Inválidos");
                            }
                            else
                            {
                                //Crear producto
                                Producto productoNuevo = new Producto();
                                productoNuevo.id = idParse;
                                productoNuevo.nombre = _txbNombreNuevo.Text;
                                productoNuevo.cantidad = cantParse;
                                productoNuevo.talla = _txbTallaNueva.Text;
                                productoNuevo.origen = _vntLogin.usuarioActual;

                                //Insertar producto nuevo
                                tblProd.Producto.InsertOnSubmit(productoNuevo);
                                tblProd.SubmitChanges();

                                //Avisar por alerta la operación exitosa
                                AlertaAgregar alertaAgregar = new AlertaAgregar();
                                alertaAgregar.enviarAlerta(true);

                                //Volver a la ventana de productos
                                _vntProd vntProd = new _vntProd();
                                vntProd.Show();
                                this.Hide();
                            }
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                //Avisar por alerta la operación no exitosa
                AlertaAgregar alertaAgregar = new AlertaAgregar();
                alertaAgregar.enviarAlerta(false);
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
