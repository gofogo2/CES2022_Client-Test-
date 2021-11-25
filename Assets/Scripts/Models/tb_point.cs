using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CES2022_Server.Models
{
    class tb_point
    {
        public string userCode { get; set; }
        public int point { get; set; }
        public string itemCode { get; set; }
    }

    [Serializable]
    class score
    {
        public string userCode { get; set; }
        public int point { get; set; }
        public string itemCode { get; set; }
    }
}
