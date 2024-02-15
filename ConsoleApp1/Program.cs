using Examen;

Asignatura asig = new Asignatura();
Nota nota = new Nota();

try
{
    Console.WriteLine("Nombre del estudiante: ");
    asig.Nombre = Console.ReadLine();
} catch (Exception ex) { }

try
{
    Console.WriteLine("Numero de cuenta: ");
    asig.NumeroCuenta = Console.ReadLine();
} catch (Exception ex) { }

try
{
    Console.WriteLine("Correo electronico: ");
    asig.Email = Console.ReadLine();
} catch (Exception ex) { }

Console.WriteLine("--------------------------------------------");

try { 
    Console.WriteLine("Nombre de la clase: ");
    asig.Nombre = Console.ReadLine();
} catch (Exception ex) { }

try {
    Console.WriteLine("Horario: ");
    asig.Horario = Console.ReadLine();
} catch (Exception ex) { }

try { 
    Console.WriteLine("Nombre del docente: ");
    asig.Docente = Console.ReadLine();
} catch (Exception ex) { }

Console.WriteLine("--------------------------------------------");

try {
    do {
        Console.WriteLine("Ingrese nota primer parcial: (No debe ser mayor que 30)");
        nota.Nota1 = Convert.ToDouble(Console.ReadLine());
    } while (nota.Nota1 >30);
} catch (Exception ex) { }

try
{
    do {
        Console.WriteLine("Ingrese nota primer parcial: (No debe ser mayor que 30)");
        nota.Nota2 = Convert.ToDouble(Console.ReadLine());
    } while (nota.Nota2 > 30);
}
catch (Exception ex) { }

try
{
    do {
        Console.WriteLine("Ingrese nota primer parcial: (No debe ser mayor que 30)");
        nota.Nota1 = Convert.ToDouble(Console.ReadLine());
    } while (nota.Nota1 > 40);
}
catch (Exception ex) { }


Console.WriteLine("**********************************************");
asig.Imprimir();
Console.WriteLine("Su Nota Final: "+nota.CalcularNotaFinal(nota.Nota1, nota.Nota2, nota.Nota3)+"% ("+nota.MensajeNota(nota.CalcularNotaFinal(nota.Nota1, nota.Nota2, nota.Nota3))+")");