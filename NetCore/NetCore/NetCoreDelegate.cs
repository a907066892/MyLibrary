using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCore
{
    public delegate Task RequestDelegate(HttpContext httpcontext);
    public delegate Func<RequestDelegate, RequestDelegate> Middleware();
}
