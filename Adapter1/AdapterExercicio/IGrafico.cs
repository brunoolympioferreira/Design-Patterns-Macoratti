namespace AdapterExercicio;
public interface IGrafico
{
    string Titulo { get; set; }
    List<string> XValores { get; set; }
    List<int> YValores { get; set; }
    void GerarGrafico(string Titulo, List<string> Xvalores, List<int> YValores);
}
