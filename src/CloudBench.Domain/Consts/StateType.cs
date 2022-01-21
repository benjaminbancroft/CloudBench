using Ardalis.SmartEnum;

namespace CloudBench.Domain.Consts;

public abstract class StateType : SmartEnum<StateType>
{
  public static readonly StateType New = new NewStateType();
  public static readonly StateType Open = new OpenStateType();
  public static readonly StateType Completed = new CompletedStateType();
  public static readonly StateType Denied = new DeniedStateType();
  public static readonly StateType Cancelled = new CancelledStateType();
  public static readonly StateType OnHold = new OnHoldStateType();
  
  public StateType(string name, int value)
    : base(name, value)
  {
  }

  private sealed class NewStateType : StateType
  {
    public NewStateType() : base("New", 1)
    {
    }
  }
  
  private sealed class OpenStateType : StateType
  {
    public OpenStateType() : base("Open", 2)
    {
    }
  }
  
  private sealed class CompletedStateType : StateType
  {
    public CompletedStateType() : base("Completed", 3)
    {
    }
  }
  
  private sealed class DeniedStateType : StateType
  {
    public DeniedStateType() : base("Denied", 4)
    {
    }
  }
  
  private sealed class CancelledStateType : StateType
  {
    public CancelledStateType() : base("Cancelled", 5)
    {
    }
  }
  
  private sealed class OnHoldStateType : StateType
  {
    public OnHoldStateType() : base("OnHold", 6)
    {
    }
  }
}