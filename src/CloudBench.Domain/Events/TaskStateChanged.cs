using CloudBench.Domain.ValueObjects;
using CloudBench.Shared.Abstractions.Domain;

namespace CloudBench.Domain.Events;

public record TaskStateChanged(Entities.Task Task, State OldState, State NewState) : IDomainEvent;