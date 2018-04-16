using BusinessLogic.Models;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Mappers
{
    public class ZootMapper : IZootMapper
    {
        public ZootDTO GetZootDTOFromZootModel(ZootModel model)
        {
            var result = new ZootDTO
            {
                Id = model.Id
            };
            return result;
        }
    }
}
