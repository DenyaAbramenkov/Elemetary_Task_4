using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;

namespace Elementary_Task_4
{
    class CountOfEntries : FileParser
    {
        public int Count {get;set;}
        public CountOfEntries(string filepath, string pattern):base(filepath, pattern)
        {
            Count = 0;
        }
        public override void FileParse()
        {
            try
            {
                using (StreamReader streamToRead = new StreamReader(FilePath))
                {
                    while (!streamToRead.EndOfStream)
                    {
                        string line = (streamToRead.ReadLine());
                        Count += new Regex($@"{Pattern}").Matches(line).Count;
                    }
                }
            }
            catch
            {
                throw new FileNotFoundException("Сould not find the file at the specified path");
            }
        }
    }
}
