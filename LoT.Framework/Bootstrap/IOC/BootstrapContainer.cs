
using LoT.Framework.Bootstrap.IBootstrap;

namespace LoT.Framework.Bootstrap.IOC
{
    /// <summary>
    /// 容器，用来存放Bootstrap各个组件[后期可扩展]
    /// </summary>
    public class BootstrapContainer : IBootstrapContainer
    {
        /// <summary>
        /// 按钮
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public IBootstrapBotton Botton(string text)
        {
            return new BootstrapBotton(text);
        }
    }
}
