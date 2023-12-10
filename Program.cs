Console.WriteLine("--- Múltiplo ---");

Console.Write("Digite um número: ");
int value = Convert.ToInt32(Console.ReadLine());

Console.Write("Verificar se é múltiplo de: ");
int multiplier = Convert.ToInt32(Console.ReadLine());

if (value % multiplier == 0) {
  Console.WriteLine($"{value} é múltiplo de {multiplier}.");
} else {
  Console.WriteLine($"{value} não é múltiplo de {multiplier}.");
}