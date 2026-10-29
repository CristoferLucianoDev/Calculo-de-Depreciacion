namespace Cálculo_de_Depreciación;

/// <summary>
/// Punto de entrada del programa de cálculo de depreciación.
/// </summary>
internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Cálculo de Depreciación por Saldo Decreciente ===");
        Console.WriteLine();

        // Lectura de datos
        decimal valor = Validador.LeerValor();
        decimal tasa = Validador.LeerTasa();
        int anios = Validador.LeerAnios();

        // Cálculo
        var calculadora = new CalculadoraDepreciacion(valor, tasa);
        decimal resultado = calculadora.CalcularValorContable(anios);

        // Desglose por año
        Console.WriteLine();
        for (int i = 0; i <= anios; i++)
        {
            Console.WriteLine($"Año {i}: {calculadora.CalcularValorContable(i):N2}");
        }

        // Resultado final
        Console.WriteLine();
        Console.WriteLine($"Valor contable después de {anios} años: {resultado:N2}");
    }
}