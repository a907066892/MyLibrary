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
    /// <summary>
    /// 用于存储http对象,项目中为适配httpcontext
    /// </summary>
    public class FeaturnCollection : Dictionary<Type, object>, IFeatureCollection { }
   
}
