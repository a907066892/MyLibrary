using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace NetCore
{
    public class HttpListenerServer : IServer
    {
        private readonly HttpListener _httpListener;

        private readonly string[] _urls;
        public HttpListenerServer(params string[] urls)
        {
            _httpListener = new HttpListener();
            _urls = urls.Any() ? urls : new string[] { "http://localhost:5000/" };
        }

        public async Task StartAsync(RequestDelegate handler)
        {
            try
            {

                Array.ForEach(_urls, url => _httpListener.Prefixes.Add(url));
                _httpListener.Start();

                while (true)
                {
                    var listenerContext = await _httpListener.GetContextAsync();
                    var feature = new HttpListenerFeature(listenerContext);
                    var features = new FeaturnCollection();
                    features.Set<IHttpRequestFerture>(feature);
                    features.Set<IHttpResponseFerture>(feature);
                    HttpContext context = new HttpContext(features);
                    await handler(context);
                    listenerContext.Response.Close();
                }

            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
