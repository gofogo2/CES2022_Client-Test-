using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CES2022_Server.Models
{
    class tb_zone_schedule : tb_common
    {
        public string zoneCode { get; set; }
        public string action { get; set; }
        public string runTime { get; set; }
    }

    [Serializable]
    class zone_schedule : common
    {
        public string zoneCode { get; set; }
        public string action { get; set; }
        public string runTime { get; set; }
    }
}
