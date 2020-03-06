using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCore
{
    public class WebHostBuilder : IWebHostBuilder
    {
        private IServer _server;
        private readonly List<Action<IApplicationBuilder>> _configures = new List<Action<IApplicationBuilder>>();
        /// <summary>
        /// 注册中间件
        /// </summary>
        /// <param name="configure"></param>
        /// <returns></returns>
        public IWebHostBuilder Configure(Action<IApplicationBuilder> configure)
        {
            _configures.Add(configure);
            return this;
        }
        /// <summary>
        /// 服务器
        /// </summary>
        /// <returns></returns>
        public IWebHost Build()
        {
            var builder = new ApplicationBuilder();
            foreach (var confgure in _configures)
            {
                confgure(builder);
            }
            return new WebHost(_server, builder.Build());
        }

        public IWebHostBuilder UserServer(IServer server)
        {
            _server = server;
            return this;
        }
    }
}
