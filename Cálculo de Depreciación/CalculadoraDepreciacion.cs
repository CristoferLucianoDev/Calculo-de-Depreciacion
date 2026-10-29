namespace Cálculo_de_Depreciación;

/// <summary>
/// Calcula la depreciación de un activo por saldo decreciente.
/// </summary>
public class CalculadoraDepreciacion
{
    /// <summary>Valor de compra original.</summary>
    public decimal V { get; }

    /// <summary>Tasa de depreciación anual (%).</summary>
    public decimal d { get; }

    /// <summary>Factor de retención: 1 - d / 100.</summary>
    public decimal r => 1 - (d / 100);

    /// <param name="valor">Costo inicial, mayor que 0.</param>
    /// <param name="depreciacion">Tasa anual entre 0 y 100.</param>
    public CalculadoraDepreciacion(decimal valor, decimal depreciacion)
    {
        V = (valor > 0) ? valor : throw new ArgumentOutOfRangeException(nameof(valor), "El valor debe ser positivo");
        d = (depreciacion >= 0 && depreciacion <= 100) ? depreciacion : throw new ArgumentOutOfRangeException(nameof(depreciacion), "La depreciación debe estar entre 0 y 100");
    }

    /// <summary>
    /// Calcula recursivamente el valor contable al final del año t.
    /// </summary>
    /// <param name="t">Años transcurridos, no negativo.</param>
    /// <returns>Valor contable en el año t.</returns>
    public decimal CalcularValorContable(int t)
    {
        t = (t >= 0) ? t : throw new ArgumentOutOfRangeException(nameof(t), "El tiempo debe ser no negativo");

        // Caso base
        if (t == 0)
        {
            return V;
        }
        else
        {
            // Caso recursivo
            return CalcularValorContable(t - 1) * r;
        }
    }
}