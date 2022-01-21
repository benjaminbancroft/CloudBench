using CloudBench.Domain.Events;
using CloudBench.Domain.ValueObjects;
using CloudBench.Shared.Abstractions.Domain;

namespace CloudBench.Domain.Entities;

public class Task : AggregateRoot<TaskId>
{
  // private Process _process;
  private State _state;
  private Person _requester;
  
  private Task()
  {
    
  }

  internal Task(TaskId id, State initialState, Person requester)
  {
    Id = id;
    _state = initialState;
    _requester = requester;
  }

  public void ChangeState(State newState)
  {
    if(_state.Equals(newState))
      return;
    var oldState = _state;
    _state = newState;
    AddEvent(new TaskStateChanged(this, oldState, newState));
  }
}