Double Consumo, Diario;

Decimal Custo, Resultado;

Console.WriteLine
    ("--- Custo de Energia ---");

Console.Write
    ("Consumo do aparelho por mês em kWh...: ");
Consumo = Convert.ToDouble(Console.ReadLine());

Console.Write
    ("Horas de uso por dia.................: ");
Diario = Convert.ToDouble(Console.ReadLine());

Console.Write
    ("Custo da energia em R$...............: ");
Custo = Convert.ToDecimal(Console.ReadLine());

Resultado = Convert.ToDecimal(Consumo * Diario) * Custo;

Console.WriteLine
    ($"Custo estimado: R$ " + Resultado);