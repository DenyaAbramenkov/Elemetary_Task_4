using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace Elementary_Task_4
{
    abstract class FileParser
    {
        public string FilePath{get; set;}
        public string Pattern { get; set; }
        public FileParser(string filepath, string pattern)
        {
            FilePath = filepath;
            Pattern = pattern;
        }
        public abstract void FileParse();
        
    }
}
