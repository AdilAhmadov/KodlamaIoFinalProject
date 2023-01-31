namespace EntityLayer.Models;

public class Territory:IEntity
{
    public string? TerritoryID { get; set; }
    public string? TerritoryDescription { get; set; }
    public int RegionID { get; set; }
}
