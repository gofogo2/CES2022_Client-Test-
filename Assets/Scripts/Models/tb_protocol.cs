using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CES2022_Server.Models
{
    [Serializable]
    class protocol : common
    {
        public int itemCode { get; set; }
        //31 
        public string action1 { get; set; }
        // 0:idle 1:play1 2:play2
        public string action2 { get; set; }

        public string action3 { get; set; }
        public string action4 { get; set; }
        public string action5 { get; set; }
    }
}
