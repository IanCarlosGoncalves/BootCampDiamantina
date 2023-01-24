using System.ComponentModel;

namespace Tarefas.Web.Models;

public class TarefaViewModel

{
   [DisplayName("Titulo")]
   public string Titulo{get;set;}
   [DisplayName("Descricao")]
   public string Descricao{get;set;}

}