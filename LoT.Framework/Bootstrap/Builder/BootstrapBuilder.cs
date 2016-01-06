using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LoT.Framework.Bootstrap.Builder
{
    public class BootstrapBuilder
    {
        private BeginBuilder beginBuilder = new BeginBuilder();
        private InnerBuilder innerBuilder = new InnerBuilder();
        private EndBuilder endBuilder = new EndBuilder();
    }
}
