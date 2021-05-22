namespace HairSalon.Models
{
    public class Stylist
    {
        public string Name {get; set; }
        // public List<string> Clients = 
        public Stylist(string name){
            Name = name;
        }

    }
}