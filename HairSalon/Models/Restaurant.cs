namespace HairSalon.Models
{
  public class Client
  {
    public int ClientId { get; set; }
    public string Name { get; set; } //was previously Description
    public int Rating { get; set; } //new
    public int Cost { get; set; } //new
    public string Type { get; set; }//new
    public int StylistId { get; set; }
    public virtual Stylist Stylist { get; set; }
  }
}