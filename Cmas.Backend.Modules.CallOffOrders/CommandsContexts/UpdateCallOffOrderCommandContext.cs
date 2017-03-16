using Cmas.Backend.Infrastructure.Domain.Commands;
using Cmas.Backend.Modules.CallOffOrders.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cmas.Backend.Modules.CallOffOrders.CommandsContexts
{
    public class UpdateCallOffOrderCommandContext : ICommandContext
    {
        public CallOffOrder Form;
    }
}
