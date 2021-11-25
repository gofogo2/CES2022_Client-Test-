using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Utils
{
   public static class CommonUtils
    {
        public static string GenerateID()
        {
            return Guid.NewGuid().ToString();
        }
    }
}
