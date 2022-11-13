var path = @"C:\Users\I\Desktop\Arquivos-Streams\Directory_And_DirectoryInfo\Globo";

//LerDiretorios(path);

lerArquivos(path);
System.Console.WriteLine("Aperte [enter] para finalizar a aplicação ...");
Console.ReadLine();


static void lerArquivos (string path)
{
    var arquivos = Directory.GetFiles(path,"*",SearchOption.AllDirectories);

    foreach (var arquivo in arquivos)
    {
        var FileInfo = new FileInfo(arquivo);
        System.Console.WriteLine($"[Nome]: {FileInfo.Name}");
        System.Console.WriteLine($"[Tamanho]: {FileInfo.Length}");
        System.Console.WriteLine($"[Ultimo acesso]: {FileInfo.LastAccessTime}");
        System.Console.WriteLine($"[Pasta]: {FileInfo.DirectoryName}");
        System.Console.WriteLine("----------------------------------");
    }
}





static void LerDiretorios(string path)
{
    if (Directory.Exists(path))
    {
        var diretorios = Directory.GetDirectories(path, "*", SearchOption.AllDirectories);

        foreach (var dir in diretorios)
        {
            var dirInfo = new DirectoryInfo(dir);
            Console.WriteLine($"[Nome]: {dirInfo.Name}");
            System.Console.WriteLine($"[Raiz]: {dirInfo.Root}");
            if (dirInfo != null)
                System.Console.WriteLine($"[Pai]: {dirInfo.Parent.Name}");

            System.Console.WriteLine("------------------");
        }

    }
    else
    {
        System.Console.WriteLine($"{path} não existe");
    }

}