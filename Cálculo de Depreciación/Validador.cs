namespace Cálculo_de_Depreciación;

/// <summary>
/// Lee y valida los datos ingresados por el usuario.
/// </summary>
public static class Validador
{
    /// <summary>Solicita el valor de compra hasta que sea mayor que 0.</summary>
    /// <returns>Valor de compra válido.</returns>
    public static decimal LeerValor()
    {
        Console.Write("Ingrese el valor de compra: ");
        var x = decimal.TryParse(Console.ReadLine(), out decimal valor);

        if (!x || valor <= 0)
        {
            Console.WriteLine("Valor inválido. Por favor, ingrese un número positivo.");
            return LeerValor();
        }

        return valor;
    }

    /// <summary>Solicita la tasa de depreciación hasta que esté entre 0 y 100.</summary>
    /// <returns>Tasa de depreciación válida.</returns>
    public static decimal LeerTasa()
    {
        Console.Write("Ingrese la tasa de depreciación (en porcentaje): ");
        var x = decimal.TryParse(Console.ReadLine(), out decimal tasa);

        if (!x || tasa < 0 || tasa > 100)
        {
            Console.WriteLine("Tasa inválida. Por favor, ingrese un número entre 0 y 100.");
            return LeerTasa();
        }

        return tasa;
    }

    /// <summary>Solicita los años transcurridos hasta que no sean negativos.</summary>
    /// <returns>Número de años válido.</returns>
    public static int LeerAnios()
    {
        Console.Write("Ingrese el número de años: ");
        var x = int.TryParse(Console.ReadLine(), out int anios);

        if (!x || anios < 0)
        {
            Console.WriteLine("Años inválidos. Por favor, ingrese un número entero mayor o igual a 0.");
            return LeerAnios();
        }

        return anios;
    }
}