using System;

namespace Open_Lab_01._01
{
    public class Exercise
    {
        public bool IsLessThan10(string input)
        {
            int wowko;
            Int32.TryParse(input, out wowko);
            if (wowko < 10)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }
    }
}