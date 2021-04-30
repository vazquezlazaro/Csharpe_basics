using System;
using System.Collections.Generic;

namespace Util
{
    class Console{
        static public string Ask(string question)
        {
            System.Console.Write(question);
            return System.Console.ReadLine();
        }
        static public int AskInt(string question)
        {
            try
            {
               System.Console.Write(question);
            return int.Parse(System.Console.ReadLine()); 
            }
            catch (System.Exception)
            {
                throw new FormatException("Input is not a number");
            }
            
        }
    }

}
