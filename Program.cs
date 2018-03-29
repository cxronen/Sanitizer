using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Injection_Flaw
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Type a command:  ");
            String cmd = Console.ReadLine();
            System.Diagnostics.Process.Start(makeSafe(cmd));

            if(isSafe(cmd))
                System.Diagnostics.Process.Start(cmd);
        }//end Main

        static String makeSafe(String s)
        {
            if (s.ToUpper().Equals("NOTEPAD.EXE"))
                return s;
            return null;
        }
        static bool isSafe(String s)
        {
            if (s.ToUpper().Equals("NOTEPAD.EXE"))
                return true;
            return false;
        }//end isSafe
    }//end Program
}//end Injection_Flaw