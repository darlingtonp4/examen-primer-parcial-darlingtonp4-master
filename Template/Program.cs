// See https://aka.ms/new-console-template for more information
Asignatura alumno = new Asignatura();
Console.WriteLine("Ingrese el nombre del alumno:");
alumno.NombreAlumno = Console.ReadLine();
Console.WriteLine("Ingrese el número de cuenta:");
alumno.NumeroCuenta = Console.ReadLine();
Console.WriteLine("Ingrese el correo electrónico:");
alumno.Email = Console.ReadLine();
Console.WriteLine("Ingrese el nombre de la clase:");
alumno.NombreAsignatura = Console.ReadLine();
Console.WriteLine("Ingrese el horario de la clase:");
alumno.Horario = Console.ReadLine();
Console.WriteLine("Ingrese el nombre del docente:");
alumno.NombreDocente = Console.ReadLine();

double IngresoNota1 = 0;
double IngresoNota2= 0;
double IngresoNota3  = 0;

try
{
    do
    {
        Console.WriteLine("Ingrese la nota del primer parcial:");
        IngresoNota1 = Convert.ToDouble(Console.ReadLine());
        if (IngresoNota1 > 30)
        {
            Console.WriteLine("Nota no debe ser mayor a 30");
        }
    } while (IngresoNota1 > 30 || IngresoNota1 < 1);
    alumno.N1 = IngresoNota1;

    do
    {
        Console.WriteLine("Ingrese la nota del segundo parcial:");
        IngresoNota2 = Convert.ToDouble(Console.ReadLine());
        if (IngresoNota2 > 30)
        {
            Console.WriteLine("Nota no debe ser mayor a 30");
        }
    } while (IngresoNota2 > 30 || IngresoNota2 < 1);
    alumno.N2 = IngresoNota2;

    do
    {
        Console.WriteLine("Ingrese la nota del tercerr parcial:");
        IngresoNota3 = Convert.ToDouble(Console.ReadLine());
        if (IngresoNota3 > 40)
        {
            Console.WriteLine("Nota no debe ser mayor a 40");
        }
    } while (IngresoNota3 > 40 || IngresoNota3 < 1);
    alumno.N3 = IngresoNota3;

    alumno.Imprimir();
    Console.ReadLine();
}
catch (Exception e)
{
    Console.WriteLine($"Sus ingresos presentan un error del siguiente tipo:{e})");
}

