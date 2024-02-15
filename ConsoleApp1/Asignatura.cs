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
            Console.WriteLine("Nombre del estudiante: "+this.Nombre);
            Console.WriteLine("Numero de Cuenta: "+ NumeroCuenta);
            Console.WriteLine("Correo electronico: "+ Email);
            Console.WriteLine("Nombre de la clase: " + Nombre);
            Console.WriteLine("Horario: " + Horario);
            Console.WriteLine("Nombre del Docente: " + Docente);
        }
    }
}
