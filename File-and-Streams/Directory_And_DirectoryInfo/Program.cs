
CriarDiretoriosGlobo();
CriarArquivo();
var origem = Path.Combine(Environment.CurrentDirectory, "Brasil.txt");
var destino = Path.Combine(Environment.CurrentDirectory, "Globo", "America do sul", "Uruguay", "uruguay.txt");
//MoverArquivo(origem, destino);
CopiarArquivo(origem, destino);

static void CopiarArquivo(string pathOrigem, string pathDestino)
{
       if (!File.Exists(pathOrigem))
    {
        Console.WriteLine("Arquivo de origem não existe");
        return;
    }
    if (File.Exists(pathDestino))
    {
        Console.WriteLine("Arquivo Já existe na pasta de destino");
        return;
    }
    
    File.Copy(pathOrigem,pathDestino);
}


static void MoverArquivo(string pathOrigem, string pathDestino)
{
    if (!File.Exists(pathOrigem))
    {
        Console.WriteLine("Arquivo de origem não existe");
        return;
    }
    if (File.Exists(pathDestino))
    {
        Console.WriteLine("Arquivo Já existe na pasta de destino");
        return;
    }
    File.Move(pathOrigem, pathDestino);
}

static void CriarArquivo()
{
    var path = Path.Combine(Environment.CurrentDirectory, "Brasil.txt");
    if (!File.Exists(path))
    {
        using var sw = File.CreateText(path);
        sw.WriteLine("População: 220MM");
        sw.WriteLine("IDH: 0,901");
        sw.WriteLine("Dados atualizados em: 20/04/2018");
    }

}


static void CriarDiretoriosGlobo()
{

    var path = Path.Combine(Environment.CurrentDirectory, "Globo");
    if (!Directory.Exists(path))
    {

        var dirGlobo = Directory.CreateDirectory(path);
        var dirAmNorte = dirGlobo.CreateSubdirectory("America do norte");
        var dirAmCentral = dirGlobo.CreateSubdirectory("America central");
        var dirAmSul = dirGlobo.CreateSubdirectory("America do sul");

        dirAmNorte.CreateSubdirectory("USA");
        dirAmNorte.CreateSubdirectory("Mexico");
        dirAmNorte.CreateSubdirectory("Canada");

        dirAmCentral.CreateSubdirectory("Costa rica");
        dirAmCentral.CreateSubdirectory("Panama");

        dirAmSul.CreateSubdirectory("Brasil");
        dirAmSul.CreateSubdirectory("Uruguay");
        dirAmSul.CreateSubdirectory("Chile");
    }

}




