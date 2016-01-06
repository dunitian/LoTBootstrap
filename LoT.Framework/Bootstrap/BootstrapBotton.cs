using System.Text;
using LoT.Framework.Enum;
using LoT.Framework.Common;
using LoT.Framework.IBootstrap;

namespace LoT.Framework.Bootstrap
{
    public class BootstrapBotton : IBootstrapBotton
    {
        StringBuilder btnBuilder = new StringBuilder("<button type=\"button\" class=\"btn btn-primary\">Button</button>");

        /// <summary>
        /// 设置按钮大小
        /// </summary>
        /// <param name="btnSize"></param>
        /// <returns></returns>
        public BootstrapBotton Size(BottonSizeEnum btnSize)
        {
            string des = btnSize.GetDescription();
            return this;
        }

        /// <summary>
        /// 设置按钮样式
        /// </summary>
        /// <param name="btnStyle"></param>
        /// <returns></returns>
        public BootstrapBotton Style(BottonStyleEnum btnStyle)
        {
            string des = btnStyle.GetDescription();
            return this;
        }

        /// <summary>
        /// 设置自定义样式
        /// </summary>
        /// <param name="style"></param>
        /// <returns></returns>
        public BootstrapBotton DivAttr(string style)
        {

            return this;
        }
    }
}
