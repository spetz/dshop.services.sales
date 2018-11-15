using System.Threading.Tasks;
using DShop.Services.Sales.Services;
using Microsoft.AspNetCore.Mvc;

namespace DShop.Services.Sales.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public abstract class BaseController : ControllerBase
    {
        private readonly IDispatcher _dispatcher;

        protected BaseController(IDispatcher dispatcher)
        {
            _dispatcher = dispatcher;
        }
        
        protected ActionResult<T> Single<T>(T model)
        {
            if (model == null)
            {
                return NotFound();
            }

            return model;
        }

        protected async Task SendAsync<T>(T command) where T : ICommand
            => await _dispatcher.SendAsync(command);

        protected async Task<TResult> QueryAsync<TResult>(IQuery<TResult> query)
            => await _dispatcher.QueryAsync(query);
    }
}