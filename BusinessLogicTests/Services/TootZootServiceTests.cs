using NUnit.Framework;
using BusinessLogic.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Repositories;
using BusinessLogic.Mappers;
using Moq;
using DAL.Models;

namespace BusinessLogic.Services.Tests
{
    [TestFixture()]
    public class TootZootServiceTests
    {
        private ITootZootService _sut;
        private Mock<ITootRepository> _tootRepository;
        private Mock<IZootMapper> _zootMapper;

        [SetUp]
        public void Setup()
        {
            _tootRepository = new Mock<ITootRepository>();
            _zootMapper = new Mock<IZootMapper>();

            _sut = new TootZootService(_tootRepository.Object, _zootMapper.Object);
        }

        [Test()]
        public void TootZootServiceTest()
        {
            
        }

        [Test()]
        [TestCase(10, "Cos")]
        [TestCase(14, "Cos")]
        [TestCase(17, "Cos")]
        public void GetZootByTootId_ShouldReturnsZoot_WithIdCos(int id, string zootId)
        {
            _tootRepository.Setup(x => x.GetTootById(It.IsAny<int>())).Returns(new TootModel { Zoot = It.IsAny<ZootModel>() });
            _zootMapper.Setup(x => x.GetZootDTOFromZootModel(It.IsAny<ZootModel>())).Returns(new Models.ZootDTO { Id = "Cos" });

            var result = _sut.GetZootByTootId(id);

            Assert.AreEqual(zootId, result.Id);
            _zootMapper.Verify(x => x.GetZootDTOFromZootModel(It.IsAny<ZootModel>()), Times.AtLeastOnce);
        }
    }
}