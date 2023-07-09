using Proxy;

Console.WriteLine("### Exemplo de implementação do padrão Proxy ###\n");

//acesso do Programado
Console.WriteLine("\nFuncionário com perfil 'Programador' acessando " +
"a Pasta Compartilhada Proxy");
Funcionario funci1 = new Funcionario("Macoratti", "Programador");
PastaCompartilhadaProxy pastaProxy1 = new PastaCompartilhadaProxy(funci1);
pastaProxy1.OperacaoDeLeituraGravacao();

//acesso Usuario
Console.WriteLine("\nFuncionário com perfil 'Usuario' acessando a Pasta " +
    "Compartilhada Proxy");

Funcionario funci2 = new Funcionario("Amanda", "Usuario");
PastaCompartilhadaProxy pastaProxy2 = new PastaCompartilhadaProxy(funci2);
pastaProxy2.OperacaoDeLeituraGravacao();

//acesso Ceo
Console.WriteLine("\nFuncionário com perfil 'Ceo' acessando a " +
    "Pasta Compartilhada Proxy");

Funcionario funci3 = new Funcionario("Bill Gates", "Ceo");
PastaCompartilhadaProxy pastaProxy3 = new PastaCompartilhadaProxy(funci3);
pastaProxy3.OperacaoDeLeituraGravacao();

Console.ReadKey();
