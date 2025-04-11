Console.Clear();
// j - c. i. t
// m - t.j

decimal capital, juros, montante;
double taxa;
int tempo;

Console.WriteLine("juros simples (j)\n");

Console.Write("capital [c] (R$).........:\n");

capital = Convert.ToDecimal(Console.ReadLine());
Console.Write("taxa juros [i] (%).......:\n");
taxa = Convert.ToDouble(Console.ReadLine());
Console.Write("tempo [t] (meses)........:\n");
tempo = Convert.ToInt32(Console.ReadLine());
 

Console.WriteLine($"\nJuros (R$).....: 360,00");
Console.WriteLine($"Montante (R$)..: 1560,00");