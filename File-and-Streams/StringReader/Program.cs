using System.Text;

var sb = new StringBuilder();

sb.AppendLine("Caracteres na primeira linha para ler");
sb.AppendLine("Segunda linha para ler");
sb.AppendLine("Terceira linha para ler");


using var sr = new StringReader(sb.ToString());
var buffer = new char[10];
var tamanho = 0;

do
{
    System.Console.WriteLine(sr.ReadLine());
     Console.ReadKey();
}while(sr.Peek() >= 0);

 System.Console.WriteLine("Aperte [enter] para finalizar a aplicacão"); 
 Console.ReadKey();


// do
// {
    
//     buffer = new char[10];
//     tamanho = sr.Read(buffer);
//     Console.Write(string.Join("", buffer));

// } while (tamanho >= buffer.Length);
