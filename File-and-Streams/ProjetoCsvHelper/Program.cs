using static System.Console;

using System.Globalization;
using CsvHelper.Configuration;
using CsvHelper;

//LerCsvClasse();
//LerCsvDynamic();
LerCsvComOutroDelimitador();


System.Console.WriteLine("Aperte [enter] para finalizar!");
ReadLine();


static void LerCsvComOutroDelimitador()
{
    var path = Path.Combine(Environment.CurrentDirectory, "Entrada", "Livros.csv");

    var fi = new FileInfo(path);

    if (!fi.Exists)
        throw new FileNotFoundException($"O arquivo {path} não foi encontrado");

    using var sr = new StreamReader(fi.FullName);

    var csvConfig = new CsvConfiguration(CultureInfo.InvariantCulture)
    {
        Delimiter = ";"
    };

    using var csvReader = new CsvReader(sr, csvConfig);
    csvReader.Context.RegisterClassMap<LivroMap>();

    var registros = csvReader.GetRecords<Livros>().ToList();

    foreach (var registro in registros)
    {
        WriteLine($"Nome: {registro.Titulo}");
        WriteLine($"Preço: {registro.Preco}");
        WriteLine($"Autor: {registro.Autor}");
        WriteLine($"Lançamento:{registro.Lancamento}");
        WriteLine("--------------------------");
    }

}

static void LerCsvClasse()
{
    var path = Path.Combine(Environment.CurrentDirectory, "Entrada", "Usuarios.csv");

    var fi = new FileInfo(path);

    if (!fi.Exists)
        throw new FileNotFoundException($"O arquivo {path} não foi encontrado");

    using var sr = new StreamReader(fi.FullName);

    var csvConfig = new CsvConfiguration(CultureInfo.InvariantCulture);

    using var csvReader = new CsvReader(sr, csvConfig);

    var registros = csvReader.GetRecords<Usuario>();

    foreach (var registro in registros)
    {
        WriteLine($"Nome: {registro.Nome}");
        WriteLine($"Email: {registro.Email}");
        WriteLine($"Telefone : {registro.Telefone}");
        WriteLine("--------------------------");
    }

}

static void LerCsvDynamic()
{
    var path = Path.Combine(Environment.CurrentDirectory, "Entrada", "Produto.csv");

    var fi = new FileInfo(path);

    if (!fi.Exists)
        throw new FileNotFoundException($"O arquivo {path} não foi encontrado");

    using var sr = new StreamReader(fi.FullName);

    var csvConfig = new CsvConfiguration(CultureInfo.InvariantCulture);

    using var csvReader = new CsvReader(sr, csvConfig);

    var registros = csvReader.GetRecords<dynamic>();

    foreach (var registro in registros)
    {
        WriteLine($"Nome: {registro.Produto}");
        WriteLine($"Marca: {registro.Marca}");
        WriteLine($"Preco: {registro.Preco}");
        WriteLine("--------------------------");
    }
}
