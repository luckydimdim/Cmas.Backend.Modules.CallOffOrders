using Cmas.Backend.Infrastructure.Domain.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cmas.Backend.Modules.CallOffOrders.CommandsContexts
{
    public class CreateCallOffOrderCommandContext : ICommandContext
    {
        public string id;
    }
}
