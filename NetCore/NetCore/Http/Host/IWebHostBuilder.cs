using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCore
{
    public interface IWebHostBuilder
    {
        IWebHostBuilder UserServer(IServer server);
        /// <summary>
        /// 注册中间件
        /// </summary>
        /// <param name="configure"></param>
        /// <returns></returns>
        IWebHostBuilder Configure(Action<IApplicationBuilder> configure);
        IWebHost Build();


    }
}
