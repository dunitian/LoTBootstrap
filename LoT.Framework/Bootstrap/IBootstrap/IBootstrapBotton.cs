using LoT.Framework.Bootstrap;
using LoT.Framework.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoT.Framework.IBootstrap
{

    public interface IBootstrapBotton : IBootstrapCssStyle
    {
        /// <summary>
        /// 设置大小
        /// </summary>
        /// <param name="btnSize"></param>
        /// <returns></returns>
        BootstrapBotton Size(BottonSizeEnum btnSize);
        /// <summary>
        /// 设置样式
        /// </summary>
        /// <param name="btnStyle"></param>
        /// <returns></returns>
        BootstrapBotton Style(BottonStyleEnum btnStyle);

    }
}
