using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace NetCore
{
    /// <summary>
    /// 用于适配httpcontext的类
    /// </summary>
    public class HttpListenerFeature : IHttpRequestFerture, IHttpResponseFerture
    {
        public HttpListenerContext _context;

        public HttpListenerFeature(HttpListenerContext context) => _context = context;

        public Uri Uri => _context.Request.Url;

        NameValueCollection IHttpRequestFerture.Headers => _context.Request.Headers;
        NameValueCollection IHttpResponseFerture.Headers => _context.Response.Headers;

        Stream IHttpRequestFerture.Body => _context.Request.InputStream;
        Stream IHttpResponseFerture.Body => _context.Response.OutputStream;

        public int StatusCode { get { return _context.Response.StatusCode; } set { _context.Response.StatusCode = value; } }
    }
}
