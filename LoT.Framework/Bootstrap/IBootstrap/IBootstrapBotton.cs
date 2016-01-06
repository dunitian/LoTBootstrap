using LoT.Framework.Bootstrap.Enum;

namespace LoT.Framework.Bootstrap.IBootstrap
{

    public interface IBootstrapBotton : IBootstrapAttr<IBootstrapBotton>
    {
        /// <summary>
        /// 设置大小
        /// </summary>
        /// <param name="btnSize"></param>
        /// <returns></returns>
        IBootstrapBotton Size(BottonSizeEnum? btnSize);
        /// <summary>
        /// 设置样式
        /// </summary>
        /// <param name="btnStyle"></param>
        /// <returns></returns>
        IBootstrapBotton Style(BottonStyleEnum? btnStyle);
    }
}
