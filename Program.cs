using System;
using System.Threading.Tasks;
using ServicoInterno.Model;

namespace ServicoInterno
{
 public class Program
 {
  static async Task Main(string[] args)
  {
   //variavel para armazenar servico
   List<Servico> servicos = new List<Servico>();

   Console.WriteLine("Solicitacao de Servicos internos");
   Console.Write("Arquivo:");
   try
   {
    //Pega caminho do arquivo
    var path = Console.ReadLine();
    if (!Path.Exists(path))
    {
     Console.WriteLine($"Arquivo nao existe ou caminho esta errado Tente novamente");

    }


    //Ler arquivo linha por linha 
    var lines = await File.ReadAllLinesAsync(path);
    foreach (var line in lines)
    {
     var campos = line.Split(';');
     

     servicos.Add(new Servico
     {
      Solicitante = campos[0],
      Tipo = campos[1],
      Descricao = campos[2]
     

     });
    }
   }
   catch (Exception ex)
   {
    Console.WriteLine("Ocorreu um erro");
   }

   
   for (int i = 0; i <= servicos.Count - 1; i++)
   {
    
    Console.WriteLine($"Solicitante: {servicos[i].Solicitante} - Tipo de Servico: {servicos[i].Tipo} - Descricao: {servicos[i].Descricao}");
   } 


  }
 } 
}
