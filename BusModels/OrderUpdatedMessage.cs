namespace BusModels;

public class OrderUpdatedMessage
{
    public List<Guid> ContainerIds { get; set; }
    
    public Guid OrderId { get; set; }
    
    public Guid HubStartId { get; set; }
    
    public DateTime EngagedUntil { get; set; }
}