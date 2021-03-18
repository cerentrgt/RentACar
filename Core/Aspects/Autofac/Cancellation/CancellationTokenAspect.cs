using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using Core.Utilities.IoC;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace Core.Aspects.Autofac.Cancellation
{
    public class CancellationTokenAspect : MethodInterception
    {
        public override void Intercept(IInvocation invocation)
        {
            var token = ServiceTool.ServiceProvider.GetService<IHttpContextAccessor>().HttpContext.RequestAborted;
            Task.Run(() =>
            {
                invocation.Proceed();
            }, token).Wait(token);
        }
    }
}
