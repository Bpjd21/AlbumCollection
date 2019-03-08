using AlbumCollection.Controllers;
using System;
using Xunit;

namespace AlbumCollection.Tests
{
    public class AlbumCollectionTest
    {
        AlbumController underTest;

        [Fact]
        public void Index_Sets_Model_To_All_Albums()
        {
            //Arrange//
            underTest = new AlbumController();
            //Action//

            //Assert//

        }

        [Fact]
        public void Details_Sets_Model_To_Correct_Album()
        {
            //Arrange//

            //Action//

            //Assert//
        }

    }
}
