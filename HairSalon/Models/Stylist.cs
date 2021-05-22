using System.Collections.Generic;

namespace HairSalon.Models
{
  public class Stylist
  {
    public Stylist()
    {
      this.Clients = new HashSet<Client>(); //HashSet is an unordered collection of unique elements - no duplicates allowed (one to many)/handles no records case
    }

    public int StylistId { get; set; }  //1st coloumn in "stylists" table: primary key in table (used as foreign key in Client.cs)
    public string Name { get; set; }  //2nd column in "stylists" table
    public virtual ICollection<Client> Clients { get; set; }  //"Clients" represent DBSet of "one" in "many". 
                                                              // DBSet is declared as ICollection<Client> (interface) data type, so that EF can use all the ICollection 
                                                              // methods it requires on the "one" objects in order to act as ORM. "Virtual" needed for lazy loading.
  }
}