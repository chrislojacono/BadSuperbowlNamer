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
            var expectedResult = "I";

            //Act
            var result = translator.NumberToNumeral(numberToConvert);

            //Assert
            Assert.Equal(expectedResult, result);
            
        }

        [Fact]
        public void when_the_number_5_is_passed_V_should_be_returned()
        {
            var numberToConvert = 5;
            var translator = new RomanNumeralTranslator();

            var result = translator.NumberToNumeral(numberToConvert);

            Assert.Equal("V", result);
        }

        [Fact]
        public void when_the_number_9_is_passed_IX_should_be_returned()
        {
            var numberToConvert = 9;
            var translator = new RomanNumeralTranslator();

            var result = translator.NumberToNumeral(numberToConvert);

            Assert.Equal("IX", result);
        }
    }
}
