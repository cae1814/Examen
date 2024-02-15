using Examen;

Asignatura asig = new Asignatura();
Nota nota = new Nota();

try
{
    Console.WriteLine("Nombre del estudiante: ");
    asig.Nombre_ = Console.ReadLine();
} catch (Exception ex) {
    Console.WriteLine("Error al capturar el nombre");
}

try
{
    Console.WriteLine("Numero de cuenta: ");
    asig.NumeroCuenta = Console.ReadLine();
} catch (Exception ex) {
    Console.WriteLine("Error al capturar el Cuenta");
}

try
{
    Console.WriteLine("Correo electronico: ");
    asig.Email = Console.ReadLine();
} catch (Exception ex) {
    Console.WriteLine("Error al capturar el Correo");
}

Console.WriteLine("--------------------------------------------");

try { 
    Console.WriteLine("Nombre de la clase: ");
    asig.Nombre = Console.ReadLine();
} catch (Exception ex) {
    Console.WriteLine("Error al capturar el nombre de la clase");
}

try {
    Console.WriteLine("Horario: ");
    asig.Horario = Console.ReadLine();
} catch (Exception ex) {
    Console.WriteLine("Error al capturar el horario");
}

try { 
    Console.WriteLine("Nombre del docente: ");
    asig.Docente = Console.ReadLine();
} catch (Exception ex) {
    Console.WriteLine("Error al capturar el nombre de docente");
}

Console.WriteLine("--------------------------------------------");

try {
         
    Console.WriteLine("Ingrese nota del primer parcial:");
     nota.Nota1 = Convert.ToDouble(Console.ReadLine());

    if (nota.Nota1 > 30) {
        Console.WriteLine("La nota ingresada "+nota.Nota1+" es incorrecta.");
        nota.Nota1 = 0;
    }
} catch (Exception ex) {
    Console.WriteLine("Error al obtener la nota 1");
    nota.Nota1 = 0;
}

try
{

    Console.WriteLine("Ingrese nota del segundo parcial:");
    nota.Nota2 = Convert.ToDouble(Console.ReadLine());

    if (nota.Nota2 > 30)
    {
        Console.WriteLine("La nota ingresada " + nota.Nota2 + " es incorrecta.");
        nota.Nota2 = 0;
    }
} catch (Exception ex) {
    Console.WriteLine("Error al obtener la nota 2");
    nota.Nota2 = 0;
}

try
{

    Console.WriteLine("Ingrese nota del tercer parcial:");
    nota.Nota3 = Convert.ToDouble(Console.ReadLine());

    if (nota.Nota3 > 40)
    {
        Console.WriteLine("La nota ingresada " + nota.Nota3 + " es incorrecta.");
        nota.Nota3 = 0;
    }
}
catch (Exception ex) {
    Console.WriteLine("Error al obtener la nota 3");
    nota.Nota3 = 0;
}


Console.WriteLine("**********************************************");
asig.Imprimir();
Console.WriteLine("Su Nota Final: "+nota.CalcularNotaFinal(nota.Nota1, nota.Nota2, nota.Nota3)+"% ("+nota.MensajeNota(nota.CalcularNotaFinal(nota.Nota1, nota.Nota2, nota.Nota3))+")");