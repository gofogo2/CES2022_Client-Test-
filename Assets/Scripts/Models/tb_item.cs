using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CES2022_Server.Models
{
    class tb_item : tb_common
    {
        public string zoneCode { get; set; }
    }

    [Serializable]
    class item : common
    {
        public string zoneCode { get; set; }
    }
}
