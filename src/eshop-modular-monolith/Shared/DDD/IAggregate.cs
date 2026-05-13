using System;

public abstract class Aggregate<T> : Entiy<TId>, IAggregate<TId>
{
  private readonly List<IDomainEvent> _domainEvents = new();
  private IReadonlyList<IDomainEvent> DomainEvents => _domainEvents.AsReadOnly();
    public void AddDomainEvent(IDomainEvent domainEvent)
    {
        _domainEvents.Add(domainEvent);
    }
    public IDomainEvent[] GetDomainEvents()
    {
        return DomainEvents.ToArray();
    }
}
