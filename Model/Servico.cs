using System;

namespace ServicoInterno.Model
{
 public class Servico
 {
  public string Solicitante { get; set; }
  public string Tipo { get; set; }

  public string Descricao { get; set; }

  public string Protocol { get; set; }



  public string GeradorProtocol(int qtd)
  {
    var protocol = "";
   
    protocol = $"SC- {qtd}/2025";
   
    return protocol;
  }
   
 }
}
