using System.Collections.Generic;

namespace ClairesHairSalon.Models
{
  public class Stylist
  {
    public Stylist()
    {
      Clients = new HashSet<Client>();
    }
    public int StylistId { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public string HomeTown { get; set; }
    public string Specialty { get; set; }
    public virtual ICollection<Client> Clients { get; set; }
  }
}