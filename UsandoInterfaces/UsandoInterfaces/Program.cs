using UsandoInterfaces;

var registraConsole = new RegistraOcorrencias(new RegistrarNoConsole());
registraConsole.Registrar("registro no console");

var registraArquivo = new RegistraOcorrencias(new RegistrarNoArquivo(@"C:\temp\teste.txt"));
registraArquivo.Registrar("registro no arquivo");
