using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


static class CustomFunctions
{


    private static bool _lastReadGood;






    /// <summary>
    /// Returns the stringToConvert converted to an int, or it returns -1 on bad input
    /// </summary>
    /// <param name="stringToConvert">The string to convert</param>
    /// <returns>Converted string as int</returns>
    public static int StringToInt(string stringToConvert)
    {
        _lastReadGood = false;
        int result = -1;
        bool testResult = int.TryParse(stringToConvert, out result);
        _lastReadGood = testResult;

        return result;

    }

    public static bool IsReadGood()
    {
        return _lastReadGood;
    }
}

