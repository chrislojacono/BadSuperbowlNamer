using System;
using Xunit;

namespace BadSuperBowlNamer.Tests
{
    //name the class for the things we are testing
    public class TranslateNumbersToRomanNumerals 
    {
        [Fact]  //this method is a test
        public void when_the_number_1_is_passed_I_should_be_returned() // must be public and return nothing(void) and take no parameters
        {
            //Arrange - what are the things I need in order to run these tests -> context creation
            var numberToConvert = 1;
            var translator = new RomanNumeralTranslator();


            //Act
            var result = translator.NumberToNumeral(numberToConvert);

            //Assert
            Assert.Equal("I", result);
            

        }
    }
}
