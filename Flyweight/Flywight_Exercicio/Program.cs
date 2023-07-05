using Flywight_Exercicio;

var factory = new ImagemFactory();

for (int i = 0; i < 6; ++i)
{
    var imagem = factory.GetImagem("minhaImagem.jpg");

    imagem.Exibir(getRandomPosicao(), getRandomPosicao(),
                  getRandomDimensao(), getRandomDimensao());
}
Console.ReadKey();

static int getRandomPosicao()
{
    Random rnd = new();
    return rnd.Next(0, 500);
}
static int getRandomDimensao()
{
    Random rnd = new();
    return rnd.Next(100, 500);
}