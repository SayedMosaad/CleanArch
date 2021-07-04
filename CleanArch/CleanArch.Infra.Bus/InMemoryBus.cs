using CleanArch.Domains.Core.Bus;
using CleanArch.Domains.Core.Commands;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Infra.Bus
{
    public class InMemoryBus:IMediatorHandler
    {
        private readonly IMediator _mediator;
        public InMemoryBus(IMediator mediator)
        {
            _mediator = mediator;
        }

        public Task SendCommand<T>( T command) where T : Command
        {
            return _mediator.Send(command);
        }

    }
}
