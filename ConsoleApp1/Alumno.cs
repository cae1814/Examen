using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    internal abstract class Alumno
    {
        public string Nombre_ { get; set; }
        public string NumeroCuenta { get; set; }
        public string Email { get; set; }

        public abstract void Imprimir();
    }
}
