using System.Text;
using LoT.Framework.Common;
using LoT.Framework.Bootstrap.Enum;
using System;
using LoT.Framework.Bootstrap.IBootstrap;

namespace LoT.Framework.Bootstrap
{
    public class BootstrapBotton : IBootstrapBotton
    {
        StringBuilder btnBuilder = new StringBuilder("<button type=\"button\" class=\"btn btn-primary\">Button</button>");

        /// <summary>
        /// 属性
        /// </summary>
        public string Text { get; set; }


        /// <summary>
        /// 构造函数
        /// </summary>
        public BootstrapBotton(string text) { Text = text; }

        /// <summary>
        /// 设置控件ID（可空）
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IBootstrapBotton SetID(string id)
        {
            if (!string.IsNullOrEmpty(id))
            {
                //todo: 设置控件ID
            }
            return this;
        }

        /// <summary>
        /// 设置按钮大小
        /// </summary>
        /// <param name="btnSize"></param>
        /// <returns></returns>
        public IBootstrapBotton Size(BottonSizeEnum? btnSize)
        {
            if (btnSize != null)
            {
                string des = btnSize.GetDescription();
                //todo: 设置按钮大小
            }
            return this;
        }

        /// <summary>
        /// 设置按钮样式
        /// </summary>
        /// <param name="btnStyle"></param>
        /// <returns></returns>
        public IBootstrapBotton Style(BottonStyleEnum? btnStyle)
        {
            if (btnStyle != null)
            {
                string des = btnStyle.GetDescription();
                //todo: 设置按钮样式
            }
            return this;
        }

        /// <summary>
        /// 设置自定义样式
        /// </summary>
        /// <param name="divStr">在控件内部自由添加其他属性</param>
        /// <returns></returns>
        public IBootstrapBotton DivAttr(string divStr)
        {
            if (string.IsNullOrEmpty(divStr))
            {
                //todo: 设置按钮样式
            }
            return this;
        }

        /// <summary>
        /// 返回控件-字符串格式
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            //todo: 返回控件-字符串格式
            return base.ToString();
        }

        /// <summary>
        /// 返回控件-HTML格式
        /// </summary>
        /// <returns></returns>
        public string ToHtml()
        {
            //todo: 返回控件-HTML格式
            throw new NotImplementedException();
        }
    }
}
