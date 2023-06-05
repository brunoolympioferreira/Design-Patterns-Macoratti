namespace ClasseAbstrata;
abstract class Forma
{
    public double Area { get; set; }
    public double Perimetro { get; set; }
    public abstract void CalcularPerimetro();
    public abstract void CalcularArea();
    public string Descricao()
    {
        return "Sua a classe abstrata Forma";
    }
}
