using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionStock.Modelo
{
    class AlertaModificar : Alerta
    {
        protected override void crearAlerta(bool exitosa)
        {
            if (exitosa)
            {
                this.mensaje = "Se modificó el producto correctamente.";
                this.titulo = "Producto Modificado";
            }
            else
            {
                this.mensaje = "No se modificó el producto correctamente.";
                this.titulo = "Producto No Modificado";
            }
        }
    }
}
