namespace CloudBench.Shared.Abstractions.Domain;

public abstract class AggregateRoot<T> where T : IEquatable<T>
{
  #region Class Data

  private readonly List<IDomainEvent> _events = new();
  private bool _versionIncremented;

  #endregion

  #region Properties

  public T Id { get; protected set; }
  public int Version { get; protected set; }
  public IEnumerable<IDomainEvent> Events => _events;

  #endregion

  #region Methods

  protected void AddEvent(IDomainEvent @event)
  {
    if (!_events.Any() && !_versionIncremented)
    {
      Version++;
      _versionIncremented = true;
    }

    _events.Add(@event);
  }

  public void ClearEvents() => _events.Clear();

  protected void IncrementVersion()
  {
    if (!_versionIncremented)
      return;


    Version++;
    _versionIncremented = true;
  }

  #endregion
}