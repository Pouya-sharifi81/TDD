using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDProjectTest
{
    public class HomeControllerTest
    {
        [Fact]
         public void IndexTest()
        {
            //Arrange
            HomeController homeController = new HomeController();
            //Act
            var result = homeController.Index();
            //Assert
            Assert.IsType<ViewResult>(result);
        }
    }
}
