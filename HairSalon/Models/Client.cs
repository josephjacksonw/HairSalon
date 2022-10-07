namespace HairSalon.Models
{
  public class Client
  {
    public int ClientId { get; set; }
    public string Name { get; set; }
    public int Visits { get; set; } //was previously rating
    public int StylistId { get; set; }// also removed cost and type
    public virtual Stylist Stylist { get; set; }
  }
}