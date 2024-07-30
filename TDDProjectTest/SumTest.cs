using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDDProjectMvc.SumData;

namespace TDDProjectTest
{
    public class SumTest
    {
        [Theory]
        [InlineData("2,2", 4)]
        [InlineData("", 0)]
        [InlineData("0", 0)]
        [InlineData("2,2,2,2,2,2,2", 14)]
        [InlineData("2,2,", 4)]

        public void SumNumber(string Numbers , int expected)
            {
                //Arrange
               Sum sum = new Sum();
                //Act
                var result = sum.Exute(Numbers);
                //Assert
                Assert.Equal(expected, result);

            }

    }
}
