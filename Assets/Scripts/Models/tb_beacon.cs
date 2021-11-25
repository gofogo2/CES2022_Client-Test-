using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CES2022_Server.Models
{
    class tb_beacon : tb_common
    {
        public string rssi { get; set; }
        public string range { get; set; }
        public string position { get; set; }
    }

    

    [Serializable]
   public class beacon 
    {
        public string name { get; set; }
        public string code { get; set; }
        public string rssi { get; set; }
        public string range { get; set; }
        public string position { get; set; }
    }

}
