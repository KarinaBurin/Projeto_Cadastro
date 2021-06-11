using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEnd.Helpers
{
  public class SettingsApplication
  {
    public string ConnectionString { get; set; }
    public TokenConfigurations TokenConfigurations { get; set; }

  }
  public class TokenConfigurations
  {
    public string Audience { get; set; }
    public string Issuer { get; set; }
    public int Seconds { get; set; }
  }
  
}
