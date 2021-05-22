namespace HairSalon.Models
{
    public class Stylist
    {
        public string Name {get; set; }
        public int StylistId {get;}
        // public List<string> Clients = 
        public Stylist(string name){
            Name = name;
        }

    }
}