using MediatR;
using RegionalTaxi.Domain.Abstraction;

namespace RegionalTaxi.Application.Abstraction.Messaging;

public interface ICommand:IRequest<Result>
{

}

public interface ICommand<TResponse> : IRequest<Result<TResponse>>, IBaseCommand
{

}

public interface IBaseCommand
{

}

