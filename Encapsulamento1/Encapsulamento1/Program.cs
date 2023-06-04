using Encapsulamento1;

try
{
    Conta conta1 = new();
    conta1.Saldo = -10;
    Console.WriteLine($"O saldo da conta é {conta1.Saldo}");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

