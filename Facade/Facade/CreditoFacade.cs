using Facade.Subsistemas;

namespace Facade;
public class CreditoFacade
{
    private LimiteCredito limite;
    private Serasa serasa;
    private Cadin cadin;
    private Cadastro cadastro;

    public CreditoFacade()
    {
        limite = new LimiteCredito();
        serasa = new Serasa();
        cadin = new Cadin();
        cadastro = new Cadastro();
    }

    public bool ConcederEmprestimo(Cliente cliente, double valor)
    {
        Console.WriteLine($"{cliente.Nome} esta pleitando " +
                $"um empréstimo no valor de {valor:C}\n");

        //cadastro
        cadastro.CadastrarCliente(cliente);

        bool concederEmprestimo = true;

        if (serasa.EstaNoSerasa(cliente))
        {
            // Verifica o Serasa
            Console.WriteLine($"Cliente {cliente.Nome} possui restrição no SERASA");
            concederEmprestimo = false;
        }
        else if (cadin.EstaNoCadin(cliente))
        {
            // Verifica o Cadin
            Console.WriteLine($"Cliente {cliente.Nome} possui restrição no CADIN");
            concederEmprestimo = false;
        }
        else if (!limite.PossuiLimiteCredito(cliente, valor))
        {
            //verifica se o cliente tem limite de crédito para o valor requerido
            Console.WriteLine($"O Cliente {cliente.Nome} possui limite de crédido" +
                $" inferior a {valor:C}\n ");
            concederEmprestimo = false;
        }
        //true-concede  false-nega
        return concederEmprestimo;
    }
}
