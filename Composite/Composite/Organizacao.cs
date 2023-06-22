namespace Composite;
public class Organizacao : HoraTrabalhada
{
    //composite
    protected List<HoraTrabalhada> departamentos = new();
    public override void Add(HoraTrabalhada component)
    {
        departamentos.Add(component);
    }
    public override int GetHoraTrabalhada()
    {
        var horasTrabalhadasDepartamento = 0;
        foreach (var departamento in departamentos)
        {
            horasTrabalhadasDepartamento += departamento.GetHoraTrabalhada();
        }
        Console.WriteLine($"{Nome} registrou um total de {horasTrabalhadasDepartamento}");

        return horasTrabalhadasDepartamento;
    }
}
