using BusinessLogic.Models;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Mappers
{
    public interface IZootMapper
    {
        ZootDTO GetZootDTOFromZootModel(ZootModel model);
    }
}
