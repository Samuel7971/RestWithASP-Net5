using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestWithASPNETCORE5.ValidatorNumber
{
    public class Validator
    {
        public static bool IsNumeric(string strNumber) // Valida se é numerico;
        {
            double number;
            bool isNumber = double.TryParse(
                strNumber,
                System.Globalization.NumberStyles.Any,
                System.Globalization.NumberFormatInfo.InvariantInfo,
                out number);
            return isNumber;
        }

        public static decimal ConvertToDecimal(string strNumber)  // Converte a string strNumber em decimal
        {
            if (decimal.TryParse(strNumber, out decimal decimalValue))
            {
                return decimalValue;
            }
            return 0;
        }
    }
}
