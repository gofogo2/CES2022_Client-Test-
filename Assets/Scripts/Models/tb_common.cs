using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CES2022_Server.Models
{
    
    class tb_common
    {
        public string name { get; set; }
        public string code { get; set; }
    }

    [Serializable]
    class common
    {
        public string name { get; set; }
        public string code { get; set; }
    }
}
