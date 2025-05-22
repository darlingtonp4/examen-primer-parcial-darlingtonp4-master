public class Asignatura : Alumno, IAsignatura
{
    public double N1 { get; set; }
    public double N2 { get; set; }
    public double N3 { get; set; }
    public string? NombreAsignatura { get; set; }
    public string? Horario { get; set; }
    public string? NombreDocente { get; set; }


    public double CalcularNotaFinal(double N1, double N2, double N3)
    {
        return N1 + N2 + N1;
    }

    public double CalcularNotaFinal()
    {
        return N1 + N2 + N1;
    }


    public void Imprimir()
    {
        Console.WriteLine("************************************************************");
        Console.WriteLine($"Nombre del estudiante: {NombreAlumno}");
        Console.WriteLine($"Número de cuenta: {NumeroCuenta}");
        Console.WriteLine($"Correo electrónico: {Email}");
        Console.WriteLine($"Nombre de la clase: {NombreAsignatura}");
        Console.WriteLine($"Horario: {Horario}");
        Console.WriteLine($"Nombre del docente: {NombreDocente}");
        Console.WriteLine($"{MensajeNotaFinal(CalcularNotaFinal())}");
        Console.WriteLine($"{MensajeNotaFinal(CalcularNotaFinal(N1, N2, N3))}");
        Console.WriteLine("************************************************************");

    }

    public string MensajeNotaFinal(double notaFinal)
    {
        if (notaFinal < 60)
        {
            return $"Nota Final:{notaFinal}% - Reprobado ";
        }
        else if (notaFinal < 79 && notaFinal > 59)
        {
            return $"Nota Final:{notaFinal}% - Bueno";
        }
        else if (notaFinal > 79 && notaFinal < 90)
        {
            return $"Nota Final:{notaFinal}% - Muy Bueno ";
        }
        else return $"Nota Final:{notaFinal}% - Sobresaliente ";
    }

}