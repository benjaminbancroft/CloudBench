namespace CloudBench.Shared.Abstractions.Exceptions;

public abstract class CloudBenchException : Exception
{
  protected CloudBenchException()
    : base("Task identifier must be a positive, non-zero integer.")
  {
  }
}