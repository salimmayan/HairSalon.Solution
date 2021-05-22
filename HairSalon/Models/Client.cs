namespace HairSalon.Models
{
    public class Client
    {
        public int ClientId { get; }                //1st coloumn in "clients" table: primary key in table (NOT used as foreign key in Stylist.cs)
        public string Description { get; set; }     //2nd coloumn in "clients" table
        public int StylistId { get; set; }          //3rd coloumn in "clients" table: primary key in "stylists" table used as as foreign key in "clients" table
        public virtual Stylist Stylist { get; set; }
    }
}