using Adapter1;

var alunosArray = SistemaEscolar.GetListaAlunosMensalidades();

ICalculaMensalidade calculo = new AlunosAdapter();
calculo.ProcessaCalculoMensalidade(alunosArray);
