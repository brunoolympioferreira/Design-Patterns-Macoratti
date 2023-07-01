// Cria uma instância do Facade
using Facade;

CreditoFacade concedeCreditoFacade = new CreditoFacade();

// Cria uma instância de um  novo Cliente informando o nome
Cliente cliente1 = new Cliente("Macoratti");

//Utiliza o Facade para verificar condições de concessão ou não
bool resultado = concedeCreditoFacade.ConcederEmprestimo(cliente1, 199000.00);

//exibe o resultado
Console.WriteLine($"O empréstimo pleiteado pelo cliente {cliente1.Nome} foi "
    + (resultado ? "Aprovado" : "Negado"));

Console.ReadKey();