using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class TootModel : BaseModel<int>
    {
        public ZootModel Zoot { get; set; }
    }
}
