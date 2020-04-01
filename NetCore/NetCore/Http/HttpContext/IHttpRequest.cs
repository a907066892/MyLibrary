using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCore
{
    public interface IHttpRequestFerture
    {
        Uri Uri { get; }
        NameValueCollection Headers { get; }
        Stream Body { get; }
    }
}
