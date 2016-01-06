namespace LoT.Framework.Common
{
    /// <summary>
    /// Bootstrap HtmlHelper扩展类
    /// </summary>
    public static class HtmlHelperExt
    {
        /// <summary>
        /// 返回BootstrapIoc容器（里面存放的是Bootstrap相关的组件）
        /// </summary>
        /// <param name="htmlHelper"></param>
        /// <returns></returns>
        public static Bootstrap.IOC.IBootstrapContainer Bootstrap(this System.Web.Mvc.HtmlHelper htmlHelper)
        {
            return new Bootstrap.IOC.BootstrapContainer();
        }
    }
}
