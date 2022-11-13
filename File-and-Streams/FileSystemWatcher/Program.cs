var path = @"C:\Users\I\Desktop\Arquivos-Streams\Directory_And_DirectoryInfo\Globo";
using var fsw = new FileSystemWatcher(path);
fsw.Created += OnCreated;
fsw.Deleted += OnDeleted;
fsw.Renamed += OnRenamed;

fsw.EnableRaisingEvents = true;
fsw.IncludeSubdirectories = true;

System.Console.WriteLine($"Monitorando eventos na tela {path}");
System.Console.WriteLine("Pressione [enter] para finalizar");
Console.ReadLine();

void OnCreated(object sender, FileSystemEventArgs e)
{
    Console.WriteLine($"Foi Criado o arquivo {e.Name}");
}


void OnDeleted(object sender, FileSystemEventArgs e)
{
    Console.WriteLine($"Foi deletado o arquivo {e.Name}");
}


void OnRenamed(object sender, FileSystemEventArgs e)
{
     Console.WriteLine($"Foi Alterado o nome do arquivo {e.Name}");
}