using System;

namespace Kest.Module
{
    /// <summary>
    /// 模块描述
    /// 既然一个模块会包含多个模块的引用，那么就应该有一个存储的方式
    /// 新建类 ModuleDescriptor 该类来存储 自身和引用的其他模块
    /// </summary>
    public class ModuleDescriptor
    {
        private object _instance;

        /// <summary>
        /// 模块类型
        /// </summary>
        public Type ModuleType { get; private set; }

        /// <summary>
        /// 依赖项
        /// </summary>
        public ModuleDescriptor[] Dependencies { get; private set; }

        /// <summary>
        /// 实例
        /// </summary>
        public object Instance
        {
            get {
                if (_instance == null)
                {
                    _instance = Activator.CreateInstance(ModuleType);
                }
                return _instance;
            }
        }

        public ModuleDescriptor(Type moduleType, params ModuleDescriptor[] dependencies)
        {
            this.ModuleType = moduleType;
            // 如果模块依赖 为空给一个空数组
            this.Dependencies = dependencies ?? new ModuleDescriptor[0];
        }
    }
}
