using Decorator_Exemplo;

IPizza pizzaMussarela = new Pizza("Mussarela");
Console.WriteLine(pizzaMussarela.Opcionais());
Console.WriteLine($"Preco R$ {pizzaMussarela.Preco()}");

Console.WriteLine("Tecle algo para aplicar o padrão Decorator");
Console.ReadKey();
Console.WriteLine("------ Aplicando o Decorator ------------------");

IPizza massaEspecial = new MassaEspecialDecorator(pizzaMussarela);
IPizza baconDecorator = new BaconDecorator(massaEspecial);
IPizza bordaDecorator = new BordaRecheadaDecorator(baconDecorator);

Console.WriteLine(bordaDecorator.Opcionais());
Console.WriteLine($"Preço Total R$ : {bordaDecorator.Preco()}\n");

Console.ReadKey();
