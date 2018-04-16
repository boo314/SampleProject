using BusinessLogic.Mappers;
using BusinessLogic.Models;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services
{
    public class TootZootService : ITootZootService
    {
        private ITootRepository _tootRepository;
        private IZootMapper _zootMapper;
        public TootZootService(ITootRepository tootRepository, IZootMapper zootMapper)
        {
            _tootRepository = tootRepository;
            _zootMapper = zootMapper;
        }
        public ZootDTO GetZootByTootId(int id)
        {
            var toot = _tootRepository.GetTootById(id);
            var result = _zootMapper.GetZootDTOFromZootModel(toot.Zoot);
            return result;
        }
    }
}
