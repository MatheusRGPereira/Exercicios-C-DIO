
CriarCsv();

System.Console.WriteLine("Pressioine [enter] para finalizar!");
Console.ReadLine();

static void CriarCsv(){
var path = Path.Combine(Environment.CurrentDirectory, "Saida");

var pessoas = new List<Pessoa>(){
        new Pessoa()
        {
            Nome = "José da silva",
            Email = "jose@email.com",
            Telefone = 1195487260,
            Nascimento = new DateOnly(year: 1972, month:08 , day: 14)
        },
         new Pessoa()
        {
            Nome = "José da silva2",
            Email = "jose2@email.com",
            Telefone = 1195487260,
            Nascimento = new DateOnly(year: 1972, month:08 , day: 14)
        },
         new Pessoa()
        {
            Nome = "José da silva3",
            Email = "jose3@email.com",
            Telefone = 1195487260,
            Nascimento = new DateOnly(year: 1972, month:08 , day: 14)
        },
         new Pessoa()
        {
            Nome = "José da silva4",
            Email = "jose4@email.com",
            Telefone = 1195487260,
            Nascimento = new DateOnly(year: 1972, month:08 , day: 14)
        },
};
    var di = new DirectoryInfo(path);
    if(!di.Exists)
    {
        di.Create();
        path = Path.Combine(path, "usuarios.csv");
    }
    using var sw = new StreamWriter(path);
    sw.WriteLine("nome,email,telefone,nascimento");

    foreach (var pessoa in pessoas)
    {
        var linha = $"{pessoa.Nome},{pessoa.Email},{pessoa.Telefone},{pessoa.Nascimento}";
        sw.WriteLine(linha);
    }

}



static void LerCsv(){

var path = Path.Combine(Environment.CurrentDirectory, "Entrada", "Usuarios-exportacao.csv");

if (File.Exists(path))
{
using var sr = new StreamReader(path);
var cabecalho = sr.ReadLine()?.Split(',');
while (true)
{

    var registro = sr.ReadLine()?.Split(',');
    if (registro == null) break;
    if (cabecalho?.Length != registro.Length)
    {
        System.Console.WriteLine("Arquivo fora do padrão csv");
        break;
    }

    for (int i = 0; i < registro.Length; i++)
    {
        System.Console.WriteLine($"{cabecalho?[i]}: {registro[i]}");
    }
    System.Console.WriteLine("--------------------");
}
}
else
{
    System.Console.WriteLine($"O arquivo {path} Não existe!");
}

System.Console.WriteLine("\n\n Pressione [enter] para Finalizar a aplicação");
Console.ReadLine();
}


class Pessoa
{
    public string Nome {get; set;}
    public string Email {get; set;}
    public int Telefone {get; set;}
    public DateOnly Nascimento {get; set;}   

}


