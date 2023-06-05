using ClasseAbstrata;

Quadrado quadrado = new();
Console.WriteLine(quadrado.Descricao());

Console.WriteLine("Informe o valor do lado do quadrado em metros.");
quadrado.Lado = Convert.ToDouble(Console.ReadLine());
quadrado.CalcularArea();
quadrado.CalcularPerimetro();

Console.WriteLine("A área do quadrado é: " + quadrado.Area + " m2 ");
Console.WriteLine("O perímetro do quadrado é: " + quadrado.Perimetro + " m ");

