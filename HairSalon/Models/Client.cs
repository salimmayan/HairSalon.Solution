namespace HairSalon.Models
{
    public class Client
    {
        public int ClientId { get; }
        public string Description { get; set; }
        public int StylistId { get; set; }  //foreign key (primary key in Stylist.cs)
        public virtual Stylist Stylist { get; set; }
    }
}