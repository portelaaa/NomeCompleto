Console.WriteLine("Digite seu primeiro nome");
string nome;
nome = Console.ReadLine()!;

Console.WriteLine("Digite seu sobrenome");
string sobrenome;
sobrenome = Console.ReadLine()!;

Console.WriteLine($"Nome completo: {nome} {sobrenome}");
Console.WriteLine($"Nome de catálago: {sobrenome.ToUpper()}, {nome}");