namespace Composite;
public abstract class HoraTrabalhada
{
    //component
    public string Nome { get; set; }
    public virtual void Add(HoraTrabalhada component) { }
    public abstract int GetHoraTrabalhada();
}
