using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CES2022_Server.Models
{
    class tb_user : tb_common
    {
        public string nickName { get; set; }
    }

    [Serializable]
    class user : common
    {
        public string nickName { get; set; }
    }
}
