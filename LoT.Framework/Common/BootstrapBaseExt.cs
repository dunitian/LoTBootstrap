using LoT.Framework.Bootstrap;
using System.Web.Mvc;

namespace LoT.Framework.Common
{
    /// <summary>
    /// Bootstrap HtmlHelper扩展类
    /// </summary>
    public static class BootstrapBaseExt
    {
        /// <summary>
        /// Bootstrap对象
        /// </summary>
        /// <param name="htmlHelper"></param>
        /// <returns></returns>
        public static BootstrapBotton Bootstrap(this HtmlHelper htmlHelper)
        {
            return new BootstrapBotton();
        }

    }
}
