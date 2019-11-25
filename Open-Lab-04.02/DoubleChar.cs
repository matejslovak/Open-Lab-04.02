using System;
using System.Collections.Generic;
using System.Text;

namespace Open_Lab_04._02
{
    class DoubleChar
    {
        public void GetDoubleChar(string str)
        {
            string[] arr = new string[str.Length];
            for (int a = 0; a < str.Length; a++)
            {
                string array = arr[a] = str[a].ToString() + str[a].ToString();
                Console.Write(array);
            }
        }
    }

}
