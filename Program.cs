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
			cmd = makeSafe(cmd);
			execProgram(cmd);

        }//end Main

        static String makeSafe(String s)
        {
            if (s.ToUpper().Equals("NOTEPAD.EXE"))
                return s;
            return null;
        }
		
		static void execProgram(String command) {
			
			ProcessStartInfo procStartInfo = new ProcessStartInfo("cmd", "/c " + command);
			Process process = new Process()			
			process.StartInfo = procStartInfo;
			process.Start(command);
		}
		
    }//end Program
}//end Injection_Flaw
