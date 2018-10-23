using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elementary_Task_4
{
    class UI_Console
    {
        public static void BuildUI()
        {
            const int GET_COUNT_OF_ENTRIES = 3;
            const int CHANGE_STRING = 4;
            string[] args = Environment.GetCommandLineArgs();
            Instruction();
            switch (args.Length)
            {
                case GET_COUNT_OF_ENTRIES:
                    {
                        try
                        {
                            CountOfEntries fileParser = new CountOfEntries(args[1], args[2]);
                            fileParser.FileParse();
                            Console.WriteLine(fileParser.Count);
                        }
                        catch (ArgumentException)
                        {
                            Console.WriteLine("Incorect input");
                            Console.ReadKey();
                        }

                        break;
                    }
                case CHANGE_STRING:
                    {
                        try
                        {
                            PatternReplace fileParser = new PatternReplace(args[1], args[2], args[3]);
                            fileParser.FileParse();
                        }
                        catch (ArgumentException)
                        {
                            Console.WriteLine("Incorect input");
                            Console.ReadKey();
                        }
                        break;
                    }
                default:
                    {
                        Instruction();
                        break;
                    }
            }
        }
        
        private static void Instruction()
        {
            Console.WriteLine("Input path to file for parse" + Environment.NewLine +
               "If you want to get count of pattern entries input patternt" + Environment.NewLine +
               "If you want to change pattern then input string to raplece");
        }
    }
}
