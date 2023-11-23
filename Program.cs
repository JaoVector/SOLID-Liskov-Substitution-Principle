
using LSP.Classes;

var palavra = new RevertePalavra("agua");
Console.WriteLine($"Inverte palavra: {palavra.Reverte()}");

var palavraMai = new RevertePalavraMaiuscula("abelha");
Console.WriteLine($"Converte palavra em Maiuscula e Inverte: {palavraMai.Reverte()}");
