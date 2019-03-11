using AlbumCollection.Controllers;
using AlbumCollection.Repositories;
using Xunit;
using NSubstitute;
using System.Collections.Generic;
using AlbumCollection.Models;

namespace AlbumCollection.Tests
{
    public class AlbumCollectionTest
    {
        AlbumController underTest;
        private IAlbumRepository albumRepo;

        public AlbumCollectionTest()
        {
            albumRepo = Substitute.For<IAlbumRepository>();

            underTest = new AlbumController(albumRepo);
        }

        [Fact]
        public void Index_Sets_Model_To_All_Albums()
        {
            //Arrange//
            var expectedModel = new List<Album>();
            albumRepo.GetAll().Returns(expectedModel);
            //Action//
            var result = underTest.Index();
            var model = (IEnumerable<Album>)result.Model;
            //Assert//
            Assert.Equal(expectedModel, model);
        }

        [Fact]
        public void Details_Sets_Model_To_Correct_Album()
        {
            //Arrange//
            var expectedId = 3;
            var expectedModel = new Album();
            albumRepo.GetById(expectedId).Returns(expectedModel);
            //Action//
            var result = underTest.Details(expectedId);
            var model = (Album)result.Model;
            //Assert//
            Assert.Equal(expectedModel, model);
        }
    }
}
