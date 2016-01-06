using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LoT.Framework.Bootstrap.Builder
{
    public class BootstrapBuilder
    {
        /// <summary>
        /// 头部
        /// </summary>
        private BeginBuilder beginBuilder = new BeginBuilder();
        /// <summary>
        /// 内部
        /// </summary>
        private InnerBuilder innerBuilder = new InnerBuilder();
        /// <summary>
        /// 尾部
        /// </summary>
        private EndBuilder endBuilder = new EndBuilder();
    }
}
