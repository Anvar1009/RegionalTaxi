namespace RegionalTaxi.Domain.Abstraction;

public abstract class Entity
{
    protected Entity(Guid Id)
    {
        this.Id = Id;
    }
    public Guid Id { get; private set; }
}
