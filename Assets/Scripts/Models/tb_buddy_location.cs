using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CES2022_Server.Models
{
    class tb_buddy_location
    {
        public string buddyCode { get; set; }
        public string zoneCode { get; set; }
    }

    [Serializable]
    class buddy_location
    {
        public string buddyCode { get; set; }
        public string zoneCode { get; set; }
    }
}
