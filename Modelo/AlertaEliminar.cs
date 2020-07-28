using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionStock.Modelo
{
    class AlertaEliminar : Alerta
    {
        protected override void crearAlerta(bool exitosa)
        {
            if (exitosa)
            {
                this.mensaje = "Se eliminó el producto correctamente.";
                this.titulo = "Producto Eliminado";
            }
            else
            {
                this.mensaje = "No se eliminó el producto correctamente.";
                this.titulo = "Producto No Eliminado";
            }
        }
    }
}
