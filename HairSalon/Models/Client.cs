using System.Collections.Generic;

namespace ClairesHairSalon.Models
{
  public class Client
  {
    public int ClientId { get; set; }
    public int StylistId { get; set; }
    public virtual Stylist Stylist { get; set; }
    public string Name { get; set; }
  }
}