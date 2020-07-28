using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionStock.Modelo
{
    class AlertaAgregar : Alerta
    {
        protected override void crearAlerta(bool exitosa)
        {
            if (exitosa)
            {
                this.mensaje = "Se agregó el producto correctamente.";
                this.titulo = "Producto Agregado";
            }
            else
            {
                this.mensaje = "No se agregó el producto correctamente.";
                this.titulo = "Producto No Agregado";
            }
        }
    }
}
