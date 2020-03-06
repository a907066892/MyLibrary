using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCore
{
    public interface IFeatureCollection : IDictionary<Type, object>
    {
    }
    public class FeaturnCollection : Dictionary<Type, object>, IFeatureCollection { }
    public static partial class Extensions
    {
        public static Task WriteAsync(this HttpResponse response, string contents)
        {
            var buffer = Encoding.UTF8.GetBytes(contents);
            return response.Body.WriteAsync(buffer, 0, buffer.Length);
        }

        public static IWebHostBuilder UserHttpListener(this IWebHostBuilder builder, params string[] urls) => builder.UserServer(new HttpListenerServer(urls));

        public static T Get<T>(this IFeatureCollection ferturns) => ferturns.TryGetValue(typeof(T), out var value) ? (T)value : default(T);
        public static IFeatureCollection Set<T>(this IFeatureCollection ferturns, T ferturn)
        {
            ferturns[typeof(T)] = ferturn;
            return ferturns;
        }
    }
}
