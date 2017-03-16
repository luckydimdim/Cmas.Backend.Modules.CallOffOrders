using Cmas.Backend.Infrastructure.Domain.Commands;
using Cmas.Backend.Infrastructure.Domain.Queries;
using Cmas.Backend.Modules.CallOffOrders.Entities;
using Cmas.Backend.Modules.CallOffOrders.Services;
using Nancy;
using Nancy.ModelBinding;

namespace Cmas.Backend.Modules.CallOffOrders
{
    public class CallOffOrdersModule : NancyModule
    {
        private readonly ICommandBuilder _commandBuilder;
        private readonly IQueryBuilder _queryBuilder;
        private readonly CallOffOrdersService _callOffOrdersService;

        public CallOffOrdersModule(ICommandBuilder commandBuilder, IQueryBuilder queryBuilder) : base("/call-off-orders")
        {
            _commandBuilder = commandBuilder;
            _queryBuilder = queryBuilder;

            _callOffOrdersService = new CallOffOrdersService(_commandBuilder, _queryBuilder);

            Get("/", _ => {
                return _callOffOrdersService.GetCallOffOrders();
            });


            Get("/{id}", async args => await _callOffOrdersService.GetCallOffOrder(args.id));


            Post("/", async (args, ct) =>
            {
               
                string result = await _callOffOrdersService.CreateCallOffOrder();

                return result.ToString();
            });

            Put("/", async (args, ct) =>
            {
                CallOffOrder form = this.Bind();

                string result = await _callOffOrdersService.UpdateCallOffOrder(form.Id, form);

                return result.ToString();
            });

            Delete("/{id}", async args =>
            {
                return await _callOffOrdersService.DeleteCallOffOrder(args.id);
            });
        }

         
    }
}
