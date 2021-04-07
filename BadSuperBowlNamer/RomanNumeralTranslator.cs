using System;
using System.Collections.Generic;
using System.Text;

namespace BadSuperBowlNamer
{
    public class RomanNumeralTranslator
    {
        public string NumberToNumeral(int numberToConvert)
        {
            //var result = numberToConvert switch
            //{ 
            //    1 => "I",
            //    5 => "V",
            //    9 => "IX",
            //};
            var result = "";
            while (numberToConvert > 0)
            {
                if(numberToConvert >= 10)
                {
                    var numberOfTens = numberToConvert / 10;
                    numberToConvert = numberToConvert % 10;
                    for (int i = 0; i < numberOfTens; i++)
                    {
                        result += "X";
                    }
                    
                }
                else
                {
                    result += ConvertOneThroughNine(numberToConvert);
                    break;
                }

            }
            return result;
        }

        string ConvertOneThroughNine(int smallNumber)
        {
            switch (smallNumber)
            {
                case 1:
                    return "I";
                case 2:
                    return "II";
                case 3:
                    return "III";
                case 4:
                    return "IV";
                case 5:
                    return "V";
                case 6:
                    return "VI";
                case 7:
                    return "VII";
                case 8:
                    return "VII";
                case 9:
                    return "IX";
                    
                default:
                    return "";
            }
        }
    }
}
