using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class TootRepo : BaseRepo<TootModel>, ITootRepository
    {
        public TootModel GetTootById(int id)
        {
            return Get(x => x.Id == id);
        }
    }
}
