namespace Api.Database.Entity.Threats;

public class ThreatType
{
    public ThreatType()
    {

    }
    public Guid Id { get; set; }
    public string Name { get; set; }

    public virtual ICollection<Threat> Threats { get; set; }
}
