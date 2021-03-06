﻿using System.ComponentModel;

namespace LoT.Framework.Common
{
    public static class EnumDescriptionExt
    {
        /// <summary>
        /// 枚举扩展方法-获取Description特性标签的值
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string GetDescription(this System.Enum obj)
        {
            if (obj == null) { return string.Empty; }
            var type = obj.GetType();
            System.Reflection.FieldInfo field = type.GetField(System.Enum.GetName(type, obj));
            DescriptionAttribute descAttr = System.Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute)) as DescriptionAttribute;
            if (descAttr == null)
            {
                return string.Empty;
            }
            return descAttr.Description;
        }
    }
}
