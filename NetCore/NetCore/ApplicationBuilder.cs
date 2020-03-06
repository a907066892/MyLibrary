using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCore
{
    public class ApplicationBuilder : IApplicationBuilder
    {
        List<Func<RequestDelegate, RequestDelegate>> _midellware = new List<Func<RequestDelegate, RequestDelegate>>();

        public RequestDelegate Build()
        {
            _midellware.Reverse();
            return httpContext =>
            {
                RequestDelegate next = content => { content.Response.StatusCode = 404; return Task.CompletedTask; };
                foreach (var item in _midellware)
                {
                    next = item(next);
                }
                var s = next(httpContext);
                return s;
            };
        }

        public IApplicationBuilder Use(Func<RequestDelegate, RequestDelegate> midellware)
        {
            _midellware.Add(midellware);
            return this;
        }
    }
}
