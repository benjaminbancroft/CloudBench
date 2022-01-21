using CloudBench.Domain.Exceptions;

namespace CloudBench.Domain.ValueObjects;

public record TaskId
{
  public int Value { get; }

  public TaskId(int value)
  {
    if (value < 1)
      throw new InvalidTaskIdException();

    Value = value;
  }

  public static implicit operator int(TaskId id)
    => id.Value;

  public static implicit operator TaskId(int id)
    => new(id);
}