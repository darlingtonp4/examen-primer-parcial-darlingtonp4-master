public interface IAsignatura
{
    public double CalcularNotaFinal();
    public double CalcularNotaFinal(double N1, double N2, double N3);
    public string MensajeNotaFinal(double notaFinal);
    public void Imprimir();
}