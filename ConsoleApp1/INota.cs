using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    internal interface INota
    {
        public double CalcularNotaFinal(double nota1, double nota2, double nota3);

        public string MensajeNota(double notaFinal);
    }
}
