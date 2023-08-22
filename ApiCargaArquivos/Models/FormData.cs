namespace ApiCargaArquivos.Models;
public class FormData
{
   public List<IFormFile>? Files { get; set;}
   public string? User { get; set;}
   public string? Note { get; set;}
}