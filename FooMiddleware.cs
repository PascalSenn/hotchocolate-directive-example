using System.Threading.Tasks;
using HotChocolate.Resolvers;

namespace hotchocolate_directive_example
{
    public class FooMiddleware
    {
        private readonly FieldDelegate _next;

        public FooMiddleware(FieldDelegate next)
        {
            _next = next;
        }

        public async ValueTask InvokeAsync(IDirectiveContext context)
        {
            await _next(context);
            context.Result = "Middleware Executed";
        }
    }
}