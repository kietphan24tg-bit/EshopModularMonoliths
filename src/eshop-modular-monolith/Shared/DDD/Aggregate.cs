namespace Shared.DDD
public abstract class Aggregate<TId>: Entiy<TId>, IAggregateRoot<TId>
{
    private readonly List<IDomainEvent> _domainEvents = new();

    public IReadOnlyList<IDomainEvent> DomainEvents => _domainEvents.AsReadOnly();

    public void AddDomainEvent(IDomainEvent domainEvent)
    {
        _domainEvents.Add(domainEvent);
    }

    public void ClearDomainEvents()
    {
        IDomainEvent[] dequeuedEvent = DomainEvents.ToArray();
        _domainEvents.Clear();
        return dequeuedEvent;
    }
}
