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
    public partial class _vntModificarProd : Form
    {
        public _vntModificarProd()
        {
            InitializeComponent();
        }

        private void _btnCancModif_Click(object sender, EventArgs e)
        {
            //Volver a la ventana de productos
            _vntProd vntProd = new _vntProd();
            vntProd.Show();
            this.Hide();
        }

        private void _btnConfModif_Click(object sender, EventArgs e)
        {
            try
            {
                //Validar que no estén vacíos los campos
                if (_txbIDModif.Text == "" || _txbNombreModif.Text == "" || _txbCantModif.Text == "" || _txbTallaModif.Text == "")
                {
                    MessageBox.Show("Todos los campos son obligatorios.", "Datos Inválidos");
                }
                else
                {
                    //Validar que no se excedan de largo
                    if (_txbIDModif.TextLength > 10 || _txbNombreModif.TextLength > 45 || _txbCantModif.TextLength > 7 || _txbTallaModif.TextLength > 6)
                    {
                        MessageBox.Show("Uno de los campos excede el largo máximo.", "Datos Inválidos");
                    }
                    else
                    {
                        //Validar el tipo de dato
                        int idParse = 0;
                        int cantParse = 0;
                        bool idVal = Int32.TryParse(_txbIDModif.Text, out idParse);
                        bool cantVal = Int32.TryParse(_txbCantModif.Text, out cantParse);

                        if (!idVal || !cantVal)
                        {
                            MessageBox.Show("El ID o la cantidad están en un formato no válido.", "Datos Inválidos");
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
                                //Filtrar el ID
                                var productoModificar = from producto in tblProd.Producto where producto.id == idParse select producto;

                                //Modificar producto
                                productoModificar.First().nombre = _txbNombreModif.Text;
                                productoModificar.First().cantidad = cantParse;
                                productoModificar.First().talla = _txbTallaModif.Text;
                                productoModificar.First().origen = _vntLogin.usuarioActual;

                                //Actualizar tabla
                                tblProd.SubmitChanges();

                                //Avisar por alerta la operación exitosa
                                AlertaModificar alertaModificar = new AlertaModificar();
                                alertaModificar.enviarAlerta(true);

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
                AlertaModificar alertaModificar = new AlertaModificar();
                alertaModificar.enviarAlerta(false);
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
