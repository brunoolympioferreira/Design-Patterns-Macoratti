namespace Composite;
public class Funcionario : HoraTrabalhada
{
    //leaf
    public int Horas { get; set; }
    public override int GetHoraTrabalhada()
    {
        //logica
        Console.WriteLine($"O funcionário {Nome} registrou {Horas} trabalhadas");
        return Horas;
    }
}
