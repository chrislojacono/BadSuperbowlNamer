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
            switch (numberToConvert)
            {
                case 1:
                    result += "I";
                    break;
                case 5:
                    result += "V";
                    break;
                case 9:
                    result += "IX";
                    break;
            }
            return result;
        }
    }
}
