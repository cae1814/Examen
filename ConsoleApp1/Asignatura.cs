using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    internal class Asignatura : Alumno
    {
        public string Nombre { get; set; }
        public string Horario { get; set; }
        public string Docente { get; set; }

        public override void Imprimir() {
            Console.WriteLine("Nombre: "+this.Nombre);
            Console.WriteLine("Cuenta: "+ NumeroCuenta);
            Console.WriteLine("Correo: "+ Email);
            Console.WriteLine("Asignatura: " + Nombre);
            Console.WriteLine("Horario: " + Horario);
            Console.WriteLine("Docente: " + Docente);
        }
    }
}
