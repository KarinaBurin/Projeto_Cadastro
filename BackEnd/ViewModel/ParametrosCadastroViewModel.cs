using Newtonsoft.Json;

namespace BackEnd.ViewModel
{
  public class ParametrosCadastroViewModel
  {
    public string Nome { get; set; }
    public string SobreNome { get; set; }
    public string Rg { get; set; }
    public string CPF { get; set; }
    public int Idade { get; set; }
    public string Email { get; set; }

    public string ConvertModelToJSONCreate()
    {
      var jsonObj = new
      {
        Nome,
        SobreNome,
        Rg,
        CPF,
        Idade,
        Email
      };

      return JsonConvert.SerializeObject(jsonObj);
    }
  }
}
