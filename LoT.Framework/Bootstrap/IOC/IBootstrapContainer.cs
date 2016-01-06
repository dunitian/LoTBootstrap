using LoT.Framework.Bootstrap.IBootstrap;

namespace LoT.Framework.Bootstrap.IOC
{
    public interface IBootstrapContainer
    {
        /// <summary>
        /// 按钮
        /// </summary>
        /// <param name="text">文本值</param>
        /// <returns></returns>
        IBootstrapBotton Botton(string text);
    }
}
