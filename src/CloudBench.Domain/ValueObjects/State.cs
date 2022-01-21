using CloudBench.Domain.Consts;

namespace CloudBench.Domain.ValueObjects;

public record State(StateType StateType, Process Process, string Name, string Description);