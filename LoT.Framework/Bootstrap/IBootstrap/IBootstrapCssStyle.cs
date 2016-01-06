using LoT.Framework.Bootstrap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoT.Framework.IBootstrap
{
    public interface IBootstrapCssStyle
    {
        /// <summary>
        /// 自定义属性
        /// </summary>
        /// <param name="divStr">在控件内部自由添加其他属性</param>
        /// <returns></returns>
        BootstrapBotton DivAttr(string divStr);
    }
}
