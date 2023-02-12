using Projeto1;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

FichaInscricao ficha = new FichaInscricao();
ficha.Id = 1;
ficha.Nome = "William Rocha";
ficha.DataNascimento = new DateTime(1991, 1, 31);
ficha.MenorIdade = false;
ficha.EscreverDetalhes();