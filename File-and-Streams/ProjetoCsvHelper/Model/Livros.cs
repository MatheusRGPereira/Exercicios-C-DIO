using CsvHelper.Configuration.Attributes;

    public class Livros
    {
        [Index(0)]
        public string Titulo {get; set;}

        [Index(1)]
        [CultureInfo("pt-br")]
        public decimal Preco {get; set;}

        [Index(2)]
        public string Autor {get; set;}
        
        [Index(3)]
        [Format("dd/mm/yyyy")]
        public DateOnly Lancamento {get; set;}


    }
