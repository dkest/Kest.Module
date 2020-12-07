using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kest.Module
{
    /// <summary>
    /// 模块依赖的模块
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    public class DependsOnAttribute : Attribute
    {
        /// <summary>
        /// 依赖的模块类型
        /// </summary>
        public Type[] DependModuleTypes { get; private set; }

        //这里参数 params Type[] 因为一个模块会依赖多个模块
        public DependsOnAttribute(params Type[] dependModuleTypes)
        {
            DependModuleTypes = dependModuleTypes ?? new Type[0];
        }
    }
}
