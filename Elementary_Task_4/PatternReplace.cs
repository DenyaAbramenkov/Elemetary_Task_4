using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;

namespace Elementary_Task_4
{
    class PatternReplace:FileParser
    {
        public string StringToReplace { get; set; }
        public PatternReplace(string filepath, string pattern, string stringToReplace) : base(filepath, pattern)
        {
            StringToReplace = stringToReplace;
        }
        public override void FileParse()
        {
            string tempFileName = Path.GetTempFileName();
            using (StreamReader streamToRead = new StreamReader(FilePath))
            {          
                using (StreamWriter streamToWrite = new StreamWriter(tempFileName))
                {
                    while (!streamToRead.EndOfStream)
                    {
                        StringBuilder line = new StringBuilder(streamToRead.ReadLine());
                        line = line.Replace(Pattern, StringToReplace);
                        streamToWrite.WriteLine(line);
                    }
                    streamToWrite.Close();
                    streamToRead.Close();
                    
                }
            }
        File.Replace(tempFileName, FilePath, null);
        }

    }
}
