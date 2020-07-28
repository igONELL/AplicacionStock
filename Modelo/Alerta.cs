using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionStock.Modelo
{
    abstract class Alerta
    {
        protected string mensaje;
        protected string titulo;
        public void enviarAlerta(bool exitosa)
        {
            this.crearAlerta(exitosa);
            MessageBox.Show(this.mensaje, this.titulo);
        }

        protected abstract void crearAlerta(bool exitosa);
    }
}
