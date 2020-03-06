using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCore
{
    public class HttpContext
    {
        public HttpRequest Request { get; set; }
        public HttpResponse Response { get; set; }
        public HttpContext(IFeatureCollection fertures)
        {
            Request = new HttpRequest(fertures);
            Response = new HttpResponse(fertures);
        
        }
    }

    public class HttpRequest
    {
        private readonly IHttpRequestFerture _ferture;

        public Uri Uri => _ferture.Uri;
        public NameValueCollection Headers => _ferture.Headers;
        public Stream Body => _ferture.Body;
        public HttpRequest(IFeatureCollection fertures) => _ferture = fertures.Get<IHttpRequestFerture>();
    }


    public class HttpResponse
    {
        public HttpResponse(IFeatureCollection fertures) => _ferture = fertures.Get<IHttpResponseFerture>();
        public readonly IHttpResponseFerture _ferture;

        public NameValueCollection Headres => _ferture.Headers;
        public Stream Body => _ferture.Body;

        public int StatusCode { get { return _ferture.StatusCode; } set { _ferture.StatusCode = value; } }

    }
}
