//var grafico = new MeuGeradorGrafico();
using AdapterExercicio;

IGrafico grafico = new GraficoAdapter();

grafico.Titulo = "Gerador de Graficos";

List<string> xvalores = new List<string>();
xvalores.Add("Seg");
xvalores.Add("Ter");

List<int> yvalores = new List<int>();
yvalores.Add(10);
yvalores.Add(20);

//
grafico.GerarGrafico(grafico.Titulo, xvalores, yvalores);
Console.ReadKey();