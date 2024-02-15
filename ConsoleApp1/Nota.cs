using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    internal class Nota : INota
    {
        private double NotaFinal;
        public Nota() { }
        public Nota(double nota1, double nota2, double nota3) { 
            this.Nota1 = nota1;
            this.Nota2 = nota2;
            this.Nota3 = nota3;
        }

        public double Nota1 { get; set; }
        public double Nota2 { get; set; }
        public double Nota3 { get; set; }

        public double CalcularNotaFinal(double nota1, double nota2, double nota3) {
            NotaFinal = (nota1 + nota2 + nota3);

            return NotaFinal;
        }

        public string MensajeNota(double notaFinal) {
            string resultado = "";
            
            if (notaFinal >= 0 && notaFinal <= 59) {
                resultado = "Reprobado";
            } else if (notaFinal >= 60 && notaFinal <= 79) {
                resultado = "Bueno";
            } else if (notaFinal >= 80 && notaFinal <= 89) {
                resultado = "Muy Bueno";
            } else if (notaFinal >= 90 && notaFinal <= 100) {
                resultado = "Sobresaliente";
            }

            return resultado;
        }
    }
}
