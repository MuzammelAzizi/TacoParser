 using System;
using Xunit;
using Xunit.Sdk;

namespace LoggingKata.Test
{
    public class TacoParserTests
    {
        [Fact]
        public void ShouldReturnNonNullObject()
        {
            //Arrange
            var tacoParser = new TacoParser();

            //Act
            var actual = tacoParser.Parse("34.073638, -84.677017, Taco Bell Acwort...");

            //Assert
            Assert.NotNull(actual);
            
        }

        [Theory]
        [InlineData("34.073638, -84.677017, Taco Bell Acwort...", -84.677017)]
        [InlineData("30.903723, -84.556037, Taco Bell Bainbridg...", -84.556037)]
        //Add additional inline data. Refer to your CSV file.
        public void ShouldParseLongitude(string line, double expected)
        {
            // TODO: Complete the test with Arrange, Act, Assert steps below.
            //       Note: "line" string represents input data we will Parse 
            //       to extract the Longitude. 
            //       Each "line" from your .csv file
            //       represents a TacoBell location


            //Arrange- to set up the object and order to call the method to test.
            var tacoParser = new TacoParser();
            //Act
            var actual = tacoParser.Parse(line);

            //Assert
            Assert.Equal(expected, actual.Location.Longitude);
        }


        //TODO: Create a test called ShouldParseLatitude
        [Theory]
        [InlineData("34.047374,-84.223918,Taco Bell Alpharetta...", 34.047374)]
        [InlineData("34.039588,-84.283254,Taco Bell Alpharetta...", 34.039588)]
        
        public void ShouldParseLatitude(string line, double expected)
        {   //Arrenge
            var tacoParser = new TacoParser();
            //Act
            var actual = tacoParser.Parse(line);
            //Assert
            Assert.Equal(expected, actual.Location.Latitude);
        }
    }
}
