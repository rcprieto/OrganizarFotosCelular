// See https://aka.ms/new-console-template for more information

RodarTratamento();

static void RodarTratamento()
{
    Console.WriteLine("Informe a pasta dos arquivos");
    string pasta = Console.ReadLine();
    
    DirectoryInfo dir = new DirectoryInfo(pasta);
    var arquivos = dir.GetFiles();  
    foreach (var arquivo in arquivos)
    {
        int mes = arquivo.LastWriteTime.Month;
        int ano = arquivo.LastWriteTime.Year;

        DirectoryInfo dirNovo = new DirectoryInfo($@"{pasta}/{ano}/{mes}/");
        if(!dirNovo.Exists)
            dirNovo.Create();

        arquivo.MoveTo(dirNovo.FullName + arquivo.Name);
    }
    

}