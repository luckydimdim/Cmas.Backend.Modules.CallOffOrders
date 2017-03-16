using Cmas.Backend.Infrastructure.Domain.Commands;
using Cmas.Backend.Infrastructure.Domain.Criteria;
using Cmas.Backend.Infrastructure.Domain.Queries;
using Cmas.Backend.Modules.CallOffOrders.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Cmas.Backend.Modules.CallOffOrders.CommandsContexts;

namespace Cmas.Backend.Modules.CallOffOrders.Services
{
    public class CallOffOrdersService
    {
        private readonly ICommandBuilder _commandBuilder;
        private readonly IQueryBuilder _queryBuilder;

        public CallOffOrdersService(ICommandBuilder commandBuilder, IQueryBuilder queryBuilder)
        {
            _commandBuilder = commandBuilder;
            _queryBuilder = queryBuilder;
        }

        public async Task<CallOffOrder> GetCallOffOrder(string id)
        {
            return await _queryBuilder.For<Task<CallOffOrder>>().With(new FindById(id));
        }

        public async Task<string> DeleteCallOffOrder(string id)
        {

            var context = new DeleteCallOffOrderCommandContext
            {
                id = id
            };

            context = await _commandBuilder.Execute(context);

            return context.id;
        }

        public async Task<IEnumerable<CallOffOrder>> GetCallOffOrders()
        {
            return await _queryBuilder.For<Task<IEnumerable<CallOffOrder>>>().With(new AllEntities());
        }

        public async Task<string> CreateCallOffOrder()
        {
            var context = new CreateCallOffOrderCommandContext();
           
            context = await _commandBuilder.Execute(context);

            return context.id;
        }

        public async Task<string> UpdateCallOffOrder(string id, CallOffOrder form)
        {
            var context = new UpdateCallOffOrderCommandContext
            {
                Form = form
            };

            context = await _commandBuilder.Execute(context);

            return context.Form.Id;
        }

    }
}
