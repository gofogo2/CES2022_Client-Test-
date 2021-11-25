using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Converters
{
   public static class ObjectConverter
    {
        public static T ObjectToClass<T>(object code)
        {
            return (T)code;
        }
    }
}
