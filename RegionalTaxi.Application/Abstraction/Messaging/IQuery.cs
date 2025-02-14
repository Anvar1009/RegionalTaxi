using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using RegionalTaxi.Domain.Abstraction;

namespace RegionalTaxi.Application.Abstraction.Messaging;

public interface IQuery<TResponse>:IRequest<Result<TResponse>> 
{

}
