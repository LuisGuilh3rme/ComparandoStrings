Console.WriteLine("Informe o primeiro texto:");
string texto1 = Console.ReadLine();
Console.WriteLine("Informe o segundo texto:");
string texto2 = Console.ReadLine();

bool comparando1 = String.Equals(texto1, texto2);
Console.WriteLine("{0} == {1}? {2}", texto1, texto2, comparando1);

bool comparando2 = String.Equals(texto1, texto2, StringComparison.CurrentCultureIgnoreCase);
Console.WriteLine("{0} == {1}? {2} (Ignorando maiusculas e minúsculas)", texto1, texto2, comparando2);