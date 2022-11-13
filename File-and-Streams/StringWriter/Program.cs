
string textReaderText = "API é um termo para designar uma interface de comunicação que um sistema oferece para" +
                        "que outros acessem suas funções, dados e recursos sem que o software ou plataforma externa" +
                        "precise saber como eles foram implementados.\n\n" +

                        "Trata-se de um conjunto de rotinas e padrões muito utilizados na web para facilitar a" +
                        "empresa responsável. Uma API pode ser criada em várias linguagens de programação," +
                        "Uma API bem construída e documentada tem como principal vantagem oferecer uma. \n\n" +

                        "que outros acessem suas funções, dados e recursos sem que o software ou plataforma externa" +
                        "API é um termo para designar uma interface de comunicação que um sistema oferece para" +
                        "AML. Nas aplicações Web, o mais utilizado é o JSON. \n\n";


System.Console.WriteLine($"Texto original: {textReaderText}");
 string linha , paragrafo = null;
 var sr = new StringReader(textReaderText);


 while (true)
 {
    linha = sr.ReadLine();
    if (linha != null)
    {
        paragrafo += linha + "  ";
    }else
    {
        paragrafo += '\n';
        break;
    }
 }

Console.WriteLine($"Texto modificado {paragrafo}");

 int caracterLido;
 char caracterConvertido;

var sw = new StringWriter();
sr = new StringReader(paragrafo);

 while(true)
 {
    caracterLido = sr.Read();
    if (caracterLido == -1)
     break;

     caracterConvertido = Convert.ToChar(caracterLido);

     if (caracterConvertido == '.')
     {
        sw.Write("\n\n");

        sr.Read();
        sr.Read();
     }else
     {
        sw.Write(caracterConvertido);
     }
    
   
 }
 System.Console.WriteLine($"Texto armazenado no StringWriter: {sw.ToString()}");
 System.Console.WriteLine("Aperte [enter] para finalizar");
 Console.ReadLine();