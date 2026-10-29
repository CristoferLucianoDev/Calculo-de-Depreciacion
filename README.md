# Cálculo de Depreciación por Saldo Decreciente

Aplicación de consola que calcula el valor contable de un activo fijo después de `t` años. Usa el método de saldo decreciente: cada año el activo pierde un porcentaje fijo `d` de su valor del año anterior. El cálculo es estrictamente recursivo.

## Modelo

| Variable | Descripción | Tipo |
|---|---|---|
| `V` | Valor de compra original | `decimal` |
| `d` | Tasa de depreciación anual (%) | `decimal` |
| `r` | Factor de retención, `1 - d / 100` | `decimal` (calculado) |
| `t` | Años transcurridos | `int` |
| `V(t)` | Valor contable al final del año `t` | `decimal` |

- **Caso base:** si `t = 0`, `V(0) = V`.
- **Caso recursivo:** si `t > 0`, `V(t) = V(t - 1) * r`.

## Estructura

- `CalculadoraDepreciacion.cs`: guarda `V` y `d`, valida ambos en el constructor y expone `r` como propiedad calculada. Contiene `CalcularValorContable(int t)`, el método recursivo que se llama a sí mismo con `t - 1` hasta llegar al caso base.
- `Validador.cs`: clase estática que lee los datos desde consola y vuelve a pedirlos mientras no sean válidos. El valor debe ser mayor que 0, la tasa debe estar entre 0 y 100 y los años no pueden ser negativos.
- `Program.cs`: solicita los datos, crea la calculadora y muestra el valor de cada año y el resultado final con dos decimales.


## Notas

- El separador decimal y el de miles dependen de la configuración regional del sistema. Por ejemplo, en algunos equipos la tasa se ingresa como `12,5` en lugar de `12.5`.
- Cada año agrega una llamada a la pila, así que valores de `t` extremadamente grandes podrían provocar un desbordamiento de pila. Para la vida útil de un activo real (decenas de años) no es un problema.
