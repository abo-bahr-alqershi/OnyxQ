using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace ERP_Pro.Server.Controllers
{
    /// <summary>
    /// وحدة التحكم الأساسية للـ API
    /// </summary>
    [ApiController]
    public abstract class ApiControllerBase : ControllerBase
    {
        private ISender _mediator;

        /// <summary>
        /// وسيط لنمط الوساطة
        /// </summary>
        protected ISender Mediator => _mediator ??= HttpContext.RequestServices.GetService<ISender>();
    }
} 