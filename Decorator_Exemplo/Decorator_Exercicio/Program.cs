﻿using Decorator_Exercicio;

var bebidas = new List<ICafe>
            {
                //cafe filtrado com chocolate
                new ChocolateDecorator(new Filtrado()),
                //cafe filtrado com leite
                new LeiteDecorator(new Filtrado()),
                //cafe espresso com leite e chocolate
                new ChocolateDecorator(new LeiteDecorator(new Expresso())),
                //criando capuccino somente
                new Capuccino(),
                //capuccino + porcao de leite
                new LeiteDecorator(new Capuccino())
            };

var filtradoChocolate = bebidas.First();
Console.WriteLine(filtradoChocolate.Descricao());
Console.WriteLine($"{filtradoChocolate.Preco()}\n");

var filtradoLeite = bebidas.Skip(1).First();
Console.WriteLine(filtradoLeite.Descricao());
Console.WriteLine($"{filtradoLeite.Preco()}\n");

var espressoLeiteChocolate = bebidas.Skip(2).First();
Console.WriteLine(espressoLeiteChocolate.Descricao());
Console.WriteLine($"{espressoLeiteChocolate.Preco()}\n");

var capuccino = bebidas.Skip(3).First();
Console.WriteLine(capuccino.Descricao()) ;
Console.WriteLine($"{capuccino.Preco()}\n");

var capuccinoComLeite = bebidas.Skip(4).First();
Console.WriteLine(capuccinoComLeite.Descricao());
Console.WriteLine($"{capuccinoComLeite.Preco()}\n");


Console.ReadKey();
